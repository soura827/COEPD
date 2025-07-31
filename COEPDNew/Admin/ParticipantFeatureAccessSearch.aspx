<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true" CodeFile="ParticipantFeatureAccessSearch.aspx.cs" Inherits="FeatureAccessParticipantSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--Row Start-->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Assign Features To Paricipants
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-1 col-md-2">
                            <h5><b>Module</b></h5>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlParticipantModule" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlParticipantModule_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-4 col-md-2">
                            <%--<div class="form-group" id="divParticipant" runat="server">--%>
                            <label class="col-sm-3 ">
                                <asp:Label runat="server" ID="lblPartcipant" Text="Participant" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </label>
                            <div class="col-sm-7">
                                <asp:TextBox ID="txtSearch" runat="server" required="required"></asp:TextBox>
                            </div>
                            <div class="col-sm-2">
                                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="col-lg-4 col-md-2">
                            <label class="col-sm-5 ">
                                <h5><b>Select Participant</b></h5>
                            </label>
                            <div class="col-sm-7">
                                <asp:DropDownList ID="ddlParticipant" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlParticipant_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <%--<div class="col-lg-1 col-md-1">
                            <h5>
                                Participant</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlParticipant" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlParticipant_SelectedIndexChanged1">
                            </asp:DropDownList>
                        </div>--%>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6">
                            <div class="row col-lg-offset-3">
                                <h4>Available Features
                                </h4>
                            </div>
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" OnRowCommand="gv_RowCommand">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Paricipant Feature" DataField="Feature" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="Assign Feature" CommandName="cmdAdd"
                                                CssClass="btn btn-primary" CommandArgument='<%#Eval("FeatureId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate>
                                    <%--This Template is uded to display the message when no records find--%>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                        </div>
                        <div class="col-lg-6 col-md-6">
                            <div class="row col-lg-offset-3">
                                <h4>Assigned Features
                                </h4>
                            </div>
                            <asp:GridView ID="gvAssign" runat="server" AutoGenerateColumns="False" Width="100%"
                                OnRowCommand="gvAssign_RowCommand">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Paricipant Feature" DataField="Feature" />
                                    <asp:TemplateField HeaderText="Remove " ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="Remove Feature " CommandName="cmdRemove"
                                                CssClass="btn btn-info" CommandArgument='<%#Eval("FeatureAccessId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                                <EmptyDataTemplate>
                                    <%--This Template is uded to display the message when no records find--%>
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
                            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back To Participants Page" UseSubmitBehavior="false" />
                            <asp:Button ID="btnGoToExamCategory" runat="server" SkinID="btnBack" OnClick="btnGoToExamCategory_Click" Text="Go to Exam Category Assignment" UseSubmitBehavior="false" />
                        </center>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--Row End-->
</asp:Content>

