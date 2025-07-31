using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_UserExamReportSearch : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            BindLocation();
            BindTrainer();
            BindCategory();
            BindTopic();
            BindData();
        }
        BindData();
    }
    protected void BindData()
    {

        clsUserExamReport item = new clsUserExamReport();
        if (txtFromDate.Text != "")
        {
            item.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            item.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            item.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            item.ToDate = null;
        }
        item.Keywords = txtParticipant.Text;
        item.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        item.EmployeeId = Convert.ToInt16(ddlTrainer.SelectedValue);
        item.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
        item.TopicId = Convert.ToInt16(ddlTopic.SelectedValue);
        item.IsActive = true;
        //item.IsDeleted = false;
        gv.DataSource = item.LoadAll(item);
        gv.DataBind();




        if (rbActive.Checked == true)
        {

            if (txtFromDate.Text != "")
            {
                item.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
            }
            else
            {
                item.FromDate = null;
            }
            if (txtToDate.Text != "")
            {
                item.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
            }
            else
            {
                item.ToDate = null;
            }
            item.Keywords = txtParticipant.Text;
            item.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
            item.EmployeeId = Convert.ToInt16(ddlTrainer.SelectedValue);
            item.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
            item.TopicId = Convert.ToInt16(ddlTopic.SelectedValue);
            // item.keywords = txtSearch.Text;
            //item.RoleId = 2;
            item.IsActive = true;
            item.IsDeleted = false;
            gv.DataSource = item.LoadAll(item);
            gv.DataBind();
        }
        if (rbDeleted.Checked == true)
        {


            if (txtFromDate.Text != "")
            {
                item.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
            }
            else
            {
                item.FromDate = null;
            }
            if (txtToDate.Text != "")
            {
                item.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
            }
            else
            {
                item.ToDate = null;
            }
            item.Keywords = txtParticipant.Text;
            item.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
            item.EmployeeId = Convert.ToInt16(ddlTrainer.SelectedValue);
            item.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
            item.TopicId = Convert.ToInt16(ddlTopic.SelectedValue);


            item.IsActive = false;
            gv.DataSource = item.LoadAll(item);
            gv.DataBind();
        }


    }

    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("Search by Location", "0"));
    }

    protected void BindTrainer()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 2;
        ddlTrainer.DataSource = obj.LoadAll(obj);
        ddlTrainer.DataTextField = "Employee";
        ddlTrainer.DataValueField = "EmployeeId";
        ddlTrainer.DataBind();
        ddlTrainer.Items.Insert(0, new ListItem("Search by Trainer", "0"));
    }

    protected void BindCategory()
    {
        ddlCategory.Items.Clear();
        clsCategory obj = new clsCategory();
        ddlCategory.DataSource = obj.LoadAll(obj);
        ddlCategory.DataTextField = "Category";
        ddlCategory.DataValueField = "CategoryId";
        ddlCategory.DataBind();
        ddlCategory.Items.Insert(0, new ListItem("-- Select Category --", "0"));

    }

    protected void BindTopic()
    {
        ddlTopic.Items.Clear();
        if (ddlCategory.SelectedIndex > 0)
        {
            clsTopic obj = new clsTopic();
            obj.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
            ddlTopic.DataSource = obj.LoadAll(obj);
            ddlTopic.DataTextField = "Topic";
            ddlTopic.DataValueField = "TopicId";
            ddlTopic.DataBind();
        }
        ddlTopic.Items.Insert(0, new ListItem("-- Select Topic --", "0"));
        gv.DataBind();
    }


    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindTopic();
        BindData();
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
}