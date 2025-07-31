<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ChangePasswordSearch.aspx.cs" Inherits="Admin_ChangePasswordSearch" %>

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
                        Change Password Details
                    </div>
                </div>

                <div class="widget-body">


                    <div class="row">




                        <%--                        <div class="col-md-2">
                            <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" AutoPostBack="true" OnTextChanged="txtFromDate_TextChanged"></asp:TextBox>
                        </div>

                        <div class="col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" AutoPostBack="true" OnTextChanged="txtToDate_TextChanged"></asp:TextBox>
                        </div>--%>






                        <div class="col-lg-2  col-md-2">
                            <asp:Button ID="btnAddNew" runat="server" SkinID="AddNew" AutoPostBack="True" CausesValidation="false" OnClick="btnAddNew_Click" />
                        </div>
                    </div>















                    <div class="row">
                        &nbsp;
                    </div>


                    <div class="row">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="100" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" OnRowDataBound="gv_RowDataBound" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">
                            <Columns>
                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                <asp:BoundField HeaderText="User Name" DataField="Fullname" />
                                <asp:BoundField HeaderText="Pass Word" DataField="NewPassword" />
                                <asp:TemplateField HeaderText="Send Pwd" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkSend" runat="server" Text="SendPwd" SkinID="Orange" CommandName="cmdSend"
                                            CommandArgument='<%#Eval("ResetId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <%--           <asp:BoundField HeaderText="Awareness Session" DataField="Fullname" />
                                <asp:BoundField HeaderText="ModifiedOn" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy }" />
                                <asp:BoundField HeaderText="ModifiedBy" DataField="ModifiedBy"/>--%>


                                <%--       <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("SessionId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("SessionId")%>' OnClientClick="return confirm('Are you sure you want to delete this ActivityCategory?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                            </Columns>
                        </asp:GridView>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

