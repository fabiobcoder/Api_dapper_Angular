#pragma checksum "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b5ecd6bdc15192cca5a7ebc6426ea368d3c729b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Deseja deletar este produto com Id :");
            __builder.OpenElement(2, "b");
            __builder.AddContent(3, " ");
#nullable restore
#line 5 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor"
__builder.AddContent(4, id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddMarkupContent(14, "<td>Nome</td>\r\n            ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 11 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor"
__builder.AddContent(16, produto.Nome);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.AddMarkupContent(21, "<td>Descrição</td>\r\n            ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 15 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor"
__builder.AddContent(23, produto.Descricao);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.AddMarkupContent(28, "<td>Estoque</td>\r\n            ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 19 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor"
__builder.AddContent(30, produto.Estoque);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<td>Preço</td>\r\n            ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 23 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor"
__builder.AddContent(37, produto.Preco);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "tr");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.AddMarkupContent(42, "<td>Imagem</td>\r\n            ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 27 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor"
__builder.AddContent(44, produto.Imagem);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "value", "Deleta");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor"
                                                       Deleta

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "value", "Cancela");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\source\repos\BlazorProdutos\BlazorProdutos\BlazorProdutos\Pages\DeletaProduto.razor"
                                                        Cancela

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "class", "btn");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
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
