// See https://aka.ms/new-console-template for more information

// Practice number sizes and ranges
/*
1. Create a console application project named /02UnderstandingTypes/ that outputs the
   number of bytes in memory that each of the following number types uses, and the
   minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
   ulong, float, double, and decimal
*/

Console.WriteLine($"sbyte:   size = {sizeof(sbyte)} bytes, min={sbyte.MinValue}, max={sbyte.MaxValue}");
Console.WriteLine($"byte:    size = {sizeof(byte)} bytes, min={byte.MinValue}, max={byte.MaxValue}");
Console.WriteLine($"short:   size = {sizeof(short)} bytes, min={short.MinValue}, max={short.MaxValue}");
Console.WriteLine($"ushort:  size = {sizeof(ushort)} bytes, min={ushort.MinValue}, max={ushort.MaxValue}");
Console.WriteLine($"int:     size = {sizeof(int)} bytes, min={int.MinValue}, max={int.MaxValue}");
Console.WriteLine($"uint:    size = {sizeof(uint)} bytes, min={uint.MinValue}, max={uint.MaxValue}");
Console.WriteLine($"long:    size = {sizeof(long)} bytes, min={long.MinValue}, max={long.MaxValue}");
Console.WriteLine($"ulong:   size = {sizeof(ulong)} bytes, min={ulong.MinValue}, max={ulong.MaxValue}");

Console.WriteLine($"float:   size = {sizeof(float)} bytes, min={float.MinValue}, max={float.MaxValue}");
Console.WriteLine($"double:  size = {sizeof(double)} bytes, min={double.MinValue}, max={double.MaxValue}");
Console.WriteLine($"decimal: size = {sizeof(decimal)} bytes, min={decimal.MinValue}, max={decimal.MaxValue}");

// outputs:
/*
   sbyte:   size = 1 bytes, min=-128, max=127
   byte:    size = 1 bytes, min=0, max=255
   short:   size = 2 bytes, min=-32768, max=32767
   ushort:  size = 2 bytes, min=0, max=65535
   int:     size = 4 bytes, min=-2147483648, max=2147483647
   uint:    size = 4 bytes, min=0, max=4294967295
   long:    size = 8 bytes, min=-9223372036854775808, max=9223372036854775807
   ulong:   size = 8 bytes, min=0, max=18446744073709551615
   float:   size = 4 bytes, min=-3.4028235E+38, max=3.4028235E+38
   double:  size = 8 bytes, min=-1.7976931348623157E+308, max=1.7976931348623157E+308
   decimal: size = 16 bytes, min=-79228162514264337593543950335, max=79228162514264337593543950335


   ulong: size = 8 bytes, min=0, max=18446744073709551615
   float: size = 4 bytes, min=-3.4028235E+38, max=3.4028235E+38
   double: size = 8 bytes, min=-1.7976931348623157E+308, max=1.7976931348623157E+308
   decimal: size = 16 bytes, min=-79228162514264337593543950335, max=79228162514264337593543950335
 */

