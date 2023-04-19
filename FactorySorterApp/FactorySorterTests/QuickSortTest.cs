using FactorySorterApp.Models;
using FactorySorterApp.Controller;

namespace FactorySorterTests
{
    public class QuickSortTest
    {
        [TestCase(5, 5)]
        [TestCase(2, 10)]
        [TestCase(10, 2)]
        [TestCase(1, 100)]
        public void GivenArrayGenerator_WhenQuickSort_ReturnCorrectSortedArray(int length, int seed)
        {
            var AG1 = new ArrayGenerator(length, seed);
            var quickSort = new Quick(AG1);
            quickSort.Sort();
            int[] actualResult = AG1.SortableArray;
            Assert.That(actualResult, Is.Ordered);
        }
    }
}
