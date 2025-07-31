using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantDocument : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsDocument Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsDocument();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Participant Document";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtDocument.Text = Item.Document;
                    hdnDocPath.Value = Item.DocPath;
                    ddlDocCategory.SelectedValue = Item.CategoryId.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add Participant Document";
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.DocumentId = Convert.ToInt16(ItemId);
        }
        Item.Document = Convert.ToString(txtDocument.Text);


        Item.CategoryId = Convert.ToInt16(ddlDocCategory.SelectedValue);

        if (flUpload.FileName.Length > 0)
        {
            clsFileUpload objFile = new clsFileUpload();
            string strFilePath = objFile.DocumentUploadDoc(flUpload);
            Item.DocPath = strFilePath;
        }
        else
        {
            Item.DocPath = Convert.ToString(hdnDocPath.Value);
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("ParticipantDocumentSearch.aspx");

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantDocumentSearch.aspx");
    }
}