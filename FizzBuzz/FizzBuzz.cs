namespace FizzBuzz;

public static class FizzBuzz
{
    private static readonly string?[] Buzz = { "buzz", null, null, null, null };

    private static readonly string?[] ChineseRemainderTheorem =
    {
        "fizzbuzz", // 0
        null, // 1
        null, // 2
        "fizz", // 3
        null, // 4
        "buzz", // 5
        "fizz", // 6
        null, // 7
        null, // 8
        "fizz", // 9
        "buzz", // 10
        null, // 11
        "fizz", // 12
        null, // 13
        null, // 14
    };

    private static readonly string?[] Fizz = { "fizz", null, null };

    public static string ChineseRemainderTheoremApproach(int value)
    {
        return $"{FizzBuzz.ChineseRemainderTheorem[value % 15]}";
    }

    public static string TwoArrayApproach(int value)
    {
        return $"{FizzBuzz.Fizz[value % 3]}{FizzBuzz.Buzz[value % 5]}";
    }
}