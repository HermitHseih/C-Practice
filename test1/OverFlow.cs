public class OverFlow
{
    public static void DisplayOverFlow<T>(T addNum) where T : struct, IConvertible
    {
        dynamic maxValue = default(T);
        dynamic addValue = addNum;
        dynamic result;

        try
        {
            // 確保 maxValue 會被初始化為相應型別的最大值
            if (typeof(T) == typeof(int))
                maxValue = int.MaxValue;
            else if (typeof(T) == typeof(uint))
                maxValue = uint.MaxValue;
            else if (typeof(T) == typeof(short))
                maxValue = short.MaxValue;
            else if (typeof(T) == typeof(ushort))
                maxValue = ushort.MaxValue;
            else if (typeof(T) == typeof(long))
                maxValue = long.MaxValue;
            else if (typeof(T) == typeof(ulong))
                maxValue = ulong.MaxValue;
            else if (typeof(T) == typeof(byte))
                maxValue = byte.MaxValue;
            else if (typeof(T) == typeof(sbyte))
                maxValue = sbyte.MaxValue;
            else
                throw new InvalidOperationException("Unsupported type.");

            // 進行計算並處理溢位
            // 使用 unchecked 進行加法計算，以避免溢位拋出異常。
            result = unchecked(maxValue + addValue);

            // 對於無符號型別，計算回繞的結果
            if (typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(ushort) || typeof(T) == typeof(byte))
            {
                // 對無符號型別附加 (wrapped around) 標註以表明數字回繞。
                Console.WriteLine($"{maxValue} + {addValue} = {result} (wrapped around)");
            }
            else
            {
                Console.WriteLine($"{maxValue} + {addValue} = {result}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void DisplayOverflowFloat<T>(T addNum) where T : struct, IConvertible
    {
        dynamic maxValue = default(T);
        dynamic addValue = addNum;
        dynamic result;

        // 初始化 maxValue 為相應型別的最大值
        if (typeof(T) == typeof(float))
            maxValue = float.MaxValue;
        else if (typeof(T) == typeof(double))
            maxValue = double.MaxValue;
        else
            throw new InvalidOperationException("Unsupported type.");

        // 進行加法並處理溢位
        try
        {
            result = unchecked(maxValue + addValue);

            // 根據型別展示溢位的結果
            if (typeof(T) == typeof(float))
            {
                if (float.IsPositiveInfinity(result))
                    Console.WriteLine($"{maxValue} + {addValue} = Overflow: Positive Infinity");
                else if (float.IsNegativeInfinity(result))
                    Console.WriteLine($"{maxValue} + {addValue} = Overflow: Negative Infinity");
                else if (float.IsNaN(result))
                    Console.WriteLine($"{maxValue} + {addValue} = Overflow: NaN");
                else
                    Console.WriteLine($"{maxValue} + {addValue} = Result: {result}");
            }
            else if (typeof(T) == typeof(double))
            {
                if (double.IsPositiveInfinity(result))
                    Console.WriteLine($"{maxValue} + {addValue} = Overflow: Positive Infinity");
                else if (double.IsNegativeInfinity(result))
                    Console.WriteLine($"{maxValue} + {addValue} = Overflow: Negative Infinity");
                else if (double.IsNaN(result))
                    Console.WriteLine($"{maxValue} + {addValue} = Overflow: NaN");
                else
                    Console.WriteLine($"{maxValue} + {addValue} = Result: {result}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }


    public static void CheckOverFlow<T>(T addNum) where T : struct, IConvertible
    {
        dynamic maxValue = default(T);
        dynamic addValue = addNum;
        dynamic result;

        try
        {
            // 確保 maxValue 會被初始化為相應型別的最大值
            if (typeof(T) == typeof(int))
                maxValue = int.MaxValue;
            else if (typeof(T) == typeof(uint))
                maxValue = uint.MaxValue;
            else if (typeof(T) == typeof(short))
                maxValue = short.MaxValue;
            else if (typeof(T) == typeof(ushort))
                maxValue = ushort.MaxValue;
            else if (typeof(T) == typeof(long))
                maxValue = long.MaxValue;
            else if (typeof(T) == typeof(ulong))
                maxValue = ulong.MaxValue;
            else if (typeof(T) == typeof(byte))
                maxValue = byte.MaxValue;
            else if (typeof(T) == typeof(sbyte))
                maxValue = sbyte.MaxValue;
            else
                throw new InvalidOperationException("Unsupported type.");

            // 進行計算並處理溢位
            // checked：在加法、減法、乘法等運算中，如果結果超出該型別的範圍，會拋出 OverflowException 異常。
            // unchecked：忽略溢位檢查，結果會回繞到型別的範圍內
            result = checked(maxValue + addValue);

            // 對於無符號型別，計算回繞的結果
            if (typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(ushort) || typeof(T) == typeof(byte))
            {
                // 對無符號型別附加 (wrapped around) 標註以表明數字回繞。
                Console.WriteLine($"{maxValue} + {addValue} = {result} (wrapped around)");
            }
            else
            {
                Console.WriteLine($"{maxValue} + {addValue} = {result}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}