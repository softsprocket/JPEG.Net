using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{
    public class Ifd
    {
        public class FieldInteroperability
        {
            ushort tag;
            ushort type;
            uint count;
            uint offset;

            public ushort Tag { get => tag; set => tag = value; }
            public ushort Type { get => type; set => type = value; }
            public uint Count { get => count; set => count = value; }
            public uint ValueOffset { get => offset; set => offset = value; }
            public FieldType TypeValue; 

            public FieldInteroperability (byte[] buf, uint np, bool reverseNumericArrays)
            {
                byte[] b2 = new byte[2];
                if (reverseNumericArrays)
                {
                    b2[0] = buf[np + 1];
                    b2[1] = buf[np];
                }
                else
                {
                    b2[0] = buf[np];
                    b2[1] = buf[np + 1];
                }

                ushort tag = BitConverter.ToUInt16(b2, 0);

                if (reverseNumericArrays)
                {
                    b2[0] = buf[np + 3];
                    b2[1] = buf[np + 2];
                }
                else
                {
                    b2[0] = buf[np + 2];
                    b2[1] = buf[np + 3];
                }

                ushort type = BitConverter.ToUInt16(b2, 0);

                byte[] b4 = new byte[4];
                if (reverseNumericArrays)
                {
                    b4[0] = buf[np + 7];
                    b4[1] = buf[np + 6];
                    b4[2] = buf[np + 5];
                    b4[3] = buf[np + 4];
                }
                else
                {
                    b4[0] = buf[np + 4];
                    b4[1] = buf[np + 5];
                    b4[2] = buf[np + 6];
                    b4[3] = buf[np + 7];
                }

                uint count = BitConverter.ToUInt32(b4, 0);

                if (reverseNumericArrays)
                {
                    b4[0] = buf[np + 11];
                    b4[1] = buf[np + 10];
                    b4[2] = buf[np + 9];
                    b4[3] = buf[np + 8];
                }
                else
                {
                    b4[0] = buf[np + 8];
                    b4[1] = buf[np + 9];
                    b4[2] = buf[np + 10];
                    b4[3] = buf[np + 11];
                }

                uint offs = BitConverter.ToUInt32(b4, 0);


                Tag = tag;
                Type = type;
                Count = count;
                ValueOffset = offset;
                TypeValue = GetFieldType();

                int size = TypeValue.Size();
                
                if (size <= 4)
                {
                    TypeValue.SetValue(b4, offset, reverseNumericArrays);
                }
                else
                {
                    TypeValue.SetValue(buf, offset, reverseNumericArrays);
                }

            }


            public abstract class FieldType
            {
                public enum FieldValueType
                {
                    BYTE,
                    ASCII,
                    SHORT,
                    LONG,
                    RATIONAL,
                    UNDEFINED,
                    SLONG,
                    SRATIONAL
                }

                protected FieldValueType valueType;

                public FieldValueType ValueType { get => valueType; }

                public abstract int Size();

                public abstract void SetValue(byte[] buf, uint offset, bool reverse);

            }

            public class ByteValue : FieldType
            {
                byte[] value;

                public ByteValue (uint count)
                {
                    valueType = FieldValueType.BYTE;
                    Value = new byte[count];
                }

                public byte[] Value { get => value; set => this.value = value; }

                public override string ToString()
                {
                    return $"Byte length {value.Length}: {BitConverter.ToString(value)}";
                }

                public override int Size ()
                {
                    return value.Length;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    int numbytes = Size();
                    if (numbytes <= 4)
                    {
                        Array.Copy(buf, 0, Value, 0, numbytes);
                    }
                    else
                    {
                        Array.Copy(buf, offset, Value, 0, numbytes);
                    }

                }
            }

            public class AsciiValue : FieldType
            {
                byte[] value;

                public AsciiValue(uint count)
                {
                    valueType = FieldValueType.ASCII;
                    Value = new byte[count];
                }

                public byte[] Value { get => value; set => this.value = value; }

                public override string ToString()
                {
                    Console.WriteLine(BitConverter.ToString(Value));
                    return $"Ascii length {value.Length}: {UTF8Encoding.UTF8.GetString(value)}";
                }

                public override int Size ()
                {
                    return value.Length;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    int numbytes = Size();
                    if (numbytes <= 4)
                    {
                        Array.Copy(buf, 0, Value, 0, numbytes);
                    }
                    else
                    {
                        Array.Copy(buf, offset, Value, 0, numbytes);
                    }

                }
            }

            public class ShortValue : FieldType
            {
                ushort[] value;

                public ShortValue(uint count)
                {
                    valueType = FieldValueType.SHORT;
                    Value = new ushort[count];
                }

                public ushort[] Value { get => value; set => this.value = value; }

                public override string ToString()
                {
                    string s = $"Short length {value.Length}:";
                    string sep = " ";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i]}";
                        sep = ",";
                    }

                    return s;
                }

                public override int Size ()
                {
                    return value.Length * 2;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    int numbytes = Size();
                    if (numbytes <= 4)
                    {
                        for (int i = 0; i < Value.Length; ++i)
                        {
                            Value[i] = BitConverter.ToUInt16(buf, i * 2);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Value.Length; ++i)
                        {
                            value[i] = BitConverter.ToUInt16(buf, (int)offset + (2 * i));
                        }
                    }
                }
            }

            public class LongValue : FieldType
            {
                uint[] value;

                public LongValue(uint count)
                {
                    valueType = FieldValueType.LONG;
                    Value = new uint[count];
                }

                public uint[] Value { get => value; set => this.value = value; }

                public override string ToString()
                {
                    string s = $"Long length {value.Length}:";
                    string sep = " ";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i]}";
                        sep = ",";
                    }

                    return s;
                }

                public override int Size()
                {
                    return value.Length * 4;
                }


                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    int numbytes = Size();
                    if (numbytes == 4)
                    {
                        Value[0] = BitConverter.ToUInt32(buf, 0);
                    }
                    else
                    {
                        for (int i = 0; i < Value.Length; ++i)
                        {
                            value[i] = BitConverter.ToUInt32(buf, (int)offset + (4 * i));
                        }
                    }
                }
            }

            public class RationalValue : FieldType
            {
                Tuple<uint,uint>[] value;

                public RationalValue(uint count)
                {
                    valueType = FieldValueType.RATIONAL;
                    Value = new Tuple<uint,uint>[count];
                }

                public Tuple<uint,uint>[] Value { get => value; set => this.value = value; }

                public override string ToString()
                {
                    string s = $"Rational length {value.Length}:";
                    string sep = " ";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i].Item1}/{value[i].Item2}";
                        sep = ",";
                    }

                    return s;
                }

                public override int Size()
                {
                    return value.Length * 8;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    for (int i = 0; i < Value.Length; ++i)
                    {
                        Value[i] = new Tuple<uint, uint>(
                            BitConverter.ToUInt32(buf, (int)offset + (4 * i)),
                            BitConverter.ToUInt32(buf, (int)offset + ((4 * i) + 4))
                        );
                    }
                }
            }

            public class UndefinedValue : FieldType
            {
                byte[] value;

                public UndefinedValue(uint count)
                    
                {
                    valueType = FieldValueType.UNDEFINED;
                    Value = new byte[count];
                }

                public byte[] Value { get => value; set => this.value = value; }

                public override string ToString()
                {
                    return $"Undefined length {value.Length}: {BitConverter.ToString(value)}";
                    
                }

                public override int Size()
                {
                    return value.Length;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    int numbytes = Size();
                    if (numbytes <= 4)
                    {
                        Array.Copy(buf, 0, Value, 0, numbytes);
                    }
                    else
                    {
                        Array.Copy(buf, offset, Value, 0, numbytes);
                    }

                }
            }

            public class SLongValue : FieldType
            {
                int[] value;

                public SLongValue(uint count)
                {
                    valueType = FieldValueType.SLONG;
                    Value = new int[count];
                }

                public int[] Value { get => value; set => this.value = value; }

                public override string ToString()
                {
                    string s = $"SLong length {value.Length}:";
                    string sep = " ";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i]}";
                        sep = ",";
                    }

                    return s;
                }

                public override int Size()
                {
                    return value.Length * 4;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    int numbytes = Size();
                    if (numbytes == 4)
                    {
                        Value[0] = BitConverter.ToInt32(buf, 0);
                    }
                    else
                    {
                        for (int i = 0; i < Value.Length; ++i)
                        {
                            value[i] = BitConverter.ToInt32(buf, (int)offset + (4 * i));
                        }
                    }
                }
            }

            public class SRationalValue : FieldType
            {
                Tuple<int,int>[] value;

                public SRationalValue(uint count)
                {
                    valueType = FieldValueType.SRATIONAL;
                    Value = new Tuple<int,int>[count];
                }

                public Tuple<int,int>[] Value { get => value; set => this.value = value; }

                public override string ToString()
                {
                    string s = $"SRational length {value.Length}:";
                    string sep = " ";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i].Item1}/{value[i].Item2}";
                        sep = ",";
                    }

                    return s;
                }

                public override int Size()
                {
                    return value.Length * 8;
                }


                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    for (int i = 0; i < Value.Length; ++i)
                    {
                        Value[i] = new Tuple<int, int>(
                            BitConverter.ToInt32(buf, (int)offset + (4 * i)),
                            BitConverter.ToInt32(buf, (int)offset + ((4 * i) + 4))
                        );
                    }
                }
            }

            FieldType GetFieldType ()
            {
                FieldType ft = null;

                switch (Type)
                {
                    case 1:
                        ft = new ByteValue(Count);
                        break;
                    case 2:
                        ft = new AsciiValue(Count);
                        break;
                    case 3:
                        ft = new ShortValue(Count);
                        break;
                    case 4:
                        ft = new LongValue(Count);
                        break;
                    case 5:
                        ft = new RationalValue(Count);
                        break;
                    case 7:
                        ft = new UndefinedValue(Count);
                        break;
                    case 9:
                        ft = new SLongValue(Count);
                        break;
                    case 10:
                        ft = new SRationalValue(Count);
                        break;

                }

                return ft;
            }
        }

        private ushort fieldInteroperabiltyCount;
        private bool reverseNumericArrays;
        private FieldInteroperability[] fieldInteroperabilties;
        private uint offsetToNextIfd;

        public ushort FieldInteroperabiltyCount { get => fieldInteroperabiltyCount; set => fieldInteroperabiltyCount = value; }
        public FieldInteroperability[] FieldInteroperabilties { get => fieldInteroperabilties; set => fieldInteroperabilties = value; }
        public uint OffsetToNextIfd { get => offsetToNextIfd; set => offsetToNextIfd = value; }

        public Ifd (byte[] buf, uint offset, bool isLittleEndian)
        {
            reverseNumericArrays = (BitConverter.IsLittleEndian != isLittleEndian);
            byte[] narrays = new byte[2];
            if (reverseNumericArrays)
            {
                narrays[0] = buf[offset + 1];
                narrays[1] = buf[offset];
            }
            else
            {
                narrays[0] = buf[offset];
                narrays[1] = buf[offset + 1];
            }

            FieldInteroperabiltyCount = BitConverter.ToUInt16(narrays, 0);

            FieldInteroperabilties = new FieldInteroperability[FieldInteroperabiltyCount];
            uint pos = 2;
            for (int i = 0; i < FieldInteroperabiltyCount; ++i)
            {
                uint np = pos + offset;
                
                FieldInteroperabilties[i] = new FieldInteroperability (buf, np, reverseNumericArrays);

                pos += 12;
            }

            byte[] nextIfd = new byte[4];
            uint n = pos + offset;
            if (reverseNumericArrays)
            {
                
                nextIfd[0] = buf[n + 3];
                nextIfd[1] = buf[n + 2];
                nextIfd[2] = buf[n + 1];
                nextIfd[3] = buf[n];
            }
            else
            {
                nextIfd[0] = buf[n];
                nextIfd[1] = buf[n + 1];
                nextIfd[2] = buf[n + 2];
                nextIfd[3] = buf[n + 3];
            }

            OffsetToNextIfd = BitConverter.ToUInt32(nextIfd, 0);
        }


    }
}
