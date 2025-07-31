<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Administratio.aspx.cs" Inherits="Admin_Administratio" %>



<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <asp:Label ID="lblMessage" runat="server" Visible="false" Text=""></asp:Label>


    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Administration
                    </div>
                </div>
                <div class="widget-body">

                    <asp:Button ID="btnCancel" runat="server" Text="Back to Page" UseSubmitBehavior="false" OnClick="btnCancel_Click" />

                    <div class="col-md-2 col-lg-2">
                        <asp:DropDownList ID="ddlLocation" Enabled="false" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged"  />
                        </asp:DropDownList>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%">
                                <Columns>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px" Visible="false">
                                        <ItemTemplate>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Team" DataField="Roles" ItemStyle-Width="105px" />
                                    <asp:BoundField HeaderText="Employee" DataField="Employee" />
                                    <asp:BoundField HeaderText="Office Email" DataField="OfficeEmail" />
                                    <asp:BoundField HeaderText="CUG" DataField="CUGMobile" />
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
            </div>
        </div>
    </div>
    <!-- Row End -->








</asp:Content>

