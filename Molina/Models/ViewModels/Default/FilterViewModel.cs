using Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Molina.Models.ViewModels.Default
{
    public class FilterViewModel
    {
        public FilterViewModel(int? Cloth, string name)
        {
            SelectedName = name;
            SelectedCloth = Cloth;
        }
        public int? SelectedCloth { get; private set; }   // выбранная компания
        public string SelectedName { get; private set; }    // введенное имя
    }
}