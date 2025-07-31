using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Certificate : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            clsParticipant obj = new clsParticipant();
            obj = obj.Load(CurrentUser.CurrentParticipantId);
            if (obj.CertificatePath.Length > 0)
            {
                divCertify.Visible = true;
            }
            else
            {
                divCertify.Visible = false;
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsParticipant obj = new clsParticipant();
        int ParticipantId = CurrentUser.CurrentParticipantId;
        obj = obj.Load(ParticipantId);
        if (obj.CertificatePath != "")
        {
            string FilePath = Server.MapPath("~/UserDocs/Participant/" + obj.CertificatePath);
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(FilePath));
            Response.WriteFile(FilePath);
        }
    }
}