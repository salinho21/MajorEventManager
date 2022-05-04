#pragma checksum "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae842df377e0a5e3b054b5f26b26823e445c4119"
// <auto-generated/>
#pragma warning disable 1591
namespace MEM2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using MEM2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\LI4\MEM2\MEM2\MEM2\_Imports.razor"
using MEM2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
using MEM2.Config;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
using MEM2.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
using MEM2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
using MEM2.Data.MEM2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : OwningComponentBase<EventoService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "button");
                __builder2.AddAttribute(3, "class", "btn btn-info");
                __builder2.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
                                                 ()=> toastService.ShowInfo("I'm an INFO message")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(5, "Info Toast");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "button");
                __builder2.AddAttribute(8, "class", "btn btn-success");
                __builder2.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
                                                    ()=> toastService.ShowSuccess("I'm a Success message")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(10, "Success Toast");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "button");
                __builder2.AddAttribute(13, "class", "btn btn-warning");
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
                                                    ()=> toastService.ShowWarning("I'm a Warning message")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(15, "Warning Toast");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "button");
                __builder2.AddAttribute(18, "class", "btn btn-danger");
                __builder2.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
                                                   ()=> toastService.ShowError("I'm a Error message")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(20, "Error Toast");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "F:\LI4\MEM2\MEM2\MEM2\Pages\Index.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    Boolean on;

    protected override async Task OnInitializedAsync()
    {

        var user = (await authenticationStateTask).User;
        // on = Service.ScheduleAction(user.Identity.Name).Result;


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MEM2.Services.IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591