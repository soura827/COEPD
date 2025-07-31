<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantStageStatusCodeSearch.aspx.cs" Inherits="Admin_ParticipantStageStatusCodeSearch" EnableEventValidation="false"  %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc1" TagName="FormMessage" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc2" TagName="ErrorMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
     <uc1:FormMessage runat="server" ID="FormMessage" Visible="false" />
    <uc2:ErrorMessage runat="server" ID="ErrorMessage" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Row Start -->
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="updatepanel" runat="server">
        <ContentTemplate>
            <div class="Row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                 <asp:Label ID="lblTitle" runat="server" ></asp:Label>
                            </div>
                        </div>
                        <div class="widget-body">
                            <div class="Row">
                                <div class="col-lg-3 col-md-3">
                                    <asp:TextBox runat="server" ID="txtStatusName" Placeholder="ParticipantStatusName" AutoPostBack="true" OnTextChanged="txtParticipantName_TextChanged"></asp:TextBox>
                                </div>
                                 
                                <div class="col-lg-3 col-md-3">
                                    <asp:TextBox runat="server" ID="txtStatusCode" AutoPostBack="true" OnTextChanged="txtStatusCode_TextChanged" Visible="false"  ></asp:TextBox>
                                </div>
                               <div class="col-lg-2 col-md-2">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
                                 </div>
                            </div>
                            <div>
                                &nbsp;
                            </div>
                            <div>
                                &nbsp;
                            </div>
                            
                 
                            <div>
                                <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                            </div>
                            <div class="Row">
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="100" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" OnRowCommand="gv_RowCommand" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                    <Columns>
                                        <asp:BoundField HeaderText="S NO" DataField="SNO" />
                                        <asp:BoundField HeaderText="ParticipantName" DataField="Participant" />
                                        <asp:BoundField HeaderText="ReferenceNo" DataField="ReferenceNo" />
                                        <asp:BoundField HeaderText="Batch Date" DataField="StartDate"  DataFormatString="{0: dd MMM yyyy hh:mm tt}"/>
                                          <asp:BoundField HeaderText="Trainer Name" DataField="Employee" />
                                        <asp:BoundField HeaderText="StatusName" DataField="StatusName" />
                                        <asp:BoundField HeaderText="StatusCode" DataField="StatusCode" />
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                    CommandArgument='<%#Eval("ParticipantId")%>'></asp:LinkButton>
                                                <%--<asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("KPIId")%>' OnClientClick="return confirm('Are you sure you want to delete this KPI?');"></asp:LinkButton>--%>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                <div>
                                    <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-offset-5 col-sm-10">
                                    <asp:Button runat="server" ID="btnBack" Text="Back To Dashboard" OnClick="btnBack_Click" />
                                </div>
                            </div>
                            <br />
                        </div>
                    </div>

                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <!-- Row End -->
</asp:Content>

