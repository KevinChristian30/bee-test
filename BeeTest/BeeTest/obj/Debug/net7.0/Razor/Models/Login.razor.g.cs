#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Models\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a72a3adf3080550c2d33b904ad031110e7ad7168"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Models
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
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Models\Login.razor"
using BeeTest.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "BeeTest | Login");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "login");
            __builder.OpenElement(6, "form");
            __builder.AddAttribute(7, "onsubmit", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.EventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Models\Login.razor"
                     Authenticate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "<h1>BeeTest</h1>\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "field-container");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "line");
            __builder.AddMarkupContent(13, "<label>Email</label>\r\n                ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "email");
            __builder.AddAttribute(16, "placeholder", "Email");
            __builder.AddAttribute(17, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Models\Login.razor"
                              model.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Email = __value, model.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "line");
            __builder.AddMarkupContent(22, "<label>Password</label>\r\n                ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "password");
            __builder.AddAttribute(25, "placeholder", "Password");
            __builder.AddAttribute(26, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Models\Login.razor"
                              model.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Password = __value, model.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<button>Log In</button>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Models\Login.razor"
       
    private class Model
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    private Model model = new Model();

    private async Task Authenticate()
    {
        var userAccount = userAccountService.GetUser(model.Email);

        if (userAccount == null || userAccount.Password != model.Password)
        {
            await js.InvokeVoidAsync("alert", "Invalid Email or Password");
            return;
        }

        var authStateProvider = (AuthStateProvider) authenticationStateProvider;
        await authStateProvider.UpdateAuthenticationState(new UserSession
        {
            Email = userAccount.Email,
            Role = userAccount.Role.Name
        });

        navigationManager.NavigateTo("/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserAuthService userAccountService { get; set; }
    }
}
#pragma warning restore 1591
