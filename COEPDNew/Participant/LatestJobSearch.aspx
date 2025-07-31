<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true"
    CodeFile="LatestJobSearch.aspx.cs" Inherits="LatestJobSearch" EnableEventValidation="false" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
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
                        Latest Jobs
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-md-3">
                            <asp:DropDownList ID="ddlCategory" runat="server" required="">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="ddlJobDomain" runat="server" required="">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-3 col-md-3">
                           <asp:Button ID="btnSearch" runat="server" Text="Go" OnClick="btnSearch_Click" />
                        </div>
                    </div>
                     <div class="row">
                       <%-- <div class="col-lg-1">
                            <h5>From Date</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" required=""></asp:TextBox>
                        </div>
                        <div class="col-lg-1 ">
                            <h5>To Date</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" required=""></asp:TextBox>
                        </div>--%>
                        <div class="col-lg-1 col-md-1">
                            <%--<asp:Button ID="btnSearch" runat="server" Text="Go" OnClick="btnSearch_Click" />--%>
                        </div>
                        <div class=" clo-lg-1  pull-right">
                            <h4>
                                <asp:Label ID="lblCount" runat="server" ForeColor="Tomato"></asp:Label>
                            </h4>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" AutoGenerateColumns="False" Width="100%">
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Job" DataField="JobTitle" />
                                <asp:BoundField HeaderText="Company" DataField="Company" />
                                <asp:BoundField HeaderText="Location" DataField="Location" />
                                <asp:BoundField HeaderText="Exp" DataField="Experience" />
                                <asp:BoundField HeaderText="Domain" DataField="JobDomain" />
                                <asp:BoundField HeaderText="Posted Date" DataField="JobDate" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:TemplateField HeaderText="View" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkView" runat="server" Text="View" SkinID="view" CommandName="cmdView"
                                            CommandArgument='<%#Eval("JobId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
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
    <div class="box-theme">
        <div class="panel-body">
        </div>
    </div>
</asp:Content>