using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Enroll : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsEnroll Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsEnroll();
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit IoT Enroll";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtEmail.Text = Item.EmailId;
                    txtMobile.Text = Item.Mobile;
                    txtName.Text = Item.Name;
                }
            }
            else
            {

            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.EnrollId = Convert.ToInt16(ItemId);
        }
        Item.EmailId = txtEmail.Text;
        Item.Mobile = txtMobile.Text;
        Item.Name = txtName.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.CourseId = 0;
        Item.AddUpdate(Item);
        Response.Redirect("EnrollSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("EnrollSearch.aspx");
    }
}