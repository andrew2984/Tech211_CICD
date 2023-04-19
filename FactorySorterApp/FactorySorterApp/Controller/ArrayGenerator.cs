namespace FactorySorterApp.Controller;

public class ArrayGenerator
{

    public int[] SortableArray { get; set; }


    public ArrayGenerator(int arrayLength, int seed = 1)
    {
        if (arrayLength < 1)
        {
            throw new ArgumentException("Array length cannot be less than 1!");
        }
        SortableArray = new int[arrayLength];
        GenerateRandomArray(seed);
    }

    private void GenerateRandomArray(int seed)
    {
        Random rand;
        if (seed == 1)
        {
            rand = new Random();
        }
        else
        {
            rand = new Random(seed);
        }
        for (int i = 0; i < SortableArray.Length; i++)
        {
            SortableArray[i] = rand.Next(-1000, 1001);
        }
    }

    public override string ToString()
    {
        string message = "{";

        for (int i = 0; i < SortableArray.Length; i++)
        {
            message += SortableArray[i];
            if (i != SortableArray.Length - 1)
            {
                message += ",";
            }
        }
        message += "}";
        return message;
    }

}
