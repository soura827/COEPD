using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_PlacementInductionSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int CountNo = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
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
        if (CurrentUser.CurrentEmployeeId > 0)
        {
            clsPlacementInduction obj = new clsPlacementInduction();
            if (txtSearch.Text.Length > 0)
            {
                obj.KeyWords = txtSearch.Text;
            }
            if (txtFromDate.Text != "")
            {
                obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
            }
            else
            {
                obj.FromDate = null;
            }
            if (txtToDate.Text != "")
            {
                obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
            }
            else
            {
                obj.ToDate = null;
            }
            if (ddlStatus.SelectedValue != "")
                obj.IsHRMockApproved = Convert.ToBoolean(ddlStatus.SelectedValue);
            if (txtTrainer.Text != "")
                obj.Employee = txtTrainer.Text;
            if (txtLocation.Text != "")
                obj.Location = txtLocation.Text;
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
        }
        else
        {
            Response.Redirect("~/Login.html");
        }

    }

  
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
        if (e.CommandName == "cmdEdit")
        {
            int itemId = Convert.ToInt32(e.CommandArgument);

            if (itemId > 0)
            {
               clsHRMockFeedBack HRM = new clsHRMockFeedBack();
                HRM.PlacementInductionId = itemId;

                

               
                
                CountNo = HRM.LoadInductionValidation(HRM);




                if (CountNo>0)
                {
                    
                    Response.Redirect("PlacementHRMock.aspx?itemId=" + e.CommandArgument);
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
                }
                else 

                {
                    HRM.PlacementInductionId = itemId;

                    HRM.CreatedBy = CurrentUser.CurrentUserId;
                    HRM.AddUpdate(HRM);

                    Response.Redirect("PlacementHRMock.aspx?itemId=" + e.CommandArgument);
                }
            }
        }


    }
   
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnReplyFile = (HiddenField)e.Row.FindControl("hdnReplyFile");
                HyperLink hplReplyFile = (HyperLink)e.Row.FindControl("hplReplyFile");

                if (hdnReplyFile.Value == "")
                {
                    hplReplyFile.Visible = false;
                }
            }
        }
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

    //protected void btnAdd_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("PlacementInduction.aspx");
    //}

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtTrainer_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    //protected void btnAdd_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("PlacementHRMock.aspx");
    //}
}