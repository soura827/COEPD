using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Career : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCareer Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCareer();
        if(!IsPostBack)
        {
            if(ItemId > 0)
            {
                lblTitle.Text = "Edit COEPD Opening";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtEmail.Text = Item.EmailId;
                    txtMobile.Text = Item.Mobile;
                    txtDescription.Text = Item.JobDescription;
                    txtSkills.Text = Item.KeySkills;
                    txtTitle.Text = Item.JobTitle;
                    txtYearofExp.Text = Item.Experience;
                    if(Item.IsActive == true)
                    {
                        chkActive.Checked = true;
                    }
                    else
                    {
                        chkActive.Checked = false;
                    }
                    DateTime dt = Convert.ToDateTime(Item.Date);
                    txtDay.Text = dt.Day.ToString();
                    txtMonth.Text = dt.Month.ToString();
                    txtYear.Text = dt.Year.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add COEPD Opening";
                chkActive.Checked = true;
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.CareerId = Convert.ToInt16(ItemId);
        }
        Item.EmailId = txtEmail.Text;
        Item.Mobile = txtMobile.Text;
        Item.JobDescription = txtDescription.Text;
        Item.KeySkills = txtSkills.Text;
        Item.JobTitle = txtTitle.Text;
        Item.Experience = txtYearofExp.Text;
        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtDay.Text);
            int month = Convert.ToInt16(txtMonth.Text);
            int year = Convert.ToInt16(txtYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.Date = dt;
        }

        if (chkActive.Checked == true)
        {
            Item.IsActive = true;
        }
        else
        {
            Item.IsActive = false;
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("CareerSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CareerSearch.aspx");
    }
}