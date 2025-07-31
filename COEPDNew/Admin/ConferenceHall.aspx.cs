using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ConferenceHall : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsConferenceHall Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);

        Item = new clsConferenceHall();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Conference Room";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtHall.Text = Item.ConferenceHall;
                    txtCapacity.Text = Item.Capacity.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add Conference Room";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.HallId = Convert.ToInt16(ItemId);
        }
        Item.ConferenceHall = txtHall.Text;
        Item.Capacity = Convert.ToInt16(txtCapacity.Text);
        if(flUpload.HasFile)
        {
            clsFileUpload upload = new clsFileUpload();
            string Path =  upload.ConferenceHallUploadDoc(flUpload);
            Item.ImagePath = Path;
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("ConferenceHallSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConferenceHallSearch.aspx");
    }
}