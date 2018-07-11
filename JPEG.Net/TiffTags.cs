using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JPEG.Net.Ifd.FieldInteroperability;

namespace JPEG.Net
{
    public static class TiffTags
    {

        public const ushort NewSubfileType = 254; //   A general indication of the kind of data contained in this subfile.Baseline Req'd in LC RFP97-6 Section C.4.7.
        public const ushort SubfileType = 255; //  A general indication of the kind of data contained in this subfile.Baseline	 
        public const ushort ImageWidth = 256; //  The number of columns in the image, i.e., the number of pixels per row.Baseline    Listed in LoC Baseline Tags.
        public const ushort ImageLength = 257; //  The number of rows of pixels in the image.	Baseline Listed in LoC Baseline Tags.
        public const ushort BitsPerSample = 258; //  Number of bits per component.	Baseline
        public const ushort Compression = 259; //  Compression scheme used on the image data.	Baseline Listed in LoC Baseline Tags.Sample values: 1=uncompressed and 4=CCITT Group 4.
        public const ushort PhotometricInterpretation = 262; //  The color space of the image data.	Baseline Listed in LoC Baseline Tags.Sample values: 1=black is zero and 2=RGB.Document also states "RGB is assumed to be sRGB; if RGB, an ICC profile should be present in the 34675 tag."
        public const ushort Threshholding = 263; //  For black and white TIFF files that represent shades of gray, the technique used to convert from gray to black and white pixels.	Baseline Usage rule in JHOVE TIFF module.
        public const ushort CellWidth = 264; //  The width of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file.	Baseline
        public const ushort CellLength = 265; //  The length of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file.	Baseline Usage rule in JHOVE TIFF module.
        public const ushort FillOrder = 266; //    The logical order of bits within a byte.	Baseline
        public const ushort DocumentName = 269; //  The name of the document from which this image was scanned.Extended Listed in LoC Baseline Tags.
        public const ushort ImageDescription = 270; //  A string that describes the subject of the image.	Baseline Also used by HD Photo
        public const ushort Make = 271; //  The scanner manufacturer.	Baseline Listed in LoC Baseline Tags.
        public const ushort Model = 272; //  The scanner model name or number.Baseline Listed in LoC Baseline Tags.
        public const ushort StripOffsets = 273; //  For each strip, the byte offset of that strip.Baseline Listed in LoC Baseline Tags.
        public const ushort Orientation = 274; //  The orientation of the image with respect to the rows and columns.Baseline Req'd in LC NDNP TIFF profile.
        public const ushort SamplesPerPixel = 277; //  The number of components per pixel.Baseline Listed in LoC Baseline Tags.Sample values: 8 8 8.
        public const ushort RowsPerStrip = 278; //  The number of rows per strip.Baseline Listed in LoC Baseline Tags.
        public const ushort StripByteCounts = 279; //  For each strip, the number of bytes in the strip after compression.	Baseline Listed in LoC Baseline Tags.
        public const ushort MinSampleValue = 280; //  The minimum component value used.	Baseline
        public const ushort MaxSampleValue = 281; //  The maximum component value used.	Baseline
        public const ushort XResolution = 282; //  The number of pixels per ResolutionUnit in the ImageWidth direction.Baseline Listed in LoC Baseline Tags.
        public const ushort YResolution = 283; //  The number of pixels per ResolutionUnit in the ImageLength direction.Baseline Listed in LoC Baseline Tags.
        public const ushort PlanarConfiguration = 284; //  How the components of each pixel are stored.	Baseline Mandatory for TIFF/EP.
        public const ushort PageName = 285; //  The name of the page from which this image was scanned.Extended Also used by HD Photo
        public const ushort XPosition = 286; //  X position of the image.	Extended
        public const ushort YPosition = 287; //  Y position of the image.	Extended
        public const ushort FreeOffsets = 288; //  For each string of contiguous unused bytes in a TIFF file, the byte offset of the string.	Baseline
        public const ushort FreeByteCounts = 289; //  For each string of contiguous unused bytes in a TIFF file, the number of bytes in the string.	Baseline
        public const ushort GrayResponseUnit = 290; //  The precision of the information contained in the GrayResponseCurve.	Baseline
        public const ushort GrayResponseCurve = 291; //  For grayscale data, the optical density of each possible pixel value.	Baseline
        public const ushort T4Options = 292; //  Options for Group 3 Fax compression Extended
        public const ushort T6Options = 293; //  Options for Group 4 Fax compression Extended
        public const ushort ResolutionUnit = 296; //  The unit of measurement for XResolution and YResolution.Baseline Listed in LoC Baseline Tags.
        public const ushort PageNumber = 297; //  The page number of the page from which this image was scanned.Extended Also used by HD Photo
        public const ushort TransferFunction = 301; //  Describes a transfer function for the image in tabular style.	Extended
        public const ushort Software = 305; //  Name and version number of the software package(s) used to create the image.	Baseline Listed in LoC Baseline Tags.Document states "Acceptable to include only capture software; preferred to list both capture and post-capture processing software (if applicable), separated by ";".
        public const ushort DateTime = 306; //  Date and time of image creation.Baseline Listed in LoC Baseline Tags.
        public const ushort Artist = 315; //   Person who created the image.Baseline Listed in LoC Baseline Tags.Document states "Insitution name followed (if applicable) by ";" and name of scanning contractor.
        public const ushort HostComputer = 316; //     The computer and/or operating system in use at the time of image creation.Baseline Also used by HD Photo
        public const ushort Predictor = 317; //  A mathematical operator that is applied to the image data before an encoding scheme is applied.Extended
        public const ushort WhitePoint = 318; //  The chromaticity of the white point of the image.	Extended
        public const ushort PrimaryChromaticities = 319; //  The chromaticities of the primaries of the image.Extended
        public const ushort ColorMap = 320; //  A color map for palette color images.Baseline Mandatory for TIFF 6.0 class P.1
        public const ushort HalftoneHints = 321; //  Conveys to the halftone function the range of gray levels within a colorimetrically-specified image that should retain tonal detail.Extended	 
        public const ushort TileWidth = 322; //  The tile width in pixels.This is the number of columns in each tile.Extended    Mandatory for TIFF 6.0 files that use tiles. (Files that use strips employ tags 273, 278, and 279.)
        public const ushort TileLength = 323; //  The tile length (height) in pixels.This is the number of rows in each tile.	Extended Referenced in JHOVE TIFF module for files that use tiles. (Files that use strips employ tags 273, 278, and 279.)
        public const ushort TileOffsets = 324; //  For each tile, the byte offset of that tile, as compressed and stored on disk.Extended Mandatory for TIFF 6.0 files that use tiles. (Files that use strips employ tags 273, 278, and 279.)
        public const ushort TileByteCounts = 325; //  For each tile, the number of (compressed) bytes in that tile.	Extended Mandatory for TIFF 6.0 files that use tiles. (Files that use strips employ tags 273, 278, and 279.)
        public const ushort BadFaxLines = 326; //  Used in the TIFF-F standard, denotes the number of 'bad' scan lines encountered by the facsimile device.Extended
        public const ushort CleanFaxData = 327; //  Used in the TIFF-F standard, indicates if 'bad' lines encountered during reception are stored in the data, or if 'bad' lines have been replaced by the receiver.Extended
        public const ushort ConsecutiveBadFaxLines = 328; //  Used in the TIFF-F standard, denotes the maximum number of consecutive 'bad' scanlines received.	Extended
        public const ushort SubIFDs = 330; //  Offset to child IFDs.	Extended
        public const ushort InkSet = 332; //   The set of inks used in a separated (PhotometricInterpretation= 5) image.Extended	 
        public const ushort InkNames = 333; //  The name of each ink used in a separated image.Extended	 
        public const ushort NumberOfInks = 334; //  The number of inks.Extended	 
        public const ushort DotRange = 336; //  The component values that correspond to a 0% dot and 100% dot.Extended Usage rule in JHOVE TIFF module.
        public const ushort TargetPrinter = 337; //  A description of the printing environment for which this separation is intended.Extended
        public const ushort ExtraSamples = 338; //  Description of extra components.Baseline
        public const ushort SampleFormat = 339; //  Specifies how to interpret each data sample in a pixel.	Extended
        public const ushort SMinSampleValue = 340; //  Specifies the minimum sample value.	Extended
        public const ushort SMaxSampleValue = 341; //  Specifies the maximum sample value.	Extended
        public const ushort TransferRange = 342; //  Expands the range of the TransferFunction.Extended
        public const ushort ClipPath = 343; //  Mirrors the essentials of PostScript's path creation functionality.	Extended	Usage rule in JHOVE TIFF module.
        public const ushort XClipPathUnits = 344; //  The number of units that span the width of the image, in terms of integer ClipPath coordinates.Extended Usage rule in JHOVE TIFF module.
        public const ushort YClipPathUnits = 345; //  The number of units that span the height of the image, in terms of integer ClipPath coordinates.Extended
        public const ushort Indexed = 346; //  Aims to broaden the support for indexed images to include support for any color space.Extended
        public const ushort JPEGTables = 347; //   JPEG quantization and/or Huffman tables.Extended
        public const ushort OPIProxy = 351; //  OPI-related.Extended
        public const ushort GlobalParametersIFD = 400; //  Used in the TIFF-FX standard to point to an IFD containing tags that are globally applicable to the complete TIFF file.	Extended
        public const ushort ProfileType = 401; //  Used in the TIFF-FX standard, denotes the type of data stored in this file or IFD.Extended
        public const ushort FaxProfile = 402; //  Used in the TIFF-FX standard, denotes the 'profile' that applies to this file.Extended
        public const ushort CodingMethods = 403; //  Used in the TIFF-FX standard, indicates which coding methods are used in the file.	Extended
        public const ushort VersionYear = 404; //  Used in the TIFF-FX standard, denotes the year of the standard specified by the FaxProfile field.Extended
        public const ushort ModeNumber = 405; //  Used in the TIFF-FX standard, denotes the mode of the standard specified by the FaxProfile field.Extended
        public const ushort Decode = 433; //   Used in the TIFF-F and TIFF-FX standards, holds information about the ITULAB (PhotometricInterpretation = 10) encoding.	Extended	 
        public const ushort DefaultImageColor = 434; //  Defined in the Mixed Raster Content part of RFC 2301, is the default color needed in areas where no image is available.	Extended	 
        public const ushort JPEGProc = 512; //  Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 
        public const ushort JPEGInterchangeFormat = 513; //  Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 
        public const ushort JPEGInterchangeFormatLength = 514; //  Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 
        public const ushort JPEGRestartInterval = 515; //  Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 
        public const ushort JPEGLosslessPredictors = 517; //  Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 
        public const ushort JPEGPointTransforms = 518; //  Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 
        public const ushort JPEGQTables = 519; //  Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 
        public const ushort JPEGDCTables = 520; //  Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 
        public const ushort JPEGACTables = 521; //  Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 
        public const ushort YCbCrCoefficients = 529; //  The transformation from RGB to YCbCr image data.	Extended Mandatory for TIFF/EP YCbCr images.
        public const ushort YCbCrSubSampling = 530; //  Specifies the subsampling factors used for the chrominance components of a YCbCr image.	Extended Mandatory for TIFF/EP YCbCr images.
        public const ushort YCbCrPositioning = 531; //  Specifies the positioning of subsampled chrominance components relative to luminance samples.	Extended Mandatory for TIFF/EP YCbCr images.
        public const ushort ReferenceBlackWhite = 532; //  Specifies a pair of headroom and footroom image data values (codes) for each pixel component.Extended Mandatory for TIFF 6.0 class Y.1
        public const ushort StripRowCounts = 559; //  Defined in the Mixed Raster Content part of RFC 2301, used to replace RowsPerStrip for IFDs with variable-sized strips.Extended
        public const ushort XMP = 700; //  XML packet containing XMP metadata Extended    Also used by HD Photo
        public const ushort ImageRating = 18246; // .Rating Ratings tag used by Windows Exif private IFD	 
        public const ushort PrivateImageRating = 18249; // .RatingPercent Ratings tag used by Windows, value as percent Exif private IFD	 
        public const ushort ImageID = 32781; //  OPI-related.Extended	 
        public const ushort Wang = 32932; //  Annotation Annotation data, as used in 'Imaging for Windows'.	Private	 
        public const ushort CFARepeatPatternDim = 33421; //  For camera raw files from sensors with CFA overlay.
        public const ushort CFAPattern = 33422; //  For camera raw files from sensors with CFA overlay.	
        public const ushort BatteryLevel = 33423; //  Encodes camera battery level at time of image capture.	
        public const ushort Copyright = 33432; //  Copyright notice.Baseline Also used by HD Photo.
        public const ushort ExposureTime = 33434; //     Exposure time, given in seconds.Exif Private IFD
        public const ushort FNumber = 33437; //  The F number.	Exif Private IFD
        public const ushort MDFileTag = 33445; //  FileTag Specifies the pixel data format encoding in the Molecular Dynamics GEL file format.	Private
        public const ushort MDScalePixel = 33446; //  ScalePixel Specifies a scale factor in the Molecular Dynamics GEL file format.	Private
        public const ushort MDColorTable = 33447; //  ColorTable Used to specify the conversion from 16bit to 8bit in the Molecular Dynamics GEL file format.	Private
        public const ushort MDLabName = 33448; //  LabName Name of the lab that scanned this file, as used in the Molecular Dynamics GEL file format.	Private
        public const ushort MDSampleInfo = 33449; //  SampleInfo Information about the sample, as used in the Molecular Dynamics GEL file format.	Private
        public const ushort MDPrepDate = 33450; //  PrepDate Date the sample was prepared, as used in the Molecular Dynamics GEL file format.	Private
        public const ushort MDPrepTime = 33451; //  PrepTime Time the sample was prepared, as used in the Molecular Dynamics GEL file format.	Private
        public const ushort MDFileUnits = 33452; //  FileUnits Units for data in this file, as used in the Molecular Dynamics GEL file format.	Private
        public const ushort ModelPixelScaleTag = 33550; //  Used in interchangeable GeoTIFF_1_0 files.Private
        public const ushort IPTC = 33723; // /NAA IPTC-NAA (International Press Telecommunications Council-Newspaper Association of America) metadata.TIFF/EP spec, p. 33	Tag name and values defined by IPTC-NAA Info Interchange Model & Digital Newsphoto Parameter Record.
        public const ushort INGRPacketData = 33918; //  Packet Data Tag    Intergraph Application specific storage.	Private
        public const ushort INGRFlagRegisters = 33919; //  Flag Registers Intergraph Application specific flags.Private
        public const ushort IrasB = 33920; //  Transformation Matrix Originally part of Intergraph's GeoTIFF tags, but likely understood by IrasB only.	Private	 
        public const ushort ModelTiepointTag = 33922; //  Originally part of Intergraph's GeoTIFF tags, but now used in interchangeable GeoTIFF_1_0 files.	Private	In GeoTIFF_1_0, either this tag or 34264 must be defined, but not both
        public const ushort Site = 34016; //  Site where image created.TIFF/IT spec, 7.2.3	 
        public const ushort ColorSequence = 34017; //  Sequence of colors if other than CMYK.TIFF/IT spec, 7.2.8.3.2	For BP and BL only2
        public const ushort IT8Header = 34018; //  Certain inherited headers.	TIFF/IT spec, 7.2.3	Obsolete
        public const ushort RasterPadding = 34019; //  Type of raster padding used, if any.TIFF/IT spec, 7.2.6	 
        public const ushort BitsPerRunLength = 34020; //  Number of bits for short run length encoding.	TIFF/IT spec, 7.2.6	For LW only2
        public const ushort BitsPerExtendedRunLength = 34021; //  Number of bits for long run length encoding.	TIFF/IT spec, 7.2.6	For LW only2
        public const ushort ColorTable = 34022; //  Color value in a color pallette.TIFF/IT spec, 7.2.8.4	For BP and BL only2
        public const ushort ImageColorIndicator = 34023; //  Indicates if image (foreground) color or transparency is specified.TIFF/IT spec, 7.2.9	For MP, BP, and BL only2
        public const ushort BackgroundColorIndicator = 34024; //  Background color specification.	TIFF/IT spec, 7.2.9	For BP and BL only2
        public const ushort ImageColorValue = 34025; //  Specifies image (foreground) color.	TIFF/IT spec, 7.2.8.4	For MP, BP, and BL only2
        public const ushort BackgroundColorValue = 34026; //  Specifies background color.	TIFF/IT spec, 7.2.8.4	For BP and BL only2
        public const ushort PixelIntensityRange = 34027; //  Specifies data values for 0 percent and 100 percent pixel intensity.TIFF/IT spec, 7.2.8.4	For MP only2
        public const ushort TransparencyIndicator = 34028; //  Specifies if transparency is used in HC file.	TIFF/IT spec, 7.2.8.4	For HC only2
        public const ushort ColorCharacterization = 34029; //  Specifies ASCII table or other reference per ISO 12641 and ISO 12642.	TIFF/IT spec, 7.2.8.4	 
        public const ushort HCUsage = 34030; //  Indicates the type of information in an HC file.TIFF/IT spec, 7.2.6	For HC only2
        public const ushort TrapIndicator = 34031; //  Indicates whether or not trapping has been applied to the file.	TIFF/IT spec, 7.2.6	 
        public const ushort CMYKEquivalent = 34032; //  Specifies CMYK equivalent for specific separations.	TIFF/IT spec, 7.2.8.3.4	 
        public const ushort Reserved1 = 34033; //  For future TIFF/IT use  TIFF/IT spec	 
        public const ushort Reserved2 = 34034; //  For future TIFF/IT use  TIFF/IT spec	 
        public const ushort Reserved3 = 34035; //  For future TIFF/IT use  TIFF/IT spec	 
        public const ushort ModelTransformationTag = 34264; //  Used in interchangeable GeoTIFF_1_0 files.Private In GeoTIFF_1_0, either this tag or 33922 must be defined, but not both
        public const ushort Photoshop = 34377; //  Collection of Photoshop 'Image Resource Blocks'.	Private
        public const ushort Exif = 34665; //  IFD    A pointer to the Exif IFD.	Private Also used by HD Photo.
        public const ushort InterColorProfile = 34675; //  ICC profile data.	
        public const ushort ImageLayer = 34732; //   Defined in the Mixed Raster Content part of RFC 2301, used to denote the particular function of this Image in the mixed raster scheme.	Extended
        public const ushort GeoKeyDirectoryTag = 34735; //   Used in interchangeable GeoTIFF_1_0 files.Private Mandatory in GeoTIFF_1_0
        public const ushort GeoDoubleParamsTag = 34736; //   Used in interchangeable GeoTIFF_1_0 files.Private
        public const ushort GeoAsciiParamsTag = 34737; //    Used in interchangeable GeoTIFF_1_0 files.Private
        public const ushort ExposureProgram = 34850; //  The class of the program used by the camera to set exposure when the picture is taken.Exif Private IFD
        public const ushort SpectralSensitivity = 34852; //  Indicates the spectral sensitivity of each channel of the camera used.Exif Private IFD
        public const ushort GPSInfo = 34853; //  A pointer to the Exif-related GPS Info IFD.	
        public const ushort ISOSpeedRatings = 34855; //  Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.	Exif Private IFD
        public const ushort OECF = 34856; //  Indicates the Opto-Electric Conversion Function(OECF) specified in ISO 14524.	Exif Private IFD
        public const ushort Interlace = 34857; //  Indicates the field number of multifield images.
        public const ushort TimeZoneOffset = 34858; //   Encodes time zone of camera clock relative to GMT.
        public const ushort SelfTimeMode = 34859; //     Number of seconds image capture was delayed from button press.
        public const ushort SensitivityType = 34864; //  The SensitivityType tag indicates PhotographicSensitivity tag, which one of the parameters of ISO 12232. Although it is an optional tag, it should be recorded when a PhotographicSensitivity tag is recorded.Value = 4, 5, 6, or 7 may be used in case that the values of plural parameters are the same.Exif private IFD	 
        public const ushort StandardOutputSensitivity = 34865; //  This tag indicates the standard output sensitivity value of a camera or input device defined in ISO 12232. When recording this tag, the PhotographicSensitivity and SensitivityType tags shall also be recorded.Exif private IFD	 
        public const ushort RecommendedExposureIndex = 34866; //  This tag indicates the recommended exposure index value of a camera or input device defined in ISO 12232. When recording this tag, the PhotographicSensitivity and SensitivityType tags shall also be recorded.Exif private IFD	 
        public const ushort ISOSpeed = 34867; //  This tag indicates the ISO speed value of a camera or input device that is defined in ISO 12232. When recording this tag, the PhotographicSensitivity and SensitivityType tags shall also be recorded.Exif private IFD	 
        public const ushort ISOSpeedLatitudeyyy = 34868; //  This tag indicates the ISO speed latitude yyy value of a camera or input device that is defined in ISO 12232. However, this tag shall not be recorded without ISOSpeed and ISOSpeedLatitudezzz.Exif private IFD	 
        public const ushort ISOSpeedLatitudezzz = 34869; //  This tag indicates the ISO speed latitude zzz value of a camera or input device that is defined in ISO 12232. However, this tag shall not be recorded without ISOSpeed and ISOSpeedLatitudeyyy.Exif private IFD	 
        public const ushort HylaFAXRecvParams = 34908; //  FaxRecvParams Used by HylaFAX.Private
        public const ushort HylaFAXSubaddress = 34909; //  FaxSubAddress   Used by HylaFAX.Private
        public const ushort HylaFAXRecvTime = 34910; //  FaxRecvTime Used by HylaFAX.Private
        public const ushort ExifVersion = 36864; //  The version of the supported Exif standard.	Exif Private IFD Mandatory in the Exif IFD.
        public const ushort DateTimeOriginal = 36867; //  The date and time when the original image data was generated.	Exif Private IFD
        public const ushort DateTimeDigitized = 36868; //  The date and time when the image was stored as digital data.	Exif Private IFD
        public const ushort ComponentsConfiguration = 37121; //  Specific to compressed data; specifies the channels and complements PhotometricInterpretation   Exif Private IFD	 
        public const ushort CompressedBitsPerPixel = 37122; //  Specific to compressed data; states the compressed bits per pixel.Exif Private IFD
        public const ushort ShutterSpeedValue = 37377; //  Shutter speed.Exif Private IFD
        public const ushort ApertureValue = 37378; //  The lens aperture.	Exif Private IFD
        public const ushort BrightnessValue = 37379; //  The value of brightness.Exif Private IFD
        public const ushort ExposureBiasValue = 37380; //  The exposure bias.	Exif Private IFD
        public const ushort MaxApertureValue = 37381; //  The smallest F number of the lens.	Exif Private IFD
        public const ushort SubjectDistance = 37382; //  The distance to the subject, given in meters.Exif Private IFD
        public const ushort MeteringMode = 37383; //  The metering mode.	Exif Private IFD
        public const ushort LightSource = 37384; //  The kind of light source.	Exif Private IFD
        public const ushort Flash = 37385; //  Indicates the status of flash when the image was shot.Exif Private IFD
        public const ushort FocalLength = 37386; //  The actual focal length of the lens, in mm.Exif Private IFD
        public const ushort FlashEnergy = 37387; //  Amount of flash energy (BCPS).	
        public const ushort SpatialFrequencyResponse = 37388; //     SFR of the camera.	
        public const ushort Noise = 37389; //  Noise measurement values.	
        public const ushort FocalPlaneXResolution = 37390; //  Number of pixels per FocalPlaneResolutionUnit (37392) in ImageWidth direction for main image.
        public const ushort FocalPlaneYResolution = 37391; //  Number of pixels per FocalPlaneResolutionUnit (37392) in ImageLength direction for main image.
        public const ushort FocalPlaneResolutionUnit = 37392; //  Unit of measurement for FocalPlaneXResolution(37390) and FocalPlaneYResolution(37391).	
        public const ushort ImageNumber = 37393; //  Number assigned to an image, e.g., in a chained image burst.
        public const ushort SecurityClassification = 37394; //  Security classification assigned to the image.
        public const ushort ImageHistory = 37395; //  Record of what has been done to the image.	
        public const ushort SubjectLocation = 37396; //  Indicates the location and area of the main subject in the overall scene.Exif Private IFD
        public const ushort ExposureIndex = 37397; //  Encodes the camera exposure index setting when image was captured.
        public const ushort TIFF = 37398; // /EPStandardID For current spec, tag value equals 1 0 0 0.	
        public const ushort SensingMethod = 37399; //  Type of image sensor.
        public const ushort MakerNote = 37500; //    Manufacturer specific information.Exif Private IFD	 
        public const ushort UserComment = 37510; //  Keywords or comments on the image; complements ImageDescription.Exif Private IFD	 
        public const ushort SubsecTime = 37520; //  A tag used to record fractions of seconds for the DateTime tag.Exif Private IFD
        public const ushort SubsecTimeOriginal = 37521; //  A tag used to record fractions of seconds for the DateTimeOriginal tag.Exif Private IFD
        public const ushort SubsecTimeDigitized = 37522; //  A tag used to record fractions of seconds for the DateTimeDigitized tag.Exif Private IFD
        public const ushort ImageSourceData = 37724; //  Used by Adobe Photoshop.	Private
        public const ushort XPTitle = 40091; //  Title tag used by Windows, encoded in UCS2 Exif Private IFD	 
        public const ushort XPComment = 40092; //    Comment tag used by Windows, encoded in UCS2 Exif Private IFD	 
        public const ushort XPAuthor = 40093; //     Author tag used by Windows, encoded in UCS2 Exif Private IFD	 
        public const ushort XPKeywords = 40094; //   Keywords tag used by Windows, encoded in UCS2 Exif Private IFD	 
        public const ushort XPSubject = 40095; //    Subject tag used by Windows, encoded in UCS2 Exif Private IFD	 
        public const ushort FlashpixVersion = 40960; //  The Flashpix format version supported by a FPXR file.Exif Private IFD Mandatory in the Exif IFD
        public const ushort ColorSpace = 40961; //   The color space information tag is always recorded as the color space specifier.	Exif Private IFD Mandatory in the Exif IFD
        public const ushort PixelXDimension = 40962; //  Specific to compressed data; the valid width of the meaningful image.Exif Private IFD	 
        public const ushort PixelYDimension = 40963; //  Specific to compressed data; the valid height of the meaningful image.Exif Private IFD	 
        public const ushort RelatedSoundFile = 40964; //     Used to record the name of an audio file related to the image data.Exif Private IFD	 
        public const ushort Interoperability = 40965; //  IFD A pointer to the Exif-related Interoperability IFD.Private
        public const ushort FlashEnergyExifPrivate = 41483; //  Indicates the strobe energy at the time the image is captured, as measured in Beam Candle Power Seconds Exif Private IFD
        public const ushort SpatialFrequencyResponseExifPrivate = 41484; //     Records the camera or input device spatial frequency table and SFR values in the direction of image width, image height, and diagonal direction, as specified in ISO 12233.	Exif Private IFD
        public const ushort FocalPlaneXResolutionExifPrivate = 41486; //    Indicates the number of pixels in the image width (X) direction per FocalPlaneResolutionUnit on the camera focal plane.Exif Private IFD
        public const ushort FocalPlaneYResolutionExifPrivate = 41487; //    Indicates the number of pixels in the image height (Y) direction per FocalPlaneResolutionUnit on the camera focal plane.Exif Private IFD
        public const ushort FocalPlaneResolutionUnitExifPrivate = 41488; //     Indicates the unit for measuring FocalPlaneXResolution and FocalPlaneYResolution.	Exif Private IFD
        public const ushort SubjectLocationExifPrivate = 41492; //  Indicates the location of the main subject in the scene.	Exif Private IFD
        public const ushort ExposureIndexExifPrivate = 41493; //    Indicates the exposure index selected on the camera or input device at the time the image is captured.Exif Private IFD
        public const ushort SensingMethodExifPrivate = 41495; //    Indicates the image sensor type on the camera or input device.Exif Private IFD
        public const ushort FileSource = 41728; //   Indicates the image source.	Exif Private IFD Req'd in LC NDNP TIFF profile. Values: "microfilm," "microfiche," or "print."
        public const ushort SceneType = 41729; //    Indicates the type of scene.Exif Private IFD
        public const ushort CFAPatternExifPrivate = 41730; //   Indicates the color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used.Exif Private IFD
        public const ushort CustomRendered = 41985; //   Indicates the use of special processing on image data, such as rendering geared to output.	Exif Private IFD
        public const ushort ExposureMode = 41986; //     Indicates the exposure mode set when the image was shot.	Exif Private IFD
        public const ushort WhiteBalance = 41987; //     Indicates the white balance mode set when the image was shot.Exif Private IFD
        public const ushort DigitalZoomRatio = 41988; //     Indicates the digital zoom ratio when the image was shot.	Exif Private IFD
        public const ushort FocalLengthIn35mmFilm = 41989; //    Indicates the equivalent focal length assuming a 35mm film camera, in mm.Exif Private IFD
        public const ushort SceneCaptureType = 41990; //     Indicates the type of scene that was shot.	Exif Private IFD
        public const ushort GainControl = 41991; //  Indicates the degree of overall image gain adjustment.	Exif Private IFD
        public const ushort Contrast = 41992; //     Indicates the direction of contrast processing applied by the camera when the image was shot.Exif Private IFD
        public const ushort Saturation = 41993; //   Indicates the direction of saturation processing applied by the camera when the image was shot.Exif Private IFD
        public const ushort Sharpness = 41994; //    Indicates the direction of sharpness processing applied by the camera when the image was shot.Exif Private IFD
        public const ushort DeviceSettingDescription = 41995; //     This tag indicates information on the picture-taking conditions of a particular camera model.Exif Private IFD
        public const ushort SubjectDistanceRange = 41996; //     Indicates the distance to the subject.	Exif Private IFD
        public const ushort ImageUniqueID = 42016; //    Indicates an identifier assigned uniquely to each image.	Exif Private IFD Req'd in LC NDNP TIFF profile. Microfilm reel sequence number. If from paper: "issue date-edition-page sequence."
        public const ushort CameraOwnerName = 42032; //  Camera owner name as ASCII string.	Exif Private IFD
        public const ushort BodySerialNumber = 42033; //     Camera body serial number as ASCII string.	Exif Private IFD
        public const ushort LensSpecification = 42034; //    This tag notes minimum focal length, maximum focal length, minimum F number in the minimum focal length, and minimum F number in the maximum focal length, which are specification information for the lens that was used in photography.When the minimum F number is unknown, the notation is 0/0.	Exif Private IFD
        public const ushort LensMake = 42035; //     Lens manufacturer name as ASCII string.	Exif Private IFD
        public const ushort LensModel = 42036; //    Lens model name and number as ASCII string.	Exif Private IFD
        public const ushort LensSerialNumber = 42037; //     Lens serial number as ASCII string.	Exif Private IFD
        public const ushort GDAL_METADATA = 42112; //    Used by the GDAL library, holds an XML list of name = value 'metadata' values about the image as a whole, and about specific samples.	Private
        public const ushort GDAL_NODATA = 42113; //  Used by the GDAL library, contains an ASCII encoded nodata or background pixel value.Private
        public const ushort PixelFormat = 48129; //  A 128-bit Globally Unique Identifier (GUID) that identifies the image pixel format.HD Photo Feature Spec, p. 17	 
        public const ushort Transformation = 48130; //   Specifies the transformation to be applied when decoding the image to present the desired representation.HD Photo Feature Spec, p. 23	 
        public const ushort Uncompressed = 48131; //     Specifies that image data is uncompressed.HD Photo Feature Spec, p. 23	 
        public const ushort ImageType = 48132; //    Specifies the image type of each individual frame in a multi-frame file.	HD Photo Feature Spec, p. 27	 
        public const ushort ImageWidthHD = 48256; //   Specifies the number of columns in the transformed photo, or the number of pixels per scan line.	HD Photo Feature Spec, p. 21	 
        public const ushort ImageHeight = 48257; //  Specifies the number of pixels or scan lines in the transformed photo.HD Photo Feature Spec, p. 21	 
        public const ushort WidthResolution = 48258; //  Specifies the horizontal resolution of a transformed image expressed in pixels per inch.HD Photo Feature Spec, p. 21	 
        public const ushort HeightResolution = 48259; //     Specifies the vertical resolution of a transformed image expressed in pixels per inch.HD Photo Feature Spec, p. 21	 
        public const ushort ImageOffset = 48320; //  Specifies the byte offset pointer to the beginning of the photo data, relative to the beginning of the file.HD Photo Feature Spec, p. 22	 
        public const ushort ImageByteCount = 48321; //   Specifies the size of the photo in bytes.HD Photo Feature Spec, p. 22	 
        public const ushort AlphaOffset = 48322; //  Specifies the byte offset pointer the beginning of the planar alpha channel data, relative to the beginning of the file.HD Photo Feature Spec, p. 22	 
        public const ushort AlphaByteCount = 48323; //   Specifies the size of the alpha channel data in bytes.HD Photo Feature Spec, p. 23	 
        public const ushort ImageDataDiscard = 48324; //     Signifies the level of data that has been discarded from the image as a result of a compressed domain transcode to reduce the file size.	HD Photo Feature Spec, p. 25	 
        public const ushort AlphaDataDiscard = 48325; //     Signifies the level of data that has been discarded from the planar alpha channel as a result of a compressed domain transcode to reduce the file size.	HD Photo Feature Spec, p. 26	 
        public const ushort OceDesc = 50215; //  Scanjob Description Used in the Oce scanning process.	Private
        public const ushort OceAppSelector = 50216; //  Application Selector    Used in the Oce scanning process.	Private
        public const ushort OceIDNumber = 50217; //  Identification Number   Used in the Oce scanning process.	Private
        public const ushort OceCharacteristics = 50218; //  ImageLogic Characteristics  Used in the Oce scanning process.	Private
        public const ushort PrintImageMatching = 50341; //   Description needed.	Exif Private IFD
        public const ushort DNGVersion = 50706; //   Encodes DNG four-tier version number; for version 1.1.0.0, the tag contains the bytes 1, 1, 0, 0. Used in IFD 0 of DNG files.
        public const ushort DNGBackwardVersion = 50707; //   Defines oldest version of spec with which file is compatible.Used in IFD 0 of DNG files.
        public const ushort UniqueCameraModel = 50708; //    Unique, non-localized nbame for camera model.Used in IFD 0 of DNG files.
        public const ushort LocalizedCameraModel = 50709; //     Similar to 50708, with localized camera name.Used in IFD 0 of DNG files.
        public const ushort CFAPlaneColor = 50710; //    Mapping between values in the CFAPattern tag and the plane numbers in LinearRaw space.Used in Raw IFD of DNG files.
        public const ushort CFALayout = 50711; //    Spatial layout of the CFA.Used in Raw IFD of DNG files.
        public const ushort LinearizationTable = 50712; //   Lookup table that maps stored values to linear values.Used in Raw IFD of DNG files.
        public const ushort BlackLevelRepeatDim = 50713; //  Repeat pattern size for BlackLevel tag.Used in Raw IFD of DNG files.
        public const ushort BlackLevel = 50714; //   Specifies the zero light encoding level.Used in Raw IFD of DNG files.
        public const ushort BlackLevelDeltaH = 50715; //     Specifies the difference between zero light encoding level for each column and the baseline zero light encoding level.Used in Raw IFD of DNG files.
        public const ushort BlackLevelDeltaV = 50716; //     Specifies the difference between zero light encoding level for each row and the baseline zero light encoding level.Used in Raw IFD of DNG files.
        public const ushort WhiteLevel = 50717; //   Specifies the fully saturated encoding level for the raw sample values.Used in Raw IFD of DNG files.
        public const ushort DefaultScale = 50718; //     For cameras with non-square pixels, specifies the default scale factors for each direction to convert the image to square pixels.Used in Raw IFD of DNG files.
        public const ushort DefaultCropOrigin = 50719; //    Specifies the origin of the final image area, ignoring the extra pixels at edges used to prevent interpolation artifacts.Used in Raw IFD of DNG files.
        public const ushort DefaultCropSize = 50720; //  Specifies size of final image area in raw image coordinates.Used in Raw IFD of DNG files.
        public const ushort ColorMatrix1 = 50721; //     Defines a transformation matrix that converts XYZ values to reference camera native color space values, under the first calibration illuminant.Used in IFD 0 of DNG files.
        public const ushort ColorMatrix2 = 50722; //     Defines a transformation matrix that converts XYZ values to reference camera native color space values, under the second calibration illuminant.Used in IFD 0 of DNG files.
        public const ushort CameraCalibration1 = 50723; //   Defines a calibration matrix that transforms reference camera native space values to individual camera native space values under the first calibration illuminant.Used in IFD 0 of DNG files.
        public const ushort CameraCalibration2 = 50724; //   Defines a calibration matrix that transforms reference camera native space values to individual camera native space values under the second calibration illuminant.Used in IFD 0 of DNG files.
        public const ushort ReductionMatrix1 = 50725; //     Defines a dimensionality reduction matrix for use as the first stage in converting color camera native space values to XYZ values, under the first calibration illuminant.Used in IFD 0 of DNG files.
        public const ushort ReductionMatrix2 = 50726; //     Defines a dimensionality reduction matrix for use as the first stage in converting color camera native space values to XYZ values, under the second calibration illuminant.Used in IFD 0 of DNG files.
        public const ushort AnalogBalance = 50727; //    Pertaining to white balance, defines the gain, either analog or digital, that has been applied to the stored raw values.Used in IFD 0 of DNG files.
        public const ushort AsShotNeutral = 50728; //    Specifies the selected white balance at the time of capture, encoded as the coordinates of a perfectly neutral color in linear reference space values.Used in IFD 0 of DNG files.
        public const ushort AsShotWhiteXY = 50729; //    Specifies the selected white balance at the time of capture, encoded as x-y chromaticity coordinates.Used in IFD 0 of DNG files.
        public const ushort BaselineExposure = 50730; //     Specifies in EV units how much to move the zero point for exposure compensation.Used in IFD 0 of DNG files.
        public const ushort BaselineNoise = 50731; //    Specifies the relative noise of the camera model at a baseline ISO value of 100, compared to reference camera model.Used in IFD 0 of DNG files.
        public const ushort BaselineSharpness = 50732; //    Specifies the relative amount of sharpening required for this camera model, compared to reference camera model.Used in IFD 0 of DNG files.
        public const ushort BayerGreenSplit = 50733; //  For CFA images, specifies, in arbitrary units, how closely the values of the green pixels in the blue/green rows track the values of the green pixels in the red/green rows.Used in Raw IFD of DNG files.
        public const ushort LinearResponseLimit = 50734; //  Specifies the fraction of the encoding range above which the response may become significantly non-linear.Used in IFD 0 of DNG files.
        public const ushort CameraSerialNumber = 50735; //   Serial number of camera.Used in IFD 0 of DNG files.
        public const ushort LensInfo = 50736; //     Information about the lens.Used in IFD 0 of DNG files.
        public const ushort ChromaBlurRadius = 50737; //     Normally for non-CFA images, provides a hint about how much chroma blur ought to be applied.Used in Raw IFD of DNG files.
        public const ushort AntiAliasStrength = 50738; //    Provides a hint about the strength of the camera's anti-aliasing filter. Used in Raw IFD of DNG files.	
        public const ushort DNGPrivateData = 50740; //   Provides a way for camera manufacturers to store private data in DNG files for use by their own raw convertors.Used in IFD 0 of DNG files.
        public const ushort MakerNoteSafety = 50741; //  Lets the DNG reader know whether the Exif MakerNote tag is safe to preserve.Used in IFD 0 of DNG files.
        public const ushort CalibrationIlluminant1 = 50778; //   Illuminant used for first set of calibration tags.Used in IFD 0 of DNG files.
        public const ushort CalibrationIlluminant2 = 50779; //   Illuminant used for second set of calibration tags.Used in IFD 0 of DNG files.
        public const ushort BestQualityScale = 50780; //     Specifies the amount by which the values of the DefaultScale tag need to be multiplied to achieve best quality image size.Used in Raw IFD of DNG files.
        public const ushort RawDataUniqueID = 50781; //  Contains a 16-byte unique identifier for the raw image file in the DNG file.Used in IFD 0 of DNG files.
        public const ushort Alias = 50784; //  Layer Metadata    Alias Sketchbook Pro layer usage description.Private
        public const ushort OriginalRawFileName = 50827; //  Name of original file if the DNG file results from conversion from a non-DNG raw file.Used in IFD 0 of DNG files.
        public const ushort OriginalRawFileData = 50828; //  If the DNG file was converted from a non-DNG raw file, then this tag contains the original raw data. Used in IFD 0 of DNG files.
        public const ushort ActiveArea = 50829; //  Defines the active (non-masked) pixels of the sensor.Used in Raw IFD of DNG files.
        public const ushort MaskedAreas = 50830; //  List of non-overlapping rectangle coordinates of fully masked pixels, which can optimally be used by DNG readers to measure the black encoding level.Used in Raw IFD of DNG files.
        public const ushort AsShotICCProfile = 50831; //  Contains ICC profile that, in conjunction with the AsShotPreProfileMatrix tag, specifies a default color rendering from camera color space coordinates(linear reference values) into the ICC profile connection space.Used in IFD 0 of DNG files.
        public const ushort AsShotPreProfileMatrix = 50832; //  Specifies a matrix that should be applied to the camera color space coordinates before processing the values through the ICC profile specified in the AsShotICCProfile tag.Used in IFD 0 of DNG files.
        public const ushort CurrentICCProfile = 50833; //  The CurrentICCProfile and CurrentPreProfileMatrix tags have the same purpose and usage as
        public const ushort CurrentPreProfileMatrix = 50834; //  The CurrentICCProfile and CurrentPreProfileMatrix tags have the same purpose and usage as the AsShotICCProfile and AsShotPreProfileMatrix tag pair, except they are for use by raw file editors rather than camera manufacturers.Used in IFD 0 of DNG files.
        public const ushort ColorimetricReference = 50879; //    The DNG color model documents a transform between camera colors and CIE XYZ values.This tag describes the colorimetric reference for the CIE XYZ values. 0 = The XYZ values are scene-referred. 1 = The XYZ values are output-referred, using the ICC profile perceptual dynamic range.Used in IFD 0 of DNG files.
        public const ushort CameraCalibrationSignature = 50931; //   A UTF-8 encoded string associated with the CameraCalibration1 and CameraCalibration2 tags.Used in IFD 0 of DNG files.
        public const ushort ProfileCalibrationSignature = 50932; //  A UTF-8 encoded string associated with the camera profile tags.Used in IFD 0 or CameraProfile IFD of DNG files.
        public const ushort ExtraCameraProfiles = 50933; //  A list of file offsets to extra Camera Profile IFDs.The format of a camera profile begins with a 16-bit byte order mark (MM or II) followed by a 16-bit "magic" number equal to 0x4352 (CR), a 32-bit IFD offset, and then a standard TIFF format IFD.Used in IFD 0 of DNG files.
        public const ushort AsShotProfileName = 50934; //    A UTF-8 encoded string containing the name of the "as shot" camera profile, if any.Used in IFD 0 of DNG files.
        public const ushort NoiseReductionApplied = 50935; //    Indicates how much noise reduction has been applied to the raw data on a scale of 0.0 to 1.0. A 0.0 value indicates that no noise reduction has been applied.A 1.0 value indicates that the "ideal" amount of noise reduction has been applied, i.e.that the DNG reader should not apply additional noise reduction by default. A value of 0/0 indicates that this parameter is unknown.Used in Raw IFD of DNG files.
        public const ushort ProfileName = 50936; //  A UTF-8 encoded string containing the name of the camera profile. Used in IFD 0 or Camera Profile IFD of DNG files.	
        public const ushort ProfileHueSatMapDims = 50937; //  Specifies the number of input samples in each dimension of the hue/saturation/value mapping tables. The data for these tables are stored in ProfileHueSatMapData1 and ProfileHueSatMapData2 tags. Allowed values include the following: HueDivisions >= 1; SaturationDivisions >= 2; ValueDivisions >=1. Used in IFD 0 or Camera Profile IFD of DNG files.	
        public const ushort ProfileHueSatMapData1 = 50938; //  Contains the data for the first hue/saturation/value mapping table. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees; the second entry is saturation scale factor; and the third entry is a value scale factor. Used in IFD 0 or Camera Profile IFD of DNG files.	
        public const ushort ProfileHueSatMapData2 = 50939; //  Contains the data for the second hue/saturation/value mapping table. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees; the second entry is saturation scale factor; and the third entry is a value scale factor. Used in IFD 0 or Camera Profile IFD of DNG files.	
        public const ushort ProfileToneCurve = 50940; //  Contains a default tone curve that can be applied while processing the image as a starting point for user adjustments. The curve is specified as a list of 32-bit IEEE floating-point value pairs in linear gamma. Each sample has an input value in the range of 0.0 to 1.0, and an output value in the range of 0.0 to 1.0. The first sample is required to be (0.0, 0.0), and the last sample is required to be (1.0, 1.0). Interpolated the curve using a cubic spline.Used in IFD 0 or Camera Profile IFD of DNG files.
        public const ushort ProfileEmbedPolicy = 50941; //   Contains information about the usage rules for the associated camera profile.The valid values and meanings are: 0 = “allow copying”; 1 = “embed if used”; 2 = “embed never”; and 3 = “no restrictions”. Used in IFD 0 or Camera Profile IFD of DNG files.
        public const ushort ProfileCopyright = 50942; //     Contains information about the usage rules for the associated camera profile.The valid values and meanings are: 0 = “allow copying”; 1 = “embed if used”; 2 = “embed never”; and 3 = “no restrictions”. Used in IFD 0 or Camera Profile IFD of DNG files.
        public const ushort ForwardMatrix1 = 50964; //   Defines a matrix that maps white balanced camera colors to XYZ D50 colors.Used in IFD 0 or Camera Profile IFD of DNG files.
        public const ushort ForwardMatrix2 = 50965; //   Defines a matrix that maps white balanced camera colors to XYZ D50 colors.Used in IFD 0 or Camera Profile IFD of DNG files.
        public const ushort PreviewApplicationName = 50966; //   A UTF-8 encoded string containing the name of the application that created the preview stored in the IFD.Used in Preview IFD of DNG files.
        public const ushort PreviewApplicationVersion = 50967; //    A UTF-8 encoded string containing the version number of the application that created the preview stored in the IFD.Used in Preview IFD of DNG files.
        public const ushort PreviewSettingsName = 50968; //  A UTF-8 encoded string containing the name of the conversion settings(for example, snapshot name) used for the preview stored in the IFD.Used in Preview IFD of DNG files.
        public const ushort PreviewSettingsDigest = 50969; //    A unique ID of the conversion settings(for example, MD5 digest) used to render the preview stored in the IFD.Used in Preview IFD of DNG files.
        public const ushort PreviewColorSpace = 50970; //    This tag specifies the color space in which the rendered preview in this IFD is stored.The valid values include: 0 = Unknown; 1 = Gray Gamma 2.2; 2 = sRGB; 3 = Adobe RGB; and 4 = ProPhoto RGB. Used in Preview IFD of DNG files.
        public const ushort PreviewDateTime = 50971; //  This tag is an ASCII string containing the name of the date/time at which the preview stored in the IFD was rendered, encoded using ISO 8601 format.Used in Preview IFD of DNG files.
        public const ushort RawImageDigest = 50972; //   MD5 digest of the raw image data.All pixels in the image are processed in row-scan order.Each pixel is zero padded to 16 or 32 bits deep (16-bit for data less than or equal to 16 bits deep, 32-bit otherwise). The data is processed in little-endian byte order.Used in IFD 0 of DNG files.
        public const ushort OriginalRawFileDigest = 50973; //    MD5 digest of the data stored in the OriginalRawFileData tag.Used in IFD 0 of DNG files.
        public const ushort SubTileBlockSize = 50974; //     Normally, pixels within a tile are stored in simple row-scan order.This tag specifies that the pixels within a tile should be grouped first into rectangular blocks of the specified size.These blocks are stored in row-scan order. Within each block, the pixels are stored in row-scan order. Used in Raw IFD of DNG files.
        public const ushort RowInterleaveFactor = 50975; //  Specifies that rows of the image are stored in interleaved order.The value of the tag specifies the number of interleaved fields. Used in Raw IFD of DNG files.
        public const ushort ProfileLookTableDims = 50981; //     Specifies the number of input samples in each dimension of a default "look" table.The data for this table is stored in the ProfileLookTableData tag.Allowed values include: HueDivisions >= 1; SaturationDivisions >= 2; and ValueDivisions >= 1. Used in IFD 0 or Camera Profile IFD of DNG files.
        public const ushort ProfileLookTableData = 50982; //  Default "look" table that can be applied while processing the image as a starting point for user adjustment. This table uses the same format as the tables stored in the ProfileHueSatMapData1 and ProfileHueSatMapData2 tags, and is applied in the same color space. However, it should be applied later in the processing pipe, after any exposure compensation and/or fill light stages, but before any tone curve stage. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees, the second entry is a saturation scale factor, and the third entry is a value scale factor. Used in IFD 0 or Camera Profile IFD of DNG files.	
        public const ushort OpcodeList1 = 51008; //  Specifies the list of opcodes (image processing operation codes) that should be applied to the raw image, as read directly from the file. Used in Raw IFD of DNG files.	
        public const ushort OpcodeList2 = 51009; //  Specifies the list of opcodes (image processing operation codes) that should be applied to the raw image, just after it has been mapped to linear reference values. Used in Raw IFD of DNG files.	
        public const ushort OpcodeList3 = 51022; //  Specifies the list of opcodes (image processing operation codes) that should be applied to the raw image, just after it has been demosaiced. Used in Raw IFD of DNG files.	
        public const ushort NoiseProfile = 51041; //  Describes the amount of noise in a raw image; models the amount of signal-dependent photon (shot) noise and signal-independent sensor readout noise, two common sources of noise in raw images. Used in Raw IFD of DNG files.	
        public const ushort OriginalDefaultFinalSize = 51089; //  If this file is a proxy for a larger original DNG file, this tag specifics the default final size of the larger original file from which this proxy was generated. The default value for this tag is default final size of the current DNG file, which is DefaultCropSize * DefaultScale.	DNG spec (1.4, 2012), p. 74	 
        public const ushort OriginalBestQualityFinalSize = 51090; //  If this file is a proxy for a larger original DNG file, this tag specifics the best quality final size of the larger original file from which this proxy was generated. The default value for this tag is the OriginalDefaultFinalSize, if specified. Otherwise the default value for this tag is the best quality size of the current DNG file, which is DefaultCropSize * DefaultScale * BestQualityScale.	DNG spec (1.4, 2012), p. 75	 
        public const ushort OriginalDefaultCropSize = 51091; //  If this file is a proxy for a larger original DNG file, this tag specifics the DefaultCropSize of the larger original file from which this proxy was generated. The default value for this tag is the OriginalDefaultFinalSize, if specified. Otherwise, the default value for this tag is the DefaultCropSize of the current DNG file.	DNG spec (1.4, 2012), p. 75	 
        public const ushort ProfileHueSatMapEncoding = 51107; //  Provides a way for color profiles to specify how indexing into a 3D HueSatMap is performed during raw conversion. This tag is not applicable to 2.5D HueSatMap tables (i.e., where the Value dimension is 1). The currently defined values are: 0 = Linear encoding (method described in DNG spec); 1 = sRGB encoding (method described in DNG spec).	DNG spec (1.4, 2012), p. 73	 
        public const ushort ProfileLookTableEncoding = 51108; //  Provides a way for color profiles to specify how indexing into a 3D LookTable is performed during raw conversion. This tag is not applicable to a 2.5D LookTable (i.e., where the Value dimension is 1). The currently defined values are: 0 = Linear encoding (method described in DNG spec); 1 = sRGB encoding (method described in DNG spec).	DNG spec (1.4, 2012), p. 72-3	 
        public const ushort BaselineExposureOffset = 51109; //  Provides a way for color profiles to increase or decrease exposure during raw conversion. BaselineExposureOffset specifies the amount (in EV units) to add to th e BaselineExposure tag during image rendering. For example, if the BaselineExposure value fo r a given camera model is +0.3, and the BaselineExposureOffset value for a given camera profile used to render an image for that camera model is -0.7, then th e actual default exposure value used during rendering will be + 0.3 - 0.7 = -0.4.DNG spec(1.4, 2012), p. 71
        public const ushort DefaultBlackRender = 51110; //   This optional tag in a color profile provides a hint to the raw converter regarding how to handle the black point(e.g., flare subtraction) during rendering.The currently defined values are: 0 = Auto; 1 = None.If set to Auto, the raw converter should perform black subtraction during rendering.The amount and method of black subtraction may be automatically determined and may be image - dependent.If set to None, the raw converter should not perform any black subtraction during rendering.This may be desirable when using color lookup tables(e.g., LookTable) or tone curves in camera profiles to perform a fixed, consistent level of black subtraction.	DNG spec(1.4, 2012), p. 71
        public const ushort NewRawImageDigest = 51111; //    This tag is a modified MD5 digest of the raw image data.It has been updated from the algorithm used to compute the RawImageDigest tag be more multi-processor friendly, and to support lossy compression algorithms. The details of the algorithm used to compute this tag are documented in the Adobe DNG SDK source code.	DNG spec(1.4, 2012), p. 76
        public const ushort RawToPreviewGain = 51112; //     The gain(what number the sample values are multiplied by) between the main raw IFD and the preview IFD containing this tag.DNG spec(1.4, 2012), p. 76
        public const ushort DefaultUserCrop = 51125; //  Specifies a default user crop rectangle in relative coordinates. The values must satisfy: 0.0 <= top < bottom <= 1.0; 0.0 <= left < right <= 1.0.The default values of(top = 0, left = 0, bottom = 1, right = 1) correspond exactly to the default crop rectangle(as specified by the DefaultCropOrigin and DefaultCropSize tags).	DNG spec(1.4, 2012), p. 70
        public const ushort OffsetSchema = 59933; // Microsoft's offset to makers note

        public static string ToString(ushort tagNumber, bool longDesc = false)
        {
            string tagName = "";

            switch (tagNumber)
            {
               
                case TiffTags.NewSubfileType:
                    tagName = "NewSubfileType";
                    if (longDesc) { tagName += "  A general indication of the kind of data contained in this subfile.Baseline Req'd in LC RFP97-6 Section C.4.7."; }
                    break;
                case TiffTags.SubfileType:
                    tagName = "SubfileType";
                    if (longDesc) { tagName += " A general indication of the kind of data contained in this subfile.Baseline	 "; }
                    break;
                case TiffTags.ImageWidth:
                    tagName = "ImageWidth";
                    if (longDesc) { tagName += " The number of columns in the image, i.e., the number of pixels per row.Baseline    Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.ImageLength:
                    tagName = "ImageLength";
                    if (longDesc) { tagName += " The number of rows of pixels in the image.	Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.BitsPerSample:
                    tagName = "BitsPerSample";
                    if (longDesc) { tagName += " Number of bits per component.	Baseline"; }
                    break;
                case TiffTags.Compression:
                    tagName = "Compression";
                    if (longDesc) { tagName += " Compression scheme used on the image data.	Baseline Listed in LoC Baseline Tags.Sample values: 1=uncompressed and 4=CCITT Group 4."; }
                    break;
                case TiffTags.PhotometricInterpretation:
                    tagName = "PhotometricInterpretation";
                    if (longDesc) { tagName += " The color space of the image data.	Baseline Listed in LoC Baseline Tags.Sample values: 1=black is zero and 2=RGB.Document also states 'RGB is assumed to be sRGB; if RGB, an ICC profile should be present in the 34675 tag.'"; }
                    break;
                case TiffTags.Threshholding:
                    tagName = "Threshholding";
                    if (longDesc) { tagName += " For black and white TIFF files that represent shades of gray, the technique used to convert from gray to black and white pixels.	Baseline Usage rule in JHOVE TIFF module."; }
                    break;
                case TiffTags.CellWidth:
                    tagName = "CellWidth";
                    if (longDesc) { tagName += " The width of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file.	Baseline"; }
                    break;
                case TiffTags.CellLength:
                    tagName = "CellLength";
                    if (longDesc) { tagName += " The length of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file.	Baseline Usage rule in JHOVE TIFF module."; }
                    break;
                case TiffTags.FillOrder:
                    tagName = "FillOrder";
                    if (longDesc) { tagName += "   The logical order of bits within a byte.	Baseline"; }
                    break;
                case TiffTags.DocumentName:
                    tagName = "DocumentName";
                    if (longDesc) { tagName += " The name of the document from which this image was scanned.Extended Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.ImageDescription:
                    tagName = "ImageDescription";
                    if (longDesc) { tagName += " A string that describes the subject of the image.	Baseline Also used by HD Photo"; }
                    break;
                case TiffTags.Make:
                    tagName = "Make";
                    if (longDesc) { tagName += " The scanner manufacturer.	Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.Model:
                    tagName = "Model";
                    if (longDesc) { tagName += " The scanner model name or number.Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.StripOffsets:
                    tagName = "StripOffsets";
                    if (longDesc) { tagName += " For each strip, the byte offset of that strip.Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.Orientation:
                    tagName = "Orientation";
                    if (longDesc) { tagName += " The orientation of the image with respect to the rows and columns.Baseline Req'd in LC NDNP TIFF profile."; }
                    break;
                case TiffTags.SamplesPerPixel:
                    tagName = "SamplesPerPixel";
                    if (longDesc) { tagName += " The number of components per pixel.Baseline Listed in LoC Baseline Tags.Sample values: 8 8 8."; }
                    break;
                case TiffTags.RowsPerStrip:
                    tagName = "RowsPerStrip";
                    if (longDesc) { tagName += " The number of rows per strip.Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.StripByteCounts:
                    tagName = "StripByteCounts";
                    if (longDesc) { tagName += " For each strip, the number of bytes in the strip after compression.	Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.MinSampleValue:
                    tagName = "MinSampleValue";
                    if (longDesc) { tagName += " The minimum component value used.	Baseline"; }
                    break;
                case TiffTags.MaxSampleValue:
                    tagName = "MaxSampleValue";
                    if (longDesc) { tagName += " The maximum component value used.	Baseline"; }
                    break;
                case TiffTags.XResolution:
                    tagName = "XResolution";
                    if (longDesc) { tagName += " The number of pixels per ResolutionUnit in the ImageWidth direction.Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.YResolution:
                    tagName = "YResolution";
                    if (longDesc) { tagName += " The number of pixels per ResolutionUnit in the ImageLength direction.Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.PlanarConfiguration:
                    tagName = "PlanarConfiguration";
                    if (longDesc) { tagName += " How the components of each pixel are stored.	Baseline Mandatory for TIFF/EP."; }
                    break;
                case TiffTags.PageName:
                    tagName = "PageName";
                    if (longDesc) { tagName += " The name of the page from which this image was scanned.Extended Also used by HD Photo"; }
                    break;
                case TiffTags.XPosition:
                    tagName = "XPosition";
                    if (longDesc) { tagName += " X position of the image.	Extended"; }
                    break;
                case TiffTags.YPosition:
                    tagName = "YPosition";
                    if (longDesc) { tagName += " Y position of the image.	Extended"; }
                    break;
                case TiffTags.FreeOffsets:
                    tagName = "FreeOffsets";
                    if (longDesc) { tagName += " For each string of contiguous unused bytes in a TIFF file, the byte offset of the string.	Baseline"; }
                    break;
                case TiffTags.FreeByteCounts:
                    tagName = "FreeByteCounts";
                    if (longDesc) { tagName += " For each string of contiguous unused bytes in a TIFF file, the number of bytes in the string.	Baseline"; }
                    break;
                case TiffTags.GrayResponseUnit:
                    tagName = "GrayResponseUnit";
                    if (longDesc) { tagName += " The precision of the information contained in the GrayResponseCurve.	Baseline"; }
                    break;
                case TiffTags.GrayResponseCurve:
                    tagName = "GrayResponseCurve";
                    if (longDesc) { tagName += " For grayscale data, the optical density of each possible pixel value.	Baseline"; }
                    break;
                case TiffTags.T4Options:
                    tagName = "T4Options";
                    if (longDesc) { tagName += " Options for Group 3 Fax compression Extended"; }
                    break;
                case TiffTags.T6Options:
                    tagName = "T6Options";
                    if (longDesc) { tagName += " Options for Group 4 Fax compression Extended"; }
                    break;
                case TiffTags.ResolutionUnit:
                    tagName = "ResolutionUnit";
                    if (longDesc) { tagName += " The unit of measurement for XResolution and YResolution.Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.PageNumber:
                    tagName = "PageNumber";
                    if (longDesc) { tagName += " The page number of the page from which this image was scanned.Extended Also used by HD Photo"; }
                    break;
                case TiffTags.TransferFunction:
                    tagName = "TransferFunction";
                    if (longDesc) { tagName += " Describes a transfer function for the image in tabular style.	Extended"; }
                    break;
                case TiffTags.Software:
                    tagName = "Software";
                    if (longDesc) { tagName += " Name and version number of the software package(s) used to create the image.	Baseline Listed in LoC Baseline Tags.Document states 'Acceptable to include only capture software; preferred to list both capture and post-capture processing software (if applicable), separated by \";\"'."; }
                    break;
                case TiffTags.DateTime:
                    tagName = "DateTime";
                    if (longDesc) { tagName += " Date and time of image creation.Baseline Listed in LoC Baseline Tags."; }
                    break;
                case TiffTags.Artist:
                    tagName = "Artist";
                    if (longDesc) { tagName += "  Person who created the image.Baseline Listed in LoC Baseline Tags.Document states 'Insitution name followed (if applicable) by \";\" and name of scanning contractor.'"; }
                    break;
                case TiffTags.HostComputer:
                    tagName = "HostComputer";
                    if (longDesc) { tagName += "    The computer and/or operating system in use at the time of image creation.Baseline Also used by HD Photo"; }
                    break;
                case TiffTags.Predictor:
                    tagName = "Predictor";
                    if (longDesc) { tagName += " A mathematical operator that is applied to the image data before an encoding scheme is applied.Extended"; }
                    break;
                case TiffTags.WhitePoint:
                    tagName = "WhitePoint";
                    if (longDesc) { tagName += " The chromaticity of the white point of the image.	Extended"; }
                    break;
                case TiffTags.PrimaryChromaticities:
                    tagName = "PrimaryChromaticities";
                    if (longDesc) { tagName += " The chromaticities of the primaries of the image.Extended"; }
                    break;
                case TiffTags.ColorMap:
                    tagName = "ColorMap";
                    if (longDesc) { tagName += " A color map for palette color images.Baseline Mandatory for TIFF 6.0 class P.1"; }
                    break;
                case TiffTags.HalftoneHints:
                    tagName = "HalftoneHints";
                    if (longDesc) { tagName += " Conveys to the halftone function the range of gray levels within a colorimetrically-specified image that should retain tonal detail.Extended	 "; }
                    break;
                case TiffTags.TileWidth:
                    tagName = "TileWidth";
                    if (longDesc) { tagName += " The tile width in pixels.This is the number of columns in each tile.Extended    Mandatory for TIFF 6.0 files that use tiles. (Files that use strips employ tags 273, 278, and 279.)"; }
                    break;
                case TiffTags.TileLength:
                    tagName = "TileLength";
                    if (longDesc) { tagName += " The tile length (height) in pixels.This is the number of rows in each tile.	Extended Referenced in JHOVE TIFF module for files that use tiles. (Files that use strips employ tags 273, 278, and 279.)"; }
                    break;
                case TiffTags.TileOffsets:
                    tagName = "TileOffsets";
                    if (longDesc) { tagName += " For each tile, the byte offset of that tile, as compressed and stored on disk.Extended Mandatory for TIFF 6.0 files that use tiles. (Files that use strips employ tags 273, 278, and 279.)"; }
                    break;
                case TiffTags.TileByteCounts:
                    tagName = "TileByteCounts";
                    if (longDesc) { tagName += " For each tile, the number of (compressed) bytes in that tile.	Extended Mandatory for TIFF 6.0 files that use tiles. (Files that use strips employ tags 273, 278, and 279.)"; }
                    break;
                case TiffTags.BadFaxLines:
                    tagName = "BadFaxLines";
                    if (longDesc) { tagName += " Used in the TIFF-F standard, denotes the number of 'bad' scan lines encountered by the facsimile device.Extended"; }
                    break;
                case TiffTags.CleanFaxData:
                    tagName = "CleanFaxData";
                    if (longDesc) { tagName += " Used in the TIFF-F standard, indicates if 'bad' lines encountered during reception are stored in the data, or if 'bad' lines have been replaced by the receiver.Extended"; }
                    break;
                case TiffTags.ConsecutiveBadFaxLines:
                    tagName = "ConsecutiveBadFaxLines";
                    if (longDesc) { tagName += " Used in the TIFF-F standard, denotes the maximum number of consecutive 'bad' scanlines received.	Extended"; }
                    break;
                case TiffTags.SubIFDs:
                    tagName = "SubIFDs";
                    if (longDesc) { tagName += " Offset to child IFDs.	Extended"; }
                    break;
                case TiffTags.InkSet:
                    tagName = "InkSet";
                    if (longDesc) { tagName += "  The set of inks used in a separated (PhotometricInterpretation= 5) image.Extended	 "; }
                    break;
                case TiffTags.InkNames:
                    tagName = "InkNames";
                    if (longDesc) { tagName += " The name of each ink used in a separated image.Extended	 "; }
                    break;
                case TiffTags.NumberOfInks:
                    tagName = "NumberOfInks";
                    if (longDesc) { tagName += " The number of inks.Extended	 "; }
                    break;
                case TiffTags.DotRange:
                    tagName = "DotRange";
                    if (longDesc) { tagName += " The component values that correspond to a 0% dot and 100% dot.Extended Usage rule in JHOVE TIFF module."; }
                    break;
                case TiffTags.TargetPrinter:
                    tagName = "TargetPrinter";
                    if (longDesc) { tagName += " A description of the printing environment for which this separation is intended.Extended"; }
                    break;
                case TiffTags.ExtraSamples:
                    tagName = "ExtraSamples";
                    if (longDesc) { tagName += " Description of extra components.Baseline"; }
                    break;
                case TiffTags.SampleFormat:
                    tagName = "SampleFormat";
                    if (longDesc) { tagName += " Specifies how to interpret each data sample in a pixel.	Extended"; }
                    break;
                case TiffTags.SMinSampleValue:
                    tagName = "SMinSampleValue";
                    if (longDesc) { tagName += " Specifies the minimum sample value.	Extended"; }
                    break;
                case TiffTags.SMaxSampleValue:
                    tagName = "SMaxSampleValue";
                    if (longDesc) { tagName += " Specifies the maximum sample value.	Extended"; }
                    break;
                case TiffTags.TransferRange:
                    tagName = "TransferRange";
                    if (longDesc) { tagName += " Expands the range of the TransferFunction.Extended"; }
                    break;
                case TiffTags.ClipPath:
                    tagName = "ClipPath";
                    if (longDesc) { tagName += " Mirrors the essentials of PostScript's path creation functionality.	Extended	Usage rule in JHOVE TIFF module."; }
                    break;
                case TiffTags.XClipPathUnits:
                    tagName = "XClipPathUnits";
                    if (longDesc) { tagName += " The number of units that span the width of the image, in terms of integer ClipPath coordinates.Extended Usage rule in JHOVE TIFF module."; }
                    break;
                case TiffTags.YClipPathUnits:
                    tagName = "YClipPathUnits";
                    if (longDesc) { tagName += " The number of units that span the height of the image, in terms of integer ClipPath coordinates.Extended"; }
                    break;
                case TiffTags.Indexed:
                    tagName = "Indexed";
                    if (longDesc) { tagName += " Aims to broaden the support for indexed images to include support for any color space.Extended"; }
                    break;
                case TiffTags.JPEGTables:
                    tagName = "JPEGTables";
                    if (longDesc) { tagName += "  JPEG quantization and/or Huffman tables.Extended"; }
                    break;
                case TiffTags.OPIProxy:
                    tagName = "OPIProxy";
                    if (longDesc) { tagName += " OPI-related.Extended"; }
                    break;
                case TiffTags.GlobalParametersIFD:
                    tagName = "GlobalParametersIFD";
                    if (longDesc) { tagName += " Used in the TIFF-FX standard to point to an IFD containing tags that are globally applicable to the complete TIFF file.	Extended"; }
                    break;
                case TiffTags.ProfileType:
                    tagName = "ProfileType";
                    if (longDesc) { tagName += " Used in the TIFF-FX standard, denotes the type of data stored in this file or IFD.Extended"; }
                    break;
                case TiffTags.FaxProfile:
                    tagName = "FaxProfile";
                    if (longDesc) { tagName += " Used in the TIFF-FX standard, denotes the 'profile' that applies to this file.Extended"; }
                    break;
                case TiffTags.CodingMethods:
                    tagName = "CodingMethods";
                    if (longDesc) { tagName += " Used in the TIFF-FX standard, indicates which coding methods are used in the file.	Extended"; }
                    break;
                case TiffTags.VersionYear:
                    tagName = "VersionYear";
                    if (longDesc) { tagName += " Used in the TIFF-FX standard, denotes the year of the standard specified by the FaxProfile field.Extended"; }
                    break;
                case TiffTags.ModeNumber:
                    tagName = "ModeNumber";
                    if (longDesc) { tagName += " Used in the TIFF-FX standard, denotes the mode of the standard specified by the FaxProfile field.Extended"; }
                    break;
                case TiffTags.Decode:
                    tagName = "Decode";
                    if (longDesc) { tagName += "  Used in the TIFF-F and TIFF-FX standards, holds information about the ITULAB (PhotometricInterpretation = 10) encoding.	Extended	 "; }
                    break;
                case TiffTags.DefaultImageColor:
                    tagName = "DefaultImageColor";
                    if (longDesc) { tagName += " Defined in the Mixed Raster Content part of RFC 2301, is the default color needed in areas where no image is available.	Extended	 "; }
                    break;
                case TiffTags.JPEGProc:
                    tagName = "JPEGProc";
                    if (longDesc) { tagName += " Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 "; }
                    break;
                case TiffTags.JPEGInterchangeFormat:
                    tagName = "JPEGInterchangeFormat";
                    if (longDesc) { tagName += " Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 "; }
                    break;
                case TiffTags.JPEGInterchangeFormatLength:
                    tagName = "JPEGInterchangeFormatLength";
                    if (longDesc) { tagName += " Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 "; }
                    break;
                case TiffTags.JPEGRestartInterval:
                    tagName = "JPEGRestartInterval";
                    if (longDesc) { tagName += " Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 "; }
                    break;
                case TiffTags.JPEGLosslessPredictors:
                    tagName = "JPEGLosslessPredictors";
                    if (longDesc) { tagName += " Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 "; }
                    break;
                case TiffTags.JPEGPointTransforms:
                    tagName = "JPEGPointTransforms";
                    if (longDesc) { tagName += " Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 "; }
                    break;
                case TiffTags.JPEGQTables:
                    tagName = "JPEGQTables";
                    if (longDesc) { tagName += " Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 "; }
                    break;
                case TiffTags.JPEGDCTables:
                    tagName = "JPEGDCTables";
                    if (longDesc) { tagName += " Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 "; }
                    break;
                case TiffTags.JPEGACTables:
                    tagName = "JPEGACTables";
                    if (longDesc) { tagName += " Old-style JPEG compression field. TechNote2 invalidates this part of the specification.	Extended	 "; }
                    break;
                case TiffTags.YCbCrCoefficients:
                    tagName = "YCbCrCoefficients";
                    if (longDesc) { tagName += " The transformation from RGB to YCbCr image data.	Extended Mandatory for TIFF/EP YCbCr images."; }
                    break;
                case TiffTags.YCbCrSubSampling:
                    tagName = "YCbCrSubSampling";
                    if (longDesc) { tagName += " Specifies the subsampling factors used for the chrominance components of a YCbCr image.	Extended Mandatory for TIFF/EP YCbCr images."; }
                    break;
                case TiffTags.YCbCrPositioning:
                    tagName = "YCbCrPositioning";
                    if (longDesc) { tagName += " Specifies the positioning of subsampled chrominance components relative to luminance samples.	Extended Mandatory for TIFF/EP YCbCr images."; }
                    break;
                case TiffTags.ReferenceBlackWhite:
                    tagName = "ReferenceBlackWhite";
                    if (longDesc) { tagName += " Specifies a pair of headroom and footroom image data values (codes) for each pixel component.Extended Mandatory for TIFF 6.0 class Y.1"; }
                    break;
                case TiffTags.StripRowCounts:
                    tagName = "StripRowCounts";
                    if (longDesc) { tagName += " Defined in the Mixed Raster Content part of RFC 2301, used to replace RowsPerStrip for IFDs with variable-sized strips.Extended"; }
                    break;
                case TiffTags.XMP:
                    tagName = "XMP";
                    if (longDesc) { tagName += " XML packet containing XMP metadata Extended    Also used by HD Photo"; }
                    break;
                case TiffTags.ImageRating:
                    tagName = "ImageRating";
                    if (longDesc) { tagName += ".Rating Ratings tag used by Windows Exif private IFD	 "; }
                    break;
                case TiffTags.PrivateImageRating:
                    tagName = "PrivateImageRating";
                    if (longDesc) { tagName += ".RatingPercent Ratings tag used by Windows, value as percent Exif private IFD	 "; }
                    break;
                case TiffTags.ImageID:
                    tagName = "ImageID";
                    if (longDesc) { tagName += " OPI-related.Extended	 "; }
                    break;
                case TiffTags.Wang:
                    tagName = "Wang";
                    if (longDesc) { tagName += " Annotation Annotation data, as used in 'Imaging for Windows'.	Private	 "; }
                    break;
                case TiffTags.CFARepeatPatternDim:
                    tagName = "CFARepeatPatternDim";
                    if (longDesc) { tagName += " For camera raw files from sensors with CFA overlay."; }
                    break;
                case TiffTags.CFAPattern:
                    tagName = "CFAPattern";
                    if (longDesc) { tagName += " For camera raw files from sensors with CFA overlay.	"; }
                    break;
                case TiffTags.BatteryLevel:
                    tagName = "BatteryLevel";
                    if (longDesc) { tagName += " Encodes camera battery level at time of image capture.	"; }
                    break;
                case TiffTags.Copyright:
                    tagName = "Copyright";
                    if (longDesc) { tagName += " Copyright notice.Baseline Also used by HD Photo."; }
                    break;
                case TiffTags.ExposureTime:
                    tagName = "ExposureTime";
                    if (longDesc) { tagName += "    Exposure time, given in seconds.Exif Private IFD"; }
                    break;
                case TiffTags.FNumber:
                    tagName = "FNumber";
                    if (longDesc) { tagName += " The F number.	Exif Private IFD"; }
                    break;
                case TiffTags.MDFileTag:
                    tagName = "MDFileTag";
                    if (longDesc) { tagName += " FileTag Specifies the pixel data format encoding in the Molecular Dynamics GEL file format.	Private"; }
                    break;
                case TiffTags.MDScalePixel:
                    tagName = "MDScalePixel";
                    if (longDesc) { tagName += " ScalePixel Specifies a scale factor in the Molecular Dynamics GEL file format.	Private"; }
                    break;
                case TiffTags.MDColorTable:
                    tagName = "MDColorTable";
                    if (longDesc) { tagName += " ColorTable Used to specify the conversion from 16bit to 8bit in the Molecular Dynamics GEL file format.	Private"; }
                    break;
                case TiffTags.MDLabName:
                    tagName = "MDLabName";
                    if (longDesc) { tagName += " LabName Name of the lab that scanned this file, as used in the Molecular Dynamics GEL file format.	Private"; }
                    break;
                case TiffTags.MDSampleInfo:
                    tagName = "MDSampleInfo";
                    if (longDesc) { tagName += " SampleInfo Information about the sample, as used in the Molecular Dynamics GEL file format.	Private"; }
                    break;
                case TiffTags.MDPrepDate:
                    tagName = "MDPrepDate";
                    if (longDesc) { tagName += " PrepDate Date the sample was prepared, as used in the Molecular Dynamics GEL file format.	Private"; }
                    break;
                case TiffTags.MDPrepTime:
                    tagName = "MDPrepTime";
                    if (longDesc) { tagName += " PrepTime Time the sample was prepared, as used in the Molecular Dynamics GEL file format.	Private"; }
                    break;
                case TiffTags.MDFileUnits:
                    tagName = "MDFileUnits";
                    if (longDesc) { tagName += " FileUnits Units for data in this file, as used in the Molecular Dynamics GEL file format.	Private"; }
                    break;
                case TiffTags.ModelPixelScaleTag:
                    tagName = "ModelPixelScaleTag";
                    if (longDesc) { tagName += " Used in interchangeable GeoTIFF_1_0 files.Private"; }
                    break;
                case TiffTags.IPTC:
                    tagName = "IPTC";
                    if (longDesc) { tagName += "/NAA IPTC-NAA (International Press Telecommunications Council-Newspaper Association of America) metadata.TIFF/EP spec, p. 33	Tag name and values defined by IPTC-NAA Info Interchange Model & Digital Newsphoto Parameter Record."; }
                    break;
                case TiffTags.INGRPacketData:
                    tagName = "INGRPacketData";
                    if (longDesc) { tagName += " Packet Data Tag    Intergraph Application specific storage.	Private"; }
                    break;
                case TiffTags.INGRFlagRegisters:
                    tagName = "INGRFlagRegisters";
                    if (longDesc) { tagName += " Flag Registers Intergraph Application specific flags.Private"; }
                    break;
                case TiffTags.IrasB:
                    tagName = "IrasB";
                    if (longDesc) { tagName += " Transformation Matrix Originally part of Intergraph's GeoTIFF tags, but likely understood by IrasB only.	Private	 "; }
                    break;
                case TiffTags.ModelTiepointTag:
                    tagName = "ModelTiepointTag";
                    if (longDesc) { tagName += " Originally part of Intergraph's GeoTIFF tags, but now used in interchangeable GeoTIFF_1_0 files.	Private	In GeoTIFF_1_0, either this tag or 34264 must be defined, but not both"; }
                    break;
                case TiffTags.Site:
                    tagName = "Site";
                    if (longDesc) { tagName += " Site where image created.TIFF/IT spec, 7.2.3	 "; }
                    break;
                case TiffTags.ColorSequence:
                    tagName = "ColorSequence";
                    if (longDesc) { tagName += " Sequence of colors if other than CMYK.TIFF/IT spec, 7.2.8.3.2	For BP and BL only2"; }
                    break;
                case TiffTags.IT8Header:
                    tagName = "IT8Header";
                    if (longDesc) { tagName += " Certain inherited headers.	TIFF/IT spec, 7.2.3	Obsolete"; }
                    break;
                case TiffTags.RasterPadding:
                    tagName = "RasterPadding";
                    if (longDesc) { tagName += " Type of raster padding used, if any.TIFF/IT spec, 7.2.6	 "; }
                    break;
                case TiffTags.BitsPerRunLength:
                    tagName = "BitsPerRunLength";
                    if (longDesc) { tagName += " Number of bits for short run length encoding.	TIFF/IT spec, 7.2.6	For LW only2"; }
                    break;
                case TiffTags.BitsPerExtendedRunLength:
                    tagName = "BitsPerExtendedRunLength";
                    if (longDesc) { tagName += " Number of bits for long run length encoding.	TIFF/IT spec, 7.2.6	For LW only2"; }
                    break;
                case TiffTags.ColorTable:
                    tagName = "ColorTable";
                    if (longDesc) { tagName += " Color value in a color pallette.TIFF/IT spec, 7.2.8.4	For BP and BL only2"; }
                    break;
                case TiffTags.ImageColorIndicator:
                    tagName = "ImageColorIndicator";
                    if (longDesc) { tagName += " Indicates if image (foreground) color or transparency is specified.TIFF/IT spec, 7.2.9	For MP, BP, and BL only2"; }
                    break;
                case TiffTags.BackgroundColorIndicator:
                    tagName = "BackgroundColorIndicator";
                    if (longDesc) { tagName += " Background color specification.	TIFF/IT spec, 7.2.9	For BP and BL only2"; }
                    break;
                case TiffTags.ImageColorValue:
                    tagName = "ImageColorValue";
                    if (longDesc) { tagName += " Specifies image (foreground) color.	TIFF/IT spec, 7.2.8.4	For MP, BP, and BL only2"; }
                    break;
                case TiffTags.BackgroundColorValue:
                    tagName = "BackgroundColorValue";
                    if (longDesc) { tagName += " Specifies background color.	TIFF/IT spec, 7.2.8.4	For BP and BL only2"; }
                    break;
                case TiffTags.PixelIntensityRange:
                    tagName = "PixelIntensityRange";
                    if (longDesc) { tagName += " Specifies data values for 0 percent and 100 percent pixel intensity.TIFF/IT spec, 7.2.8.4	For MP only2"; }
                    break;
                case TiffTags.TransparencyIndicator:
                    tagName = "TransparencyIndicator";
                    if (longDesc) { tagName += " Specifies if transparency is used in HC file.	TIFF/IT spec, 7.2.8.4	For HC only2"; }
                    break;
                case TiffTags.ColorCharacterization:
                    tagName = "ColorCharacterization";
                    if (longDesc) { tagName += " Specifies ASCII table or other reference per ISO 12641 and ISO 12642.	TIFF/IT spec, 7.2.8.4	 "; }
                    break;
                case TiffTags.HCUsage:
                    tagName = "HCUsage";
                    if (longDesc) { tagName += " Indicates the type of information in an HC file.TIFF/IT spec, 7.2.6	For HC only2"; }
                    break;
                case TiffTags.TrapIndicator:
                    tagName = "TrapIndicator";
                    if (longDesc) { tagName += " Indicates whether or not trapping has been applied to the file.	TIFF/IT spec, 7.2.6	 "; }
                    break;
                case TiffTags.CMYKEquivalent:
                    tagName = "CMYKEquivalent";
                    if (longDesc) { tagName += " Specifies CMYK equivalent for specific separations.	TIFF/IT spec, 7.2.8.3.4	 "; }
                    break;
                case TiffTags.Reserved1:
                    tagName = "Reserved1";
                    if (longDesc) { tagName += " For future TIFF/IT use  TIFF/IT spec	 "; }
                    break;
                case TiffTags.Reserved2:
                    tagName = "Reserved2";
                    if (longDesc) { tagName += " For future TIFF/IT use  TIFF/IT spec	 "; }
                    break;
                case TiffTags.Reserved3:
                    tagName = "Reserved3";
                    if (longDesc) { tagName += " For future TIFF/IT use  TIFF/IT spec	 "; }
                    break;
                case TiffTags.ModelTransformationTag:
                    tagName = "ModelTransformationTag";
                    if (longDesc) { tagName += " Used in interchangeable GeoTIFF_1_0 files.Private In GeoTIFF_1_0, either this tag or 33922 must be defined, but not both"; }
                    break;
                case TiffTags.Photoshop:
                    tagName = "Photoshop";
                    if (longDesc) { tagName += " Collection of Photoshop 'Image Resource Blocks'.	Private"; }
                    break;
                case TiffTags.Exif:
                    tagName = "Exif";
                    if (longDesc) { tagName += " IFD    A pointer to the Exif IFD.	Private Also used by HD Photo."; }
                    break;
                case TiffTags.InterColorProfile:
                    tagName = "InterColorProfile";
                    if (longDesc) { tagName += " ICC profile data.	"; }
                    break;
                case TiffTags.ImageLayer:
                    tagName = "ImageLayer";
                    if (longDesc) { tagName += "  Defined in the Mixed Raster Content part of RFC 2301, used to denote the particular function of this Image in the mixed raster scheme.	Extended"; }
                    break;
                case TiffTags.GeoKeyDirectoryTag:
                    tagName = "GeoKeyDirectoryTag";
                    if (longDesc) { tagName += "  Used in interchangeable GeoTIFF_1_0 files.Private Mandatory in GeoTIFF_1_0"; }
                    break;
                case TiffTags.GeoDoubleParamsTag:
                    tagName = "GeoDoubleParamsTag";
                    if (longDesc) { tagName += "  Used in interchangeable GeoTIFF_1_0 files.Private"; }
                    break;
                case TiffTags.GeoAsciiParamsTag:
                    tagName = "GeoAsciiParamsTag";
                    if (longDesc) { tagName += "   Used in interchangeable GeoTIFF_1_0 files.Private"; }
                    break;
                case TiffTags.ExposureProgram:
                    tagName = "ExposureProgram";
                    if (longDesc) { tagName += " The class of the program used by the camera to set exposure when the picture is taken.Exif Private IFD"; }
                    break;
                case TiffTags.SpectralSensitivity:
                    tagName = "SpectralSensitivity";
                    if (longDesc) { tagName += " Indicates the spectral sensitivity of each channel of the camera used.Exif Private IFD"; }
                    break;
                case TiffTags.GPSInfo:
                    tagName = "GPSInfo";
                    if (longDesc) { tagName += " A pointer to the Exif-related GPS Info IFD.	"; }
                    break;
                case TiffTags.ISOSpeedRatings:
                    tagName = "ISOSpeedRatings";
                    if (longDesc) { tagName += " Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.	Exif Private IFD"; }
                    break;
                case TiffTags.OECF:
                    tagName = "OECF";
                    if (longDesc) { tagName += " Indicates the Opto-Electric Conversion Function(OECF) specified in ISO 14524.	Exif Private IFD"; }
                    break;
                case TiffTags.Interlace:
                    tagName = "Interlace";
                    if (longDesc) { tagName += " Indicates the field number of multifield images."; }
                    break;
                case TiffTags.TimeZoneOffset:
                    tagName = "TimeZoneOffset";
                    if (longDesc) { tagName += "  Encodes time zone of camera clock relative to GMT."; }
                    break;
                case TiffTags.SelfTimeMode:
                    tagName = "SelfTimeMode";
                    if (longDesc) { tagName += "    Number of seconds image capture was delayed from button press."; }
                    break;
                case TiffTags.SensitivityType:
                    tagName = "SensitivityType";
                    if (longDesc) { tagName += " The SensitivityType tag indicates PhotographicSensitivity tag, which one of the parameters of ISO 12232. Although it is an optional tag, it should be recorded when a PhotographicSensitivity tag is recorded.Value = 4, 5, 6, or 7 may be used in case that the values of plural parameters are the same.Exif private IFD	 "; }
                    break;
                case TiffTags.StandardOutputSensitivity:
                    tagName = "StandardOutputSensitivity";
                    if (longDesc) { tagName += " This tag indicates the standard output sensitivity value of a camera or input device defined in ISO 12232. When recording this tag, the PhotographicSensitivity and SensitivityType tags shall also be recorded.Exif private IFD	 "; }
                    break;
                case TiffTags.RecommendedExposureIndex:
                    tagName = "RecommendedExposureIndex";
                    if (longDesc) { tagName += " This tag indicates the recommended exposure index value of a camera or input device defined in ISO 12232. When recording this tag, the PhotographicSensitivity and SensitivityType tags shall also be recorded.Exif private IFD	 "; }
                    break;
                case TiffTags.ISOSpeed:
                    tagName = "ISOSpeed";
                    if (longDesc) { tagName += " This tag indicates the ISO speed value of a camera or input device that is defined in ISO 12232. When recording this tag, the PhotographicSensitivity and SensitivityType tags shall also be recorded.Exif private IFD	 "; }
                    break;
                case TiffTags.ISOSpeedLatitudeyyy:
                    tagName = "ISOSpeedLatitudeyyy";
                    if (longDesc) { tagName += " This tag indicates the ISO speed latitude yyy value of a camera or input device that is defined in ISO 12232. However, this tag shall not be recorded without ISOSpeed and ISOSpeedLatitudezzz.Exif private IFD	 "; }
                    break;
                case TiffTags.ISOSpeedLatitudezzz:
                    tagName = "ISOSpeedLatitudezzz";
                    if (longDesc) { tagName += " This tag indicates the ISO speed latitude zzz value of a camera or input device that is defined in ISO 12232. However, this tag shall not be recorded without ISOSpeed and ISOSpeedLatitudeyyy.Exif private IFD	 "; }
                    break;
                case TiffTags.HylaFAXRecvParams:
                    tagName = "HylaFAXRecvParams";
                    if (longDesc) { tagName += " FaxRecvParams Used by HylaFAX.Private"; }
                    break;
                case TiffTags.HylaFAXSubaddress:
                    tagName = "HylaFAXSubaddress";
                    if (longDesc) { tagName += " FaxSubAddress   Used by HylaFAX.Private"; }
                    break;
                case TiffTags.HylaFAXRecvTime:
                    tagName = "HylaFAXRecvTime";
                    if (longDesc) { tagName += " FaxRecvTime Used by HylaFAX.Private"; }
                    break;
                case TiffTags.ExifVersion:
                    tagName = "ExifVersion";
                    if (longDesc) { tagName += " The version of the supported Exif standard.	Exif Private IFD Mandatory in the Exif IFD."; }
                    break;
                case TiffTags.DateTimeOriginal:
                    tagName = "DateTimeOriginal";
                    if (longDesc) { tagName += " The date and time when the original image data was generated.	Exif Private IFD"; }
                    break;
                case TiffTags.DateTimeDigitized:
                    tagName = "DateTimeDigitized";
                    if (longDesc) { tagName += " The date and time when the image was stored as digital data.	Exif Private IFD"; }
                    break;
                case TiffTags.ComponentsConfiguration:
                    tagName = "ComponentsConfiguration";
                    if (longDesc) { tagName += " Specific to compressed data; specifies the channels and complements PhotometricInterpretation   Exif Private IFD	 "; }
                    break;
                case TiffTags.CompressedBitsPerPixel:
                    tagName = "CompressedBitsPerPixel";
                    if (longDesc) { tagName += " Specific to compressed data; states the compressed bits per pixel.Exif Private IFD"; }
                    break;
                case TiffTags.ShutterSpeedValue:
                    tagName = "ShutterSpeedValue";
                    if (longDesc) { tagName += " Shutter speed.Exif Private IFD"; }
                    break;
                case TiffTags.ApertureValue:
                    tagName = "ApertureValue";
                    if (longDesc) { tagName += " The lens aperture.	Exif Private IFD"; }
                    break;
                case TiffTags.BrightnessValue:
                    tagName = "BrightnessValue";
                    if (longDesc) { tagName += " The value of brightness.Exif Private IFD"; }
                    break;
                case TiffTags.ExposureBiasValue:
                    tagName = "ExposureBiasValue";
                    if (longDesc) { tagName += " The exposure bias.	Exif Private IFD"; }
                    break;
                case TiffTags.MaxApertureValue:
                    tagName = "MaxApertureValue";
                    if (longDesc) { tagName += " The smallest F number of the lens.	Exif Private IFD"; }
                    break;
                case TiffTags.SubjectDistance:
                    tagName = "SubjectDistance";
                    if (longDesc) { tagName += " The distance to the subject, given in meters.Exif Private IFD"; }
                    break;
                case TiffTags.MeteringMode:
                    tagName = "MeteringMode";
                    if (longDesc) { tagName += " The metering mode.	Exif Private IFD"; }
                    break;
                case TiffTags.LightSource:
                    tagName = "LightSource";
                    if (longDesc) { tagName += " The kind of light source.	Exif Private IFD"; }
                    break;
                case TiffTags.Flash:
                    tagName = "Flash";
                    if (longDesc) { tagName += " Indicates the status of flash when the image was shot.Exif Private IFD"; }
                    break;
                case TiffTags.FocalLength:
                    tagName = "FocalLength";
                    if (longDesc) { tagName += " The actual focal length of the lens, in mm.Exif Private IFD"; }
                    break;
                case TiffTags.FlashEnergy:
                    tagName = "FlashEnergy";
                    if (longDesc) { tagName += " Amount of flash energy (BCPS).	"; }
                    break;
                case TiffTags.SpatialFrequencyResponse:
                    tagName = "SpatialFrequencyResponse";
                    if (longDesc) { tagName += "    SFR of the camera.	"; }
                    break;
                case TiffTags.Noise:
                    tagName = "Noise";
                    if (longDesc) { tagName += " Noise measurement values.	"; }
                    break;
                case TiffTags.FocalPlaneXResolution:
                    tagName = "FocalPlaneXResolution";
                    if (longDesc) { tagName += " Number of pixels per FocalPlaneResolutionUnit (37392) in ImageWidth direction for main image."; }
                    break;
                case TiffTags.FocalPlaneYResolution:
                    tagName = "FocalPlaneYResolution";
                    if (longDesc) { tagName += " Number of pixels per FocalPlaneResolutionUnit (37392) in ImageLength direction for main image."; }
                    break;
                case TiffTags.FocalPlaneResolutionUnit:
                    tagName = "FocalPlaneResolutionUnit";
                    if (longDesc) { tagName += " Unit of measurement for FocalPlaneXResolution(37390) and FocalPlaneYResolution(37391).	"; }
                    break;
                case TiffTags.ImageNumber:
                    tagName = "ImageNumber";
                    if (longDesc) { tagName += " Number assigned to an image, e.g., in a chained image burst."; }
                    break;
                case TiffTags.SecurityClassification:
                    tagName = "SecurityClassification";
                    if (longDesc) { tagName += " Security classification assigned to the image."; }
                    break;
                case TiffTags.ImageHistory:
                    tagName = "ImageHistory";
                    if (longDesc) { tagName += " Record of what has been done to the image.	"; }
                    break;
                case TiffTags.SubjectLocation:
                    tagName = "SubjectLocation";
                    if (longDesc) { tagName += " Indicates the location and area of the main subject in the overall scene.Exif Private IFD"; }
                    break;
                case TiffTags.ExposureIndex:
                    tagName = "ExposureIndex";
                    if (longDesc) { tagName += " Encodes the camera exposure index setting when image was captured."; }
                    break;
                case TiffTags.TIFF:
                    tagName = "TIFF";
                    if (longDesc) { tagName += "/EPStandardID For current spec, tag value equals 1 0 0 0.	"; }
                    break;
                case TiffTags.SensingMethod:
                    tagName = "SensingMethod";
                    if (longDesc) { tagName += " Type of image sensor."; }
                    break;
                case TiffTags.MakerNote:
                    tagName = "MakerNote";
                    if (longDesc) { tagName += "   Manufacturer specific information.Exif Private IFD	 "; }
                    break;
                case TiffTags.UserComment:
                    tagName = "UserComment";
                    if (longDesc) { tagName += " Keywords or comments on the image; complements ImageDescription.Exif Private IFD	 "; }
                    break;
                case TiffTags.SubsecTime:
                    tagName = "SubsecTime";
                    if (longDesc) { tagName += " A tag used to record fractions of seconds for the DateTime tag.Exif Private IFD"; }
                    break;
                case TiffTags.SubsecTimeOriginal:
                    tagName = "SubsecTimeOriginal";
                    if (longDesc) { tagName += " A tag used to record fractions of seconds for the DateTimeOriginal tag.Exif Private IFD"; }
                    break;
                case TiffTags.SubsecTimeDigitized:
                    tagName = "SubsecTimeDigitized";
                    if (longDesc) { tagName += " A tag used to record fractions of seconds for the DateTimeDigitized tag.Exif Private IFD"; }
                    break;
                case TiffTags.ImageSourceData:
                    tagName = "ImageSourceData";
                    if (longDesc) { tagName += " Used by Adobe Photoshop.	Private"; }
                    break;
                case TiffTags.XPTitle:
                    tagName = "XPTitle";
                    if (longDesc) { tagName += " Title tag used by Windows, encoded in UCS2 Exif Private IFD	 "; }
                    break;
                case TiffTags.XPComment:
                    tagName = "XPComment";
                    if (longDesc) { tagName += "   Comment tag used by Windows, encoded in UCS2 Exif Private IFD	 "; }
                    break;
                case TiffTags.XPAuthor:
                    tagName = "XPAuthor";
                    if (longDesc) { tagName += "    Author tag used by Windows, encoded in UCS2 Exif Private IFD	 "; }
                    break;
                case TiffTags.XPKeywords:
                    tagName = "XPKeywords";
                    if (longDesc) { tagName += "  Keywords tag used by Windows, encoded in UCS2 Exif Private IFD	 "; }
                    break;
                case TiffTags.XPSubject:
                    tagName = "XPSubject";
                    if (longDesc) { tagName += "   Subject tag used by Windows, encoded in UCS2 Exif Private IFD	 "; }
                    break;
                case TiffTags.FlashpixVersion:
                    tagName = "FlashpixVersion";
                    if (longDesc) { tagName += " The Flashpix format version supported by a FPXR file.Exif Private IFD Mandatory in the Exif IFD"; }
                    break;
                case TiffTags.ColorSpace:
                    tagName = "ColorSpace";
                    if (longDesc) { tagName += "  The color space information tag is always recorded as the color space specifier.	Exif Private IFD Mandatory in the Exif IFD"; }
                    break;
                case TiffTags.PixelXDimension:
                    tagName = "PixelXDimension";
                    if (longDesc) { tagName += " Specific to compressed data; the valid width of the meaningful image.Exif Private IFD	 "; }
                    break;
                case TiffTags.PixelYDimension:
                    tagName = "PixelYDimension";
                    if (longDesc) { tagName += " Specific to compressed data; the valid height of the meaningful image.Exif Private IFD	 "; }
                    break;
                case TiffTags.RelatedSoundFile:
                    tagName = "RelatedSoundFile";
                    if (longDesc) { tagName += "    Used to record the name of an audio file related to the image data.Exif Private IFD	 "; }
                    break;
                case TiffTags.Interoperability:
                    tagName = "Interoperability";
                    if (longDesc) { tagName += " IFD A pointer to the Exif-related Interoperability IFD.Private"; }
                    break;
                case TiffTags.FlashEnergyExifPrivate:
                    tagName = "FlashEnergyExifPrivate";
                    if (longDesc) { tagName += " Indicates the strobe energy at the time the image is captured, as measured in Beam Candle Power Seconds Exif Private IFD"; }
                    break;
                case TiffTags.SpatialFrequencyResponseExifPrivate:
                    tagName = "SpatialFrequencyResponseExifPrivate";
                    if (longDesc) { tagName += "    Records the camera or input device spatial frequency table and SFR values in the direction of image width, image height, and diagonal direction, as specified in ISO 12233.	Exif Private IFD"; }
                    break;
                case TiffTags.FocalPlaneXResolutionExifPrivate:
                    tagName = "FocalPlaneXResolutionExifPrivate";
                    if (longDesc) { tagName += "   Indicates the number of pixels in the image width (X) direction per FocalPlaneResolutionUnit on the camera focal plane.Exif Private IFD"; }
                    break;
                case TiffTags.FocalPlaneYResolutionExifPrivate:
                    tagName = "FocalPlaneYResolutionExifPrivate";
                    if (longDesc) { tagName += "   Indicates the number of pixels in the image height (Y) direction per FocalPlaneResolutionUnit on the camera focal plane.Exif Private IFD"; }
                    break;
                case TiffTags.FocalPlaneResolutionUnitExifPrivate:
                    tagName = "FocalPlaneResolutionUnitExifPrivate";
                    if (longDesc) { tagName += "    Indicates the unit for measuring FocalPlaneXResolution and FocalPlaneYResolution.	Exif Private IFD"; }
                    break;
                case TiffTags.SubjectLocationExifPrivate:
                    tagName = "SubjectLocationExifPrivate";
                    if (longDesc) { tagName += " Indicates the location of the main subject in the scene.	Exif Private IFD"; }
                    break;
                case TiffTags.ExposureIndexExifPrivate:
                    tagName = "ExposureIndexExifPrivate";
                    if (longDesc) { tagName += "   Indicates the exposure index selected on the camera or input device at the time the image is captured.Exif Private IFD"; }
                    break;
                case TiffTags.SensingMethodExifPrivate:
                    tagName = "SensingMethodExifPrivate";
                    if (longDesc) { tagName += "   Indicates the image sensor type on the camera or input device.Exif Private IFD"; }
                    break;
                case TiffTags.FileSource:
                    tagName = "FileSource";
                    if (longDesc) { tagName += "  Indicates the image source.	Exif Private IFD Req'd in LC NDNP TIFF profile. Values: 'microfilm,' 'microfiche,' or 'print.'"; }
                    break;
                case TiffTags.SceneType:
                    tagName = "SceneType";
                    if (longDesc) { tagName += "   Indicates the type of scene.Exif Private IFD"; }
                    break;
                case TiffTags.CFAPatternExifPrivate:
                    tagName = "CFAPatternExifPrivate";
                    if (longDesc) { tagName += "  Indicates the color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used.Exif Private IFD"; }
                    break;
                case TiffTags.CustomRendered:
                    tagName = "CustomRendered";
                    if (longDesc) { tagName += "  Indicates the use of special processing on image data, such as rendering geared to output.	Exif Private IFD"; }
                    break;
                case TiffTags.ExposureMode:
                    tagName = "ExposureMode";
                    if (longDesc) { tagName += "    Indicates the exposure mode set when the image was shot.	Exif Private IFD"; }
                    break;
                case TiffTags.WhiteBalance:
                    tagName = "WhiteBalance";
                    if (longDesc) { tagName += "    Indicates the white balance mode set when the image was shot.Exif Private IFD"; }
                    break;
                case TiffTags.DigitalZoomRatio:
                    tagName = "DigitalZoomRatio";
                    if (longDesc) { tagName += "    Indicates the digital zoom ratio when the image was shot.	Exif Private IFD"; }
                    break;
                case TiffTags.FocalLengthIn35mmFilm:
                    tagName = "FocalLengthIn35mmFilm";
                    if (longDesc) { tagName += "   Indicates the equivalent focal length assuming a 35mm film camera, in mm.Exif Private IFD"; }
                    break;
                case TiffTags.SceneCaptureType:
                    tagName = "SceneCaptureType";
                    if (longDesc) { tagName += "    Indicates the type of scene that was shot.	Exif Private IFD"; }
                    break;
                case TiffTags.GainControl:
                    tagName = "GainControl";
                    if (longDesc) { tagName += " Indicates the degree of overall image gain adjustment.	Exif Private IFD"; }
                    break;
                case TiffTags.Contrast:
                    tagName = "Contrast";
                    if (longDesc) { tagName += "    Indicates the direction of contrast processing applied by the camera when the image was shot.Exif Private IFD"; }
                    break;
                case TiffTags.Saturation:
                    tagName = "Saturation";
                    if (longDesc) { tagName += "  Indicates the direction of saturation processing applied by the camera when the image was shot.Exif Private IFD"; }
                    break;
                case TiffTags.Sharpness:
                    tagName = "Sharpness";
                    if (longDesc) { tagName += "   Indicates the direction of sharpness processing applied by the camera when the image was shot.Exif Private IFD"; }
                    break;
                case TiffTags.DeviceSettingDescription:
                    tagName = "DeviceSettingDescription";
                    if (longDesc) { tagName += "    This tag indicates information on the picture-taking conditions of a particular camera model.Exif Private IFD"; }
                    break;
                case TiffTags.SubjectDistanceRange:
                    tagName = "SubjectDistanceRange";
                    if (longDesc) { tagName += "    Indicates the distance to the subject.	Exif Private IFD"; }
                    break;
                case TiffTags.ImageUniqueID:
                    tagName = "ImageUniqueID";
                    if (longDesc) { tagName += "   Indicates an identifier assigned uniquely to each image.	Exif Private IFD Req'd in LC NDNP TIFF profile. Microfilm reel sequence number. If from paper: 'issue date-edition-page sequence.'"; }
                    break;
                case TiffTags.CameraOwnerName:
                    tagName = "CameraOwnerName";
                    if (longDesc) { tagName += " Camera owner name as ASCII string.	Exif Private IFD"; }
                    break;
                case TiffTags.BodySerialNumber:
                    tagName = "BodySerialNumber";
                    if (longDesc) { tagName += "    Camera body serial number as ASCII string.	Exif Private IFD"; }
                    break;
                case TiffTags.LensSpecification:
                    tagName = "LensSpecification";
                    if (longDesc) { tagName += "   This tag notes minimum focal length, maximum focal length, minimum F number in the minimum focal length, and minimum F number in the maximum focal length, which are specification information for the lens that was used in photography.When the minimum F number is unknown, the notation is 0/0.	Exif Private IFD"; }
                    break;
                case TiffTags.LensMake:
                    tagName = "LensMake";
                    if (longDesc) { tagName += "    Lens manufacturer name as ASCII string.	Exif Private IFD"; }
                    break;
                case TiffTags.LensModel:
                    tagName = "LensModel";
                    if (longDesc) { tagName += "   Lens model name and number as ASCII string.	Exif Private IFD"; }
                    break;
                case TiffTags.LensSerialNumber:
                    tagName = "LensSerialNumber";
                    if (longDesc) { tagName += "    Lens serial number as ASCII string.	Exif Private IFD"; }
                    break;
                case TiffTags.GDAL_METADATA:
                    tagName = "GDAL_METADATA";
                    if (longDesc) { tagName += "   Used by the GDAL library, holds an XML list of name = value 'metadata' values about the image as a whole, and about specific samples.	Private"; }
                    break;
                case TiffTags.GDAL_NODATA:
                    tagName = "GDAL_NODATA";
                    if (longDesc) { tagName += " Used by the GDAL library, contains an ASCII encoded nodata or background pixel value.Private"; }
                    break;
                case TiffTags.PixelFormat:
                    tagName = "PixelFormat";
                    if (longDesc) { tagName += " A 128-bit Globally Unique Identifier (GUID) that identifies the image pixel format.HD Photo Feature Spec, p. 17	 "; }
                    break;
                case TiffTags.Transformation:
                    tagName = "Transformation";
                    if (longDesc) { tagName += "  Specifies the transformation to be applied when decoding the image to present the desired representation.HD Photo Feature Spec, p. 23	 "; }
                    break;
                case TiffTags.Uncompressed:
                    tagName = "Uncompressed";
                    if (longDesc) { tagName += "    Specifies that image data is uncompressed.HD Photo Feature Spec, p. 23	 "; }
                    break;
                case TiffTags.ImageType:
                    tagName = "ImageType";
                    if (longDesc) { tagName += "   Specifies the image type of each individual frame in a multi-frame file.	HD Photo Feature Spec, p. 27	 "; }
                    break;
                case TiffTags.ImageWidthHD:
                    tagName = "ImageWidthHD";
                    if (longDesc) { tagName += "  Specifies the number of columns in the transformed photo, or the number of pixels per scan line.	HD Photo Feature Spec, p. 21	 "; }
                    break;
                case TiffTags.ImageHeight:
                    tagName = "ImageHeight";
                    if (longDesc) { tagName += " Specifies the number of pixels or scan lines in the transformed photo.HD Photo Feature Spec, p. 21	 "; }
                    break;
                case TiffTags.WidthResolution:
                    tagName = "WidthResolution";
                    if (longDesc) { tagName += " Specifies the horizontal resolution of a transformed image expressed in pixels per inch.HD Photo Feature Spec, p. 21	 "; }
                    break;
                case TiffTags.HeightResolution:
                    tagName = "HeightResolution";
                    if (longDesc) { tagName += "    Specifies the vertical resolution of a transformed image expressed in pixels per inch.HD Photo Feature Spec, p. 21	 "; }
                    break;
                case TiffTags.ImageOffset:
                    tagName = "ImageOffset";
                    if (longDesc) { tagName += " Specifies the byte offset pointer to the beginning of the photo data, relative to the beginning of the file.HD Photo Feature Spec, p. 22	 "; }
                    break;
                case TiffTags.ImageByteCount:
                    tagName = "ImageByteCount";
                    if (longDesc) { tagName += "  Specifies the size of the photo in bytes.HD Photo Feature Spec, p. 22	 "; }
                    break;
                case TiffTags.AlphaOffset:
                    tagName = "AlphaOffset";
                    if (longDesc) { tagName += " Specifies the byte offset pointer the beginning of the planar alpha channel data, relative to the beginning of the file.HD Photo Feature Spec, p. 22	 "; }
                    break;
                case TiffTags.AlphaByteCount:
                    tagName = "AlphaByteCount";
                    if (longDesc) { tagName += "  Specifies the size of the alpha channel data in bytes.HD Photo Feature Spec, p. 23	 "; }
                    break;
                case TiffTags.ImageDataDiscard:
                    tagName = "ImageDataDiscard";
                    if (longDesc) { tagName += "    Signifies the level of data that has been discarded from the image as a result of a compressed domain transcode to reduce the file size.	HD Photo Feature Spec, p. 25	 "; }
                    break;
                case TiffTags.AlphaDataDiscard:
                    tagName = "AlphaDataDiscard";
                    if (longDesc) { tagName += "    Signifies the level of data that has been discarded from the planar alpha channel as a result of a compressed domain transcode to reduce the file size.	HD Photo Feature Spec, p. 26	 "; }
                    break;
                case TiffTags.OceDesc:
                    tagName = "OceDesc";
                    if (longDesc) { tagName += " Scanjob Description Used in the Oce scanning process.	Private"; }
                    break;
                case TiffTags.OceAppSelector:
                    tagName = "OceAppSelector";
                    if (longDesc) { tagName += " Application Selector    Used in the Oce scanning process.	Private"; }
                    break;
                case TiffTags.OceIDNumber:
                    tagName = "OceIDNumber";
                    if (longDesc) { tagName += " Identification Number   Used in the Oce scanning process.	Private"; }
                    break;
                case TiffTags.OceCharacteristics:
                    tagName = "OceCharacteristics";
                    if (longDesc) { tagName += " ImageLogic Characteristics  Used in the Oce scanning process.	Private"; }
                    break;
                case TiffTags.PrintImageMatching:
                    tagName = "PrintImageMatching";
                    if (longDesc) { tagName += "  Description needed.	Exif Private IFD"; }
                    break;
                case TiffTags.DNGVersion:
                    tagName = "DNGVersion";
                    if (longDesc) { tagName += "  Encodes DNG four-tier version number; for version 1.1.0.0, the tag contains the bytes 1, 1, 0, 0. Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.DNGBackwardVersion:
                    tagName = "DNGBackwardVersion";
                    if (longDesc) { tagName += "  Defines oldest version of spec with which file is compatible.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.UniqueCameraModel:
                    tagName = "UniqueCameraModel";
                    if (longDesc) { tagName += "   Unique, non-localized nbame for camera model.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.LocalizedCameraModel:
                    tagName = "LocalizedCameraModel";
                    if (longDesc) { tagName += "    Similar to 50708, with localized camera name.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.CFAPlaneColor:
                    tagName = "CFAPlaneColor";
                    if (longDesc) { tagName += "   Mapping between values in the CFAPattern tag and the plane numbers in LinearRaw space.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.CFALayout:
                    tagName = "CFALayout";
                    if (longDesc) { tagName += "   Spatial layout of the CFA.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.LinearizationTable:
                    tagName = "LinearizationTable";
                    if (longDesc) { tagName += "  Lookup table that maps stored values to linear values.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.BlackLevelRepeatDim:
                    tagName = "BlackLevelRepeatDim";
                    if (longDesc) { tagName += " Repeat pattern size for BlackLevel tag.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.BlackLevel:
                    tagName = "BlackLevel";
                    if (longDesc) { tagName += "  Specifies the zero light encoding level.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.BlackLevelDeltaH:
                    tagName = "BlackLevelDeltaH";
                    if (longDesc) { tagName += "    Specifies the difference between zero light encoding level for each column and the baseline zero light encoding level.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.BlackLevelDeltaV:
                    tagName = "BlackLevelDeltaV";
                    if (longDesc) { tagName += "    Specifies the difference between zero light encoding level for each row and the baseline zero light encoding level.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.WhiteLevel:
                    tagName = "WhiteLevel";
                    if (longDesc) { tagName += "  Specifies the fully saturated encoding level for the raw sample values.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.DefaultScale:
                    tagName = "DefaultScale";
                    if (longDesc) { tagName += "    For cameras with non-square pixels, specifies the default scale factors for each direction to convert the image to square pixels.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.DefaultCropOrigin:
                    tagName = "DefaultCropOrigin";
                    if (longDesc) { tagName += "   Specifies the origin of the final image area, ignoring the extra pixels at edges used to prevent interpolation artifacts.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.DefaultCropSize:
                    tagName = "DefaultCropSize";
                    if (longDesc) { tagName += " Specifies size of final image area in raw image coordinates.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.ColorMatrix1:
                    tagName = "ColorMatrix1";
                    if (longDesc) { tagName += "    Defines a transformation matrix that converts XYZ values to reference camera native color space values, under the first calibration illuminant.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.ColorMatrix2:
                    tagName = "ColorMatrix2";
                    if (longDesc) { tagName += "    Defines a transformation matrix that converts XYZ values to reference camera native color space values, under the second calibration illuminant.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.CameraCalibration1:
                    tagName = "CameraCalibration1";
                    if (longDesc) { tagName += "  Defines a calibration matrix that transforms reference camera native space values to individual camera native space values under the first calibration illuminant.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.CameraCalibration2:
                    tagName = "CameraCalibration2";
                    if (longDesc) { tagName += "  Defines a calibration matrix that transforms reference camera native space values to individual camera native space values under the second calibration illuminant.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.ReductionMatrix1:
                    tagName = "ReductionMatrix1";
                    if (longDesc) { tagName += "    Defines a dimensionality reduction matrix for use as the first stage in converting color camera native space values to XYZ values, under the first calibration illuminant.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.ReductionMatrix2:
                    tagName = "ReductionMatrix2";
                    if (longDesc) { tagName += "    Defines a dimensionality reduction matrix for use as the first stage in converting color camera native space values to XYZ values, under the second calibration illuminant.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.AnalogBalance:
                    tagName = "AnalogBalance";
                    if (longDesc) { tagName += "   Pertaining to white balance, defines the gain, either analog or digital, that has been applied to the stored raw values.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.AsShotNeutral:
                    tagName = "AsShotNeutral";
                    if (longDesc) { tagName += "   Specifies the selected white balance at the time of capture, encoded as the coordinates of a perfectly neutral color in linear reference space values.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.AsShotWhiteXY:
                    tagName = "AsShotWhiteXY";
                    if (longDesc) { tagName += "   Specifies the selected white balance at the time of capture, encoded as x-y chromaticity coordinates.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.BaselineExposure:
                    tagName = "BaselineExposure";
                    if (longDesc) { tagName += "    Specifies in EV units how much to move the zero point for exposure compensation.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.BaselineNoise:
                    tagName = "BaselineNoise";
                    if (longDesc) { tagName += "   Specifies the relative noise of the camera model at a baseline ISO value of 100, compared to reference camera model.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.BaselineSharpness:
                    tagName = "BaselineSharpness";
                    if (longDesc) { tagName += "   Specifies the relative amount of sharpening required for this camera model, compared to reference camera model.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.BayerGreenSplit:
                    tagName = "BayerGreenSplit";
                    if (longDesc) { tagName += " For CFA images, specifies, in arbitrary units, how closely the values of the green pixels in the blue/green rows track the values of the green pixels in the red/green rows.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.LinearResponseLimit:
                    tagName = "LinearResponseLimit";
                    if (longDesc) { tagName += " Specifies the fraction of the encoding range above which the response may become significantly non-linear.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.CameraSerialNumber:
                    tagName = "CameraSerialNumber";
                    if (longDesc) { tagName += "  Serial number of camera.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.LensInfo:
                    tagName = "LensInfo";
                    if (longDesc) { tagName += "    Information about the lens.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.ChromaBlurRadius:
                    tagName = "ChromaBlurRadius";
                    if (longDesc) { tagName += "    Normally for non-CFA images, provides a hint about how much chroma blur ought to be applied.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.AntiAliasStrength:
                    tagName = "AntiAliasStrength";
                    if (longDesc) { tagName += "   Provides a hint about the strength of the camera's anti-aliasing filter. Used in Raw IFD of DNG files.	"; }
                    break;
                case TiffTags.DNGPrivateData:
                    tagName = "DNGPrivateData";
                    if (longDesc) { tagName += "  Provides a way for camera manufacturers to store private data in DNG files for use by their own raw convertors.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.MakerNoteSafety:
                    tagName = "MakerNoteSafety";
                    if (longDesc) { tagName += " Lets the DNG reader know whether the Exif MakerNote tag is safe to preserve.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.CalibrationIlluminant1:
                    tagName = "CalibrationIlluminant1";
                    if (longDesc) { tagName += "  Illuminant used for first set of calibration tags.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.CalibrationIlluminant2:
                    tagName = "CalibrationIlluminant2";
                    if (longDesc) { tagName += "  Illuminant used for second set of calibration tags.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.BestQualityScale:
                    tagName = "BestQualityScale";
                    if (longDesc) { tagName += "    Specifies the amount by which the values of the DefaultScale tag need to be multiplied to achieve best quality image size.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.RawDataUniqueID:
                    tagName = "RawDataUniqueID";
                    if (longDesc) { tagName += " Contains a 16-byte unique identifier for the raw image file in the DNG file.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.Alias:
                    tagName = "Alias";
                    if (longDesc) { tagName += " Layer Metadata    Alias Sketchbook Pro layer usage description.Private"; }
                    break;
                case TiffTags.OriginalRawFileName:
                    tagName = "OriginalRawFileName";
                    if (longDesc) { tagName += " Name of original file if the DNG file results from conversion from a non-DNG raw file.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.OriginalRawFileData:
                    tagName = "OriginalRawFileData";
                    if (longDesc) { tagName += " If the DNG file was converted from a non-DNG raw file, then this tag contains the original raw data. Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.ActiveArea:
                    tagName = "ActiveArea";
                    if (longDesc) { tagName += " Defines the active (non-masked) pixels of the sensor.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.MaskedAreas:
                    tagName = "MaskedAreas";
                    if (longDesc) { tagName += " List of non-overlapping rectangle coordinates of fully masked pixels, which can optimally be used by DNG readers to measure the black encoding level.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.AsShotICCProfile:
                    tagName = "AsShotICCProfile";
                    if (longDesc) { tagName += " Contains ICC profile that, in conjunction with the AsShotPreProfileMatrix tag, specifies a default color rendering from camera color space coordinates(linear reference values) into the ICC profile connection space.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.AsShotPreProfileMatrix:
                    tagName = "AsShotPreProfileMatrix";
                    if (longDesc) { tagName += " Specifies a matrix that should be applied to the camera color space coordinates before processing the values through the ICC profile specified in the AsShotICCProfile tag.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.CurrentICCProfile:
                    tagName = "CurrentICCProfile";
                    if (longDesc) { tagName += " The CurrentICCProfile and CurrentPreProfileMatrix tags have the same purpose and usage as"; }
                    break;
                case TiffTags.CurrentPreProfileMatrix:
                    tagName = "CurrentPreProfileMatrix";
                    if (longDesc) { tagName += " The CurrentICCProfile and CurrentPreProfileMatrix tags have the same purpose and usage as the AsShotICCProfile and AsShotPreProfileMatrix tag pair, except they are for use by raw file editors rather than camera manufacturers.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.ColorimetricReference:
                    tagName = "ColorimetricReference";
                    if (longDesc) { tagName += "   The DNG color model documents a transform between camera colors and CIE XYZ values.This tag describes the colorimetric reference for the CIE XYZ values. 0 = The XYZ values are scene-referred. 1 = The XYZ values are output-referred, using the ICC profile perceptual dynamic range.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.CameraCalibrationSignature:
                    tagName = "CameraCalibrationSignature";
                    if (longDesc) { tagName += "  A UTF-8 encoded string associated with the CameraCalibration1 and CameraCalibration2 tags.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.ProfileCalibrationSignature:
                    tagName = "ProfileCalibrationSignature";
                    if (longDesc) { tagName += " A UTF-8 encoded string associated with the camera profile tags.Used in IFD 0 or CameraProfile IFD of DNG files."; }
                    break;
                case TiffTags.ExtraCameraProfiles:
                    tagName = "ExtraCameraProfiles";
                    if (longDesc) { tagName += " A list of file offsets to extra Camera Profile IFDs.The format of a camera profile begins with a 16-bit byte order mark (MM or II) followed by a 16-bit 'magic' number equal to 0x4352 (CR), a 32-bit IFD offset, and then a standard TIFF format IFD.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.AsShotProfileName:
                    tagName = "AsShotProfileName";
                    if (longDesc) { tagName += "   A UTF-8 encoded string containing the name of the 'as shot' camera profile, if any.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.NoiseReductionApplied:
                    tagName = "NoiseReductionApplied";
                    if (longDesc) { tagName += "   Indicates how much noise reduction has been applied to the raw data on a scale of 0.0 to 1.0. A 0.0 value indicates that no noise reduction has been applied.A 1.0 value indicates that the 'ideal' amount of noise reduction has been applied, i.e.that the DNG reader should not apply additional noise reduction by default. A value of 0/0 indicates that this parameter is unknown.Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.ProfileName:
                    tagName = "ProfileName";
                    if (longDesc) { tagName += " A UTF-8 encoded string containing the name of the camera profile. Used in IFD 0 or Camera Profile IFD of DNG files.	"; }
                    break;
                case TiffTags.ProfileHueSatMapDims:
                    tagName = "ProfileHueSatMapDims";
                    if (longDesc) { tagName += " Specifies the number of input samples in each dimension of the hue/saturation/value mapping tables. The data for these tables are stored in ProfileHueSatMapData1 and ProfileHueSatMapData2 tags. Allowed values include the following: HueDivisions >= 1; SaturationDivisions >= 2; ValueDivisions >=1. Used in IFD 0 or Camera Profile IFD of DNG files.	"; }
                    break;
                case TiffTags.ProfileHueSatMapData1:
                    tagName = "ProfileHueSatMapData1";
                    if (longDesc) { tagName += " Contains the data for the first hue/saturation/value mapping table. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees; the second entry is saturation scale factor; and the third entry is a value scale factor. Used in IFD 0 or Camera Profile IFD of DNG files.	"; }
                    break;
                case TiffTags.ProfileHueSatMapData2:
                    tagName = "ProfileHueSatMapData2";
                    if (longDesc) { tagName += " Contains the data for the second hue/saturation/value mapping table. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees; the second entry is saturation scale factor; and the third entry is a value scale factor. Used in IFD 0 or Camera Profile IFD of DNG files.	"; }
                    break;
                case TiffTags.ProfileToneCurve:
                    tagName = "ProfileToneCurve";
                    if (longDesc) { tagName += " Contains a default tone curve that can be applied while processing the image as a starting point for user adjustments. The curve is specified as a list of 32-bit IEEE floating-point value pairs in linear gamma. Each sample has an input value in the range of 0.0 to 1.0, and an output value in the range of 0.0 to 1.0. The first sample is required to be (0.0, 0.0), and the last sample is required to be (1.0, 1.0). Interpolated the curve using a cubic spline.Used in IFD 0 or Camera Profile IFD of DNG files."; }
                    break;
                case TiffTags.ProfileEmbedPolicy:
                    tagName = "ProfileEmbedPolicy";
                    if (longDesc) { tagName += "  Contains information about the usage rules for the associated camera profile.The valid values and meanings are: 0 = “allow copying”; 1 = “embed if used”; 2 = “embed never”; and 3 = “no restrictions”. Used in IFD 0 or Camera Profile IFD of DNG files."; }
                    break;
                case TiffTags.ProfileCopyright:
                    tagName = "ProfileCopyright";
                    if (longDesc) { tagName += "    Contains information about the usage rules for the associated camera profile.The valid values and meanings are: 0 = “allow copying”; 1 = “embed if used”; 2 = “embed never”; and 3 = “no restrictions”. Used in IFD 0 or Camera Profile IFD of DNG files."; }
                    break;
                case TiffTags.ForwardMatrix1:
                    tagName = "ForwardMatrix1";
                    if (longDesc) { tagName += "  Defines a matrix that maps white balanced camera colors to XYZ D50 colors.Used in IFD 0 or Camera Profile IFD of DNG files."; }
                    break;
                case TiffTags.ForwardMatrix2:
                    tagName = "ForwardMatrix2";
                    if (longDesc) { tagName += "  Defines a matrix that maps white balanced camera colors to XYZ D50 colors.Used in IFD 0 or Camera Profile IFD of DNG files."; }
                    break;
                case TiffTags.PreviewApplicationName:
                    tagName = "PreviewApplicationName";
                    if (longDesc) { tagName += "  A UTF-8 encoded string containing the name of the application that created the preview stored in the IFD.Used in Preview IFD of DNG files."; }
                    break;
                case TiffTags.PreviewApplicationVersion:
                    tagName = "PreviewApplicationVersion";
                    if (longDesc) { tagName += "   A UTF-8 encoded string containing the version number of the application that created the preview stored in the IFD.Used in Preview IFD of DNG files."; }
                    break;
                case TiffTags.PreviewSettingsName:
                    tagName = "PreviewSettingsName";
                    if (longDesc) { tagName += " A UTF-8 encoded string containing the name of the conversion settings(for example, snapshot name) used for the preview stored in the IFD.Used in Preview IFD of DNG files."; }
                    break;
                case TiffTags.PreviewSettingsDigest:
                    tagName = "PreviewSettingsDigest";
                    if (longDesc) { tagName += "   A unique ID of the conversion settings(for example, MD5 digest) used to render the preview stored in the IFD.Used in Preview IFD of DNG files."; }
                    break;
                case TiffTags.PreviewColorSpace:
                    tagName = "PreviewColorSpace";
                    if (longDesc) { tagName += "   This tag specifies the color space in which the rendered preview in this IFD is stored.The valid values include: 0 = Unknown; 1 = Gray Gamma 2.2; 2 = sRGB; 3 = Adobe RGB; and 4 = ProPhoto RGB. Used in Preview IFD of DNG files."; }
                    break;
                case TiffTags.PreviewDateTime:
                    tagName = "PreviewDateTime";
                    if (longDesc) { tagName += " This tag is an ASCII string containing the name of the date/time at which the preview stored in the IFD was rendered, encoded using ISO 8601 format.Used in Preview IFD of DNG files."; }
                    break;
                case TiffTags.RawImageDigest:
                    tagName = "RawImageDigest";
                    if (longDesc) { tagName += "  MD5 digest of the raw image data.All pixels in the image are processed in row-scan order.Each pixel is zero padded to 16 or 32 bits deep (16-bit for data less than or equal to 16 bits deep, 32-bit otherwise). The data is processed in little-endian byte order.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.OriginalRawFileDigest:
                    tagName = "OriginalRawFileDigest";
                    if (longDesc) { tagName += "   MD5 digest of the data stored in the OriginalRawFileData tag.Used in IFD 0 of DNG files."; }
                    break;
                case TiffTags.SubTileBlockSize:
                    tagName = "SubTileBlockSize";
                    if (longDesc) { tagName += "    Normally, pixels within a tile are stored in simple row-scan order.This tag specifies that the pixels within a tile should be grouped first into rectangular blocks of the specified size.These blocks are stored in row-scan order. Within each block, the pixels are stored in row-scan order. Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.RowInterleaveFactor:
                    tagName = "RowInterleaveFactor";
                    if (longDesc) { tagName += " Specifies that rows of the image are stored in interleaved order.The value of the tag specifies the number of interleaved fields. Used in Raw IFD of DNG files."; }
                    break;
                case TiffTags.ProfileLookTableDims:
                    tagName = "ProfileLookTableDims";
                    if (longDesc) { tagName += "    Specifies the number of input samples in each dimension of a default 'look' table.The data for this table is stored in the ProfileLookTableData tag.Allowed values include: HueDivisions >= 1; SaturationDivisions >= 2; and ValueDivisions >= 1. Used in IFD 0 or Camera Profile IFD of DNG files."; }
                    break;
                case TiffTags.ProfileLookTableData:
                    tagName = "ProfileLookTableData";
                    if (longDesc) { tagName += " Default 'look' table that can be applied while processing the image as a starting point for user adjustment. This table uses the same format as the tables stored in the ProfileHueSatMapData1 and ProfileHueSatMapData2 tags, and is applied in the same color space. However, it should be applied later in the processing pipe, after any exposure compensation and/or fill light stages, but before any tone curve stage. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees, the second entry is a saturation scale factor, and the third entry is a value scale factor. Used in IFD 0 or Camera Profile IFD of DNG files.	"; }
                    break;
                case TiffTags.OpcodeList1:
                    tagName = "OpcodeList1";
                    if (longDesc) { tagName += " Specifies the list of opcodes (image processing operation codes) that should be applied to the raw image, as read directly from the file. Used in Raw IFD of DNG files.	"; }
                    break;
                case TiffTags.OpcodeList2:
                    tagName = "OpcodeList2";
                    if (longDesc) { tagName += " Specifies the list of opcodes (image processing operation codes) that should be applied to the raw image, just after it has been mapped to linear reference values. Used in Raw IFD of DNG files.	"; }
                    break;
                case TiffTags.OpcodeList3:
                    tagName = "OpcodeList3";
                    if (longDesc) { tagName += " Specifies the list of opcodes (image processing operation codes) that should be applied to the raw image, just after it has been demosaiced. Used in Raw IFD of DNG files.	"; }
                    break;
                case TiffTags.NoiseProfile:
                    tagName = "NoiseProfile";
                    if (longDesc) { tagName += " Describes the amount of noise in a raw image; models the amount of signal-dependent photon (shot) noise and signal-independent sensor readout noise, two common sources of noise in raw images. Used in Raw IFD of DNG files.	"; }
                    break;
                case TiffTags.OriginalDefaultFinalSize:
                    tagName = "OriginalDefaultFinalSize";
                    if (longDesc) { tagName += " If this file is a proxy for a larger original DNG file, this tag specifics the default final size of the larger original file from which this proxy was generated. The default value for this tag is default final size of the current DNG file, which is DefaultCropSize * DefaultScale.	DNG spec (1.4, 2012), p. 74	 "; }
                    break;
                case TiffTags.OriginalBestQualityFinalSize:
                    tagName = "OriginalBestQualityFinalSize";
                    if (longDesc) { tagName += " If this file is a proxy for a larger original DNG file, this tag specifics the best quality final size of the larger original file from which this proxy was generated. The default value for this tag is the OriginalDefaultFinalSize, if specified. Otherwise the default value for this tag is the best quality size of the current DNG file, which is DefaultCropSize * DefaultScale * BestQualityScale.	DNG spec (1.4, 2012), p. 75	 "; }
                    break;
                case TiffTags.OriginalDefaultCropSize:
                    tagName = "OriginalDefaultCropSize";
                    if (longDesc) { tagName += " If this file is a proxy for a larger original DNG file, this tag specifics the DefaultCropSize of the larger original file from which this proxy was generated. The default value for this tag is the OriginalDefaultFinalSize, if specified. Otherwise, the default value for this tag is the DefaultCropSize of the current DNG file.	DNG spec (1.4, 2012), p. 75	 "; }
                    break;
                case TiffTags.ProfileHueSatMapEncoding:
                    tagName = "ProfileHueSatMapEncoding";
                    if (longDesc) { tagName += " Provides a way for color profiles to specify how indexing into a 3D HueSatMap is performed during raw conversion. This tag is not applicable to 2.5D HueSatMap tables (i.e., where the Value dimension is 1). The currently defined values are: 0 = Linear encoding (method described in DNG spec); 1 = sRGB encoding (method described in DNG spec).	DNG spec (1.4, 2012), p. 73	 "; }
                    break;
                case TiffTags.ProfileLookTableEncoding:
                    tagName = "ProfileLookTableEncoding";
                    if (longDesc) { tagName += " Provides a way for color profiles to specify how indexing into a 3D LookTable is performed during raw conversion. This tag is not applicable to a 2.5D LookTable (i.e., where the Value dimension is 1). The currently defined values are: 0 = Linear encoding (method described in DNG spec); 1 = sRGB encoding (method described in DNG spec).	DNG spec (1.4, 2012), p. 72-3	 "; }
                    break;
                case TiffTags.BaselineExposureOffset:
                    tagName = "BaselineExposureOffset";
                    if (longDesc) { tagName += " Provides a way for color profiles to increase or decrease exposure during raw conversion. BaselineExposureOffset specifies the amount (in EV units) to add to th e BaselineExposure tag during image rendering. For example, if the BaselineExposure value fo r a given camera model is +0.3, and the BaselineExposureOffset value for a given camera profile used to render an image for that camera model is -0.7, then th e actual default exposure value used during rendering will be + 0.3 - 0.7 = -0.4.DNG spec(1.4, 2012), p. 71"; }
                    break;
                case TiffTags.DefaultBlackRender:
                    tagName = "DefaultBlackRender";
                    if (longDesc) { tagName += "  This optional tag in a color profile provides a hint to the raw converter regarding how to handle the black point(e.g., flare subtraction) during rendering.The currently defined values are: 0 = Auto; 1 = None.If set to Auto, the raw converter should perform black subtraction during rendering.The amount and method of black subtraction may be automatically determined and may be image - dependent.If set to None, the raw converter should not perform any black subtraction during rendering.This may be desirable when using color lookup tables(e.g., LookTable) or tone curves in camera profiles to perform a fixed, consistent level of black subtraction.	DNG spec(1.4, 2012), p. 71"; }
                    break;
                case TiffTags.NewRawImageDigest:
                    tagName = "NewRawImageDigest";
                    if (longDesc) { tagName += "   This tag is a modified MD5 digest of the raw image data.It has been updated from the algorithm used to compute the RawImageDigest tag be more multi-processor friendly, and to support lossy compression algorithms. The details of the algorithm used to compute this tag are documented in the Adobe DNG SDK source code.	DNG spec(1.4, 2012), p. 76"; }
                    break;
                case TiffTags.RawToPreviewGain:
                    tagName = "RawToPreviewGain";
                    if (longDesc) { tagName += "    The gain(what number the sample values are multiplied by) between the main raw IFD and the preview IFD containing this tag.DNG spec(1.4, 2012), p. 76"; }
                    break;
                case TiffTags.DefaultUserCrop:
                    tagName = "DefaultUserCrop";
                    if (longDesc) { tagName += " Specifies a default user crop rectangle in relative coordinates. The values must satisfy: 0.0 <= top < bottom <= 1.0; 0.0 <= left < right <= 1.0.The default values of(top = 0, left = 0, bottom = 1, right = 1) correspond exactly to the default crop rectangle(as specified by the DefaultCropOrigin and DefaultCropSize tags).	DNG spec(1.4, 2012), p. 70"; }
                    break;
                case TiffTags.OffsetSchema:
                    tagName = "OffsetSchema";
                    if (longDesc) { tagName += "   Microsoft's offset to makers note."; }
                    break;

            }

            return tagName;
        }

        public static string ResolutionUnitToString(FieldType typeValue)
        {
            short[] values = (short[])typeValue.GetValue();
            short value = values[0];

            string v = "";
            switch (value)
            {
                case 1:
                    v = "None";
                    break;
                case 2:
                    v = "Inch";
                    break;
                case 3:
                    v = "Centimeter";
                    break;
                default:
                    v = "Inch";
                    break;
            }

            return v;
        }

        public static string SensitivityTypeToString(FieldType typeValue)
        {
            short[] values = (short[])typeValue.GetValue();
            short value = values[0];

            string v = "";
            switch (value)
            {
                case 0:
                    v = "Unknown";
                    break;
                case 1:
                    v = "Standard output sensitivity(SOS)";
                    break;
                case 2:
                    v = "Recommended exposure index(REI)";
                    break;
                case 3:
                    v = "ISO speed";
                    break;
                case 4:
                    v = "Standard output sensitivity(SOS) and recommended exposure index(REI)";
                    break;
                case 5:
                    v = "Standard output sensitivity(SOS) and ISO speed";
                    break;
                case 6:
                    v = "Recommended exposure index(REI) and ISO speed";
                    break;
                case 7:
                    v = "Standard output sensitivity(SOS) and recommended exposure index(REI) and ISO speed";
                    break;
            }

            return v;
        }

        public static string OrientationToString(FieldType typeValue)
        {

            string s = "";

            short[] values = (short[])typeValue.GetValue();
            short value = values[0];


            switch (value)
            {
                case 1:
                    s = "Top Left";
                    break;
                case 2:
                    s = "Top Right";
                    break;
                case 3:
                    s = "Bottom Right";
                    break;
                case 4:
                    s = "Bottom Left";
                    break;
                case 5:
                    s = "Left Top";
                    break;
                case 6:
                    s = "Right Top";
                    break;
                case 7:
                    s = "Right Bottom";
                    break;
                case 8:
                    s = "Left Bottom";
                    break;
            }

            return s;
        }


        public static string YCbCrPositioningToString(FieldType typeValue)
        {
            string s = "";

            short[] values = (short[])typeValue.GetValue();
            short value = values[0];


            switch (value)
            {
                case 1:
                    s = "Centered";
                    break;
                case 2:
                    s = "Cosited";
                    break;

            }

            return s;
        }

        public static string ExposureProgramToString(FieldType typeValue)
        {
            string s = "";

            short[] values = (short[])typeValue.GetValue();
            short value = values[0];


            switch (value)
            {
                case 1:
                    s = "Not defined";
                    break;
                case 2:
                    s = "Normal program";
                    break;
                case 3:
                    s = "Aperture priority";
                    break;
                case 4:
                    s = "Shutter priority";
                    break;
                case 5:
                    s = "Creative program (biased toward depth of field)";
                    break;
                case 6:
                    s = "Action program (biased toward fast shutter speed)";
                    break;
                case 7:
                    s = "Portrait mode (for closeup photos with the background out of focus)";
                    break;

                case 8:
                    s = "Landscape mode (for landscape photos with the background in focus)";
                    break;
            }

            return s;
        }

        public static string MeteringModeToString(FieldType typeValue)
        {
            string s = "";

            short[] values = (short[])typeValue.GetValue();
            short value = values[0];


            switch (value)
            {
                case 0:
                    s += "Unknown";
                    break;
                case 1:
                    s += "Average";
                    break;
                case 2:
                    s += "CenterWeightedAverage";
                    break;
                case 3:
                    s += "Spot";
                    break;
                case 4:
                    s += "MultiSpot";
                    break;
                case 5:
                    s += "Pattern";
                    break;
                case 6:
                    s += "Partial";
                    break;
                case 255:
                    s += "other";
                    break;
            }

            return s;
        }

        public static string FlashToString(FieldType typeValue)
        {
            string s = "";

            short[] values = (short[])typeValue.GetValue();
            short value = values[0];


            switch (value)
            {
                case 0x0000:
                    s += "Flash did not fire";
                    break;
                case 0x0001:
                    s += "Flash fired";
                    break;
                case 0x0005:
                    s += "Strobe return light not detected";
                    break;
                case 0x0007:
                    s += "Strobe return light detected";
                    break;
                case 0x0009:
                    s += "Flash fired, compulsory flash mode";
                    break;
                case 0x000D:
                    s += "Flash fired, compulsory flash mode, return light not detected";
                    break;
                case 0x000F:
                    s += "Flash fired, compulsory flash mode, return light detected";
                    break;
                case 0x0010:
                    s += "Flash did not fire, compulsory flash mode";
                    break;
                case 0x0018:
                    s += "Flash did not fire, auto mode";
                    break;
                case 0x0019:
                    s += "Flash fired, auto mode";
                    break;
                case 0x001D:
                    s += "Flash fired, auto mode, return light not detected";
                    break;
                case 0x001F:
                    s += "Flash fired, auto mode, return light detected";
                    break;
                case 0x0020:
                    s += "No flash function";
                    break;
                case 0x0041:
                    s += "Flash fired, red - eye reduction mode";
                    break;
                case 0x0045:
                    s += "Flash fired, red - eye reduction mode, return light not detected";
                    break;
                case 0x0047:
                    s += "Flash fired, red - eye reduction mode, return light detected";
                    break;
                case 0x0049:
                    s += "Flash fired, compulsory flash mode, red - eye reduction mode";
                    break;
                case 0x004D:
                    s += "Flash fired, compulsory flash mode, red - eye reduction mode, return light not detected";
                    break;
                case 0x004F:
                    s += "Flash fired, compulsory flash mode, red - eye reduction mode, return light detected";
                    break;
                case 0x0059:
                    s += "Flash fired, auto mode, red-eye reduction mode";
                    break;
                case 0x005D:
                    s += "Flash fired, auto mode, return light not detected, red-eye reduction mode";
                    break;
                case 0x005F:
                    s += "Flash fired, auto mode, return light detected, red - eye reduction mode";
                    break;
            }

            return s;
        }

        public static string LightSourceToString(FieldType typeValue)
        {
            string s = "";

            short[] values = (short[])typeValue.GetValue();
            short value = values[0];

            switch (value)
            {
                case 0:
                    s += "Unknown";
                    break;
                case 1:
                    s += "Daylight";
                    break;
                case 2:
                    s += "Fluorescent";
                    break;
                case 3:
                    s += "Tungsten(incandescent light)";
                    break;
                case 4:
                    s += "Flash";
                    break;
                case 9:
                    s += "Fine weather";
                    break;
                case 10:
                    s += "Cloudy weather";
                    break;
                case 11:
                    s += "Shade";
                    break;
                case 12:
                    s += "Daylight fluorescent(D 5700 - 7100K)";
                    break;
                case 13:
                    s += "Day white fluorescent(N 4600 - 5400K)";
                    break;
                case 14:
                    s += "Cool white fluorescent(W 3900 - 4500K)";
                    break;
                case 15:
                    s += "White fluorescent(WW 3200 - 3700K)";
                    break;
                case 17:
                    s += "Standard light A";
                    break;
                case 18:
                    s += "Standard light B";
                    break;
                case 19:
                    s += "Standard light C";
                    break;
                case 20:
                    s += "D55";
                    break;
                case 21:
                    s += "D65";
                    break;
                case 22:
                    s += "D75";
                    break;
                case 23:
                    s += "D50";
                    break;
                case 24:
                    s += "ISO studio tungsten";
                    break;
                case 255:
                    s += "Other light source";
                    break;
            }

            return s;
        }

        public static string ColorSpaceToString(FieldType typeValue)
        {
            string s = "";

            ushort[] values = (ushort[])typeValue.GetValue();
            ushort value = values[0];

            switch (value)
            {
                case 1:
                    s += "sRGB";
                    break;
                case 2:
                    s += "Adobe RGB";
                    break;
                case 65533:
                    s += "Wide Gamut RGB";
                    break;
                case 65534:
                    s += "ICC Profile";
                    break;
                case 65535:
                    s += "Uncalibrated";
                    break;
            }

            return s;
        }

        public static string SensingMethodToString(FieldType typeValue)
        {
            string s = "";

            ushort[] values = (ushort[])typeValue.GetValue();
            ushort value = values[0];

            switch (value)
            {
                case 1:
					s += "Not defined";
					break;
                case 2:
					s += "One-chip color area sensor";
					break;
                case 3:
					s += "Two-chip color area sensor";
					break;
                case 4:
					s += "Three-chip color area sensor";
					break;
                case 5:
					s += "Color sequential area sensor";
					break;
                case 7:
					s += "Trilinear sensor";
					break;
                case 8:
					s += "Color sequential linear sensor";
					break;

            }

            return s;
        }
    }
}
