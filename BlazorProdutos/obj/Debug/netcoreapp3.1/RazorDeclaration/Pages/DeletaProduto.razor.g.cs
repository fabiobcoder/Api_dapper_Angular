// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProdutos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using BlazorProdutos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using BlazorProdutos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\_Imports.razor"
using BlazorProdutos.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletaproduto/{id:int}")]
    public partial class DeletaProduto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor"
       

    [Parameter]
    public int id { get; set; }

    Produto produto = new Produto();

    protected override async Task OnInitializedAsync()
    {
        produto = await produtoService.GetById(id);
    }

    protected async Task Deleta()
    {
        await produtoService.Delete(id);
        NavigationManager.NavigateTo("produtos");
    }

    void Cancela()
    {
        NavigationManager.NavigateTo("produtos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProdutoService produtoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
