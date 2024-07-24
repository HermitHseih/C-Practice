using System;

public class NumberRange
{
    public static void DisplayRanges()
    {
        // 整數型別範圍
        Console.WriteLine($"sbyte 最大值: {sbyte.MaxValue:N0}");
        Console.WriteLine($"sbyte 最小值: {sbyte.MinValue:N0}");
        Console.WriteLine($"byte 最大值: {byte.MaxValue:N0}");
        Console.WriteLine($"byte 最小值: {byte.MinValue:N0}");
        Console.WriteLine($"short 最大值: {short.MaxValue:N0}");
        Console.WriteLine($"short 最小值: {short.MinValue:N0}");
        Console.WriteLine($"ushort 最大值: {ushort.MaxValue:N0}");
        Console.WriteLine($"ushort 最小值: {ushort.MinValue:N0}");
        Console.WriteLine($"int 最大值: {int.MaxValue:N0}");
        Console.WriteLine($"int 最小值: {int.MinValue:N0}");
        Console.WriteLine($"uint 最大值: {uint.MaxValue:N0}");
        Console.WriteLine($"uint 最小值: {uint.MinValue:N0}");
        Console.WriteLine($"long 最大值: {long.MaxValue:N0}");
        Console.WriteLine($"long 最小值: {long.MinValue:N0}");
        Console.WriteLine($"ulong 最大值: {ulong.MaxValue:N0}");
        Console.WriteLine($"ulong 最小值: {ulong.MinValue:N0}");

        // 浮點型別範圍
        Console.WriteLine($"float 最大值: {float.MaxValue}");
        Console.WriteLine($"float 最小值: {float.MinValue}");
        Console.WriteLine($"float 最小正數: {float.Epsilon}");
        Console.WriteLine($"double 最大值: {double.MaxValue}");
        Console.WriteLine($"double 最小值: {double.MinValue}");
        Console.WriteLine($"double 最小正數: {double.Epsilon}");

        // decimal 型別範圍
        Console.WriteLine($"decimal 最大值: {decimal.MaxValue:N0}");
        Console.WriteLine($"decimal 最小值: {decimal.MinValue:N0}");
        Console.WriteLine($"decimal 最小正數: {1E-28M}"); // decimal 型別的最小正數大約為 1E-28
    }

    public static void DisplayMemoryUsage()
    {
        // 整數型別範圍
        Console.WriteLine("數值型別大小 (以位元組為單位)：");
        Console.WriteLine($"byte  的大小 = {sizeof(byte)} bytes");
        Console.WriteLine($"short 的大小 = {sizeof(short)} bytes");
        Console.WriteLine($"int   的大小 = {sizeof(int)} bytes");
        Console.WriteLine($"uint  的大小 = {sizeof(uint)} bytes");
        Console.WriteLine($"long  的大小 = {sizeof(long)} bytes");
        Console.WriteLine($"ulong 的大小 = {sizeof(ulong)} bytes");

        // 浮點型別範圍
        Console.WriteLine("浮點數型別大小 (以位元組為單位)：");
        Console.WriteLine($"float 的大小 = {sizeof(float)} bytes");
        Console.WriteLine($"double 的大小 = {sizeof(double)} bytes");

        // decimal 型別範圍
        Console.WriteLine("decimal 型別大小 (以位元組為單位)：");
        Console.WriteLine($"decimal 的大小 = {sizeof(decimal)} bytes");
    }
}
