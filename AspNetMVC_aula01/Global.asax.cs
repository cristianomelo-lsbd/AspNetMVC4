using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AspNetMVC_aula01
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // includes two helpers methods 
            // one for client-side validation and another obstrusive validation javascript
            HtmlHelper.ClientValidationEnabled = true;
            // All you starter here are going to being validated 
            // otherwise, if you hadn't put it the method below, you must be declare in every page
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true; 
      
        }
    }
}
