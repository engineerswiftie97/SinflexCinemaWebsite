using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.WEBUI.Authentications
{
    public class EmployeeAuthentication:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["Executive"] != null || httpContext.Session["BoxOffice"] != null)
            {
                return true;
            }
            else
            {

                string a = "You don't have any permisson for this operation!";

                httpContext.Response.Redirect($"/Home/Login/{a}");
                return false;
            }
        }

    }
}