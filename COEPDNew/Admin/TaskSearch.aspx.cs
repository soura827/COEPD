using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class TaskSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    public string color;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindEmployee();
            BindDefault();
           // BindData();
        }
       
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Task.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindEmployee()
    {
        clsEmployeeMapped obj = new clsEmployeeMapped();
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- All Employees --", "0"));

    }
    //This Method is used to display Inprogress records defaultly.
    protected void BindDefault()
    {
        clsTask obj = new clsTask();
        obj.keywords = txtSearch.Text;
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        obj.AssignedEmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        obj.TaskStatusId = 1;
        obj.PriorityId = Convert.ToInt32(ddlPriority.SelectedValue);
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
                if (objList[i].StatusId == 1 || objList[i].StatusId == 3 || objList[i].StatusId == 4)
                {
                    objList[i].TaskStatus = "In Progress";
                    objList[i].color = "Red";
                }
                else if (objList[i].StatusId == 2)
                {
                    objList[i].TaskStatus = "Completed";
                    objList[i].color = "Green";
                }
            }


        }
        gv.DataSource = objList;
        gv.DataBind();

    }
    protected void BindData()
    {
        clsTask obj = new clsTask();
        obj.keywords = txtSearch.Text;
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        obj.AssignedEmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        obj.PriorityId = Convert.ToInt32(ddlPriority.SelectedValue);
        obj.TaskStatusId = Convert.ToInt32(ddlTaskStatus.SelectedValue);
        obj.StatusId = Convert.ToInt32(ddlStatusCheck.SelectedValue);
        
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
        
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Task.aspx?ItemId=" + e.CommandArgument);
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

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
       
    }

    protected void ddlTaskStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
        
    }
    protected void ddlStatusCheck_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        BindData();

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

        clsTask Item = new clsTask();
        Item.StatusId = Convert.ToInt16(ddlStatus.SelectedValue);
        
        Item.TaskId = Convert.ToInt32(gv.DataKeys[gvRow.RowIndex].Value.ToString());
        if (Item.StatusId == 1 || Item.StatusId==3 || Item.StatusId==4 || Item.StatusId==0)
        {
            Item.TaskStatusId = 1;           
        }
        else if (Item.StatusId == 2)
        {
            Item.TaskStatusId = 2;    
        }
       
       
        Item.UpdateStatus(Item);
        //BindData();
        BindDefault();
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnFileUpload = (HiddenField)e.Row.FindControl("hdnFileUpload");
                HyperLink hplflFileUpload = (HyperLink)e.Row.FindControl("hplflFileUpload");
             
                if (hdnFileUpload.Value == "")
                    hplflFileUpload.Visible = false;
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

}



