using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class EmployeeDocument : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsEmployeeDocument Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsEmployeeDocument();
        if (!IsPostBack)
        {
            BindDocCategory();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit My Document";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtEmployeeDocument.Text = Item.EmployeeDocument;
                    ddlDocCategory.SelectedValue = Convert.ToString(Item.EmployeeDocumentTypeId);
                    hdnDocPath.Value = Item.EmployeeDocumentPath;
                }
            }
            else
            {
                lblTitle.Text = "Add My Document";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.EmployeeDocumentId = Convert.ToInt16(ItemId);
        }
        Item.EmployeeId = CurrentUser.CurrentEmployeeId;
        Item.EmployeeDocumentTypeId = Convert.ToInt32(ddlDocCategory.SelectedValue);
        Item.EmployeeDocument = Convert.ToString(txtEmployeeDocument.Text);
        if (flUpload.FileName.Length > 0)
        {
            int filesize = flUpload.PostedFile.ContentLength;
            if (filesize > 10485760) // 10 MB
            {
                Response.Redirect("EmployeeDocument.aspx");
            }
            else
            {
                clsFileUpload objFile = new clsFileUpload();
                string strFilePath = objFile.EmployeeDocumentUploadDoc(flUpload);
                Item.EmployeeDocumentPath = strFilePath;                
            }
        }
        else
        {
            Item.EmployeeDocumentPath = Convert.ToString(hdnDocPath.Value);
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("EmployeeDocumentSearch.aspx");
    }
    protected void BindDocCategory()
    {
        clsDocCategory obj= new clsDocCategory();
        ddlDocCategory.DataSource = obj.LoadAll(obj);
        ddlDocCategory.DataTextField = "Category";
        ddlDocCategory.DataValueField = "CategoryId";
        ddlDocCategory.DataBind();
        ddlDocCategory.Items.Insert(0, new ListItem("--Select Category--", ""));        
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeDocumentSearch.aspx");
    }
}