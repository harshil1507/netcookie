using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie ck = new HttpCookie("cookie_name");
            ck.Value = "This is the value of the cookie";
            Response.Cookies.Add(ck);
            var t = Response.Cookies["cookie_name"].Value;
            Label1.Text = t;
        }
    }
}