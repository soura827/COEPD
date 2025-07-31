<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="InternParticipantSearch.aspx.cs" Inherits="Admin_InternParticipantSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
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
                       Internship Participants
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                      
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtSearch" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                       <div class="col-lg-1 col-md-1">
                           &nbsp;
                        </div>
                         <div class="col-lg-2 col-md-2">
                            <h4>Internship Batch</h4>
                        </div>
                        <div class="col-lg-4 col-md-4">
                            <asp:DropDownList ID="ddlInternbatch" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlInternBatch_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                       
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging"
                            OnRowDataBound="gv_RowDataBound" AllowPaging="true" PageSize="20" AutoGenerateColumns="False"
                            Width="100%">
                            <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("ParticipantId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                           Visible="false"  CommandArgument='<%#Eval("ParticipantId")%>' OnClientClick="return confirm('Are you sure you want to delete this Record?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                 <asp:BoundField HeaderText="Intern Batch Date" DataField="InternDate" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:BoundField HeaderText="ReferenceNo" DataField="ReferenceNo" />
                                <asp:BoundField HeaderText="Participant" DataField="Participant" ItemStyle-Width="200px" />
                                <asp:BoundField HeaderText="Email" DataField="Email" />
                                <asp:TemplateField HeaderText="Certificate" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" CommandName="cmdDownload"
                                            Visible="false" CommandArgument='<%#Eval("CertificatePath")%>'></asp:LinkButton>
                                        <asp:HiddenField ID="hdnCertificatePath" runat="server" Value='<%#Eval("CertificatePath")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Mobile" DataField="Mobile" ItemStyle-Width="50px" />
                               <%-- <asp:TemplateField HeaderText="Send Pwd" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkSend" runat="server" Text="SendPwd" CommandName="cmdSend"
                                            CommandArgument='<%#Eval("ParticipantId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                            </Columns>
                            <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
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