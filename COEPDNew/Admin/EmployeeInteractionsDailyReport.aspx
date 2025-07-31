<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="EmployeeInteractionsDailyReport.aspx.cs" Inherits="Admin_EmployeeInteractionsDailyReport" %>

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
                      <asp:Label ID="lblEmployeeName" runat ="server"></asp:Label>   Interactions Daily Report - <asp:Label ID="lblDate" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-2  col-md-2">
                                        <asp:Button ID="btnGoToTasks" runat="server" Text="Go To Activity Tasks" CausesValidation="false" OnClick="btnGoToTasks_Click" />
                                    </div>
                        <div class="col-lg-offset-2 col-lg-2 col-md-offset-3 col-md-3 div-right">
                            <asp:Button ID="btnSendReport" runat="server" Text="Send Daily Report"  OnClick="btnSendReport_Click" OnClientClick="return confirm('Are you sure want to send daily report ?');"/>
                        </div>                                             
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%">
                            <Columns>
                               <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <%--<asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" ItemStyle-Width="100px" />--%>
                                <asp:TemplateField HeaderText="ES Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("EnteredStartTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>                             
                                <asp:TemplateField HeaderText="EE Time">
                                    <ItemTemplate>
                                        <%# Eval("EnteredEndTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="EDur.(Min.)" DataField="EnteredMinutes" />
                               <asp:TemplateField HeaderText="SS Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("SystemStartTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="SE Time">
                                    <ItemTemplate>
                                        <%# Eval("SystemEndTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SDur.(Min.)" DataField="SystemMinutes" />
                                <asp:BoundField HeaderText="Activity Category" DataField="ActivityCategory" />
                                  <asp:BoundField HeaderText="Activity Subcategory" DataField="ActivitySubCategory" />
                                <asp:BoundField HeaderText="Activity" DataField="Activity" />
                                <asp:BoundField HeaderText="Task Title" DataField="Description" />                         
                                <asp:BoundField HeaderText="Task Inputs" DataField="ActivityInteractionInputs" />
                                <asp:BoundField HeaderText="Status" DataField="Status" />
                                <asp:BoundField HeaderText="Target Date" DataField="DateToWorkOn" DataFormatString="{0:dd MMM yyyy}" />

                            </Columns>
                            <EmptyDataTemplate>
                                <center>
                                    No Records Found
                                </center>
                            </EmptyDataTemplate>
                        </asp:GridView>
                              <asp:GridView ID="gvReport" runat="server" AutoGenerateColumns="False"  Width="100%">
                            <Columns>                              
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <%--<asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0:dd MMM yyyy}" ItemStyle-Width="100px" Visible="false" />--%>
                                <asp:TemplateField HeaderText="ES Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("EnteredStartTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>                             
                                <asp:TemplateField HeaderText="EE Time">
                                    <ItemTemplate>
                                        <%# Eval("EnteredEndTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="EDur.(Min.)" DataField="EnteredMinutes" />
                               <asp:TemplateField HeaderText="SS Time" ItemStyle-Width="100px">
                                    <ItemTemplate>
                                        <%# Eval("SystemStartTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="SE Time">
                                    <ItemTemplate>
                                        <%# Eval("SystemEndTime", "{0:hh:mm tt}") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SDur.(Min.)" DataField="SystemMinutes" />                             
                                <asp:BoundField HeaderText="Activity Category" DataField="ActivityCategory" />
                                  <asp:BoundField HeaderText="Activity Subcategory" DataField="ActivitySubCategory" />
                                <asp:BoundField HeaderText="Activity" DataField="Activity" />
                                <asp:BoundField HeaderText="Task Title" DataField="Description" />                           
                                <asp:BoundField HeaderText="Task Inputs" DataField="ActivityInteractionInputs" />
                                <asp:BoundField HeaderText="Status" DataField="Status" />
                                <asp:BoundField HeaderText="Target Date" DataField="DateToWorkOn" DataFormatString="{0:dd MMM yyyy}" />
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