using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Seed
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/content/inline.bundle.js")
                .IncludeDirectory("~/content", "inline.*")
                );

            bundles.Add(new ScriptBundle("~/content/polyfills.bundle.js")
               .IncludeDirectory("~/content", "polyfills.*")
               );
            bundles.Add(new ScriptBundle("~/content/vendor.bundle.js")
               .IncludeDirectory("~/content", "vendor.*")
               );
            bundles.Add(new ScriptBundle("~/content/main.bundle.js")
               .IncludeDirectory("~/content", "main.*")
               );
            bundles.Add(new StyleBundle("~/content/style.css")
                .IncludeDirectory("~/content", "*.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}