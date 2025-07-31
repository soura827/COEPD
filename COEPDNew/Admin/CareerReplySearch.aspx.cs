//This code behind page is used to Display all Empolyees Job Opening Responses.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class CareerReplySearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCareerReply item = new clsCareerReply();
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
    //This method is used to get the required data(aspirant) from LoadAll() and displaying in GridView.
    public void BindData()
    {
        gv.DataSource = item.LoadAll(item);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //This command will fire when user click on View button and display the Gridview data in view mode.
        if (e.CommandName == "cmdView")
        {
            item = item.Load(Convert.ToInt16(e.CommandArgument));
            lblName.Text = item.Name;
            lblDOB.Text = item.DateOfBirth.ToString("dd-MM-yyyy");
            lblQualification.Text = item.Qualification;
            lblAppliedFor.Text = item.AppliedFor;
            lblTotalExp.Text = item.TotalExp;
            lblRelevantExp.Text = item.RelavantExperience;
            lblSkills.Text = item.Skills;
            lblStrengths.Text = item.Strengths;
            lblCompanyAddress.Text = item.CompanyAddress;
            lblPresentCTC.Text = item.PresentCTC;
            lblExpectedCTC.Text = item.ExpectedCTC;
            lblReason.Text = item.ReasonForChange;//This field is used to Display EmailId.
            lblAddress.Text = item.ResidentialAddress;//This field is used to Display Mobile number.
            lblDateOfApplication.Text = item.CreatedOn.ToString();
            //hplFile.NavigateUrl = "~/UserDocs/" + item.ImagePath;
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
        }
        //This command will fire when user click on Delete button 
        //This Command is used to delete the data of particular aspirant.
        if (e.CommandName == "cmdDelete")
        {
            item.Remove(Convert.ToInt32(e.CommandArgument));
            BindData();
            ErrorMessage.Text = "COEPD Job Response successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //This Command is used to disable Delete option for associates and enable for only Admin.
        if(e.Row.RowType==DataControlRowType.DataRow)
        {
            if(CurrentUser.CurrentEmployeeId==2 || CurrentUser.CurrentEmployeeId==1)
            {
                LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                lnk.Visible = true;
            }
            else
            {
                LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                lnk.Visible = false;
            }
        }
    }
}