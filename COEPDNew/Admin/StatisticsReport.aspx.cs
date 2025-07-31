using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_StatisticsReport : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsStatistics Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsStatistics();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Statistics";
                Item = Item.Load(ItemId);
                txtbatches.Text = Item.BatchesCompleted;
                txtparticipants.Text = Item.StudentsTrained;
                txtplacements.Text = Item.Placements;
                txtcorporates.Text = Item.Corporates;
                txtbschools.Text = Item.BSchools;
                FormMessage.Text = "Statistics details updated successfully";
            }
            else
            {
                lblTitle.Text = "Add New Statistics";
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
     {
        if (ItemId > 0)
        {
            Item.StatisticsId = Convert.ToInt16(ItemId);
            Session["ItemId"] = ItemId;
        }

        Item.BatchesCompleted = Convert.ToString(txtbatches.Text);
        Item.StudentsTrained = Convert.ToString(txtparticipants.Text);
        Item.Placements = Convert.ToString(txtplacements.Text);
        Item.Corporates = Convert.ToString(txtcorporates.Text);
        Item.BSchools = Convert.ToString(txtbschools.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("StatisticsReportSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StatisticsReportSearch.aspx");
    }
}