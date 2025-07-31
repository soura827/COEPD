using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_PopUpImages : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsPopUpImages Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsPopUpImages();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Pop Up Image";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtPopUpImageName.Text = Item.PopUpImageName;
                }
            }
            else
            {
                lblTitle.Text = "Add Pop Up Image";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.PopUpImageId = Convert.ToInt16(ItemId);
        }

        Item.PopUpImageName = Convert.ToString(txtPopUpImageName.Text);
        if (fl.FileName.Length > 0)
        {
            clsFileUpload objFile = new clsFileUpload();
            string strFilePath = objFile.UploadPopUpImages(fl);
            Item.PopUpImagePath = strFilePath;
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("PopUpImagesSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PopUpImagesSearch.aspx");
    }
}