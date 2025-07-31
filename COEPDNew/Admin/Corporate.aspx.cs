using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Corporate : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCorporate Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCorporate();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit BA Placements";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtCorporate.Text = Item.Corporate;
                    txtWebsite.Text = Item.Website;
                    if (Item.IsFeatured == true)
                    {
                        chkFeatured.Checked = true;
                    }
                    else
                    {
                        chkFeatured.Checked = false;
                    }
                    ImgPhoto.Visible = true;
                    ImgPhoto.ImageUrl = "~/UserDocs/Corporate/" + Item.ImageThumbPath;
                    hdnImagePath.Value = Item.ImageThumbPath;
                    hdnImageThumbPath.Value = Item.ImagePath;
                    ReqFileUpload.Enabled = false;
                }
            }
            else
            {
                lblTitle.Text = "Add BA Placements";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.CorporateId = Convert.ToInt16(ItemId);
        }
        Item.Corporate = Convert.ToString(txtCorporate.Text);
        Item.Website = Convert.ToString(txtWebsite.Text);
        if (chkFeatured.Checked == true)
        {
            Item.IsFeatured = true;
        }
        else
        {
            Item.IsFeatured = false;
        }
        if (flUpload.FileName.Length > 0)
        {
            clsFileUpload objFile = new clsFileUpload();
            string strFilePath = objFile.CorporateUploadDoc(flUpload);
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
        Response.Redirect("CorporateSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CorporateSearch.aspx");
    }   
}