using Microsoft.AspNetCore.Components;
using Radzen;
using Web.UI.Server.Api.Contracts;
using Web.UI.Server.Models.Labs;

namespace Web.UI.Pages.Settings.Labs.Creates;
public class CreateBase : ComponentBase
{
    protected Lab model { get; set; } = new ();
     [Inject] private ILabService _labService { get; set; }
     [Inject] private  NotificationService _notificationService { get; set; }
     [Inject] private  DialogService _dialogService { get; set; }
    protected async void OnSave()
    {
        try
        {
          var result= await _labService.CreateLab(model);
          _notificationService.Notify(NotificationSeverity.Success, "", result, 6000);
          _dialogService.Close();
        }
        catch (Exception e)
        {
            _notificationService.Notify(NotificationSeverity.Error, "", e.Message, 6000);
        }

    }

    protected void OnReset()
    {
        model = new Lab();
    }
}