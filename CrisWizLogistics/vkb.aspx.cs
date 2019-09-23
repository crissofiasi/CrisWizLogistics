using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrisWizLogistics
{
    public partial class vkb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void KB_Click(object sender, EventArgs e)
        {
            CheckBox1.Checked = CheckBox1.Checked ? false : true;
            SiteMaster.keyb = CheckBox1.Checked ? 1 : 0;
            //Request.Cookies["VirtualKeyBoard"].Value = SiteMaster.keyb.ToString();
            HttpCookie myCookie = new HttpCookie("VirtualKeyBoard");
            myCookie.Value = SiteMaster.keyb.ToString();
            myCookie.Expires = DateTime.Now.AddDays(900d);
            Response.Cookies.Add(myCookie);
        }

        protected void CheckBox1_Init(object sender, EventArgs e)
        {

            CheckBox chk = (CheckBox)sender;
            chk.Checked = (SiteMaster.keyb != 0) ? true : false;
        }
    }
}