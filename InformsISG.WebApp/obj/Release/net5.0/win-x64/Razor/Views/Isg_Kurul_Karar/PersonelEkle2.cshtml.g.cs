#pragma checksum "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c2a6a99876fa42d18be8b9c3b1e8ebc1f7cf11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Isg_Kurul_Karar_PersonelEkle2), @"mvc.1.0.view", @"/Views/Isg_Kurul_Karar/PersonelEkle2.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\_ViewImports.cshtml"
using InformsISG.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\_ViewImports.cshtml"
using InformsISG.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c2a6a99876fa42d18be8b9c3b1e8ebc1f7cf11", @"/Views/Isg_Kurul_Karar/PersonelEkle2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b979eed0774bf60a61861e228c260c32c44618e", @"/Views/_ViewImports.cshtml")]
    public class Views_Isg_Kurul_Karar_PersonelEkle2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InformsISG.Entities.Dtos.Isg_Kurul_ElemanDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersonelCikar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
  
    ViewData["Title"] = "PersonelAta";
    var egitimTanimId = ViewBag.egitimTanimId;
    var talibirimId = ViewBag.Tali_Birim_Id;
    var personelId = ViewBag.Personel_Id;
    var deneme = ViewBag.deneme;
    var PersonelList = (List<InformsISG.Entities.Dtos.Personel_BilgiDTO>)ViewBag.PersonelList;
    int siraNo = 1;
    TempData["id"] = TempData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card shadow-sm\">\r\n    <div class=\"card-body\">\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 19 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
       Write(await Component.InvokeAsync("IsgKurulKararGetir", new { Id = egitimTanimId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <br /> <br /> <br /> <br />
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card shadow-sm"">
                    <div class=""card-body"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">TOPLANTIYA EKLENEN PERSONEL LİSTESİ</h3>
                        </div>
                        <table id=""tblPersonelBilgi"" class=""table table-striped table-row-bordered gy-5 gs-7"">
                            <thead>
                                <tr>
                                    <th>
                                        Ad Soyad
                                    </th>
                                    <th>
                                        Sicil No
                                    </th>
                                    <th>
                                        Tc No
                                    </th>
                                    <th>
       ");
            WriteLiteral("                                 Birim\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n");
#nullable restore
#line 47 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                             foreach (var item in Model)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                 if (item.Isg_Kurul_Karar_Id == egitimTanimId)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                     foreach (var item2 in PersonelList)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                         if (item.Personel_Id == item2.Id)
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tbody>\r\n\r\n                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 60 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                                   Write(item2.Ad_Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 63 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                                   Write(item2.Sicil_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 66 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                                   Write(item2.Tc_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 69 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                                   Write(item2.Tali_Birim_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4c2a6a99876fa42d18be8b9c3b1e8ebc1f7cf119276", async() => {
                WriteLiteral("\r\n                                                            Çıkar\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n                                            </tbody>\r\n");
#nullable restore
#line 79 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </table>


                        <br /> <br /> <br />
                        <div class=""card-header"">
                            <h3 class=""card-title"">TOPLANTIYA EKLENECEK PERSONEL LİSTESİ</h3>
                        </div>

                        <div>
                            ");
#nullable restore
#line 92 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Isg_Kurul_Karar\PersonelEkle2.cshtml"
                       Write(await Component.InvokeAsync("PersonelGetirKurul"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br /><br /><br />\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#tblBirim"").DataTable({
            ""pageLength"": 50,
            language: {
                ""sDecimal"": "","",
                ""sEmptyTable"": ""Tabloda herhangi bir veri mevcut değil"",
                ""sInfoEmpty"": ""Kayıt yok"",
                ""sInfoFiltered"": ""(MAX kayıt içerisinden bulunan)"",
                ""sInfoThousands"": ""."",
                ""sLengthMenu"": ""Sayfada MENU kayıt göster"",
                ""sLoadingRecords"": ""Yükleniyor..."",
                ""sProcessing"": ""İşleniyor..."",
                ""sSearch"": ""Ara:"",
                ""sZeroRecords"": ""Eşleşen kayıt bulunamadı"",
                ""oPaginate"": {
                    ""sFirst"": ""İlk"",
                    ""sLast"": ""Son"",
                    ""sNext"": ""Sonraki"",
                    ""sPrevious"": ""Önceki""
                },
                ""oAria"": {
                    ""sSortAscending"": "": artan sütun sıralamasını aktifleştir"",
                    ""sSortDescending"": "": azalan sütun sıralamasını aktifleş");
                WriteLiteral(@"tir""
                },
                ""select"": {
                    ""rows"": {
                        ""_"": ""%d kayıt seçildi"",
                        ""1"": ""1 kayıt seçildi""
                    }
                }
            },
            dom:
                ""<'row'"" +
                ""<'col-sm-6 d-flex align-items-center justify-conten-start'>"" +
                ""<'col-sm-6 d-flex align-items-center justify-content-end'f>"" +
                "">"" +

                ""<'table-responsive'tr>"" +

                ""<'row'"" +
                ""<'col-sm-12 col-md-5 d-flex align-items-center justify-content-center justify-content-md-start'i>"" +
                ""<'col-sm-12 col-md-7 d-flex align-items-center justify-content-center justify-content-md-end'p>"" +
                "">""

        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InformsISG.Entities.Dtos.Isg_Kurul_ElemanDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591