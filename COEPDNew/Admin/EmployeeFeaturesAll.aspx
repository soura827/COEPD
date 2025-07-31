<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="EmployeeFeaturesAll.aspx.cs" Inherits="Admin_EmployeeFeaturesAll" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Assigned Features
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                         <div class="col-lg-1 col-md-1">
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <h5>
                                Designation</h5>
                        </div>
                         <div class="col-lg-2 col-md-1">
                            <asp:DropDownList ID="ddldesignation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddldesignation_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        
                        <div class="col-lg-1 col-md-1">
                            <h5>
                                Location</h5>
                        </div>
                         <div class="col-lg-1 col-md-1">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        
                        <div class="col-lg-1 col-md-1">
                            <h5>
                                Employee</h5>
                        </div>
                        <div class="col-lg-2 col-md-1">
                            <asp:DropDownList ID="ddlEmployee" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEmployee_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <h5>
                                Select feature</h5>
                        </div>
                        <div class="col-lg-2 col-md-1">
                            <asp:DropDownList ID="ddlFeature" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlFeature_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                            <div class="table-responsive">
                            <asp:GridView ID="gvAssign" runat="server" AutoGenerateColumns="False" Width="100%"
                                OnRowCommand="gvAssign_RowCommand">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                   
                                    <asp:BoundField HeaderText="Employee Feature" DataField="Feature" />
                                    <asp:BoundField HeaderText="Employee" DataField="Employee" />
                                   <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:BoundField HeaderText="Designation" DataField="Designation" />
                                    <asp:TemplateField HeaderText="Remove " ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="Un-Assign Feature " CommandName="cmdRemove"
                                                CssClass="btn btn-info" CommandArgument='<%#Eval("FeatureAccessId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                                <EmptyDataTemplate> <%--This Template is uded to display the message when no records find--%>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                                </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <center>
                         <asp:Button ID="btnBackToFeatureAccess" runat="server" Text="Back to Assign Features" OnClick="btnBackToFeatureAccess_Click" />
                        </center>
                   </div>
                </div>
            </div>
        </div>
    </div>
      <!-- Row End -->
</asp:Content>

