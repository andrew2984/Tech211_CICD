namespace FactorySorterApp.Controller;

using FactorySorterApp.Models;

public class SortFactory
{
    public static ISorter ChosenSort(string requestedModel, ArrayGenerator array) 
    {
        ISorter sortAlgorithm;
        switch (requestedModel.ToLower())
        {
            case "merge":
                sortAlgorithm = new Merge(array);
                sortAlgorithm.Sort();
                break;
            case "bubble":
                sortAlgorithm = new Bubble(array);
                sortAlgorithm.Sort();
                break;
            case "standard":
                sortAlgorithm = new Standard(array);
                sortAlgorithm.Sort();
                break;
            case "quick":
                sortAlgorithm = new Quick(array);
                sortAlgorithm.Sort();
                break;
            default:
                throw new ArgumentException();
        }
        return sortAlgorithm;
    }
}
