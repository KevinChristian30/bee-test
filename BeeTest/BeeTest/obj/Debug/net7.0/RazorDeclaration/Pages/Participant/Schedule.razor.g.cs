// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BeeTest.Pages.Participant
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
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\Schedule.razor"
using BeeTest.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\Schedule.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\Schedule.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\Schedule.razor"
using BeeTest.Pages.Components.Gates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\Schedule.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\Schedule.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\Schedule.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\Schedule.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticatedLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/participant-schedules")]
    public partial class Schedule : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Participant\Schedule.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    private string email = "";

    private List<Participant_Schedule> futureParticipant_Schedules = new List<Participant_Schedule>();
    private List<Participant_Schedule> currentParticipant_Schedules = new List<Participant_Schedule>();

    protected override async Task OnInitializedAsync()
    {
        email = AuthStateProvider.GetCurrentUserEmail(await authenticationState);

        futureParticipant_Schedules = await participant_scheduleService.GetParticipantSchedulesByParticipantEmailAfter(email, DateTime.Now);

        currentParticipant_Schedules = await participant_scheduleService.GetParticipantSchedulesByParticipantEmailBetween(email, DateTime.Now);

        await base.OnInitializedAsync();
    }

    private async Task NavigateToTestPage(Participant_Schedule participant_Schedule)
    {
        if (!(await participant_scheduleService.InitializeTest(participant_Schedule)))
        {
            await js.InvokeVoidAsync("alert", "Failed to Initialize Questions");
            return;
        }

        navigationManager.NavigateTo($"/tests/{participant_Schedule.Schedule.Id}/take", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IParticipant_ScheduleService participant_scheduleService { get; set; }
    }
}
#pragma warning restore 1591
