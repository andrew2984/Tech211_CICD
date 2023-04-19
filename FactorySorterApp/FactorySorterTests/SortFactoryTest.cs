using FactorySorterApp.Controller;
using FactorySorterApp.Models;

namespace FactorySorterTests;

public class SortFactoryTest
{
    
    private ArrayGenerator _arrayGenerator;
    [SetUp]
    public void Init()
    {
        _arrayGenerator = new ArrayGenerator(5, 5);
    }
    [TestCase("Bubble")]
    [TestCase("bubble")]
    [TestCase("buBbLe")]
    public void GivenSortTypeBubble_WhenSortFactory_ReturnsCorrectType(string input)
    {
        ISorter sorter = SortFactory.ChosenSort(input, _arrayGenerator);
        Assert.That(sorter, Is.TypeOf<Bubble>());
    }
    [TestCase("Merge")]
    [TestCase("merge")]
    [TestCase("MeRge")]
    public void GivenSortTypeMerge_WhenSortFactory_ReturnsCorrectType(string input)
    {
        ISorter sorter = SortFactory.ChosenSort(input, _arrayGenerator);
        Assert.That(sorter, Is.TypeOf<Merge>());
    }
    [TestCase("Quick")]
    [TestCase("quick")]
    [TestCase("QuIcK")]
    public void GivenSortTypeQuick_WhenSortFactory_ReturnsCorrectType(string input)
    {
        ISorter sorter = SortFactory.ChosenSort(input, _arrayGenerator);
        Assert.That(sorter, Is.TypeOf<Quick>());
    }
    [TestCase("Standard")]
    [TestCase("standard")]
    [TestCase("StanDarD")]
    public void GivenSortTypeStandard_WhenSortFactory_ReturnsCorrectType(string input)
    {
        ISorter sorter = SortFactory.ChosenSort(input, _arrayGenerator);
        Assert.That(sorter, Is.TypeOf<Standard>());
    }
    [TestCase("Invalid")]
    [TestCase("dhdhdhddg")]
    public void GivenSortTypeInvalid_WhenSortFactory_ReturnsException(string input)
    {
        Assert.That(()=>SortFactory.ChosenSort(input,_arrayGenerator),Throws.TypeOf<ArgumentException>());
    }
}
