#pragma checksum "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74161769d0721f55a918b977a79a6df2e36a7bb5"
// <auto-generated/>
#pragma warning disable 1591
namespace Frontend_Project.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-kpgbg4naec");
            __builder.OpenComponent<Frontend_Project.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "main");
            __builder.AddAttribute(7, "b-kpgbg4naec");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "content");
            __builder.AddAttribute(10, "b-kpgbg4naec");
            __builder.AddContent(11, 
#nullable restore
#line 7 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
