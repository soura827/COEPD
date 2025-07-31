using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ParticipantInteractionsReport : System.Web.UI.Page
{
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
        clsActivityInteractions Obj = new clsActivityInteractions();
        if (txtActivityCategory.Text != "")
            Obj.ActivityCategory = txtActivityCategory.Text;
        if (txtActivitySubCategory.Text != "")
            Obj.ActivitySubcategory = txtActivitySubCategory.Text;
        if (txtActivity.Text != "")
            Obj.Activity = txtActivity.Text;
        if (txtInputsEnteredBy.Text != "")
            Obj.InputsEnteredBy = txtInputsEnteredBy.Text;
        if (txtInvolvedEmployees.Text != "")
            Obj.InvolvedEmployees = txtInvolvedEmployees.Text;
        if (txtInvolvedParticipants.Text != "")
            Obj.InvolvedParticipants = txtInvolvedParticipants.Text;
        if (txtBranch.Text != "")
            Obj.Branch = txtBranch.Text;
        if (txtFromDate.Text != "")
        {
            Obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            Obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            Obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            Obj.ToDate = null;
        }
        gv.DataSource = Obj.LoadAllParticipantInteractions(Obj);
        gv.DataBind();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();

    }

    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;

    }

    protected void txtActivityCategory_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtActivitySubCategory_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtActivity_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtInputsEnteredBy_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtInvolvedEmployees_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtInvolvedParticipants_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtBranch_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}