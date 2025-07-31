using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Task : System.Web.UI.Page
{

    CurrentUser CurrentUser = new CurrentUser();
    clsTask Item;
   
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsTask();
        if (!IsPostBack)
        {
            BindEmployee();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Task";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtTask.Text = Item.Task;
                    txtDescription.Text = Item.Description;
                    txtDescription.Enabled = false;
                    ddlPriority.SelectedValue = Item.PriorityId.ToString();
                    if (Item.FileUploadPath != "")
                    {
                        hplPhotoFile.Visible = true;
                        hplPhotoFile.NavigateUrl = "~/UserDocs/FileUpload/" + Item.FileUploadPath;
                    }

                    clsEmployee Obj = new clsEmployee();
                    Obj = Obj.Load(Item.AssignedEmployeeId);
                    ddlEmp.SelectedValue = Item.AssignedEmployeeId.ToString();
                    BindData();
                }
            }
            else
            {
                lblTitle.Text = "Add Task";
                //clsTaskDescription TaskDescription = new clsTaskDescription();
                //TaskDescription = TaskDescription.Load(3);
                //rp.DataSource = TaskDescription.Description;
                //rp.DataBind();
                 divMenterinputs.Visible = false;
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        if (ItemId > 0)
        {
            Item.TaskId = Convert.ToInt16(ItemId);
        }
        Item.UserId = Convert.ToInt16(CurrentUser.CurrentUserId);
        Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        Item.Task = Convert.ToString(txtTask.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.AssignedEmployeeId = Convert.ToInt32(ddlEmp.SelectedValue);
        Item.PriorityId = Convert.ToInt32(ddlPriority.SelectedValue);
        Item.ModifiedBy = Convert.ToString(CurrentUser.CurrentName);
        Item.TaskStatusId = 1;
        Item.CreatedBy = CurrentUser.CurrentUserId;


        if (flUpload.HasFile)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.TaskFileUpload(flUpload);
            Item.FileUploadPath = strFilePath;
        }




        Item.AddUpdate(Item);
        Response.Redirect("TaskSearch.aspx");
        
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Task.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TaskSearch.aspx");
    }

    protected void BindEmployee()
    {
        clsEmployeeMapped obj = new clsEmployeeMapped();
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        ddlEmp.DataSource = obj.LoadAll(obj);
        ddlEmp.DataTextField = "Employee";
        ddlEmp.DataValueField = "EmployeeId";
        ddlEmp.DataBind();
        ddlEmp.Items.Insert(0, new ListItem("-- Select Employee --", ""));

    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (txtChat.Text.Length > 0)
        {
            clsTaskDescription task = new clsTaskDescription();
            task.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            task.AssignedEmployeeId = Convert.ToInt32(ddlEmp.SelectedValue);
            task.Description = txtChat.Text;
            task.CreatedBy = CurrentUser.CurrentUserId;
            task.TaskId = Convert.ToInt32(ItemId);
            task.InsertedBy = 1;
            task.AddUpdate(task);
            //BindData();
            txtChat.Visible = true;
            txtChat.Text = "";
            FormMessage.Text = "Your request is successfully sent.";
            FormMessage.Visible = true;
            Response.Redirect("Task.aspx?ItemId="+ItemId);


        }
    }
    protected void BindData()
    {
        clsTaskDescription Item = new clsTaskDescription();
        //Item.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        Item.AssignedEmployeeId = Convert.ToInt32(ddlEmp.SelectedValue);
        //Item.Description = txtChat.Text;
        rp.DataSource = Item.LoadAll(Item);
        rp.DataBind();
    }

    protected void rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnInserted = (HiddenField)item.FindControl("hdnInserted");
            int Insertedvalue = Convert.ToInt16(hdnInserted.Value);

            if (Insertedvalue == 1)
            {
                Panel pnlIn = (Panel)item.FindControl("pnlIn");
                pnlIn.Visible = true;
                
            }
            else
            {
                Panel PnlOut = (Panel)item.FindControl("PnlOut");
                PnlOut.Visible = true;
            }
        }
    }
}