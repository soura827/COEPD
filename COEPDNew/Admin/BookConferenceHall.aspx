<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="BookConferenceHall.aspx.cs" Inherits="BookConferenceHall" %>

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
        <!-- Row End -->
        <!-- Row Start -->
        <div class="col-lg-8 col-md-8">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Conference Hall Slot Booked List
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <label class="col-lg-2 col-md-2">
                            Conference Hall 
                        </label>
                        <div class="col-lg-4 col-md-4">
                            <asp:DropDownList ID="ddlConference1" runat="server" AutoPostBack="true"
                                OnSelectedIndexChanged="ddlConference1_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                                Width="100%" OnRowDataBound="gv_RowDataBound">
                                <Columns>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnEmpId" runat="server" Value='<%#Eval("EmployeeId") %>' />
                                            <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("ConferenceHallId")%>' OnClientClick="return confirm('Are you sure you want to delete this conference hall slot?');"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Conference Hall" DataField="ConferenceHall" />
                                    <asp:BoundField HeaderText="Employee" DataField="Employee" />
                                    <asp:BoundField HeaderText="Date" DataField="Date" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="StartTime" DataField="StartTime" DataFormatString="{0: hh:mm}" />
                                    <asp:BoundField HeaderText="EndTime" DataField="EndTime" DataFormatString="{0: hh:mm}" />
                                    <asp:BoundField HeaderText="Purpose" DataField="Purpose" />
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
        <div class="col-lg-4 col-md-8">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Conference Hall
                            </label>
                            <div class="col-sm-8">
                                <asp:DropDownList ID="ddlConference" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Date
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtDay" runat="server" required="" type="number" Min="1" Max="31" Placeholder="DD"> </asp:TextBox>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtMonth" runat="server" required="" type="number" Min="1" Max="12" Placeholder="MM"></asp:TextBox>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtYear" runat="server" required="" type="number" Min="2017" Placeholder="YYYY"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Start Time
                            </label>
                            <div class="col-sm-6">
                                <div class="row">
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtHSTime" runat="server" placeholder="HH" min="01" max="12" type="Number"
                                            required=""></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtMSTime" runat="server" placeholder="MM" min="00" max="59" type="Number"
                                            required=""></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                End Time
                            </label>
                            <div class="col-sm-6">
                                <div class="row">
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtHETime" runat="server" placeholder="HH" min="01" max="12" type="Number"
                                            required=""></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtMETime" runat="server" placeholder="MM" min="00" max="59" type="Number"
                                            required=""></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Purpose
                            </label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtPurpose" TextMode="MultiLine" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <%--<asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>