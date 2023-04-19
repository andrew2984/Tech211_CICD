using FactorySorterApp.Controller;

namespace FactorySorterApp.Models;

public class Quick : ISorter
{

    private ArrayGenerator _arrayGenerator;
    public Quick(ArrayGenerator array)
    {
        _arrayGenerator = array;

    }
    
    //The QuickSort method
    public void Sort()
    {
        int[] arrayToBeSorted = _arrayGenerator.SortableArray;
        int length = _arrayGenerator.SortableArray.Length;
        QuickSort(arrayToBeSorted, 0, length-1);

    }

    static void QuickSort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int partitionIndex = partition(arr, start, end);
            QuickSort(arr, start, partitionIndex - 1);
            QuickSort(arr, partitionIndex + 1, end);
        }
    }

    static int partition(int[] arr, int start, int end)
    {
        int pivot = arr[end];
        int i = (start - 1);
        for (int j = start; j <= end - 1; j++)
        {


            if (arr[j] < pivot)
            {
                i++;
                swap(arr, i, j);
            }
        }
        swap(arr, i + 1, end);
        return (i + 1);
    }

   
    static void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}
