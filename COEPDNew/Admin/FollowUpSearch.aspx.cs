using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class FollowUpSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CurrentUser.CurrentUserId == 10031)
        {
            ddlRasikaLocation.Visible = true;
            ddlLocation.Visible = false;
        }
        else
        {
            ddlRasikaLocation.Visible = false;
            ddlLocation.Visible = true;
        }



        if (!IsPostBack)
        {
            BindCourse();
            BindBatchType();
            BindLocation();
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
        ddlCourse.Items.Insert(0, new ListItem("-- Course --", "0"));
    }
    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- BatchType --", "0"));
    }
    protected void BindLocation()
    {
        if (CurrentUser.IsAdmin == true)
        {
            clsLocation obj = new clsLocation();
            ddlLocation.DataSource = obj.LoadAll(obj);
            ddlLocation.DataTextField = "Location";
            ddlLocation.DataValueField = "LocationId";
            ddlLocation.DataBind();
            ddlLocation.Items.Insert(0, new ListItem("-- All Locations --", "0"));
        }
        else
        {
            clsUserLocation obj = new clsUserLocation();
            obj.UserId = CurrentUser.CurrentUserId;
            ddlLocation.DataSource = obj.LoadAll(obj);
            ddlLocation.DataTextField = "Location";
            ddlLocation.DataValueField = "LocationId";
            ddlLocation.DataBind();
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsLead obj = new clsLead();
        if (ddlLocation.Items.Count > 0)
        {
           
            obj.CourseId = Convert.ToInt16(ddlCourse.SelectedValue);
            obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
            //obj1.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
            obj.keywords = txtSearch.Text.Trim();
            obj.AspirantName = txtAspirantName.Text;
            obj.PrimaryEmail = txtPrimaryEmail.Text;
            obj.PrimaryMobile = txtPrimaryMobile.Text;
        }

        if (txtFromDate.Text != "")
            {
                obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
            }
            else
            {
                obj.FromDate = null;
            }
            if (txtToDate.Text != "")
            {
                obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
            }
            else
            {
                obj.ToDate = null;
            }



            if (CurrentUser.CurrentUserId == 2817 || CurrentUser.CurrentUserId == 4468 || CurrentUser.CurrentUserId == 10031 || CurrentUser.CurrentUserId == 31688)  //if not venkat sir  , mahesh sir and Rasika,Praveena
            {

            }
            else
            {
               // ddlLocation.Visible = false;
                if (CurrentUser.CurrentUserId == 29217 || CurrentUser.CurrentUserId == 29943)
                {
                    int Employee = CurrentUser.CurrentUserId;
                    switch (Employee)
                    {
                        case 29217:
                            obj.LocationId = 1;
                            break;
                        case 29943:
                            obj.LocationId = 2;
                            break;
                    }
                }
                else
                {
                    obj.CreatedBy = CurrentUser.CurrentUserId;
                }
            }


            if (CurrentUser.CurrentUserId == 29217 || CurrentUser.CurrentUserId == 29943)
            {

            }
            else
            {
                if (ddlLocation.SelectedValue != "")
                    obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
            }

            if (CurrentUser.CurrentUserId == 10031) //rasika userId
            {
                if (ddlRasikaLocation.SelectedValue != "")
                    obj.LocationId = Convert.ToInt32(ddlRasikaLocation.SelectedValue);
            }

            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
    
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("FollowUp.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdRegister")
        {
            Response.Redirect("LeadRegister.aspx?ItemId=" + e.CommandArgument);
        }
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
    protected void ddlRasikaLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}