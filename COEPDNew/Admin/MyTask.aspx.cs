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
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Task";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    lblText.Text = Item.Task;
                    
                    lblDescription.Text = Item.Description;
                    hdnEmpId.Value = Item.EmployeeId.ToString();
                    hdnPriorityId.Value = Item.PriorityId.ToString();
                    hdnId.Value = Item.TaskId.ToString();
                    BindData();
                    switch (Item.PriorityId)
                    {
                        case 1:
                            lblPriority.Text = "High";
                            
                            break;
                        case 2:
                            lblPriority.Text = "Medium";
                            break;
                        case 3:
                            lblPriority.Text = "Low";
                            break;
                    }
                   

                }
            }
        }
    }

    protected void btnProgress_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.TaskId = Convert.ToInt16(ItemId);
        }
        Item.AssignedEmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        Item.EmployeeId = Convert.ToInt32(hdnEmpId.Value);
        Item.Task = Convert.ToString(lblText.Text);
        Item.Description = Convert.ToString(lblDescription.Text);
        Item.PriorityId = Convert.ToInt32(hdnPriorityId.Value);
        Item.TaskStatusId = 1;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.ModifiedBy = Convert.ToString(CurrentUser.CurrentName);
        Item.AddUpdate(Item);

        Response.Redirect("MyTask.aspx?ItemId="+ItemId);
    }

    protected void btnComplete_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.TaskId = Convert.ToInt16(ItemId);
        }
        Item.AssignedEmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        Item.EmployeeId = Convert.ToInt32(hdnEmpId.Value);
        Item.Task = Convert.ToString(lblText.Text);
        Item.Description = Convert.ToString(lblDescription.Text);
        Item.PriorityId = Convert.ToInt32(hdnPriorityId.Value);
        Item.TaskStatusId = 2;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.ModifiedBy = Convert.ToString(CurrentUser.CurrentName);
        Item.AddUpdate(Item);
        Response.Redirect("MyTask.aspx?ItemId="+ItemId);
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyTaskSearch.aspx");
    }


    protected void rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnInserted = (HiddenField)item.FindControl("hdnInserted");
            int Insertedvalue = Convert.ToInt16(hdnInserted.Value);

            if (Insertedvalue==2)
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

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (txtNotes.Text.Length > 0)
        {
            clsTaskDescription Task = new clsTaskDescription();
            Task.AssignedEmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            Task.EmployeeId = Convert.ToInt32(hdnEmpId.Value);
            Task.Description = txtNotes.Text;
            Task.TaskId=Convert.ToInt32(ItemId);
            Task.CreatedBy = CurrentUser.CurrentUserId;
            Task.InsertedBy = 2;
            Task.AddUpdate(Task);
            txtNotes.Text = "";
            FormMessage.Text = "Your request is successfully sent.";
            FormMessage.Visible = true;
            Response.Redirect("MyTask.aspx?ItemId=" + ItemId);

        }
    }
    protected void BindData()
    {
        clsTaskDescription Task = new clsTaskDescription();
        Task.TaskId= Convert.ToInt16(hdnId.Value);
        Task.AssignedEmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        Task.EmployeeId = Convert.ToInt32(hdnEmpId.Value);
       // Task.AssignedEmployeeId = Convert.ToInt32(hdnEmpId.Value);
        //Task.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        rp.DataSource = Task.LoadAll(Task);
        rp.DataBind();
    }
}