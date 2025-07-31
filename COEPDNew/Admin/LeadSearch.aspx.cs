using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class LeadSearch : System.Web.UI.Page
{
    int Total = 0;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void setGridView()
    {
        if (CurrentUser.IsAdmin == false)
        {
            gv.Columns[0].Visible = false;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CurrentUser.CurrentUserId == 10031)
        {
            ddlRasikaLocation.Visible = true;
            ddlLocation.Visible = false;
        }
        else
        {
            ddlRasikaLocation.Visible = false;
            ddlLocation.Visible = true;
        }


        if (!IsPostBack)
        {
            BindLocation();
            BindData();
        }
    }

    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindLocation()
    {
        if (CurrentUser.IsAdmin == true)
        {
            clsLocation obj = new clsLocation();
            ddlLocation.DataSource = obj.LoadAll(obj);
            ddlLocation.DataTextField = "Location";
            ddlLocation.DataValueField = "LocationId";
            ddlLocation.DataBind();
            ddlLocation.Items.Insert(0, new ListItem("-- Select Locations --", "0"));
        }
        else
        {
            clsUserLocation obj = new clsUserLocation();
            obj.UserId = CurrentUser.CurrentUserId;
            ddlLocation.DataSource = obj.LoadAll(obj);
            ddlLocation.DataTextField = "Location";
            ddlLocation.DataValueField = "LocationId";
            ddlLocation.DataBind();
            //ddlLocation.Items.Insert(0, new ListItem("-- Select Location --", "0"));
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Lead.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        if (ddlLocation.Items.Count > 0)
        {
            clsLead obj1 = new clsLead();
            obj1.LeadStatusId = 1;
           // obj1.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
            obj1.keywords = txtSearch.Text.Trim();
            gv.DataSource = obj1.LoadAll(obj1);
            gv.DataBind();
            setGridView();
        }

        clsLead obj = new clsLead();
        if (CurrentUser.CurrentUserId == 2817 || CurrentUser.CurrentUserId == 4468  || CurrentUser.CurrentUserId == 10031 || CurrentUser.CurrentUserId == 31688)  //venkat sir| mahesh sir| Rasika,| Praveena (show all Leads)
        {

        }
        else
        {
            ddlLocation.Visible = false;
            if (CurrentUser.CurrentUserId == 29217 || CurrentUser.CurrentUserId == 29943)  // Abhishek|Vinay
            {
                int Employee = CurrentUser.CurrentUserId;
                switch (Employee)
                {
                    case 29217:
                        obj.LocationId = 1;
                        break;
                    case 29943:
                        obj.LocationId = 2;
                        break;
                }
            }
            else
            {
                obj.CreatedBy = CurrentUser.CurrentUserId;
            }
        }

        if (txtSearch.Text != "")
            obj.keywords = Convert.ToString(txtSearch.Text);


        if (CurrentUser.CurrentUserId == 29217 || CurrentUser.CurrentUserId == 29943)
        {

        }
        else
        {
            if (ddlLocation.SelectedValue != "")
                obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
        }




        if (CurrentUser.CurrentUserId == 10031) //rasika userId
        {
            if (ddlRasikaLocation.SelectedValue != "")
                obj.LocationId = Convert.ToInt32(ddlRasikaLocation.SelectedValue);
        }







        List<clsLead> items = obj.LoadAll(obj);
        if (items != null)
            Total = items.Count;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

    }



    protected void BindManagerData()
    {



    }




    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Lead.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdFollowup")
        {
            Response.Redirect("FollowUp.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsLead Item = new clsLead();
            Item.Remove(ItemId);
            BindData();
            //ErrorMessage.Text = "Lead successfully removed";
            //ErrorMessage.Visible = true;
        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + (gv.PageCount).ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + (gv.PageCount).ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }


    protected void ddlRasikaLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}