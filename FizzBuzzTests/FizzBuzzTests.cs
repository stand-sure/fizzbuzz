namespace FizzBuzzTests;

using FizzBuzz;

using Xunit.Categories;

[UnitTest(nameof(FizzBuzz))]
public class FizzBuzzTests
{
    private const int Count = 30;

    [Theory]
    [MemberData(nameof(TestData))]
    public void ChineseRemainderTheoremApproachShouldReturnBuzzWhenMultipleOf5(int val)
    {
        bool expectBuzz = val % 5 == 0;

        string actual = FizzBuzz.ChineseRemainderTheoremApproach(val);

        if (expectBuzz)
        {
            actual.Should().ContainEquivalentOf("buzz");
        }
        else
        {
            actual.Should().NotContainEquivalentOf("buzz");
        }
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void ChineseRemainderTheoremApproachShouldReturnFizzWhenMultipleOf3(int val)
    {
        bool expectFizz = val % 3 == 0;

        string actual = FizzBuzz.ChineseRemainderTheoremApproach(val);

        if (expectFizz)
        {
            actual.Should().ContainEquivalentOf("fizz");
        }
        else
        {
            actual.Should().NotContainEquivalentOf("fizz");
        }
    }

    public static IEnumerable<object[]> TestData()
    {
        return from val in Enumerable.Range(0, FizzBuzzTests.Count)
            select new object[] { val };
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void TwoArrayApproachShouldReturnBuzzWhenMultipleOf5(int val)
    {
        bool expectBuzz = val % 5 == 0;

        string actual = FizzBuzz.TwoArrayApproach(val);

        if (expectBuzz)
        {
            actual.Should().ContainEquivalentOf("buzz");
        }
        else
        {
            actual.Should().NotContainEquivalentOf("buzz");
        }
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void TwoArrayApproachShouldReturnFizzWhenMultipleOf3(int val)
    {
        bool expectFizz = val % 3 == 0;

        string actual = FizzBuzz.TwoArrayApproach(val);

        if (expectFizz)
        {
            actual.Should().ContainEquivalentOf("fizz");
        }
        else
        {
            actual.Should().NotContainEquivalentOf("fizz");
        }
    }
}