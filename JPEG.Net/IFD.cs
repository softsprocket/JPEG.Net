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
            bool exifIfd;
            bool interoperabilityIfd;
            Ifd exif;
            Ifd interoperability;

            public ushort Tag { get => tag; set => tag = value; }
            public ushort Type { get => type; set => type = value; }
            public uint Count { get => count; set => count = value; }
            public uint ValueOffset { get => offset; set => offset = value; }
            public bool ExifIfd { get => exifIfd; set => exifIfd = value; }
            public Ifd Exif { get => exif; set => exif = value; }
            public Ifd Interoperability { get => interoperability; set => interoperability = value; }
            public bool InteroperabilityIfd { get => interoperabilityIfd; set => interoperabilityIfd = value; }

            public FieldType TypeValue; 


            public FieldInteroperability (byte[] buf, uint np, bool reverseNumericArrays)
            {

                ushort tag = GetValueFromBuf<UInt16>(buf, (int)np, 2, reverseNumericArrays, BitConverter.ToUInt16);
                ushort type = GetValueFromBuf<UInt16>(buf, (int)np + 2, 2, reverseNumericArrays, BitConverter.ToUInt16);
                uint count = GetValueFromBuf<UInt32>(buf, (int)np + 4, 4, reverseNumericArrays, BitConverter.ToUInt32);

                Tag = tag;
                Type = type;
                Count = count;
                TypeValue = GetFieldType();
                int size = TypeValue.Size();

                if (size > 4)
                {
                    uint offs = GetValueFromBuf<UInt32>(buf, (int)np + 8, 4, reverseNumericArrays, BitConverter.ToUInt32);
                    ValueOffset = offs;
                    TypeValue.SetValue(buf, offs, reverseNumericArrays);
                }
                else
                {
                    ValueOffset = 0;
                    byte[] b4 = new byte[4];
                    Array.Copy(buf, np + 8, b4, 0, 4);
                    TypeValue.SetValue(b4, 0, reverseNumericArrays);

                    if (tag == TiffTags.Exif)
                    {
                        uint[] a = (uint[])TypeValue.GetValue();
                        bool isLittleEndian = BitConverter.IsLittleEndian && !reverseNumericArrays;
                        Exif = new Ifd(buf, a[0], isLittleEndian);
                        ExifIfd = true;
                    }

                    if (tag == TiffTags.Interoperability)
                    {
                        uint[] a = (uint[])TypeValue.GetValue();
                        bool isLittleEndian = BitConverter.IsLittleEndian && !reverseNumericArrays;
                        Interoperability = new Ifd(buf, a[0], isLittleEndian);
                        InteroperabilityIfd = true;
                    }
                }

               
            }

            public delegate T ConverterDelegate<T>(byte[] b, int off);

            public static T GetValueFromBuf<T>(byte[] buf, int offset, int len, bool reverse, ConverterDelegate<T> converter)
            {
                byte[] b = new byte[len];
                Array.Copy(buf, offset, b, 0, len);
                if (reverse)
                {
                    Array.Reverse(b);
                }

                return converter(b, 0);
            }

            public override string ToString ()
            {
                string s = $"{TiffTags.ToString(Tag)}: ";

                if (Tag == TiffTags.ResolutionUnit)
                {
                    s += TiffTags.ResolutionUnitToString(TypeValue);
                }
                else if (Tag == TiffTags.SensitivityType)
                {
                    s += TiffTags.SensitivityTypeToString(TypeValue);
                }
                else if (Tag == TiffTags.Orientation)
                {
                    s += TiffTags.OrientationToString(TypeValue);
                }
                else if (Tag == TiffTags.YCbCrPositioning)
                {
                    s += TiffTags.YCbCrPositioningToString(TypeValue);
                }
                else if (Tag == TiffTags.ExposureProgram)
                {
                    s += TiffTags.ExposureProgramToString(TypeValue);
                }
                else if (Tag == TiffTags.Flash)
                {
                    s += TiffTags.FlashToString(TypeValue);
                }
                else if (Tag == TiffTags.MeteringMode)
                {
                    s += TiffTags.MeteringModeToString(TypeValue);
                }
                else if (Tag == TiffTags.LightSource)
                {
                    s += TiffTags.LightSourceToString(TypeValue);
                }
                else if (Tag == TiffTags.ColorSpace)
                {
                    s += TiffTags.ColorSpaceToString(TypeValue);
                }
                else if (Tag == TiffTags.SensingMethodExifPrivate || Tag == TiffTags.SensingMethod)
                {
                    s += TiffTags.SensingMethodToString(TypeValue);
                }
                else
                {
                    s += TypeValue;
                }

                return s;
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

                public abstract object GetValue();

                public abstract string TypeToString();

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
                    return BitConverter.ToString(value);
                }

                public override string TypeToString()
                {
                    return "Byte";
                }

                public override int Size ()
                {
                    return value.Length;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    int numbytes = Size();
                    Array.Copy(buf, offset, Value, 0, numbytes);
                }

                public override object GetValue () {
                    return value;
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
                    return UTF8Encoding.UTF8.GetString(value);
                }

                public override string TypeToString()
                {
                    return "Ascii";
                }

                public override int Size ()
                {
                    return value.Length;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    int numbytes = Size();
                    Array.Copy(buf, offset, Value, 0, numbytes);
                }

                public override object GetValue()
                {
                    return value;
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
                    string s = "";
                    string sep = "";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i]}";
                        sep = ",";
                    }

                    return s;
                }

                public override string TypeToString()
                {
                    return "Short";
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
                            if (reverse)
                            {
                                Value[i] = GetValueFromBuf<UInt16>(buf, i * 2, 2, reverse, BitConverter.ToUInt16);
                            }
                            else
                            {
                                Value[i] = BitConverter.ToUInt16(buf, i * 2);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Value.Length; ++i)
                        {
                            if (reverse)
                            {
                                Value[i] = GetValueFromBuf<UInt16>(buf, i * 2, 2, reverse, BitConverter.ToUInt16);
                            }
                            else
                            {
                                value[i] = BitConverter.ToUInt16(buf, (int)offset + (2 * i));
                            }
                        }
                    }
                }

                public override object GetValue()
                {
                    return value;
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
                    string s = "";
                    string sep = "";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i]}";
                        sep = ",";
                    }

                    return s;
                }

                public override string TypeToString()
                {
                    return "Long";
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
                        if (reverse)
                        {
                            Array.Reverse(buf);
                        }

                        Value[0] = BitConverter.ToUInt32(buf, 0);
                    }
                    else
                    {
                        for (int i = 0; i < Value.Length; ++i)
                        {
                            if (reverse)
                            {
                                Value[i] = GetValueFromBuf<UInt32>(buf, i * 4, 4, reverse, BitConverter.ToUInt32);
                            }
                            else
                            {
                                value[i] = BitConverter.ToUInt32(buf, (int)offset + (4 * i));
                            }
                        }
                    }
                }

                public override object GetValue()
                {
                    return value;
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
                    string s = "";
                    string sep = "";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i].Item1}/{value[i].Item2}";
                        sep = ",";
                    }

                    return s;
                }

                public override string TypeToString()
                {
                    return "Rational";
                }

                public override int Size()
                {
                    return value.Length * 8;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    for (int i = 0; i < Value.Length; ++i)
                    {
                        if (reverse)
                        {

                            Value[i] = new Tuple<uint, uint>(
                                GetValueFromBuf<UInt32>(buf, (int)offset + (4 * i), 4, reverse, BitConverter.ToUInt32),
                                GetValueFromBuf<UInt32>(buf, (int)offset + ((4 * i) + 4), 4, reverse, BitConverter.ToUInt32)
                            );
                          
                        }
                        else
                        {

                            Value[i] = new Tuple<uint, uint>(
                                BitConverter.ToUInt32(buf, (int)offset + (4 * i)),
                                BitConverter.ToUInt32(buf, (int)offset + ((4 * i) + 4))
                            );
                        }
                    }
                }

                public override object GetValue()
                {
                    return value;
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
                    return BitConverter.ToString(value);
                    
                }

                public override string TypeToString()
                {
                    return "Undefined";
                }

                public override int Size()
                {
                    return value.Length;
                }

                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    int numbytes = Size();
                   
                    Array.Copy(buf, offset, Value, 0, numbytes);

                }

                public override object GetValue()
                {
                    return value;
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
                    string s = "";
                    string sep = "";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i]}";
                        sep = ",";
                    }

                    return s;
                }

                public override string TypeToString()
                {
                    return "SLong";
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
                        if (reverse)
                        {
                            Array.Reverse(buf);
                        }

                        Value[0] = BitConverter.ToInt32(buf, 0);
                    }
                    else
                    {
                        for (int i = 0; i < Value.Length; ++i)
                        {
                            if (reverse)
                            {
                                Value[i] = GetValueFromBuf<Int32>(buf, i * 4, 4, reverse, BitConverter.ToInt32);
                            }
                            else
                            {
                                value[i] = BitConverter.ToInt32(buf, (int)offset + (4 * i));
                            }
                        }
                    }
                }

                public override object GetValue()
                {
                    return value;
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
                    string s = "";
                    string sep = "";
                    for (int i = 0; i < value.Length; ++i)
                    {
                        s += $"{sep}{value[i].Item1}/{value[i].Item2}";
                        sep = ",";
                    }

                    return s;
                }

                public override string TypeToString()
                {
                    return "SRational";
                }

                public override int Size()
                {
                    return value.Length * 8;
                }


                public override void SetValue(byte[] buf, uint offset, bool reverse)
                {
                    for (int i = 0; i < Value.Length; ++i)
                    {
                        if (reverse)
                        {
                            Value[i] = new Tuple<int, int>(
                               GetValueFromBuf<Int32>(buf, (int)offset + (4 * i), 4, reverse, BitConverter.ToInt32),
                               GetValueFromBuf<Int32>(buf, (int)offset + ((4 * i) + 4), 4, reverse, BitConverter.ToInt32)
                           );

                        }
                        else
                        {
                            Value[i] = new Tuple<int, int>(
                                BitConverter.ToInt32(buf, (int)offset + (4 * i)),
                                BitConverter.ToInt32(buf, (int)offset + ((4 * i) + 4))
                            );
                        }
                    }
                }

                public override object GetValue()
                {
                    return value;
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
