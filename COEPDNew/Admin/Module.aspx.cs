//This code behind page is used to Add and Update the Employee Modules . 

using System;
using System.Web.UI;
using BusinessLayer;

public partial class Module : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsModule Item;
    int ItemId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //when u click on edit the perticular Empolyee Moduleid value  set to ItemId.
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsModule();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Empolyee Module";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtModule.Text = Item.Module;
                }
            }
            else
            {
                lblTitle.Text = "Add Empolyee Module";
            }
        }
    }
    //When click on Save button This Event will fire and used to Save the employee module.
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        if (ItemId > 0)
        {
            Item.ModuleId = Convert.ToInt16(ItemId);
        }
        
        Item.LoadAll(Item);

        //foreach (string items in Item.Module)
        //{
            if (txtModule.Text == "ADMIN")
            {
                Response.Write("<script>alert('Module already Created')</script>");
                txtModule.Text = null;
            }

            else
            {
                Item.Module = Convert.ToString(txtModule.Text);
                Item.CreatedBy = CurrentUser.CurrentUserId;
                Item.AddUpdate(Item);
                if (ItemId > 0)
                {
                    FormMessage.Text = "Employee Module successfully updated";
                    FormMessage.Visible = true;
                    btnSubmit.Enabled = false;
                }
                else
                {
                    btnSubmit.Enabled = false;
                    FormMessage.Text = "Employee Module successfully created";
                    FormMessage.Visible = true;
                    txtModule.Text = null;
                }
            }
       // }

    }
 
    //This button click  event is not used now.
    //protected void btnAddNew_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("Module.aspx");
    //}

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModuleSearch.aspx");
    }
}