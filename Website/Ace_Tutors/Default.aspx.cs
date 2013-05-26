using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void btnClass_Click(object sender, EventArgs e) {
        Response.Redirect("AccessTutor/ClassList.aspx");
    }
    protected void btnEnrole_Click(object sender, EventArgs e) {
        Response.Redirect("AccessTutor/Register.aspx");
    }
    protected void btnTimeTable_Click(object sender, EventArgs e) {
        Response.Redirect("AccessTutor/Timetable.aspx");
    }
    protected void btnTutorInfo_Click(object sender, EventArgs e) {
        Response.Redirect("AccessStudent/TutorContact.aspx");
    }
    protected void btnTimeTableS_Click(object sender, EventArgs e) {
        Response.Redirect("AccessStudent/Timetable.aspx");
    }
}