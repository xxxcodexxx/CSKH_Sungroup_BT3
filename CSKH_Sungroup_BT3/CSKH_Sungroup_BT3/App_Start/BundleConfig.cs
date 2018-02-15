using System.Web;
using System.Web.Optimization;

namespace CSKH_Sungroup_BT3
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/AdminLTEjs").Include(
                      "~/Scripts/AdminLTE/adminlte.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/AngularJs").Include(
                      "~/Scripts/AngularJs/angular.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/chartjs.min.js").Include(
                "~/Scripts/ChartJS/Chart.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/script.js").Include(
                "~/Scripts/ChartJS/script.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css", "~/Content/AdminLTE/AdminLTE.min.css", "~/Content/font-awesome/css/font-awesome.min.css", "~/Content/Skins/skin-red-light.min.css"));
        }
    }
}
