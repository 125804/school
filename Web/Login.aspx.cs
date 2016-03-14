using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
namespace Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string usertype = DropDownList1.SelectedValue;
            string name = UserName.Text.Trim();
            string pwd = Password.Text.Trim();
            if (usertype == "1")//管理员
            {
                AdminBLL bll=new AdminBLL();
                Admin model = bll.GetModel(name,pwd);
                if (model != null)
                {
                    Response.Redirect("welcome.aspx");
                }
                else
                {
                    FailureText.Text = "Invalid username or password.";
                    ErrorMessage.Visible = true;
                }
            }
            else if (usertype == "2")//学生
            {
                /*
                studentBLL bll = new studentBLL();
                student model = bll.GetModel(name, pwd);
                if (model != null)
                {
                    Response.Redirect("welcome.aspx");
                }
                else
                {
                    FailureText.Text = "Invalid username or password.";
                    ErrorMessage.Visible = true;
                }
                */
            }
        }

     
    }
}