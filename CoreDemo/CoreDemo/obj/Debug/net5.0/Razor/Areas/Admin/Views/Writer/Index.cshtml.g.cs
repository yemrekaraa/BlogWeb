#pragma checksum "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "af5b708ca3c2f30e8b39299f0547ecfff7b1938ee9d984369ed0bae4f4dfd99f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"af5b708ca3c2f30e8b39299f0547ecfff7b1938ee9d984369ed0bae4f4dfd99f", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazar Ajax İşlemleri</h1>
<br />
<button type=""button"" id=""btngetlist"" class=""btn btn-outline-primary"">Yazar Listesi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-success"">Yazar Getir</button>
<button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info"">Yazar Ekle</button>
<button type=""button"" id=""btndeletewriter"" class=""btn btn-outline-danger"">Yazar Sil</button>
<button type=""button"" id=""btnupdatewriter"" class=""btn btn-outline-warning"">Yazar Güncelle</button>
<br />
<br />
<div id=""writerlist"">
    Buraya yazarlar gelecek
</div>
<div id=""writerget"">
   
</div>
<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazar ID Değerini Girin"" class=""fomr-control"" />
</div>
<br />

<div>
    <input type=""text"" class=""form-control"" id=""txtwriterid"" placeholder=""Eklenecek Yazar ID"" />
    <input type=""text"" class=""form-control"" id=""txtwritername"" placeholder=""Eklenecek Yazar Adı"" /> 
</div>
<br />
<div>
    <input type=""text"" class=""form-control"" id=");
            WriteLiteral("\"txtid\" placeholder=\"Silinecek Yazar ID\" />\r\n</div>\r\n<br />\r\n<input type=\"text\" id=\"txtid1\" class=\"form-control\" placeholder=\"Güncellenecek ID\" />\r\n<input type=\"text\" id=\"txtwritername1\" class=\"form-control\" placeholder=\"Güncellenecek İsim\" />\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/WriterList"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<table class= table table-bordered> <tr><th>Yazar ID </th> <th>Yazar Adı</th> </tr>"";
                    $.each(w, (index, value) => {
                        tablehtml += `<tr><td>${value.Id}</td> <td>${value.Name}</td></tr>`
                    });
                    tablehtml += ""</table>"";
                    $(""#writerlist"").html(tablehtml);
                }
            });
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#writerid"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
      ");
                WriteLiteral(@"          type: ""get"",
                url: ""/Admin/Writer/GetWriterByID/"",
                data: { writerid: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);

                    let getvalue = `<table class=table table-bordered > <tr><th>Yazar ID </th>
                                <th> Yazar Adı </th> </tr > <tr><td>${w.Id} </td> <td>${w.Name}</td > </tr></table >`;
                    $(""#writerget"").html(getvalue);
                }
            });

        });

        $(""#btnaddwriter"").click(function () {
            let writer = {
                Id: $(""#txtwriterid"").val(),
                Name: $(""#txtwritername"").val()
            };
            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/AddWriter/"",
                data: writer,
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    aler");
                WriteLiteral(@"t(""Yazar Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti"");
                }
            });
        });

        $(""#btndeletewriter"").click(x => {
            let id = $(""#txtid"").val();

            $.ajax({
                url: ""/Admin/Writer/DeleteWriter/"" + id,
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar Silme İşlemi Başarılı Bir Şekilde Gerçekleşti"");
                }
            });
        });

        $(""#btnupdatewriter"").click(function () {
            let writer = {
                Id: $(""#txtid1"").val(),
                Name: $(""#txtwritername1"").val(),
            };
            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/UpdateWriter/"",
                data: writer,
                success: function (funk) {
                    alert(""Güncelleme İşlemi Gerçkeleşti"");
               ");
                WriteLiteral(" }\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
