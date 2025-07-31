<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Inventory.aspx.cs" Inherits="Admin_Inventory" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
      
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Inventory Name
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtInventoryName" runat="server"  MaxLength="1000"  required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Inventory Type
                            </label>
                            <div class="col-sm-10">

                                <asp:DropDownList ID="ddlInventoryType" runat="server"  required=""></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Classification
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlInventoryClassification" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Purchase Date
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtDay" min="1" Max="31" MaxLength="2" runat="server" type="number" Width="70" Required=""></asp:TextBox>
                                    </div>
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtMonth" min="1" Max="12" runat="server" MaxLength="2" type="number" Width="70" Required=""></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox ID="txtYear" runat="server" type="number" MaxLength="4" Required=""></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Vendor
                            </label>
                            <div class="col-sm-10">
                              <%--  <asp:TextBox ID="txtPurchaseFrom" runat="server"   MaxLength="500" required=""></asp:TextBox>--%>
                                <asp:DropDownList ID="ddlVendor" runat="server" Required="" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                No Of Items
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtNoOfItems" runat="server" Type="Number" MaxLength="10" ></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Expiration Date
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtExpDay" min="1" Max="31" placeholder="DD" runat="server" MaxLength="2"  type="number" Width="70"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtExpMonth" min="1" Max="12" placeholder="MM" runat="server" MaxLength="2" type="number" Width="70" ></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                        <asp:TextBox ID="txtExpYear" min="0" runat="server" placeholder="YYYY" MaxLength="4" type="number" ></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Order Alert
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtOrderAlert" min="0" runat="server" MaxLength="10" Type="Number" ></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Shelf Location
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtShelfLocation" runat="server" MaxLength="500"   ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Purchase Cost
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPurchaseCost" min="0" runat="server" Type="Number" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Inventory Status
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlInventoryStatus" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlLocation" runat="server" Enabled="true" Required="" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged"  >
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location Office
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList Id="ddlLocationoffice" runat="server" Required="" AutoPostBack="true" ></asp:DropDownList>
                                <%-- <asp:TextBox ID="txtLocationOffice" runat="server"  required="" AutoPostBack="true"></asp:TextBox>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <!-- Row End -->
</asp:Content>