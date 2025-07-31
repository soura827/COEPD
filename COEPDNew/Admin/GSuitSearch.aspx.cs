using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_GSuitSearch : System.Web.UI.Page
{
    int Total = 0;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    protected void BindData()
    {
        clsGSuit obj = new clsGSuit();
        if(txtGSuitEmail.Text != "")
            obj.GSuitEmail = txtGSuitEmail.Text;
        if (ddlIsCreated.SelectedValue != "")
            obj.IsCreated = Convert.ToBoolean(ddlIsCreated.SelectedValue);
        if (ddlIsEmailAssigned.SelectedValue != "")
            obj.IsEmailAssigned = Convert.ToBoolean(ddlIsEmailAssigned.SelectedValue);
        if (txtCreatedName.Text != "")
            obj.CreatedName = txtCreatedName.Text;
        if (txtModifiedName.Text != "")
            obj.ModifiedName = txtModifiedName.Text;
        List<clsGSuit> items = obj.LoadAll(obj);
        if (items != null)
        {
            Total = items.Count;

        }
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("GSuit.aspx");
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("GSuit.aspx?ItemId=" + e.CommandArgument);
        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_PreRender(object sender, EventArgs e)
    {
        int TotalRecords = 0;
        string Records = "";
        TotalRecords = (gv.PageSize * (gv.PageIndex + 1));
        if (TotalRecords > Total)
        {
            Records = Total.ToString();

        }
        else
        {
            Records = TotalRecords.ToString();
        }
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + (gv.PageSize * (gv.PageIndex + 1)).ToString() + ") Records " + " of " + Total.ToString() + " Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " of " + gv.PageCount.ToString() + " - (" + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void txtGSuitEmail_TextChanged(object sender, EventArgs e)
    {
        BindData();
    } 
}