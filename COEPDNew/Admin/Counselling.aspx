<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="Counselling.aspx.cs" Inherits="Counselling" %>
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
                    <div class="form-horizontal no-margin">
                       
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Name
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtVisitor"   MaxLength="500" runat="server" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Employee
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlEmployee" runat="server" required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        
                        <div class="form-group">
                            <label class="col-sm-2 control-label ">
                                Start Time
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtsHours" runat="server" type="number" min="00" max="23" MaxLength="2" Required="" Placeholder="HH"
                                            Width="70px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtsmints" runat="server" type="number" min="00" max="59" MaxLength="2" Required="" Placeholder="MM"
                                            Width="70px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2  control-label">
                                End Time
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtEHours" runat="server" type="number" min="00" max="23" MaxLength="2" Placeholder="HH" Width="70px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-1 col-md-1">
                                        <asp:TextBox ID="txtEmints" runat="server" type="number" min="00" max="60" MaxLength="2" Placeholder="MM" Width="70px"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-2 col-md-2">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Purpose of Visit
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtComments" runat="server" MaxLength="2000" TextMode="MultiLine" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Notes
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtRemarks" runat="server" MaxLength="5000" TextMode="MultiLine"></asp:TextBox>
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