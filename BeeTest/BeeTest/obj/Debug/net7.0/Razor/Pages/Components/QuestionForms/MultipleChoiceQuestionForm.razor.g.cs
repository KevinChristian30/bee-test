#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ed69bc482b0928fd6578e20637325816b7e28c"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Pages.Components.QuestionForms
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
#line 1 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
using BeeTest.Models.QuestionDetail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class MultipleChoiceQuestionForm : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 14 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
 if (IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::BeeTest.Pages.Components.LoadingView>(0);
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "class", "question-form");
            __builder.AddAttribute(3, "b-xknbcvhci3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "question-title");
            __builder.AddAttribute(6, "b-xknbcvhci3");
            __builder.AddMarkupContent(7, "<label for=\"title\" b-xknbcvhci3>Question Title</label>\r\n            ");
            __builder.OpenElement(8, "textarea");
            __builder.AddAttribute(9, "id", "title");
            __builder.AddAttribute(10, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                         NewQuestion.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewQuestion.Title = __value, NewQuestion.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(12, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "choices-container");
            __builder.AddAttribute(16, "b-xknbcvhci3");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "line");
            __builder.AddAttribute(19, "b-xknbcvhci3");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "radio");
            __builder.AddAttribute(22, "name", "key");
            __builder.AddAttribute(23, "value", "a");
            __builder.AddAttribute(24, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                    UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "checked", 
#nullable restore
#line 27 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                                         IsAChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, "<label for=\"a\" b-xknbcvhci3>A. </label>\r\n                ");
            __builder.OpenElement(29, "textarea");
            __builder.AddAttribute(30, "id", "a");
            __builder.AddAttribute(31, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                         choices['a']

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => choices['a'] = __value, choices['a']));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(33, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "line");
            __builder.AddAttribute(37, "b-xknbcvhci3");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "radio");
            __builder.AddAttribute(40, "name", "key");
            __builder.AddAttribute(41, "value", "b");
            __builder.AddAttribute(42, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                    UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "checked", 
#nullable restore
#line 32 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                                         IsBChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<label for=\"b\" b-xknbcvhci3>B. </label>\r\n                ");
            __builder.OpenElement(47, "textarea");
            __builder.AddAttribute(48, "id", "b");
            __builder.AddAttribute(49, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                         choices['b']

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => choices['b'] = __value, choices['b']));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(51, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "line");
            __builder.AddAttribute(55, "b-xknbcvhci3");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "radio");
            __builder.AddAttribute(58, "name", "key");
            __builder.AddAttribute(59, "value", "c");
            __builder.AddAttribute(60, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                    UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "checked", 
#nullable restore
#line 37 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                                         IsCChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(62, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.AddMarkupContent(64, "<label for=\"c\" b-xknbcvhci3>C. </label>\r\n                ");
            __builder.OpenElement(65, "textarea");
            __builder.AddAttribute(66, "id", "c");
            __builder.AddAttribute(67, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                         choices['c']

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => choices['c'] = __value, choices['c']));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(69, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "line");
            __builder.AddAttribute(73, "b-xknbcvhci3");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "radio");
            __builder.AddAttribute(76, "name", "key");
            __builder.AddAttribute(77, "value", "d");
            __builder.AddAttribute(78, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                    UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "checked", 
#nullable restore
#line 42 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                                         IsDChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(80, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.AddMarkupContent(82, "<label for=\"d\" b-xknbcvhci3>D. </label>\r\n                ");
            __builder.OpenElement(83, "textarea");
            __builder.AddAttribute(84, "id", "d");
            __builder.AddAttribute(85, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                         choices['d']

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => choices['d'] = __value, choices['d']));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(87, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "line");
            __builder.AddAttribute(91, "b-xknbcvhci3");
            __builder.OpenElement(92, "input");
            __builder.AddAttribute(93, "type", "radio");
            __builder.AddAttribute(94, "name", "key");
            __builder.AddAttribute(95, "value", "e");
            __builder.AddAttribute(96, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                    UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "checked", 
#nullable restore
#line 47 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                                         IsEChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(98, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.AddMarkupContent(100, "<label for=\"e\" b-xknbcvhci3>E. </label>\r\n                ");
            __builder.OpenElement(101, "textarea");
            __builder.AddAttribute(102, "id", "e");
            __builder.AddAttribute(103, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                         choices['e']

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => choices['e'] = __value, choices['e']));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(105, "b-xknbcvhci3");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.OpenComponent<global::MudBlazor.MudButton>(107);
            __builder.AddAttribute(108, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 52 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(109, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 52 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                        Icons.Material.Filled.Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(110, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 52 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                                          Size.Large

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(111, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                                                               Save

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(112, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 52 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
                                                                                                                              $"background-color:{Colors.Blue.Default}; color:{Colors.Grey.Lighten5}; border-radius: 2px;"

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(113, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(114, "Save Question");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\MultipleChoiceQuestionForm.razor"
       
    [Parameter]
    public int TestId { get; set; }

    private Question NewQuestion = new Question();

    private bool IsLoading = false;

    private Dictionary<char, string> choices = new Dictionary<char, string>();
    private MultipleChoiceQuestionDetail QuestionDetail = new MultipleChoiceQuestionDetail();
    private char key;
    private bool IsAChecked => key == 'a';
    private bool IsBChecked => key == 'b';
    private bool IsCChecked => key == 'c';
    private bool IsDChecked => key == 'd';
    private bool IsEChecked => key == 'e';

    protected override void OnInitialized()
    {
        ResetFormValues();

        base.OnInitialized();
    }

    private void UpdateKey(ChangeEventArgs e) => key = e.Value.ToString()[0];

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

        NewQuestion.Id = 0;
        QuestionDetail.Choices = choices;
        QuestionDetail.Key = key;
        NewQuestion.Details = QuestionDetail.ToJSONString();
        NewQuestion.Test = await testService.Get(TestId);
        NewQuestion.QuestionType = await questionTypeService.Get("Multiple Choice");

        if (await questionService.AddOrUpdate(NewQuestion))
        {
            await js.InvokeVoidAsync("alert", "Question Added Successfully");

            ResetFormValues();
        }
        else await js.InvokeVoidAsync("alert", "Couldn't Save Question");

        IsLoading = false;
        await Task.Delay(1);
    }

    private async Task<bool> AreFormValuesValid()
    {
        if (NewQuestion.Title == null || NewQuestion.Title == "")
        {
            await js.InvokeVoidAsync("alert", "Question title must be filled");
            return false;
        }

        if (choices['a'] == "" || choices['b'] == "" || choices['c'] == "" || choices['d'] == "" || choices['e'] == "")
        {
            await js.InvokeVoidAsync("alert", "All choices must be filled");
            return false;
        }

        if (key == '\0')
        {
            await js.InvokeVoidAsync("alert", "Question answer key must be chosen");
            return false;
        }

        return true;
    }

    private void ResetFormValues()
    {
        NewQuestion = new Question();

        choices['a'] = "";
        choices['b'] = "";
        choices['c'] = "";
        choices['d'] = "";
        choices['e'] = "";
        key = '\0';
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
