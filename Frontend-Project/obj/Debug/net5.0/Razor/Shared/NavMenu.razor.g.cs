#pragma checksum "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c04135518d30c35a90cee4000a09493ff69b16b4"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""pos-f-t"" b-vll9hd7ri0><div class=""collapse"" id=""navbarToggleExternalContent"" b-vll9hd7ri0><div class=""bg-dark p-4"" b-vll9hd7ri0><h5 class=""text-white h4"" b-vll9hd7ri0>Collapsed content</h5>
      <span class=""text-muted"" b-vll9hd7ri0>Toggleable via the navbar brand.</span></div>
    <div class=""bg-dark p-4"" b-vll9hd7ri0><h5 class=""text-white h4"" b-vll9hd7ri0>Collapsed content</h5>
      <span class=""text-muted"" b-vll9hd7ri0>Toggleable via the navbar brand.</span></div></div>
  <nav class=""navbar navbar-dark bg-dark"" b-vll9hd7ri0><button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarToggleExternalContent"" aria-controls=""navbarToggleExternalContent"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-vll9hd7ri0><span class=""navbar-toggler-icon"" b-vll9hd7ri0></span></button></nav></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "/Users/oscarotterstad/code/c#eksamen/ChristiansOeFrontend/Frontend-Project/Shared/NavMenu.razor"
        
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
