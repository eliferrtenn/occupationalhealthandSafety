#pragma checksum "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6ca2971071103de277d7d1ca073c380537a32cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Makine_Ekipman_Index), @"mvc.1.0.view", @"/Views/Makine_Ekipman/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ca2971071103de277d7d1ca073c380537a32cb", @"/Views/Makine_Ekipman/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b979eed0774bf60a61861e228c260c32c44618e", @"/Views/_ViewImports.cshtml")]
    public class Views_Makine_Ekipman_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InformsISG.Entities.Dtos.Makine_EkipmanDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("menu-link px-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
  
    var currentrole = this.User.FindFirst(ClaimTypes.Role).Value;
    var tokenSet = antiforgery.GetAndStoreTokens(Context);
    ViewData["Title"] = "Index";
    int siraNo = 1;
    var TaliBirimList = (List<InformsISG.Entities.Dtos.Tali_BirimDTO>)ViewBag.TaliBirimList;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card shadow-sm\">\r\n    <div class=\"card-header\">\r\n        <h3 class=\"card-title\">MAKİNE EKİPMAN LİSTESİ</h3>\r\n        <div class=\"card-toolbar\">\r\n");
#nullable restore
#line 18 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
             if (currentrole.Equals("SuperAdmin") || currentrole.Equals("IsgUzman"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 733, "\"", 778, 1);
#nullable restore
#line 20 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
WriteAttributeValue("", 740, Url.Action("Create","Makine_Ekipman"), 740, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-hover-rotate-end\">YENİ MAKİNE EKİPMAN EKLE</a>\r\n");
#nullable restore
#line 21 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
            }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
   
    <div class=""card-body"">
        <table id=""tblBirim"" class=""table table-striped table-row-bordered gy-5 gs-7"">
            <thead>
                <tr>
                    <th>Sıra No</th>
                    <th>
                        ");
#nullable restore
#line 50 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Ekipman_Kodu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 53 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Firma_Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 56 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Periyodik_Kontrol_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 59 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tekrar_Periyodik_Kontrol_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tali_Birim_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 68 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(siraNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ekipman_Kodu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Firma_Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Periyodik_Kontrol_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tekrar_Periyodik_Kontrol_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 84 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                     foreach (var item2 in TaliBirimList)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                         if (item2.Id == item.Tali_Birim_Id)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
#nullable restore
#line 89 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item2.Tali_Birim_Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 91 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"





                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                     if (currentrole.Equals("SuperAdmin") || currentrole.Equals("IsgUzman"))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td style=""text-align:end"">
                            <button type=""button"" class=""btn btn-primary btn-sm dropdown-toggle""
                                    data-kt-menu-trigger=""click""
                                    data-kt-menu-placement=""bottom-start"">
                                İşlemler
                            </button>
                            <div class=""menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-bold fs-7 w-100px py-4""
                                 data-kt-menu=""true"">
                                <div class=""menu-item px-3"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6ca2971071103de277d7d1ca073c380537a32cb12959", async() => {
                WriteLiteral("\r\n                                        Düzenle\r\n                                    ");
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
#line 110 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"menu-item px-3\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6ca2971071103de277d7d1ca073c380537a32cb15456", async() => {
                WriteLiteral("\r\n                                        Detaylar\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"menu-item px-3\">\r\n                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 5990, "\"", 6022, 3);
            WriteAttributeValue("", 6000, "VeriSil(", 6000, 8, true);
#nullable restore
#line 120 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
WriteAttributeValue("", 6008, item.Id, 6008, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6016, ",this)", 6016, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"menu-link px-3\">\r\n                                        Sil\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n");
#nullable restore
#line 126 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 130 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                    siraNo++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"card-footer\">\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#tblBirim"").DataTable({
            ""pageLength"": 50,
            language: {
                ""sDecimal"": "","",
                ""sEmptyTable"": ""Tabloda herhangi bir veri mevcut değil"",
                 ""sInfo"": 'Toplam kayıttan _START_  - _END_ arasındaki kayıtlar gösteriliyor.' + ""Toplam ""+");
#nullable restore
#line 146 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                                                                                                      Write(ViewBag.Ekipman);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" + "" kayıt vardır."",
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
                    ""sSortDescending"": "": azalan sütun sıralamasını aktifleştir""
                },
                ""select"": {
                    ""rows"": {
                        ""_"": ""%d kayıt seçildi"",
                        ""1"": ""1 kayıt seçildi""
          ");
                WriteLiteral(@"          }
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


    <script type=""text/javascript"">
       function VeriSil(ID, obj) {
            var btn = $(obj);
            Swal.fire({
                title: 'SİLME İŞLEMİ',
                text: ""Silmek istediğinize emin misiniz?"",
                icon: 'question',
                showCancelButton: true,
                confirmButtonColor: '#50cd89',
                cancelBut");
                WriteLiteral(@"tonColor: '#f1416c',
                confirmButtonText: 'Evet Sil!',
                cancelButtonText: 'Hayır Silme!',
                showClass: {
                    popup: 'animate_animated animate_fadeInDown'
                },
                hideClass: {
                    popup: 'animate_animated animate_fadeOutUp'
                }
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        method: 'POST',
                        url: '");
#nullable restore
#line 211 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                         Write(Url.Action("Delete", "Makine_Ekipman"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        headers: {\'");
#nullable restore
#line 212 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                              Write(tokenSet.HeaderName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' : \'");
#nullable restore
#line 212 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\Index.cshtml"
                                                       Write(tokenSet.RequestToken);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'},
                        data: { id: ID }
                    }).done(function (d) {
                        const result = $.parseJSON(d);
                        if (result.ResultStatus == 0) {
                            Swal.fire({
                                title: 'SİLİNDİ',
                                icon: 'success',
                                text: `${result.Message}`,
                                showClass: {
                                    popup: 'animate_animated animate_fadeInDown'
                                },
                                hideClass: {
                                    popup: 'animate_animated animate_fadeOutUp'
                                }
                            });
                            btn.parent().parent().parent().parent().fadeOut(1000);
                        }
                    }).fail(function () {
                        Swal.fire({
                            title: 'HATALI İŞLEM',
                ");
                WriteLiteral(@"            text: ""Veri silinemedi"",
                            icon: 'error',
                            showClass: {
                                popup: 'animate_animated animate_fadeInDown'
                            },
                            hideClass: {
                                popup: 'animate_animated animate_fadeOutUp'
                            }
                        })
                    })
                }
            });
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAntiforgery antiforgery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InformsISG.Entities.Dtos.Makine_EkipmanDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
