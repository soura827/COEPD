using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_COEPDClients : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCOEPDClients Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCOEPDClients();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit COEPD Clients";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtCOEPDClientsName.Text = Item.COEPDClientsName;
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
                    ImgPhoto.ImageUrl = "~/UserDocs/COEPDClietns/" + Item.ImageThumbPath;
                    hdnImagePath.Value = Item.ImageThumbPath;
                    hdnImageThumbPath.Value = Item.ImagePath;
                    ReqFileUpload.Enabled = false;
                }
            }
            else
            {
                lblTitle.Text = "Add COEPD Clients";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.COEPDClientsId = Convert.ToInt16(ItemId);
        }
        Item.COEPDClientsName = Convert.ToString(txtCOEPDClientsName.Text);
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
            string strFilePath = objFile.COEPDClientsDoc(flUpload);
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
        Response.Redirect("COEPDClientsSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("COEPDClientsSearch.aspx");
    }
}