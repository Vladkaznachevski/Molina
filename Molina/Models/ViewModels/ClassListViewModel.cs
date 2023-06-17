using Data;
using Molina.Models.ViewModels.Default;

namespace Molina.Models.ViewModels
{
    public class ClassListViewModel
    {
        public List<Class> Classes { get; }
        public PageViewModel PageViewModel { get; }
        public SortViewModel SortViewModel { get; }
        public FilterViewModel FilterViewModel { get; }

        public ClassListViewModel
        (
            List<Class> classes,
            PageViewModel pageViewModel,
            SortViewModel sortViewModel,
            FilterViewModel filterViewModel
        )
        {
            Classes = classes;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }
    }
}
