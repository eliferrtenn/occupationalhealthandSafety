#pragma checksum "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deec5fbe05453d3509c5d5f599f7e409ee322bc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Makine_Ekipman_BakimPlanlari), @"mvc.1.0.view", @"/Views/Makine_Ekipman/BakimPlanlari.cshtml")]
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
#line 2 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deec5fbe05453d3509c5d5f599f7e409ee322bc9", @"/Views/Makine_Ekipman/BakimPlanlari.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b979eed0774bf60a61861e228c260c32c44618e", @"/Views/_ViewImports.cshtml")]
    public class Views_Makine_Ekipman_BakimPlanlari : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InformsISG.Entities.Dtos.Makine_Ekipman_Bakim_PlanlariDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
  
    var tokenSet = antiforgery.GetAndStoreTokens(Context);
    ViewData["Title"] = "Index";
    int siraNo = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card shadow-sm\">\r\n    <div class=\"card-header\">\r\n        <h3 class=\"card-title\">MAKİNE EKİPMAN BAKIM LİSTESİ</h3>\r\n        <div class=\"card-toolbar\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 455, "\"", 500, 1);
#nullable restore
#line 14 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
WriteAttributeValue("", 462, Url.Action("Create","Makine_Ekipman"), 462, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success btn-hover-rotate-end"">YENİ MAKİNE EKİPMAN EKLE</a>
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
#line 23 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                   Write(Html.DisplayNameFor(model => model.Servis_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                   Write(Html.DisplayNameFor(model => model.Diger_Servis_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bakim_Tip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                   Write(Html.DisplayNameFor(model => model.Durum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th> Onay Durumu\r\n                    </th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                   Write(siraNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Servis_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Diger_Servis_Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 51 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                     if (item.Bakim_Tip == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Periyodik Planlı Bakım\r\n                        </td>\r\n");
#nullable restore
#line 56 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                    }
                    else if (item.Bakim_Tip == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Arıza Tamiri\r\n                        </td>\r\n");
#nullable restore
#line 62 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                    }
                    else if (item.Bakim_Tip == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Periyodik Kontrol\r\n                        </td>\r\n");
#nullable restore
#line 68 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                     if (item.Durum == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Uygun\r\n                        </td>\r\n");
#nullable restore
#line 74 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                    }
                    else if (item.Durum == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Kusurlu\r\n                        </td>\r\n");
#nullable restore
#line 80 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                    }
                    else if (item.Durum == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Ağır Kusurlu\r\n                        </td>\r\n");
#nullable restore
#line 86 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                     if (item.OnayIsgUzman == 1 && item.OnayBirimSorumlu==1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Onaylandı\r\n                        </td>\r\n");
#nullable restore
#line 92 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                    }
                    else if (item.OnayIsgUzman == 2 && item.OnayBirimSorumlu==2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            Reddedildi\r\n                        </td>\r\n");
#nullable restore
#line 98 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                           Beklemede\r\n                        </td>\r\n");
#nullable restore
#line 104 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    <td style=""text-align:end"">
                        <button type=""button"" class=""btn btn-primary btn-sm dropdown-toggle""
                                data-kt-menu-trigger=""click""
                                data-kt-menu-placement=""bottom-start"">
                            İşlemler
                        </button>
                        <div class=""menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-bold fs-7 w-100px py-4""
                             data-kt-menu=""true"">
                            <div class=""menu-item px-3"">
                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4356, "\"", 4388, 3);
            WriteAttributeValue("", 4366, "VeriSil(", 4366, 8, true);
#nullable restore
#line 116 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
WriteAttributeValue("", 4374, item.Id, 4374, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4382, ",this)", 4382, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"menu-link px-3\">\r\n                                    Sil\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 123 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
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
#line 139 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
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
#line 204 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                         Write(Url.Action("DeleteBakim", "Makine_Ekipman"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        headers: {\'");
#nullable restore
#line 205 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
                              Write(tokenSet.HeaderName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' : \'");
#nullable restore
#line 205 "C:\Users\Elif\Desktop\Projeler\InformsISG\InformsISG.WebApp\Views\Makine_Ekipman\BakimPlanlari.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InformsISG.Entities.Dtos.Makine_Ekipman_Bakim_PlanlariDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591