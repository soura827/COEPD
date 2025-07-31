using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class MyTaskSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void setGridView()
    {
        if (CurrentUser.IsAdmin == false)
        {
            //gv.Columns[0].Visible = false;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsTask obj = new clsTask();
        obj.AssignedEmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
        obj.keywords = txtSearch.Text;
        
        obj.TaskStatusId = Convert.ToInt32(ddlStatus.SelectedValue);
        List<clsTask> objList = obj.LoadAll(obj);
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
                if (objList[i].TaskStatusId == 1)
                {
                    objList[i].TaskStatus = "In Progress";
                    objList[i].color = "Red";
                }
                else if (objList[i].TaskStatusId == 2)
                {
                    objList[i].TaskStatus = "Completed";
                    objList[i].color = "Green";
                }
            }
        }
        gv.DataSource = objList;
        gv.DataBind();
        setGridView();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("MyTask.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsTask Item = new clsTask();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Task successfully removed";
            ErrorMessage.Visible = true;
        }
    }

    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}
