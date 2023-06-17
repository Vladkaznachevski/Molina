using Data;
using Molina.Models.ViewModels.Default;

namespace Molina.Models.ViewModels
{
    public class ClothesListViewModel
    {
        public List<Cloth> Clothes { get; }
        public PageViewModel PageViewModel { get; }
        public SortViewModel SortViewModel { get; }
        public FilterViewModel FilterViewModel { get; }

        public ClothesListViewModel
        (
            List<Cloth> clothes,
            PageViewModel pageViewModel,
            SortViewModel sortViewModel,
            FilterViewModel filterViewModel
        )
        {
            Clothes = clothes;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }


    }
}
