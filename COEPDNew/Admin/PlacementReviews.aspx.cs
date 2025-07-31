using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_PlacementReviews : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsPlacementReviews Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsPlacementReviews();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit BA Job market  Reviews";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtPlacementReviewsName.Text = Item.PlacementReviewsName;
                    if (Item.IsFeatured == true)
                    {
                        chkFeatured.Checked = true;
                    }
                    else
                    {
                        chkFeatured.Checked = false;
                    }
                    ImgPhoto.Visible = true;
                    ImgPhoto.ImageUrl = "~/UserDocs/PlacementReviews/" + Item.ImageThumbPath;
                    hdnImagePath.Value = Item.ImageThumbPath;
                    hdnImageThumbPath.Value = Item.ImagePath;
                    ReqFileUpload.Enabled = false;
                }
            }
            else
            {
                lblTitle.Text = "Add Placement Reviews";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.PlacementReviewsId = Convert.ToInt16(ItemId);
        }
        Item.PlacementReviewsName = Convert.ToString(txtPlacementReviewsName.Text);
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
            string strFilePath = objFile.PlacementReviewsDoc(flUpload);
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
        Response.Redirect("PlacementReviewsSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlacementReviewsSearch.aspx");
    }
}