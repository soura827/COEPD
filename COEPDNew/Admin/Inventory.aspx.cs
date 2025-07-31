using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_Inventory : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsInventory Item;
    clsUtility utility = new clsUtility();
    int ItemId = 0;
    int Selectedvalue = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsInventory();
        if (!IsPostBack)
        {
            BindInventoryType();
            BindInventoryClassification();
            BindInventoryStatus();
            BindLocation();
            BindVendor();
            //BindLocationoffice();

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Inventory";
                Item = Item.Load(ItemId);
                
                if (Item != null)
                {
                    DateTime dtPurchaseDate = Convert.ToDateTime(Item.PurchaseDate);
                    txtDay.Text = dtPurchaseDate.Day.ToString();
                    txtMonth.Text = dtPurchaseDate.Month.ToString();
                    txtYear.Text = dtPurchaseDate.Year.ToString();
                    ddlInventoryType.SelectedValue = Item.InventoryTypeId.ToString();
                    ddlInventoryClassification.SelectedValue = Item.InventoryClassificationId.ToString();
                    ddlInventoryStatus.SelectedValue = Item.InventoryStatusId.ToString();
                    txtPurchaseCost.Text = Item.PurchaseCost.ToString();
                    ddlVendor.SelectedValue = Item.VendorId.ToString();
                    txtInventoryName.Text = Item.InventoryName.ToString();
                    txtNoOfItems.Text = Item.NoOfItems.ToString();
                    BindLocationoffice();
                    txtOrderAlert.Text = Item.OrderAlert.ToString();
                    txtShelfLocation.Text = Item.ShelfLocation;
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    Selectedvalue = Convert.ToInt32(Item.LocationId.ToString());
                    // txtLocationOffice.Text = Item.LocationOffice.ToString();
                    ddlLocationoffice.SelectedValue = Item.LocationOfficeId.ToString();
                    if (Item.ExpirationDate != null)
                    {
                        DateTime dtExpirationDate = Convert.ToDateTime(Item.ExpirationDate);
                        txtExpDay.Text = dtExpirationDate.Day.ToString();
                        txtExpMonth.Text = dtExpirationDate.Month.ToString();
                        txtExpYear.Text = dtExpirationDate.Year.ToString();
                    }
                }
            }
            else
            {
                lblTitle.Text = "Add New Inventory";
                DateTime dt;
                dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                txtDay.Text = dt.Day.ToString();
                txtMonth.Text = dt.Month.ToString();
                txtYear.Text = dt.Year.ToString();
            }
        }
    }
    protected void BindInventoryType()
    {
        clsInventoryType obj = new clsInventoryType();
        ddlInventoryType.DataSource = obj.LoadAll(obj);
        ddlInventoryType.DataTextField = "InventoryType";
        ddlInventoryType.DataValueField = "InventoryTypeId";
        ddlInventoryType.DataBind();
        ddlInventoryType.Items.Insert(0, new ListItem("-- Select Inventory Type --", ""));
    }

    protected void BindInventoryClassification()
    {
        clsInventoryClassification obj = new clsInventoryClassification();
        ddlInventoryClassification.DataSource = obj.LoadAll(obj);
        ddlInventoryClassification.DataTextField = "InventoryClassification";
        ddlInventoryClassification.DataValueField = "InventoryClassificationId";
        ddlInventoryClassification.DataBind();
        ddlInventoryClassification.Items.Insert(0, new ListItem("-- Select Classification --", ""));
    }
    protected void BindInventoryStatus()
    {
        clsInventoryStatus obj = new clsInventoryStatus();
        ddlInventoryStatus.DataSource = obj.LoadAll(obj);
        ddlInventoryStatus.DataTextField = "InventoryStatus";
        ddlInventoryStatus.DataValueField = "InventoryStatusId";
        ddlInventoryStatus.DataBind();
        ddlInventoryStatus.Items.Insert(0, new ListItem("-- Select Status --", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.InventoryId = Convert.ToInt16(ItemId);
        }

        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtDay.Text);
            int month = Convert.ToInt16(txtMonth.Text);
            int year = Convert.ToInt16(txtYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.PurchaseDate = dt;
        }
        Item.InventoryName = Convert.ToString(txtInventoryName.Text);
        Item.InventoryTypeId = Convert.ToInt16(ddlInventoryType.SelectedValue);
        Item.InventoryClassificationId = Convert.ToInt16(ddlInventoryClassification.SelectedValue);
        Item.InventoryStatusId = Convert.ToInt16(ddlInventoryStatus.SelectedValue);
        if (txtNoOfItems.Text.Length > 0)
        {
            Item.NoOfItems = Convert.ToInt16(txtNoOfItems.Text);
        }
        if (txtExpDay.Text.Length > 0 && txtExpMonth.Text.Length > 0 && txtExpYear.Text.Length > 0)
        {
            int Day = Convert.ToInt16(txtExpDay.Text);
            int Month = Convert.ToInt16(txtExpMonth.Text);
            int Year = Convert.ToInt16(txtExpYear.Text);
            DateTime dt1 = new DateTime(Year, Month, Day);
            Item.ExpirationDate = dt1;
        }
        if (txtOrderAlert.Text.Length > 0)
        {
            Item.OrderAlert = Convert.ToInt16(txtOrderAlert.Text);
        }
        Item.ShelfLocation = Convert.ToString(txtShelfLocation.Text);
        Item.PurchaseCost = Convert.ToDecimal(txtPurchaseCost.Text);
        //Item.PurchaseFrom = Convert.ToString(txtPurchaseFrom.Text);
        Item.VendorId=Convert.ToInt32(ddlVendor.SelectedValue);
        Item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
        
        Item.LocationOfficeId=Convert.ToInt32(ddlLocationoffice.SelectedValue);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("InventorySearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventorySearch.aspx");
    }
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("--Select Location--", ""));
    }
    protected void BindVendor()
    {
        clsVendor obj = new clsVendor();
        ddlVendor.DataSource = obj.LoadAll(obj);
        ddlVendor.DataTextField = "Vendor";
        ddlVendor.DataValueField = "VendorId";
        ddlVendor.DataBind();
        ddlVendor.Items.Insert(0, new ListItem("--Select Vendor--", ""));
    }
    protected void BindLocationoffice()
    {
        clsLocationOffice item = new clsLocationOffice();
        if (ddlLocation.SelectedIndex > 0)
        {
            item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
        }
        if(Selectedvalue!=0)
        {
            item.LocationId = Selectedvalue;
        }
            ddlLocationoffice.DataSource = item.LoadAll(item);
            ddlLocationoffice.DataTextField = "LocationOffice";
            ddlLocationoffice.DataValueField = "LocationOfficeId";
            ddlLocationoffice.DataBind();
            ddlLocationoffice.Items.Insert(0, new ListItem("--Select Location Office--", ""));
    }
    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLocation.SelectedIndex > 0)
        {
           
            BindLocationoffice();
        }
    }
    //protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (ddlLocation.SelectedIndex > 0)
    //    {
    //        clsLocationOffice item = new clsLocationOffice();
    //        int LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
    //        item = item.Load(LocationId);
    //        txtLocationOffice.Text = Convert.ToString(item.LocationOffice);
    //    }
    //}

    //protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (ddlLocation.SelectedIndex > 0)
    //    {
    //        clsLocationOffice item = new clsLocationOffice();
    //        int LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
    //        item = item.Load(LocationId);
    //       // txtLocationOffice.Text = Convert.ToString(item.LocationOffice);
    //    }
    //}
}