using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_Gallery : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsGallery Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsGallery();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Gallery Image";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtName.Text = Item.Name;                    
                    ImgPhoto.Visible = true;
                    ImgPhoto.ImageUrl = "~/UserDocs/Gallery/" + Item.ImageThumbPath;
                    hdnImagePath.Value = Item.ImageThumbPath;
                    hdnImageThumbPath.Value = Item.ImagePath;
                }
            }
            else
            {
                lblTitle.Text = "Add Gallery Image";
            }
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.GalleryId = Convert.ToInt16(ItemId);
        }
        Item.Name = Convert.ToString(txtName.Text);
        if (flUpload.FileName.Length > 0)
        {
            clsFileUpload objFile = new clsFileUpload();
            string strFilePath = objFile.GalleryUploadFile(flUpload);
            Item.ImageThumbPath = "thumb_" + strFilePath;
            Item.ImagePath = strFilePath;
        }
        else
        {
            Item.ImageThumbPath = Convert.ToString(hdnImagePath.Value);
            Item.ImagePath = Convert.ToString(hdnImageThumbPath.Value);
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("GallerySearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("GallerySearch.aspx");
    }
}