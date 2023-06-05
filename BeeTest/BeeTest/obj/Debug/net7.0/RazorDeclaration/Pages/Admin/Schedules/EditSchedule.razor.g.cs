// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BeeTest.Pages.Admin.Schedules
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using BeeTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using BeeTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\EditSchedule.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\EditSchedule.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\EditSchedule.razor"
using BeeTest.Pages.Components.Gates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\EditSchedule.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\EditSchedule.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticatedLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/schedules/{id}/edit")]
    public partial class EditSchedule : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\EditSchedule.razor"
       
    [Parameter]
    public string id { get; set; }

    private bool IsLoading = false;

    private List<User> users = new List<User>();
    private List<Participant_Schedule> participant_Schedules = new List<Participant_Schedule>();

    private Schedule Schedule = new Schedule();
    private string participantEmail = "";

    protected override async Task OnInitializedAsync()
    {
        Schedule = await scheduleService.Get(int.Parse(id));
        users = await userService.GetAllParticipants();
        participant_Schedules = await participant_scheduleService.GetParticipantSchedulesByScheduleId(int.Parse(id));

        await base.OnInitializedAsync();
    }

    private async Task AddParticipant()
    {
        if (!(await AreFormValuesValid()))
        {
            return;
        }

        IsLoading = true;

        Participant_Schedule newParticipant_Schedule = new Participant_Schedule
            {
                Participant = await userService.Get(participantEmail),
                Schedule = Schedule
            };

        bool isSuccessful = await participant_scheduleService.Add(newParticipant_Schedule);

        if (isSuccessful) {
            participant_Schedules.Add(newParticipant_Schedule);
            participantEmail = "";
        }
        else await js.InvokeVoidAsync("alert", "Participant Addition Failed");

        IsLoading = false;
        await Task.Delay(1);
    }

    private async Task<bool> AreFormValuesValid()
    {
        User? newParticipant = users.Where(u => u.Email == participantEmail).FirstOrDefault();

        if (newParticipant == null)
        {
            await js.InvokeVoidAsync("alert", "Participant Doesn't Exist");
            return false;
        }

        foreach(Participant_Schedule participant_Schedule in participant_Schedules)
        {
            if (participant_Schedule.Participant.Email == newParticipant.Email)
            {
                await js.InvokeVoidAsync("alert", "Participant Already in Schedule");
                return false;
            }
        }

        return true;
    }

    private async Task DeleteParticipant(Participant_Schedule participant_Schedule)
    {
        IsLoading = true;

        bool isSucessful = await participant_scheduleService.Delete(participant_Schedule);

        if (isSucessful) participant_Schedules.Remove(participant_Schedule);
        else await js.InvokeVoidAsync("alert", "Participant Deletion Failed");
    
        IsLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IParticipant_ScheduleService participant_scheduleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IScheduleService scheduleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
