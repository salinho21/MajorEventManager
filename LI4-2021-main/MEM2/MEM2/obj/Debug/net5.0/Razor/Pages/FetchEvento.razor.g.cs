#pragma checksum "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d8eb57abd6022db95f39583dafbc6fdc172119b"
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
#line 2 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
using MEM2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
using MEM2.Data.MEM2;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchEventos")]
    public partial class FetchEvento : OwningComponentBase<EventoService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1> Eventos </h1>");
#nullable restore
#line 9 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
 if (Eventos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "class", "search");
            __builder.AddAttribute(4, "placeholder", "Search..");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                                              SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(7, "span");
            __builder.AddAttribute(8, "class", "text-muted ml-5 ");
            __builder.AddMarkupContent(9, "\r\n        Showing ");
            __builder.AddContent(10, 
#nullable restore
#line 20 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                 filteredEventos.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " out of ");
            __builder.AddContent(12, 
#nullable restore
#line 20 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                               Eventos.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"

    foreach (var Evento in Eventos)
    {
        if (Categorias.Contains(Evento.Categoria)) { } else { Categorias.Add(Evento.Categoria); }
    }


#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "class", "RbtnMargin");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                  SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value");
            __builder.AddContent(19, "All");
            __builder.CloseElement();
#nullable restore
#line 32 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
     foreach (var Categoria in Categorias)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "class");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 34 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                 Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, 
#nullable restore
#line 34 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                             Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 35 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(24);
            __builder.AddAttribute(25, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 44 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
             if (on)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(26, "button");
                __builder2.AddAttribute(27, "class", "btn btn-outline-dark RbtnMargin ");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                                                           FollowListMK

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(29, "All");
                __builder2.CloseElement();
#nullable restore
#line 47 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(30, "button");
                __builder2.AddAttribute(31, "class", "btn btn-outline-dark RbtnMargin  ");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                                                            FollowListMK

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(33, "Followed");
                __builder2.CloseElement();
#nullable restore
#line 51 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 57 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"

    

    if (on) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "ul");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card-columns TopMargin");
#nullable restore
#line 63 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
         foreach (var Evento in filteredEventosSeguidos)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card bg-light mb-3");
            __builder.AddAttribute(39, "style", "height: 12rem;");
            __builder.AddMarkupContent(40, "<div class=\"card-header text-white bg-primary\">Event</div>\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "card-body");
            __builder.OpenElement(43, "h5");
            __builder.AddAttribute(44, "class", "card-title");
            __builder.AddContent(45, 
#nullable restore
#line 68 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                            Evento.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "href", "/EventoDetails/" + (
#nullable restore
#line 69 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                             Evento.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "class", "card-link");
            __builder.AddContent(50, "Link");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
     } else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "ul");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card-columns TopMargin");
#nullable restore
#line 77 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
         foreach (var Evento in filteredEventos)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card bg-light mb-3");
            __builder.AddAttribute(56, "style", "height: 12rem;");
            __builder.AddMarkupContent(57, "<div class=\"card-header text-white bg-primary\">Event</div>\r\n                  ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "card-body");
            __builder.OpenElement(60, "h5");
            __builder.AddAttribute(61, "class", "card-title");
            __builder.AddContent(62, 
#nullable restore
#line 82 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                               Evento.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                       ");
            __builder.OpenElement(64, "a");
            __builder.AddAttribute(65, "href", "/EventoDetails/" + (
#nullable restore
#line 83 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
                                                Evento.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "class", "card-link");
            __builder.AddContent(67, "Link");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
     }
    

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, @"<style>
    .RbtnMargin {
        margin-left: 20px;
    }

    .TopMargin {
        margin-top: 40px;
    }

    .search {
        width: 308.9999999999999px;
        height: 35.976653696498005px;
        font-family: Arial;
        font-size: 14.0px;
        font-weight: 400;
        color: #000000;
        background-color: #FFFFFF;
        border: 1px solid #C8C8C8;
        border-radius: 0px;
        padding-left: 5px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "F:\LI4\MEM2\MEM2\MEM2\Pages\FetchEvento.razor"
       

    private string Termo;

    // AuthenticationState is available as a CascadingParameter
    [CascadingParameter]
    private Task<AuthenticationState>
authenticationStateTask
    { get; set; }
    List<Evento> Eventos;
    protected override async Task OnInitializedAsync()
    {
        Eventos = await @Service.GetEventosAsync();
    }

    async Task SearchEventos()
    {
        Eventos = await Service.GetEventosAsyncFilter(Termo);

    }

    // Initialize SearchTerm to "" to prevent null's
    string SearchTerm { get; set; } = "";
    string SearchCategoria { get; set; } = "Categoria";
    string SearchSeguidos { get; set; } = "";


    // Imagine this was retrieved from an API, just hardcoding for demo purposes

    List<Evento> SeguidosEventos = new List<Evento>();

    List<Evento> filteredEventos => Eventos.Where(i => (i.Titulo.ToLower().Contains(SearchTerm.ToLower()) || i.Categoria.ToLower().Contains(SearchTerm.ToLower()))).ToList();

    List<string> Categorias = new List<string>();

    Boolean on = false;

    List<Evento> filteredEventosSeguidos => SeguidosEventos.Where(i => (i.Titulo.ToLower().Contains(SearchTerm.ToLower()) || i.Categoria.ToLower().Contains(SearchTerm.ToLower()))).ToList();

    protected async Task FollowListMK()
    {
        var user = (await authenticationStateTask).User;
        SeguidosEventos = await Service.GetListIdSeguido(user.Identity.Name);
        on = !on;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
