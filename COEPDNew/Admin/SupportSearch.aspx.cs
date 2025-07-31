using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using BusinessLayer;
public partial class Admin_SupportSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    public string color;
    public int GlobalItemStatus;
    public int GlobalSupportType;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Support.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsSupport obj = new clsSupport();
        obj.keywords = txtSearch.Text;
        obj.PriorityId = Convert.ToInt32(ddlPriority.SelectedValue);
        obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        List<clsSupport> objList = obj.LoadAll(obj);
        if (objList != null)
        {
            for (int i = 0; i < objList.Count; i++)
            {
                if (objList[i].PriorityId == 1)
                {
                    objList[i].Priority = "High";
                    objList[i].color = "Red";
                }
                else if (objList[i].PriorityId == 2)
                {
                    objList[i].Priority = "Medium";
                    objList[i].color = "Orange";
                }
                else
                {
                    objList[i].Priority = "Low";
                    objList[i].color = "Green";
                }
            }
            for (int i = 0; i < objList.Count; i++)
            {
                if (objList[i].StatusId == 1)
                {
                    objList[i].Status = "In Progress";
                    objList[i].color = "Red";
                }
                else if (objList[i].StatusId == 2)
                {
                    objList[i].Status = "Completed";
                    objList[i].color = "Green";
                }
            }


        }
        gv.DataSource = objList;
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
 
            Response.Redirect("support.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsSupport Item = new clsSupport();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Support ticket successfully removed";
            ErrorMessage.Visible = true;

        }
    }



    protected void ddlPriority_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlPriority.SelectedIndex != 0)
        {
            BindData();
        }
        if (IsPostBack)
        {
            if (ddlPriority.SelectedIndex == 0)
            {
                BindData();
            }
        }
    }

    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList ddlStatus = (DropDownList)sender;
        GridViewRow gvRow = (GridViewRow)ddlStatus.NamingContainer;

        clsSupport Item = new clsSupport();
        Item.StatusId = Convert.ToInt16(ddlStatus.SelectedValue);
        Item.SupportId = Convert.ToInt32(gv.DataKeys[gvRow.RowIndex].Value.ToString());

        // GlobalItemStatus = Convert.ToInt16(ddlStatus.SelectedValue);
        //GlobalSupportType = Convert.ToInt32(gv.DataKeys[gvRow.RowIndex].Value.ToString());

        // ViewState["StatusId"] = GlobalItemStatus;
        // ViewState["SupportId"] = GlobalSupportType;

    
        if (Item.StatusId == 2)
        {
            Response.Write("<script>window.open('" + ddlStatus.SelectedValue + "');</script>");
            Item.IsDeleted = true;
        }
        Item.ModifiedBy = CurrentUser.CurrentName;
        Item.UpdateStatus(Item);

        BindData();


    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnStatus = (HiddenField)e.Row.FindControl("hdnStatusId");
                int StatusId = Convert.ToInt32(hdnStatus.Value);
                DropDownList ddlStatus = (DropDownList)e.Row.FindControl("ddlStatus");
                ddlStatus.SelectedValue = StatusId.ToString();
                if (ddlStatus.SelectedValue == "2")
                {

                    e.Row.Cells[0].Text = "";
                }
            }

        }
    }

    //protected void btn_Click(object sender, EventArgs e)
    //{

    //    clsSupport Item = new clsSupport();
    //    Item.SupportId = GlobalSupportType;
    //    GlobalItemStatus = (int)ViewState["StatusId"];
    //    GlobalSupportType = (int)ViewState["SupportId"];
    //    Item.StatusId = GlobalItemStatus;
    //    Item.SupportId = GlobalSupportType;
    //    if (GlobalItemStatus == 2)
    //    {
    //        Item.IsDeleted = true;
    //    }

    //    Item.UpdateStatus(Item);

    //    BindData();

    //}

}