#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d815264c31e291b6a4d339cf98b4c83cd847854"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Pages.Components.EditQuestionForms
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
#line 1 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
using BeeTest.Factories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
using BeeTest.Models.QuestionDetail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class BooleanEditQuestionForm : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 15 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
 if (IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::BeeTest.Pages.Components.LoadingView>(0);
            __builder.CloseComponent();
#nullable restore
#line 18 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
} else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "class", "question-form");
            __builder.AddAttribute(3, "b-6v1iw6tvem");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "question-title");
            __builder.AddAttribute(6, "b-6v1iw6tvem");
            __builder.AddMarkupContent(7, "<label for=\"title\" b-6v1iw6tvem>Question Title</label>\r\n        ");
            __builder.OpenElement(8, "textarea");
            __builder.AddAttribute(9, "id", "title");
            __builder.AddAttribute(10, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                                     Question.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Question.Title = __value, Question.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(12, "b-6v1iw6tvem");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "choices-container");
            __builder.AddAttribute(16, "b-6v1iw6tvem");
            __builder.AddMarkupContent(17, "<h6 b-6v1iw6tvem>Answer Key</h6>\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "line");
            __builder.AddAttribute(20, "b-6v1iw6tvem");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "b-6v1iw6tvem");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "radio");
            __builder.AddAttribute(25, "name", "key");
            __builder.AddAttribute(26, "id", "true");
            __builder.AddAttribute(27, "value", "True");
            __builder.AddAttribute(28, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                                                                                 UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "checked", 
#nullable restore
#line 29 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                                                                                                      IsTrueChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "b-6v1iw6tvem");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.AddMarkupContent(32, "<label for=\"true\" b-6v1iw6tvem>True</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "b-6v1iw6tvem");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "radio");
            __builder.AddAttribute(38, "name", "key");
            __builder.AddAttribute(39, "id", "false");
            __builder.AddAttribute(40, "value", "False");
            __builder.AddAttribute(41, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                                                                                   UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "checked", 
#nullable restore
#line 33 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                                                                                                        IsFalseChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "b-6v1iw6tvem");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<label for=\"false\" b-6v1iw6tvem>False</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenComponent<global::MudBlazor.MudButton>(47);
            __builder.AddAttribute(48, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                        Variant.Filled

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(49, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                                                    Icons.Material.Filled.Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(50, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                                                                                      Size.Large

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(51, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                                                                                                           Save

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(52, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
                                                                                                                          $"background-color:{Colors.Blue.Default}; color:{Colors.Grey.Lighten5}; border-radius: 2px;"

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(53, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(54, "Save Question");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\EditQuestionForms\BooleanEditQuestionForm.razor"
       
    [Parameter]
    public int QuestionId { get; set; }

    private bool IsLoading = false;

    private Question Question = new Question();

    private BooleanQuestionDetail QuestionDetail;
    private string key = "";
    private bool IsTrueChecked => key == "True";
    private bool IsFalseChecked => key == "False";

    protected override async Task OnInitializedAsync()
    {
        Question = await questionService.Get(QuestionId);
        QuestionDetail = (BooleanQuestionDetail) QuestionDetailFactory.ParseJSON(Question.QuestionType.Name, Question.Details);

        key = QuestionDetail.Key ? "True" : "False";

        await base.OnInitializedAsync();
    }

    private async Task Save()
    {
        IsLoading = true;
        await Task.Delay(1);

        if (!(await AreFormValuesValid()))
        {
            IsLoading = false;
            await Task.Delay(1);

            return;
        }

        QuestionDetail.Key = key == "True";
        Question.Details = QuestionDetail.ToJSONString();

        if (await questionService.AddOrUpdate(Question))
        {
            await js.InvokeVoidAsync("alert", "Question Saved Successfully");
        }
        else await js.InvokeVoidAsync("alert", "Couldn't Save Question");

        IsLoading = false;
        await Task.Delay(1);
    }

    private void UpdateKey(ChangeEventArgs e) => key = e.Value.ToString();

    private async Task<bool> AreFormValuesValid()
    {
        if (Question.Title == null || Question.Title == "")
        {
            await js.InvokeVoidAsync("alert", "Question title must be filled");
            return false;
        }

        if (key == "")
        {
            await js.InvokeVoidAsync("alert", "Question answer key must be filled");
            return false;
        }

        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionService questionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionTypeService questionTypeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestService testService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
