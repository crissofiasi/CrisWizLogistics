using System;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;
namespace CrisWizLogistics
{
    public partial class Login : System.Web.UI.Page
    {
        public Login()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void User_Authenticate(object sender, AuthenticateEventArgs e)
        {
            System.Web.UI.WebControls.Login login = sender as System.Web.UI.WebControls.Login;
            string str = "";
            login.UserName = "terminal1";
            
//            object obj = (new ProceduresAdapter()).ValidateUser(login.UserName, login.Password, ref str);
            object obj = (new ProceduresAdapter()).ValidateUser(login.UserName, "1", ref str);

            object obj1 = obj;
            if (obj == null)
            {
                login.FailureText = "Utilizator sau parola gresita!";
                return;
            }
            this.Session["UserId"] = obj1;
            FormsAuthentication.RedirectFromLoginPage(str, false);
        }



    }
}