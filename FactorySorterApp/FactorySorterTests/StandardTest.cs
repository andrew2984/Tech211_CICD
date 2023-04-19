using FactorySorterApp.Models;
using FactorySorterApp.Controller;

namespace FactorySorterTests;

public class StandardTest
{

    [TestCase(5, 5)]
    [TestCase(2, 10)]
    [TestCase(10, 2)]
    [TestCase(1, 100)]
    public void GivenArrayGenerator_WhenStandardSort_ReturnsCorrectSortedArray(int length, int seed)
    {
        var AG1 = new ArrayGenerator(length, seed);
        var standardSort = new Standard(AG1);
        standardSort.Sort();
        int[] actualResult = AG1.SortableArray;
        Assert.That(actualResult, Is.Ordered);
    }
}