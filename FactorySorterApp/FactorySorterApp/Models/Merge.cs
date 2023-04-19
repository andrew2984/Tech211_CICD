using FactorySorterApp.Controller;

namespace FactorySorterApp.Models;

public class Merge : ISorter
{
    private ArrayGenerator _arrayGenerator;
    public Merge(ArrayGenerator array)
    {
        _arrayGenerator = array;
    }
    public void Sort()
    {
        var unSortedList = ToList();
        _arrayGenerator.SortableArray = MergeSort(unSortedList).ToArray();
    }

    private List<int> MergeSort(List<int> unsorted)
    {
        if (unsorted.Count <= 1) //base condition
        {
            return unsorted;
        }
        var left = new List<int>();
        var right = new List<int>();
        int middle = unsorted.Count / 2;

        for (int i = 0; i < middle; i++)
        {
            left.Add(unsorted[i]);
        }

        for (int i = middle; i < unsorted.Count; i++)
        {
            right.Add(unsorted[i]);
        }

        left = MergeSort(left);
        right = MergeSort(right);
        return Merging(left, right);
    }

    private List<int> Merging(List<int> left, List<int> right)
    {
        var mergedList = new List<int>();
        int countA = 0, countB = 0;

        while (countA < left.Count && countB < right.Count)
        {
            if (left[countA] >= right[countB])
            {
                mergedList.Add(right[countB]);
                countB += 1;
            }
            else
            {
                mergedList.Add(left[countA]);
                countA += 1;
            }
        }

        if (countA < left.Count)
        {
            for (int i = countA; i < left.Count; i++)
            {
                mergedList.Add(left[i]);
            }
        }
        else
        {
            for (int i = countB; i < right.Count; i++)
            {
                mergedList.Add(right[i]);
            }
        }
        return mergedList;
    }

    private List<int> ToList()
    {
        return _arrayGenerator.SortableArray.ToList();
    }
}
