using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsInventoryData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsInventory obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Inventory_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@InventoryId", obj.InventoryId);
                    objCmd.Parameters.AddWithValue("@InventoryName", obj.InventoryName);
                    objCmd.Parameters.AddWithValue("@InventoryTypeId", obj.InventoryTypeId);
                    objCmd.Parameters.AddWithValue("@InventoryClassificationId", obj.InventoryClassificationId);
                    objCmd.Parameters.AddWithValue("@PurchaseDate", obj.PurchaseDate);
                    objCmd.Parameters.AddWithValue("@VendorId", obj.VendorId);
                    objCmd.Parameters.AddWithValue("@PurchaseCost", obj.PurchaseCost);
                    objCmd.Parameters.AddWithValue("@InventoryStatusId", obj.InventoryStatusId);
                    objCmd.Parameters.AddWithValue("@NoOfItems", obj.NoOfItems);
                    objCmd.Parameters.AddWithValue("@ExpirationDate", obj.ExpirationDate);
                    objCmd.Parameters.AddWithValue("@OrderAlert", obj.OrderAlert);
                    objCmd.Parameters.AddWithValue("@ShelfLocation", obj.ShelfLocation);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@LocationOfficeId", obj.LocationOfficeId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsInventory Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Inventory_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@InventoryId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsInventory objInfo = new clsInventory();
                            objInfo.InventoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.InventoryName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.InventoryTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.InventoryClassificationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.PurchaseDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.VendorId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.PurchaseCost = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.InventoryStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                                objInfo.NoOfItems = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.ExpirationDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[9]);
                            if (objDset.Tables[0].Rows[0].ItemArray[10] != DBNull.Value)
                                objInfo.OrderAlert = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.ShelfLocation = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.LocationOfficeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[14]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }


        public List<clsInventory> LoadAll(clsInventory obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Inventory_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@InventoryId", obj.InventoryId);
                    objCmd.Parameters.AddWithValue("@InventoryTypeId", obj.InventoryTypeId);
                    objCmd.Parameters.AddWithValue("@InventoryClassificationId", obj.InventoryClassificationId);
                    objCmd.Parameters.AddWithValue("@InventoryStatusId", obj.InventoryStatusId);
                    // objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsInventory> objList = new List<clsInventory>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsInventory objInfo = new clsInventory();
                                objInfo.SNo = cnt + 1;
                                objInfo.InventoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.InventoryName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.InventoryType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.InventoryClassification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.PurchaseDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Vendor = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.PurchaseCost = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.InventoryStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.NoOfItems = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.ExpirationDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[10] != DBNull.Value)
                                    objInfo.OrderAlert = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.ShelfLocation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.LocationOffice = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public void Remove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Inventory_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@InventoryId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}