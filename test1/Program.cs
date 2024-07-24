// 顯示所有數值型別的範圍
// NumberRange.DisplayRanges();

// 溢位計算
// 測試不同的數值型別
// OverFlow.DisplayOverFlow(1);         // int
// OverFlow.DisplayOverFlow(1U);        // uint
// OverFlow.DisplayOverFlow((short)1);  // short
// OverFlow.DisplayOverFlow((ushort)1); // ushort
// OverFlow.DisplayOverFlow(1L);        // long
// OverFlow.DisplayOverFlow(1UL);       // ulong
// OverFlow.DisplayOverFlow((byte)1);   // byte
// OverFlow.DisplayOverFlow((sbyte)1);  // sbyte

// 測試不同的浮點數型別
// OverFlow.DisplayOverflowFloat(1F);      // float
// OverFlow.DisplayOverflowFloat(1D);      // double

// int x1;
// x1 = int.MaxValue;
// Console.WriteLine($@"{x1 + 1},
// {x1 - 1}
// ");

// 數位分隔號
// int x1 = 0b1_0011_0001;
// int x2 = 0B10_1110;
// int total;
// total = x1 + x2;
// Console.WriteLine($"x1 = {x1}");
// Console.WriteLine($"x2= {x2}");
// Console.WriteLine($"Total = {total}");
// int y1 = 1_000_111;
// int y2 = 5_333_666;
// total = y1 + y2;
// Console.WriteLine($"y1= {y1}");
// Console.WriteLine($"y2= {y2}");
// Console.WriteLine($"Total ={total}");

// 顯示數值類型使用記憶體大小
// NumberRange.DisplayMemoryUsage();

// OverFlow.CheckOverFlow(1);         // int
// OverFlow.CheckOverFlow(1U);        // uint
// OverFlow.CheckOverFlow((short)1);  // short
// OverFlow.CheckOverFlow((ushort)1); // ushort
// OverFlow.CheckOverFlow(1L);        // long
// OverFlow.CheckOverFlow(1UL);       // ulong
// OverFlow.CheckOverFlow((byte)1);   // byte
// OverFlow.CheckOverFlow((sbyte)1);  // sbyte

// 調用 Formatter 類別的方法來顯示格式化數值
// Formatter.DisplayFormattedValues();

// 調用 FloatFormatter 類別的方法來顯示格式化浮點數值
// Formatter.DisplayFormattedFloatValues();

// 調用 DateFormatter 類別的方法來顯示格式化日期
// Formatter.DisplayFormattedDates();

// 調用 CustomDateFormatter 類別的方法來顯示自訂格式化日期
// Formatter.DisplayCustomFormattedDates();

int i = 1;
int j;

do
{
    j = i;
    do
    {
        Console.Write("  ");
    } while (j++ <= 9);
    j = 1;
    do
    {
        Console.Write("AA");
    } while (j++ < i);

    Console.WriteLine();
} while (i++ <= 9);