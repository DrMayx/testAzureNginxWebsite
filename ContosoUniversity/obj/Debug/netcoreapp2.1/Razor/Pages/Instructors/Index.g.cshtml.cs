#pragma checksum "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17c096a577f50f41ff7a3b764ceab8350402732e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoUniversity.Pages.Instructors.Pages_Instructors_Index), @"mvc.1.0.razor-page", @"/Pages/Instructors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Instructors/Index.cshtml", typeof(ContosoUniversity.Pages.Instructors.Pages_Instructors_Index), @"{id:int?}")]
namespace ContosoUniversity.Pages.Instructors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17c096a577f50f41ff7a3b764ceab8350402732e", @"/Pages/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c0473ebe7d620ab1ae06d83bc5bc87bf314407", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Instructors_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
  
    ViewData["Title"] = "Instructors";

#line default
#line hidden
            BeginContext(123, 363, true);
            WriteLiteral(@"<script>
    function ChangeColor(tableRow, highlight) {
        if (highlight) {
            tableRow.style.backgroundColor = '#dff0d8';
        } else {
            tableRow.style.backgroundColor = 'transparent';
        }
    }

    function NavigateTo(url) {
        document.location.href = url;
    }
</script>
<h2>Instructors</h2>

<p>
    ");
            EndContext();
            BeginContext(486, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5e83d2efcd460480953538a1e2c349", async() => {
                BeginContext(507, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(521, 279, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Last Name</th>
            <th>First Name</th>
            <th>Hire Date</th>
            <th>Office</th>
            <th>Courses</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 37 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
         foreach (var item in Model.Instructor.Instructors)
        {
            string selectedRow = "";
            if (item.ID == Model.InstructorID)
            {
                selectedRow = "success";
            }


#line default
#line hidden
            BeginContext(1032, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1047, "\"", 1067, 1);
#line 45 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
WriteAttributeValue("", 1055, selectedRow, 1055, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1068, 76, true);
            WriteLiteral(" onmouseover=\"ChangeColor(this, true)\" onmouseout=\"ChangeColor(this, false)\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1144, "\"", 1189, 3);
            WriteAttributeValue("", 1154, "NavigateTo(\'/Instructors/", 1154, 25, true);
#line 45 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
WriteAttributeValue("", 1179, item.ID, 1179, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1187, "\')", 1187, 2, true);
            EndWriteAttribute();
            BeginContext(1190, 22, true);
            WriteLiteral(">\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1212, "\"", 1238, 2);
            WriteAttributeValue("", 1217, "instructorLN_", 1217, 13, true);
#line 46 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
WriteAttributeValue("", 1230, item.ID, 1230, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1239, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(1263, 43, false);
#line 47 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 44, true);
            WriteLiteral("\r\n                </td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1350, "\"", 1376, 2);
            WriteAttributeValue("", 1355, "instructorFN_", 1355, 13, true);
#line 49 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
WriteAttributeValue("", 1368, item.ID, 1368, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1377, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(1401, 47, false);
#line 50 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1516, 43, false);
#line 53 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 56 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                     if (item.OfficeAssignment != null)
                    {
                        

#line default
#line hidden
            BeginContext(1711, 30, false);
#line 58 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                   Write(item.OfficeAssignment.Location);

#line default
#line hidden
            EndContext();
#line 58 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                                                       
                    }

#line default
#line hidden
            BeginContext(1766, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 62 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                     foreach (var course in item.CourseAssignments)
                    {
                        

#line default
#line hidden
            BeginContext(1928, 22, false);
#line 64 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                   Write(course.Course.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(1950, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1953, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(1956, 19, false);
#line 64 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                                               Write(course.Course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1975, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 65 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2007, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2074, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28aa03a4da9a4bf99dc101293671f18c", async() => {
                BeginContext(2119, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2127, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2151, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3846f2805c54a5b8b7750b61b5a551a", async() => {
                BeginContext(2199, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2210, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2234, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bdbcb17b2d0446d8f8b5e18135df6a3", async() => {
                BeginContext(2281, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2291, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 74 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2346, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 78 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
 if (Model.Instructor.Courses != null)
{

#line default
#line hidden
            BeginContext(2415, 26, true);
            WriteLiteral("    <h3>Courses Taught by ");
            EndContext();
            BeginContext(2442, 20, false);
#line 80 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                     Write(Model.InstructorName);

#line default
#line hidden
            EndContext();
            BeginContext(2462, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(2471, 148, true);
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>Number</th>\r\n            <th>Title</th>\r\n            <th>Department</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 89 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
         foreach (var item in Model.Instructor.Courses)
        {
            string selectedRow = "";
            if (item.CourseID == Model.CourseID)
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(2847, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2862, "\"", 2882, 1);
#line 96 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
WriteAttributeValue("", 2870, selectedRow, 2870, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2883, 76, true);
            WriteLiteral(" onmouseover=\"ChangeColor(this, true)\" onmouseout=\"ChangeColor(this, false)\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2959, "\"", 3007, 3);
            WriteAttributeValue("", 2969, "NavigateTo(\'?courseID=", 2969, 22, true);
#line 96 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
WriteAttributeValue("", 2991, item.CourseID, 2991, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3005, "\')", 3005, 2, true);
            EndWriteAttribute();
            BeginContext(3008, 47, true);
            WriteLiteral(">\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3056, 13, false);
#line 99 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
               Write(item.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(3069, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3137, 10, false);
#line 102 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3147, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3215, 20, false);
#line 105 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
               Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3235, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 108 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3290, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 111 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3309, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 113 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
 if (Model.Instructor.Enrollments != null)
{

#line default
#line hidden
            BeginContext(3358, 29, true);
            WriteLiteral("    <h3>Students Enrolled in ");
            EndContext();
            BeginContext(3388, 16, false);
#line 115 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
                        Write(Model.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(3404, 118, true);
            WriteLiteral("</h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Grade</th>\r\n        </tr>\r\n");
            EndContext();
#line 121 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
         foreach (var item in Model.Instructor.Enrollments)
        {

#line default
#line hidden
            BeginContext(3594, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3655, 21, false);
#line 125 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
               Write(item.Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3676, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3744, 40, false);
#line 128 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(3784, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 131 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3839, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 133 "D:\CSharpStudy\ContosoUniversitySolution\ContosoUniversity\Pages\Instructors\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Pages.Instructors.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.Instructors.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.Instructors.IndexModel>)PageContext?.ViewData;
        public ContosoUniversity.Pages.Instructors.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
