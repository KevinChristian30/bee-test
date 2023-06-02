// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\FileQuestionForm.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\FileQuestionForm.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\FileQuestionForm.razor"
using BeeTest.Models.QuestionDetail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\FileQuestionForm.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\FileQuestionForm.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\FileQuestionForm.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class FileQuestionForm : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionForms\FileQuestionForm.razor"
       
    [Parameter]
    public int TestId { get; set; }

    private bool IsLoading = false;

    private Question NewQuestion = new Question();
    private FileQuestionDetail QuestionDetail = new FileQuestionDetail();

    private object inputFileKey = new object();

    private async Task<bool> AreFormValuesValid()
    {
        if (NewQuestion.Title == null || NewQuestion.Title == "")
        {
            await js.InvokeVoidAsync("alert", "Question title must be filled");
            return false;
        }

        return true;
    }

    private async Task HandleFileChange(InputFileChangeEventArgs e)
    {
        if (!(await AreFormValuesValid()))
        {
            await ClearFile();
            return;
        }

        IsLoading = true;
        await Task.Delay(1);

        await using FileStream fs = new(e.ToString(), FileMode.Create);
        await e.File.OpenReadStream().CopyToAsync(fs);

        string fileName = Guid.NewGuid().ToString();
        string url = await js.InvokeAsync<string>(
                "uploadFileToFirebase",
                "questions",
                fileName,
                fs
            );

        if (url == "")
        {
            IsLoading = false;
            await ClearFile();

            return;
        }

        NewQuestion.Id = 0;
        QuestionDetail.fileURL = url;
        QuestionDetail.filePath = $"questions/{fileName}";
        NewQuestion.Details = QuestionDetail.ToJSONString();
        NewQuestion.Test = await testService.Get(TestId);
        NewQuestion.QuestionType = await questionTypeService.Get("File");

        if (await questionService.AddOrUpdate(NewQuestion))
        {
            await js.InvokeVoidAsync("alert", "Question Added Successfully");

            await ResetFormValues();
        }
        else await js.InvokeVoidAsync("alert", "Couldn't Save Question");

        IsLoading = false;
        await Task.Delay(1);
    }

    private async Task ClearFile() => inputFileKey = new object ();

    private async Task ResetFormValues()
    {
        NewQuestion.Title = "";
        await ClearFile();
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
