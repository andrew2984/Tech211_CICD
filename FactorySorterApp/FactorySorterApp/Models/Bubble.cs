using FactorySorterApp.Controller;

namespace FactorySorterApp.Models
{
    public class Bubble : ISorter
    {
        private ArrayGenerator _arrayGenerator;
        public Bubble(ArrayGenerator array)
        {
            _arrayGenerator = array;
        }
        public void Sort()
        {
            List<int> listToBeSorted = _arrayGenerator.SortableArray.ToList();
            int length = listToBeSorted.Count;
            int newLength;

            while (length > 1)
            {
                newLength = 0;

                for (int i = 1; i <= length - 1; i++)
                {
                    if (listToBeSorted[i - 1] > listToBeSorted[i])
                    {
                        (listToBeSorted[i - 1], listToBeSorted[i]) = (listToBeSorted[i], listToBeSorted[i - 1]);
                        newLength = i;
                    }
                }
                length = newLength;
            }
            _arrayGenerator.SortableArray = listToBeSorted.ToArray();

        }
    }
}
