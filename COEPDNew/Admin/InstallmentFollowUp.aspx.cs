using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_InstallmentFollowUp : System.Web.UI.Page
{
    int total = 0;
    DateTime DateTime;
    CurrentUser currentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = DateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.ToString("dd/MM/yyyy");
            BindData();
        }
    }
    protected void BindData()
    {
        clsFeeInstallment obj = new clsFeeInstallment();
        if (txtLead.Text != "")
        {
            obj.Lead = txtLead.Text;

        }


        if (txtmobile.Text != "")
        {
            obj.Mobile = txtmobile.Text;
        }

        if (txtServiceOwner.Text != "")
        {
            obj.Fullname = txtServiceOwner.Text;

        }

        if (txtInstallments.Text != "")
        {
            obj.Installments = txtInstallments.Text;

        }

        if (txtFromDate.Text != "")
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        else
            obj.FromDate = null;

        if (txtToDate.Text != "")
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        else
            obj.ToDate = null;

        gv.DataSource = obj.LoadForALL(obj);
        gv.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantFeeMapping.aspx");
    }


    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
            Response.Redirect("InstallmentEdits.aspx?ItemNumber=" + e.CommandArgument);
        else if (e.CommandName == "cmdStatus")
            Response.Redirect("LeadFeePayment.aspx?ItemId=" + e.CommandArgument);
    }


    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        BindData();

    }



    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    total += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Due"));
        //}
        //if (e.Row.RowType == DataControlRowType.Footer)
        //{
        //    Label lblamount = (Label)e.Row.FindControl("lblTotal");
        //    lblamount.Text = total.ToString();
        //}
    }

    protected void txtLead_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtmobile_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtServiceOwner_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtInstallments_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-InstallmentFollowUp.xls", gv);
    }
    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";
        StringWriter SW = new StringWriter();
        HtmlTextWriter HTW = new HtmlTextWriter(SW);
        //gv.RenderControl(HTW);
        gv.RenderControl(HTW);
        Response.Write(SW.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
    }

    protected void ddlInstallments_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}