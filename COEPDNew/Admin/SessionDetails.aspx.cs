using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_SessionDetails : System.Web.UI.Page
{

    int ItemId = 0;
    clsSessionDetails Item = new clsSessionDetails();
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {

        
            Item = new clsSessionDetails();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit Session Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {


                  
                    txtSessionName.Text = Convert.ToString(Item.SessionName);
                   


                   



                }

            }

            else
            {
                lblTitle.Text = "Add Session Details";

            }
        }




    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsSessionDetails Item = new clsSessionDetails();


        if (ItemId > 0)
        {
            Item.SessionTypeId = Convert.ToInt32(ItemId);
        }

        Item.SessionName = Convert.ToString(txtSessionName.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;

        Item.AddUpdate(Item);
        
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {

            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SessionDetailsSearch.aspx");
    }
}