using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;

namespace WebApplication1
{

    public partial class registration : System.Web.UI.Page
    {
        public MyAdoHelperAccess myAdoHelperAccess = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private RegistrationForm registaration()
        {
            RegistrationForm registrationForm = new RegistrationForm();
            if ((Password.Text != "" && RePassword.Text != "") && (Password.Text == RePassword.Text))
            {
                registrationForm.Password = Password.Text;

                if (Approval.Text != "")
                {
                    registrationForm.Approval = Approval.Text;
                }
                if (FirstName.Text != "")
                {
                    registrationForm.FirstName = FirstName.Text;
                }
                if (LastName.Text != "")
                {
                    registrationForm.LastName = LastName.Text;
                }
                if (UserName.Text != "")
                {
                    registrationForm.UserName = UserName.Text;
                }
                if (Email.Text != "")
                {
                    registrationForm.Email = Email.Text;
                }
                if (DateOfbirth.SelectedDate.Date != DateTime.MinValue)
                {
                    registrationForm.DateOfBirth = DateOfbirth.SelectedDate.Date;
                }
                if (Female.Text != "")
                {
                    registrationForm.Gender = true;
                }
                if (Male.Text != "")
                {
                    registrationForm.Gender = false;
                }
                if (List.SelectedItem.Value != "")
                {
                    registrationForm.PickList = List.SelectedItem.Value;
                }
            }
            return registrationForm;

        }
        protected void RegisrationSubmit_Click(object sender, EventArgs e)
        {
            myAdoHelperAccess = new MyAdoHelperAccess();
            RegistrationForm registrationForm = registaration();
            var filename = string.Empty;
            if (registrationForm.Password == null)
            {
                Response.Redirect("registration.aspx");
            }
            var sqlCommand = "INSERT INTO tbl_users (UserFirstName, UserLastName, BirthdatDate, UserName,UserPss,UserEmail)" +
              "VALUES('" + registrationForm.FirstName.ToString() + "', '" + registrationForm.LastName.ToString() +
              "', '" + registrationForm.DateOfBirth.ToString() + "','" + "', '" + registrationForm.UserName.ToString() +
              "','" + registrationForm.Password.ToString() + "', '" + registrationForm.Email.ToString() + "')";
            myAdoHelperAccess.DoQuery(filename,sqlCommand);


        }
        protected void GetUsersById(object sender, EventArgs e)
        {
            var filename = string.Empty;
            myAdoHelperAccess = new MyAdoHelperAccess();
            if (List.Text !="")
            {
                var sqlCommand = "SELECT * From tbl_users WHERE ID =" + List.Text;
                DataTable userstbl =  myAdoHelperAccess.ExecuteDatatable(filename, sqlCommand);
                foreach (DataRow row in userstbl.Rows)
                {
                    UserName.Text = row["UserName"].ToString();
                    LastName.Text = row["LastName"].ToString();
                    FirstName.Text = row["FirstName"].ToString();
                    Email.Text = row["Email"].ToString();
                }
            }

        }
        protected void ResetButton_Click(object sender, EventArgs e)
        {
            if (Approval.Text != "")
            {
                Approval.Text = "";
            }
            if (FirstName.Text != "")
            {
                FirstName.Text = "";
            }
            if (LastName.Text != "")
            {
                LastName.Text = "";
            }
            if (UserName.Text != "")
            {
                UserName.Text = "";
            }
            if (Email.Text != "")
            {
                Email.Text = "";
            }
        }
    }
    partial class RegistrationForm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string PickList { get; set; }
        public string Password { get; internal set; }
        public string Email { get; internal set; }
        public bool Gender { get; internal set; }
        public string Approval { get; internal set; }

        public RegistrationForm() { }

        public RegistrationForm(string FirstName, string UserName, int pageCount, DateTime DateOfBirth, string PickList)
        {
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.DateOfBirth = DateOfBirth;
            this.LastName = LastName;
            this.PickList = PickList;
        }

    }
}
