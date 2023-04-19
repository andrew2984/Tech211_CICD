using FactorySorterApp.Models;
using FactorySorterApp.Controller;

namespace FactorySorterTests
{
    public class MergeSortTest
    {
        [TestCase(5, 5)]
        [TestCase(2, 10)]
        [TestCase(10, 2)]
        [TestCase(1, 100)]
        public void GivenArrayGenerator_WhenMergeSort_ReturnsCorrectSortedArray(int length, int seed) 
        {
            var AG1 = new ArrayGenerator(length, seed);
            var mergeSort = new Merge(AG1);
            mergeSort.Sort();
            int[] actualResult = AG1.SortableArray;
            Assert.That(actualResult, Is.Ordered);
        }
    }
}
