using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantCertificationSearch : System.Web.UI.Page
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
            BindCourse();
            BindBatchType();
            BindLocation();
            BindTrainer();
            BindData();
        }
    }

    protected void BindCourse()
    {
        clsCourse obj = new clsCourse();
        ddlCourse.DataSource = obj.LoadAll(obj);
        ddlCourse.DataTextField = "Course";
        ddlCourse.DataValueField = "CourseId";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("-- Select Course --", "0"));
    }

    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- Select Batch --", "0"));

    }

    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location --", "0"));
    }

    protected void BindTrainer()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 2;
        ddlTrainer.DataSource = obj.LoadAll(obj);
        ddlTrainer.DataTextField = "Employee";
        ddlTrainer.DataValueField = "EmployeeId";
        ddlTrainer.DataBind();
        ddlTrainer.Items.Insert(0, new ListItem("-- All Employee --", "0"));
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Participant.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsParticipant obj = new clsParticipant();
        if (txtSearch.Text.Length > 0)
        {
            obj.keywords = txtSearch.Text;
        }
        obj.CourseId = Convert.ToInt16(ddlCourse.SelectedValue);
        obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        obj.EmployeeId = Convert.ToInt16(ddlTrainer.SelectedValue);

        gv.DataSource = obj.LoadAll_CertificationList(obj);
        gv.DataBind();
       
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Participant.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdRequest")
        {
            Response.Redirect("PlacementRequest.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsParticipant Item = new clsParticipant();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.DeleteCertificate(ItemId);
            BindData();
            ErrorMessage.Text = "Participant certification successfully removed";
            ErrorMessage.Visible = true;
        }
        
        else if (e.CommandName == "cmdDownload")
        {
            string FilePath = Server.MapPath("~/UserDocs/Participant/" + e.CommandArgument);
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(FilePath));
            Response.WriteFile(FilePath);


        }
    }


    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlBatchType_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlTrainer_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

}