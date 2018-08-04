using System.Web.Optimization;

namespace ThemeEmbeding
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region Admin
            bundles.Add(new ScriptBundle("~/bundles/AdminJS").Include(
                "~/Scripts/angular-animate.min.js",
                "~/Scripts/angular-aria.min.js",
                "~/Scripts/angular-material.min.js",
                "~/Admin/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/Admin/bower_components/datatables.net/js/jquery.dataTables.min.js",
                "~/Admin/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js",
                "~/Admin/bower_components/fastclick/lib/fastclick.js",
                "~/Admin/js/adminlte.min.js",
                "~/Admin/js/demo.js"
                ));


            bundles.Add(new StyleBundle("~/Content/AdminCSS").Include(
                "~/Admin/bower_components/font-awesome/css/font-awesome.min.css",
                "~/Admin/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css",
                "~/Admin/bower_components/Ionicons/css/ionicons.min.css",
                "~/Admin/css/AdminLTE.min.css",
                "~/Admin/css/skins/_all-skins.min.css",
                "~/Content/angular-material.min.css"

                      ));
            #endregion

            #region Main
            bundles.Add(new ScriptBundle("~/bundles/MainJS").Include(
               "~/Main/lib/jquery/jquery.min.js",
               "~/Main/lib/jquery/jquery-migrate.min.js",
               "~/Main/lib/bootstrap/js/bootstrap.bundle.min.js",
               "~/Main/lib/easing/easing.min.js",
               "~/Main/lib/superfish/hoverIntent.js",
               "~/Main/lib/superfish/superfish.min.js",
               "~/Main/lib/wow/wow.min.js",
               "~/Main/lib/waypoints/waypoints.min.js",
               "~/Main/lib/counterup/counterup.min.js",
               "~/Main/lib/owlcarousel/owl.carousel.min.js",
               "~/Main/lib/isotope/isotope.pkgd.min.js",
               "~/Main/lib/lightbox/js/lightbox.min.js",
               "~/Main/lib/touchSwipe/jquery.touchSwipe.min.js",
               "~/Main/contactform/contactform.js",
               "~/Main/js/main.js"
               ));


            bundles.Add(new StyleBundle("~/Content/MainCSS").Include(
                "~/Main/lib/bootstrap/css/bootstrap.min.css",
                "~/Main/lib/font-awesome/css/font-awesome.min.css",
                "~/Main/lib/animate/animate.min.css",
                "~/Main/lib/ionicons/css/ionicons.min.css",
                "~/Main/lib/owlcarousel/assets/owl.carousel.min.css",
                "~/Main/lib/lightbox/css/lightbox.min.css",
                "~/Main/css/style.css"
                ));
            #endregion

            #region Account
            bundles.Add(new ScriptBundle("~/bundles/AccountJS").Include(
                "~/Admin/bower_components/jquery/dist/jquery.min.js",
                "~/Admin/bower_components/bootstrap/dist/js/bootstrap.min.js",
                "~/Admin/plugins/iCheck/icheck.min.js"

                ));


            bundles.Add(new StyleBundle("~/Content/AccountCSS").Include(
                                "~/Admin/bower_components/bootstrap/dist/css/bootstrap.min.css",
                                                "~/Admin/bower_components/font-awesome/css/font-awesome.min.css",
                "~/Admin/bower_components/Ionicons/css/ionicons.min.css",
                "~/Admin/css/AdminLTE.min.css",
                "~/Admin/plugins/iCheck/square/blue.css"

                ));
            #endregion

            #region Common


            bundles.Add(new ScriptBundle("~/bundles/Commonjquery").Include(
                        "~/Common/Scripts/jquery.min.js",
                        "~/Common/Scripts/bootstrap.min.js",
                        "~/Scripts/angular.min.js"
                        ));


            bundles.Add(new StyleBundle("~/Content/Commoncss").Include(
                        "~/Common/Css/bootstrap.min.css"
                      ));


            #endregion

            #region Shop

            bundles.Add(new ScriptBundle("~/bundles/ShopJS").Include(
                "~/Scripts/angular-animate.min.js",
                "~/Scripts/angular-aria.min.js",
                "~/Scripts/angular-material.min.js",
                "~/Shop/js/smoothscroll.js",
                "~/Shop/js/jquery.debouncedresize.js",
                "~/Shop/js/retina.min.js",
                "~/Shop/js/jquery.placeholder.js",
                "~/Shop/js/jquery.hoverIntent.min.js",
                "~/Shop/js/twitter/jquery.tweet.min.js",
                "~/Shop/js/jquery.flexslider-min.js",
                "~/Shop/js/owl.carousel.min.js",
                "~/Shop/js/jflickrfeed.min.js",
                "~/Shop/js/jquery.prettyPhoto.js",
                "~/Shop/js/jquery.nouislider.min.js",
                "~/Shop/js/colpick.js",
                "~/Shop/js/jquery.jscrollpane.min.js",
                "~/Shop/js/jquery.mousewheel.js",
                "~/Shop/js/main.js"
                ));


            bundles.Add(new StyleBundle("~/Content/ShopCSS").Include(
                "~/Shop/css/bootstrap.min.css",
                "~/Shop/css/font-awesome.min.css",
                "~/Shop/css/prettyPhoto.css",
                "~/Shop/css/colpick.css",
                "~/Shop/css/owl.carousel.css",
                "~/Shop/css/style.css",
                "~/Shop/css/responsive.css",
                "~/Shop/images/icons/icon.html",
                "~/Shop/images/icons/apple-icon-57x57.html",
                "~/Shop/images/icons/apple-icon-72x72.html"
                ));

            #endregion
        }
    }
}
