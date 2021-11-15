#pragma checksum "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "939fea3ae445d01bbc6c86f7dbc02e066700ceeb"
// <auto-generated/>
#pragma warning disable 1591
namespace Frontend_Project.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Frontend_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Frontend_Project.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/Pages/Index.razor"
using Frontend_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/Pages/Index.razor"
using Frontend_Project.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"map\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/Pages/Index.razor"
       

    private MarkerServices _markerServices = new MarkerServices();
    private readonly string API_KEY = "AIzaSyDjR5XsFSEoovZF9e7wiIJQVhiKY0ctRyc";
    private Marker[] _markers { get; set; }

    protected override async Task OnInitializedAsync()
    {
        _markers = await _markerServices.GetMarkers();
    }
    
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        bool mapDidLoad = await js.InvokeAsync<bool>("createMap", API_KEY, _markers);
    }

    // API KEY:
    // AIzaSyDjR5XsFSEoovZF9e7wiIJQVhiKY0ctRyc

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
