using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.WEBUI.Authentications
{
    public class MemberAuthentication: AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["Member"] != null )
            {
                return true;
            }
            else
            {

                string a = "You can not buy a ticket without signing up to our website.Please Sign Up first.";

                httpContext.Response.Redirect($"/Home/SignUpUser/{a}");
                return false;
            }
        }
    }
}