using System;

public class Formatter
{
    public static void DisplayFormattedValues()
    {
        // 定義數值
        int intValue = -1234;
        int posIntValue = 1234;
        float floatValue = -1234.567f;

        // 顯示格式化數值
        Console.WriteLine($"貨幣（Currency）(C) Currency:");
        Console.WriteLine($"{intValue:C}\n{posIntValue:C}\n");

        Console.WriteLine($"十進位(Decimal)(D) Decimal:");
        Console.WriteLine($"{intValue:D}\n");

        Console.WriteLine($"科學計數法（Scientific）(E) Scientific:");
        Console.WriteLine($"{floatValue:E}\n");

        Console.WriteLine($"定點數（Fixed point）(F) Fixed point:");
        Console.WriteLine($"{floatValue:F}\n");

        Console.WriteLine($"常規格式（General）(G) General:");
        Console.WriteLine($"{intValue:G}\n");

        Console.WriteLine($"預設 (default):");
        Console.WriteLine($"{intValue}\n");

        Console.WriteLine($"數字格式（Number）(N) Number:");
        Console.WriteLine($"{intValue:N}\n");

        Console.WriteLine($"百分比格式（Percent）(P) Percent:");
        Console.WriteLine($"{floatValue:P}\n");

        Console.WriteLine($"十六進位(Hexadecimal)(X) Hexadecimal:");
        Console.WriteLine($"{posIntValue:X}\n");
    }

    public static void DisplayFormattedFloatValues()
    {
        // 定義浮點數值
        float floatValue = -1234.567f;
        double doubleValue = 1234.5678;

        // 顯示格式化浮點數值
        Console.WriteLine($"貨幣（Currency）(C) Currency:");
        Console.WriteLine($"{floatValue:C}\n{doubleValue:C}\n");

        Console.WriteLine($"科學計數法（Scientific）(E) Scientific:");
        Console.WriteLine($"{floatValue:E}\n{doubleValue:E}\n");

        Console.WriteLine($"定點數（Fixed point）(F) Fixed point:");
        Console.WriteLine($"{floatValue:F}\n{doubleValue:F}\n");

        Console.WriteLine($"常規格式（General）(G) General:");
        Console.WriteLine($"{floatValue:G}\n{doubleValue:G}\n");

        Console.WriteLine($"數字格式（Number）(N) Number:");
        Console.WriteLine($"{floatValue:N}\n{doubleValue:N}\n");

        Console.WriteLine($"百分比格式（Percent）(P) Percent:");
        Console.WriteLine($"{floatValue:P}\n{doubleValue:P}\n");
    }

    public static void DisplayFormattedDates()
    {
        // 定義日期
        DateTime currentDate = DateTime.Now;

        // 顯示格式化日期
        Console.WriteLine($"(d) Short date:");
        Console.WriteLine($"{currentDate:d}\n");

        Console.WriteLine($"(D) Long date:");
        Console.WriteLine($"{currentDate:D}\n");

        Console.WriteLine($"(f) Full date/time (short time):");
        Console.WriteLine($"{currentDate:f}\n");

        Console.WriteLine($"(F) Full date/time (long time):");
        Console.WriteLine($"{currentDate:F}\n");

        Console.WriteLine($"(g) General date/time (short time):");
        Console.WriteLine($"{currentDate:g}\n");

        Console.WriteLine($"(G) General date/time (long time):");
        Console.WriteLine($"{currentDate:G}\n");

        Console.WriteLine($"(M) Month day:");
        Console.WriteLine($"{currentDate:M}\n");

        Console.WriteLine($"(O) Round-trip date/time:");
        Console.WriteLine($"{currentDate:O}\n");

        Console.WriteLine($"(R) RFC1123 date/time:");
        Console.WriteLine($"{currentDate:R}\n");

        Console.WriteLine($"(s) Sortable date/time:");
        Console.WriteLine($"{currentDate:s}\n");

        Console.WriteLine($"(t) Short time:");
        Console.WriteLine($"{currentDate:t}\n");

        Console.WriteLine($"(T) Long time:");
        Console.WriteLine($"{currentDate:T}\n");

        Console.WriteLine($"(u) Universal sortable date/time:");
        Console.WriteLine($"{currentDate:u}\n");

        Console.WriteLine($"(U) Universal full date/time:");
        Console.WriteLine($"{currentDate:U}\n");

        Console.WriteLine($"(Y) Year month:");
        Console.WriteLine($"{currentDate:Y}\n");
    }

    public static void DisplayCustomFormattedDates()
    {
        /*
        自訂格式字符串說明
        yyyy：四位數年份
        MM：兩位數月份
        dd：兩位數日期
        HH：24 小時制小時
        mm：分鐘
        ss：秒
        fff：毫秒
        dddd：完整星期名稱
        MMMM：完整月份名稱
        h：12 小時制小時（不帶前導零）
        tt：AM/PM
        K：時區信息
        */

        // 定義日期
        DateTime currentDate = DateTime.Now;

        // 顯示自訂格式化日期
        Console.WriteLine("自訂日期格式:");

        // 年-月-日 時:分
        Console.WriteLine($"yyyy-MM-dd HH:mm: {currentDate:yyyy-MM-dd HH:mm}");

        // 月/日/年
        Console.WriteLine($"MM/dd/yyyy: {currentDate:MM/dd/yyyy}");

        // 日-月-年 時:分:秒
        Console.WriteLine($"dd-MM-yyyy HH:mm:ss: {currentDate:dd-MM-yyyy HH:mm:ss}");

        // 完整日期時間
        Console.WriteLine($"dddd, MMMM dd, yyyy h:mm tt: {currentDate:dddd, MMMM dd, yyyy h:mm tt}");

        // ISO 8601 日期格式
        Console.WriteLine($"yyyy-MM-ddTHH:mm:ss.fffffffK: {currentDate:yyyy-MM-ddTHH:mm:ss.fffffffK}");

        // 月份名稱和年份
        Console.WriteLine($"MMMM yyyy: {currentDate:MMMM yyyy}");

        // 12 小時制時間
        Console.WriteLine($"hh:mm tt: {currentDate:hh:mm tt}");

        // 24 小時制時間
        Console.WriteLine($"HH:mm: {currentDate:HH:mm}");

        // 縮寫月份名稱和日期
        Console.WriteLine($"MMM dd: {currentDate:MMM dd}");

        // 完整的日期和時間，包含毫秒
        Console.WriteLine($"yyyy-MM-dd HH:mm:ss.fff: {currentDate:yyyy-MM-dd HH:mm:ss.fff}");
    }
}
