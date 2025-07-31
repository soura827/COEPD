using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Web.UI;
using BusinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.IdentityModel.Protocols.WSTrust;
using Microsoft.SqlServer.Server;
using System.Globalization;
using System.Web.UI.WebControls;

public partial class Admin_Certificate : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCertificate Item;
    int ItemId = 0;
    int CountNo = 0;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCertificate();

        if (!IsPostBack)
        {

        }

    }

    protected void BindParticipant()
    {
        ddlParticipant.Items.Clear();
        clsParticipant obj = new clsParticipant();
        obj.keywords = txtSearch.Text;
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ReferenceNo";
        ddlParticipant.DataBind();


        if (ddlParticipant.SelectedItem != null)
            txtEditParticipantName.Text = ddlParticipant.SelectedItem.Text;

    }

    //protected void BindBatchDate()
    //{
    //    ddlBatchDate.Items.Clear();
    //    clsParticipant obj = new clsParticipant();
    //    obj.keywords = txtSearch.Text;
    //    ddlBatchDate.DataSource = obj.LoadAll(obj);
    //    ddlBatchDate.DataTextField = "StartDate";
    //    ddlBatchDate.DataValueField = "ReferenceNo";
    //    ddlBatchDate.DataBind();

    //}

    protected void BindParticipantId()
    {
        clsParticipant obj = new clsParticipant();
        obj.keywords = txtSearch.Text;
        ddlParticipantId.DataSource = obj.LoadAll(obj);
        ddlParticipantId.DataTextField = "ParticipantId";
        ddlParticipantId.DataValueField = "ReferenceNo";
        ddlParticipantId.DataBind();

    }

    protected void BindRefference()
    {
        ddlReferrenceNumber.Items.Clear();
        clsParticipant obj = new clsParticipant();
        obj.keywords = txtSearch.Text;
        ddlReferrenceNumber.DataSource = obj.LoadAll(obj);
        ddlReferrenceNumber.DataTextField = "ReferenceNo";
        ddlReferrenceNumber.DataValueField = "ReferenceNo";
        ddlReferrenceNumber.DataBind();

        if (ddlReferrenceNumber.SelectedItem != null)
        {
            txtCertificateID.Text = ddlReferrenceNumber.SelectedItem.Text;
        }

    }


    protected void btnSave_Click(object sender, EventArgs e)
    {



        //DateTime StartDate = Convert.ToDateTime(txtCourseStartDate.Text);
        //string CourseStartDate = StartDate.ToString("dd MMM yyyy");
        //DateTime EndDate = Convert.ToDateTime(txtCourseEndDate.Text);
        //string CourseEndDate = EndDate.ToString("dd MMM yyyy");

        //string CourseStartDate = (Convert.ToDateTime(txtCourseStartDate.Text)).ToString("dd MMM yyyy");
        //string CourseEndDate = (Convert.ToDateTime(txtCourseEndDate.Text)).ToString("dd MMM yyyy");




        string CourseStartDate = (txtCourseStartDate.Text).ToString();
        string CourseEndDate = (txtCourseEndDate.Text).ToString();

        string ParticipantName = txtEditParticipantName.Text.ToUpper();
        string path = Guid.NewGuid() + Path.GetExtension(flUpload.PostedFile.FileName);
        System.Drawing.Image image = System.Drawing.Image.FromStream(flUpload.PostedFile.InputStream);
        int width = image.Width;
        int height = image.Height;
        Bitmap bmp = new Bitmap(width, height);
        Graphics graphics = Graphics.FromImage((System.Drawing.Image)bmp);
        graphics.InterpolationMode = InterpolationMode.High;
        graphics.SmoothingMode = SmoothingMode.HighQuality;
        graphics.Clear(Color.Transparent);
        graphics.DrawImage(image, 0, 0, width, height);
        //Font font = new Font("Arial", 40, FontStyle.Bold);
        Font font = new Font("Arial", 25, FontStyle.Bold);
        Font font1 = new Font("Arial", 25);
        SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 0));

        graphics.DrawString(CourseStartDate.Trim(), font1, brush, 440, 860);
        graphics.DrawString(CourseEndDate.Trim(), font1, brush, 830, 860);
        graphics.DrawString(txtCertificateID.Text.Trim(), font1, brush, 810, 1020);

        //allining the text in  center
        StringFormat format = new StringFormat();
        format.Alignment = StringAlignment.Center;
        float offsetX = image.Width / 2;
        float offsetY = image.Height / 3;
        Matrix matrix = new Matrix();
        matrix.Translate(offsetX, offsetY);
        graphics.Transform = matrix;
        graphics.DrawString(ParticipantName.Trim(), font, brush, 0, 0, format);


        System.Drawing.Image newImage = (System.Drawing.Image)bmp;
        newImage.Save(Path.Combine(Server.MapPath("~/UserDocs/Participant/") + path));
        graphics.Dispose();


        Item.CertificatePath = path;
        Item.ParticipantId = Convert.ToInt32(ddlParticipantId.SelectedItem.Text);
        Item.CourseEndDate = Convert.ToString(txtCourseEndDate.Text);
        Item.CertificateNumber = Convert.ToString(txtCertificateID.Text);
        // Item.ContactHours = Convert.ToString(txtContactHours.Text);
        Item.AddUpdate(Item);


        //clearing the text box
        ddlParticipant.Items.Clear();
        //ddlBatchDate.Items.Clear();
        ddlParticipantId.Items.Clear();
        txtCourseEndDate.Text = "";
        //txtContactHours.Text = "";
        txtCertificateID.Text = "";
        btnSave.Enabled = false;

        //downloding the certificate
        if (Item.CertificatePath != "")
        {
            string FilePath = Server.MapPath("~/UserDocs/Participant/" + Item.CertificatePath);
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(FilePath));
            Response.WriteFile(FilePath);

        }


    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        if (txtSearch.Text != "")
        {

            BindParticipant();
            //BindBatchDate();
            BindParticipantId();
            BindRefference();



        }
        else
        {
            ddlParticipant.Items.Clear();
            //ddlBatchDate.Items.Clear();
            ddlParticipantId.Items.Clear();
            txtCourseEndDate.Text = "";
            txtCertificateID.Text = "";
            txtEditParticipantName.Text = "";
        }
    }
}

