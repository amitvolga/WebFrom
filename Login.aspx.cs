using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    
    public partial class Login : System.Web.UI.Page
    {
        public MyAdoHelperAccess myAdoHelperAccess = null;
        public static string userName = string.Empty;
        public static int loginAttem = 1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginSubmit_Click(object sender, EventArgs e)
        {
            bool isExsist = false;
            var filename = string.Empty;
            myAdoHelperAccess = new MyAdoHelperAccess();
            if (UserName.Text != "" || Password.Text != "")
            {
                var sqlComm = "Select * From tbl_user where userName='" + UserName.Text + "' and password ='" + Password.Text + "'";

                    isExsist= myAdoHelperAccess.IsExist(filename, sqlComm);
                if (isExsist)
                {
                    loginAttem = 1;
                    Response.Redirect("HtmlPage2.html");
                }
                else
                {
                    if (userName == UserName.Text)
                    {
                        loginAttem++;
                    }
                    userName = UserName.Text;
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}