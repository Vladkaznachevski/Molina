using Data;
using Molina.Models.ViewModels.Default;

namespace Molina.Models.ViewModels
{
    public class MaterialListViewModel
    {
        public List<Material> Materials { get; }
        public PageViewModel PageViewModel { get; }
        public SortViewModel SortViewModel { get; }
        public FilterViewModel FilterViewModel { get; }

        public MaterialListViewModel
        (
            List<Material> materials,
            PageViewModel pageViewModel,
            SortViewModel sortViewModel,
            FilterViewModel filterViewModel
        )
        {
            Materials = materials;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }
    }
}

/*                             @foreach (var item in Model.Foods.Select((value, index) => new { index, value }))
                            {
                                <tr>
                                    <td>@(item.index + 1)</td>
                                    <td>@item.value.Name</td>
                                    <td>@item.value.Description</td>
                                    <td>@item.value.CreatedDate</td>
                                    <td>@item.value.ModifiedDate</td>
                                    <td>
                                        <div class="btn-group btn-group-sm">
                                            <a class="btn btn-dark" asp-controller="AdminFood" asp-action="Update" asp-route-Id="@item.value.Id">
                                                Редактировать
                                            </a>
                                            <button class="btn btn-danger" type="submit" form="delete-form-@item.value.Id">
                                                Удалить
                                            </button>
                                        </div>
                                        <form class="delete-form" asp-controller="AdminFood" asp-action="Delete" asp-route-Id="@item.value.Id" method="post" id="delete-form-@item.value.Id" data-name="@item.value.Name"></form>
                                    </td>
                                </tr>
                            }

*/