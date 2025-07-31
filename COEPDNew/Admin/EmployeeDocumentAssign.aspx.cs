using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class EmployeeDocumentAssign : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsEmployeeDocumentAssign Item;
    int EmployeeDocumentId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeDocumentId = Convert.ToInt16(Request.QueryString["DocumentId"]);
        Item = new clsEmployeeDocumentAssign();
        if (!IsPostBack)
        {
            GetDocumentName();
            BindData();
            BindEmployees();
            lblTitle.Text = "Share Document To Employees";
        }
    }
    protected void GetDocumentName()
    {
        if (EmployeeDocumentId > 0)
        {
            clsEmployeeDocument obj = new clsEmployeeDocument();
            obj = obj.Load(EmployeeDocumentId);
            lblDocumentName.Text = obj.EmployeeDocument;
        }
        else
        {
            lblDocumentName.Text = "Please Select a Document";
            lblDocumentName.ForeColor = System.Drawing.Color.Red;
        }
    }
    protected void BindData()
    {
        if (EmployeeDocumentId > 0)
        {
            clsEmployeeDocumentAssign obj = new clsEmployeeDocumentAssign();
            if (txtEmployee.Text != "")
                obj.keywords = txtEmployee.Text;
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            obj.EmployeeDocumentId = EmployeeDocumentId;
            gv.DataSource = obj.LoadAllAssigned(obj);
            gv.DataBind();
        }
    }
    protected void BindEmployees()
    {
        if (EmployeeDocumentId > 0)
        {
            clsEmployeeDocumentAssign obj = new clsEmployeeDocumentAssign();
            obj.EmployeeDocumentId = EmployeeDocumentId;
            gv1.DataSource = obj.LoadAll(obj);
            gv1.DataBind();
        }
    }
    protected void gv1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            int EmployeeDocumentAssignId = Convert.ToInt32(e.CommandArgument);
            Item.Remove(EmployeeDocumentAssignId);
            BindEmployees();
            BindData();
        }
    }
    protected void btnshare_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow row in gv.Rows)
        {
            int EmployeeID = Convert.ToInt32(gv.DataKeys[row.RowIndex].Value);
            CheckBox chk = (CheckBox)row.FindControl("chkEmployee");
            if (chk.Checked)
            {
                Item.EmployeeDocumentId = EmployeeDocumentId;
                Item.AssignedEmployeeId = EmployeeID;
                Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                Item.AddUpdate(Item);
            }
        }
        BindEmployees();
        BindData();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeDocumentSearch.aspx");
    }
    protected void gv1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            int Id = Convert.ToInt32(gv1.DataKeys[e.Row.RowIndex].Value);
            if(Id != CurrentUser.CurrentUserId)
            {
                LinkButton lnk = (LinkButton)e.Row.FindControl("lnkSend");
                lnk.Visible = false;
            }
        }
    }

    protected void txtEmployee_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}