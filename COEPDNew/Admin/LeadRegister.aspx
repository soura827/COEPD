<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="LeadRegister.aspx.cs" Inherits="LeadRegister" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-4 col-md-4">
                            <div class="form-horizontal no-margin">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Course
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:DropDownList ID="ddlCourse" runat="server" Required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        BatchType
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:DropDownList ID="ddlBatchType" runat="server" Required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Location
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:DropDownList ID="ddlLocation" runat="server" Required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Name
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtLead" runat="server" Required=""></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Pri.Mobile
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtPrimaryMobile" runat="server" Required="" type="number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Secd.Mobile
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtSecondaryMobile" runat="server" type="number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Pri.Email
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtPrimaryEmail" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Secd.Email
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtSecondaryEmail" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Phone
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Address
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-8 col-md-8">
                            <div class="form-horizontal no-margin">
                                <div class="form-group">
                                    <div class="col-sm-12">
                                        <div class="table-responsive">
                                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%">
                                                <Columns>
                                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                                    <asp:BoundField HeaderText="History" DataField="LeadLink" ItemStyle-Width="500px" />
                                                    <asp:BoundField HeaderText="Name" DataField="Username" />
                                                    <asp:BoundField HeaderText="Date" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                                </Columns>
                                                <EmptyDataTemplate>
                                                    <center>
                                                        No Records Found
                                                    </center>
                                                </EmptyDataTemplate>
                                            </asp:GridView>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Lead Category
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:DropDownList ID="ddlLeadCategory" runat="server" required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Communication
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:DropDownList ID="ddlCommunicationType" runat="server" required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Trainer
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:DropDownList ID="ddlTrainer" runat="server" required="">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Batch Date
                                    </label>
                                    <div class="col-md-2">
                                        <asp:TextBox ID="txtDay" runat="server" required="" type="number" MaxLength="2"> </asp:TextBox>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:TextBox ID="txtMonth" runat="server" required="" type="number" MaxLength="2"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4">
                                        <asp:TextBox ID="txtYear" runat="server" required="" type="number" MaxLength="4"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Course Fee
                                    </label>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtCourseFee" runat="server" required="" type="number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Notes
                                    </label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine">
                                        </asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-offset-3 col-sm-9">
                                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                        <asp:Button ID="btnAddNew" runat="server" OnClick="btnAddNew_Click" Text="Add New" />
                                        <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                            OnClick="btnCancel_Click" />
                                    </div>
                                    ,
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
    <!-- Row End -->
</asp:Content>
