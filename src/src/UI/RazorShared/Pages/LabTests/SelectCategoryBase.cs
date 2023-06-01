using Microsoft.AspNetCore.Components;
using RazorShared.Server.Models.LabTests;
using RazorShared.StateManagement;

namespace RazorShared.Pages.LabTests;

public class SelectCategoryBase : ComponentBase
{
    [Parameter] public Dictionary<string,LabTestPriceDetail> ViewModels { get; set; } = new Dictionary<string, LabTestPriceDetail>();
    [Inject] private LabTestCategoryStateService LabTestCategoryStateServiceService { get; set; } = null!;
    [Inject] private  NavigationManager NavigationManager { get; set; } = null!;
    protected void Remove(LabTestPriceDetail test)
   {
       LabTestCategoryStateServiceService.RemoveLabTest(test);
       NavigationManager.NavigateTo("/selected-lab-test");
       StateHasChanged();

   }
}