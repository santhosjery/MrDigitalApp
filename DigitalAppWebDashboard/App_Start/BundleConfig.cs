using System.Web;
using System.Web.Optimization;

namespace DigitalAppWebDashboard
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/scripts/cssfiles").Include("~/Scripts/css/bootstrap.css",
                       "~/Scripts/css/perfectscrollbar.css",
                       "~/Scripts/css/floating-labels.css",
                       "~/Scripts/css/tempusdominus-bootstrap-4.css",
                       "~/Scripts/css/dataTables.bootstrap4.css",
                       "~/Scripts/css/select2.css",
                       "~/Scripts/css/flaticon.css",
                       "~/Scripts/css/style.css"));

            bundles.Add(new ScriptBundle("~/scripts/jsjqueryunobtrusive").Include("~/Scripts/jquery.unobtrusive-ajax.js"));
            bundles.Add(new ScriptBundle("~/scripts/jsjquery").Include("~/Scripts/js/jquery-3.1.0.js"));

            bundles.Add(new ScriptBundle("~/scripts/jsfiles").Include("~/Scripts/js/popper.js",
                       "~/Scripts/js/bootstrap.js",
                       "~/Scripts/js/moment.js",
                       "~/Scripts/js/tempusdominus-bootstrap-4.js",
                       "~/Scripts/js/perfect-scrollbar.jquery.js",
                       "~/Scripts/js/jquery.dataTables.js",
                       "~/Scripts/js/dataTables.bootstrap4.js",
                       "~/Scripts/js/select2.js",
                       "~/Scripts/js/main.js"));

            bundles.Add(new StyleBundle("~/scripts/csslogin").Include("~/Scripts/css/login.css"));

            bundles.Add(new ScriptBundle("~/scripts/jsmain").Include("~/Scripts/js/main.js"));
            /*bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));*/

            /*
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
             */
        }
    }
}