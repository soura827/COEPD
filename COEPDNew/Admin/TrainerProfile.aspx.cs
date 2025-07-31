using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using BusinessLayer;
public partial class Admin_TrainerProfile : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsTrainerProfile Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsTrainerProfile();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Trainer Profile";
                Item = Item.Load(ItemId);
                txtname.Text = Item.Name;
                txtDescription.Text = Item.Description;
                ImgPhoto.Visible = true;
                ImgPhoto.ImageUrl = "~/UserDocs/TrainerProfile/" + Item.ImageThumbPath;
                hdnImagePath.Value = Item.ImageThumbPath;
                hdnImageThumbPath.Value = Item.Profile;
                if (Item.IsFeatured == true)
                {
                    chkFeatured.Checked = true;
                }
                else
                {
                    chkFeatured.Checked = false;
                }
            }
            else
            {
                lblTitle.Text = "Add Trainer Profile";
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.TrainerProfileId = Convert.ToInt16(ItemId);
        }

        Item.Name = Convert.ToString(txtname.Text);
        Item.Description = Convert.ToString(txtDescription.Text);

        if (flUpload.FileName.Length > 0)
        {
            clsFileUpload objFile = new clsFileUpload();
            string strFilePath = objFile.TrainerProfile(flUpload);

            Item.ImageThumbPath = "thumb_" + strFilePath;
            Item.Profile = strFilePath;
        }
        else
        {
            Item.ImageThumbPath = Convert.ToString(hdnImagePath.Value);
            Item.Profile = Convert.ToString(hdnImageThumbPath.Value);
        }
        if (chkFeatured.Checked == true)
        {
            Item.IsFeatured = true;
        }
        else
        {
            Item.IsFeatured = false;
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("TrainerProfileSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TrainerProfileSearch.aspx");
    }
}