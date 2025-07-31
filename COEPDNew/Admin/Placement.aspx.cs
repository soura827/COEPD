using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Placement : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsPlacement Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsPlacement();
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Recent BA Job market ";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtCompany.Text = Item.Company;
                    txtDescription.Text = Item.Description;
                    if(Item.IsFeatured == true)
                    {
                        chkFeatured.Checked = true;
                    }
                }
            }
            else
            {
                lblTitle.Text = "Add New Recent BA Job market ";
                chkFeatured.Checked = true;
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(ItemId > 0)
        {
            Item.PlacementId = ItemId;
        }
        Item.ParticipantId = 0;
        Item.Description = txtDescription.Text;
        Item.Company = txtCompany.Text;

        //if(flUpload.FileName.Length > 0)
        //{
        //    clsFileUpload Obj = new clsFileUpload();
        //    string strFile =  Obj.(flUpload);
        //    Item.ImagePath = strFile;
        //}

        if(chkFeatured.Checked == true)
        {
            Item.IsFeatured = true;
        }
        else
        {
            Item.IsFeatured = false;
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.IsActive = true;
        Item.AddUpdate(Item);
        Response.Redirect("PlacementSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlacementSearch.aspx");
    }
}