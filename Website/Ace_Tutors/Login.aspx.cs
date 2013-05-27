using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Data;
using System.Security.Cryptography;

public partial class AccessGeneral_Login : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if ((this.User.IsInRole("Student")) || (this.User.IsInRole("Tutor")) || (this.User.IsInRole("Admin"))) {
            LoginPanel.Visible = false;
        } else {
            LoginPanel.Visible = true;
        }
    }
    protected void LoginPanel_Authenticate(object sender, AuthenticateEventArgs e) {
        //code to authenticate user
        int userId = 0;
        System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
        byte[] buffer = encoder.GetBytes(LoginPanel.Password);
        SHA1 passwordSHA = new SHA1CryptoServiceProvider();
        string hash = BitConverter.ToString(passwordSHA.ComputeHash(buffer)).Replace("-", "");
        try {

            userId = int.Parse(LoginPanel.UserName);
            Student loggedin = Students.getAStudent(userId);

            if ((hash == loggedin.PassHash.ToUpper())) {
                e.Authenticated = true;
            }
        } catch (NullReferenceException exc) {
            System.Diagnostics.Trace.WriteLine(exc);
            Staff loggedin = StaffList.getAStaff(userId);
            if (hash == loggedin.PassHash.ToUpper()) {
                e.Authenticated = true;
            }
            Session.Add("UserName", userId);
        } catch (Exception exc) {
            System.Diagnostics.Trace.WriteLine(exc);
            e.Authenticated = false;
        }
    }
}