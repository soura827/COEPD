<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="TermsAcceptedParticipantsSearch.aspx.cs" Inherits="Admin_TermsAcceptedParticipantsSearch" %>

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
                        Terms and Conditions Accepted Participants
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-4 col-md-4">
                            <asp:TextBox runat="server" ID="txtSearch" MaxLength="500" placeholder="Search By Participant, Certificate, Email and Mobile"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" OnPageIndexChanging="gv_PageIndexChanging" AllowPaging="true" PageSize="20" AutoGenerateColumns="False" Width="100%" OnPreRender="gv_PreRender" OnRowDataBound="gv_RowDataBound" OnDataBound="gv_DataBound">
                            <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                              <%--  <asp:TemplateField HeaderText="SNO" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                    <asp:Label ID="lblSNO" runat="server"></asp:Label>
                                        </ItemTemplate>
                                </asp:TemplateField>--%>
                                <asp:BoundField HeaderText="Location" DataField="Location" ItemStyle-Width="100px" />
                                <asp:BoundField HeaderText="Trainer" DataField="Employee" ItemStyle-Width="100px" />
                                <asp:BoundField HeaderText="Batch" DataField="StartDate" ItemStyle-Width="100px" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:BoundField HeaderText="Certificate" DataField="ReferenceNO" ItemStyle-Width="100px" />
                                <asp:BoundField HeaderText="Participant" DataField="Participant" ItemStyle-Width="200px" />
                                <asp:BoundField HeaderText="Email" DataField="Email" ItemStyle-Width="220px" />
                                <asp:BoundField HeaderText="Mobile" DataField="Mobile" ItemStyle-Width="150px" />
                                <asp:BoundField HeaderText="Terms Accepted On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" ItemStyle-Width="150px" />
                                <asp:BoundField HeaderText="Placement Data Sheet Terms Accepted On" DataField="DataSheeetTermsAcceptedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" ItemStyle-Width="150px" />
                                <asp:BoundField HeaderText="Placement Induction Terms Accepted On" DataField="PlacementInductionTermsAcceptedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" ItemStyle-Width="150px" />
                            </Columns>
                            <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                            <EmptyDataTemplate>
                                <center>
                                    No Records Found
                                </center>
                            </EmptyDataTemplate>
                        </asp:GridView>
                        </div>
                        <div>
                            <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
    <div class="box-theme">
        <div class="box-title">
            <div class="box-head">
            </div>
            <div class="box-button">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </div>
        </div>
        <div class="panel-body">
            <div class="row">
            </div>
        </div>
    </div>
</asp:Content>

