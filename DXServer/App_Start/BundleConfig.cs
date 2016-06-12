using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace DXServer
{

    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {

            var scriptBundle = new ScriptBundle("~/Scripts/bundle");
            var styleBundle = new StyleBundle("~/Content/bundle");

            // CLDR scripts
            scriptBundle
                .Include("~/Scripts/cldr.js")
                .Include("~/Scripts/cldr/event.js")
                .Include("~/Scripts/cldr/supplemental.js")
                .Include("~/Scripts/cldr/unresolved.js");

            // Globalize 1.x
            scriptBundle
                .Include("~/Scripts/globalize.js")
                .Include("~/Scripts/globalize/number.js")
                .Include("~/Scripts/globalize/currency.js")
                .Include("~/Scripts/globalize/date.js")
                .Include("~/Scripts/globalize/message.js");

            // jQuery
            scriptBundle
                .Include("~/Scripts/jquery-2.2.3.js");

            // Bootstrap
            scriptBundle
                .Include("~/Scripts/bootstrap.js");

            // DevExtreme + extensions
            scriptBundle
                .Include("~/Scripts/dx.all.js")
                .Include("~/Scripts/aspnet/dx.aspnet.data.js")
                .Include("~/Scripts/aspnet/dx.aspnet.mvc.js");

            // Underscore.js, for templates
            scriptBundle
                .Include("~/Scripts/underscore.js");

            // dxVectorMap data (http://js.devexpress.com/Documentation/Guide/Data_Visualization/VectorMap/Providing_Data/#Data_for_Areas)
            //scriptBundle
            //    .Include("~/Scripts/vectormap-data/africa.js")
            //    .Include("~/Scripts/vectormap-data/canada.js")
            //    .Include("~/Scripts/vectormap-data/eurasia.js")
            //    .Include("~/Scripts/vectormap-data/europe.js")
            //    .Include("~/Scripts/vectormap-data/usa.js")
            //    .Include("~/Scripts/vectormap-data/world.js");

            // JSZip for client side export
            //scriptBundle
            //    .Include("~/Scripts/jszip.js");


            // Bootstrap
            styleBundle
                .Include("~/Content/bootstrap.css");

            // DevExtreme
            // NOTE: see the available theme list here: http://js.devexpress.com/Documentation/Guide/Themes/Predefined_Themes/                    
            styleBundle
                .Include("~/Content/dx.common.css")
                .Include("~/Content/dx.light.css");

            // Custom site styles
            styleBundle
                .Include("~/Content/Site.css");


            bundles.Add(scriptBundle);
            bundles.Add(styleBundle);

#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}