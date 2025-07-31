using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Download : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsDownload Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsDownload();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Download";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtDownload.Text = Item.Download;
                }
            }
            else
            {
                lblTitle.Text = "Add Download";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.DownloadId = Convert.ToInt16(ItemId);
        }

        Item.Download = Convert.ToString(txtDownload.Text);
        if (fl.FileName.Length > 0)
        {
            clsFileUpload objFile = new clsFileUpload();
            string strFilePath = objFile.DownloadUploadDoc(fl);
            Item.DownloadPath = strFilePath;
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("DownloadSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DownloadSearch.aspx");
    }
}