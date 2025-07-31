<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="PlacementServiceRequestSearch.aspx.cs" Inherits="Admin_PlacementServiceRequestSearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                BA Job market  Service Requests
                            </div>
                            </div>
                        <br />
                           <div class="col-lg-2 col-md-3 col-sm-6">
                                     <div class="mini-widget  mini-widget">
                                        <div class="mini-widget-heading clearfix">
                                            <div class="text-center">
                                                 Interview Support Requests
                                            </div>
                                        </div>
                                     <div class="mini-widget-body clearfix">
                                        <div class="pull-left">
                                            <i class="fa fa-user-circle"></i>
                                        </div>
                                        <div class="pull-right number">
                                            <asp:Literal ID="ltlInterviewSupport" runat="server" />
                                        </div>
                                     </div>
                                    <div class="mini-widget-footer center-align-text " style="background-color:lavender;">
                                        <asp:Button runat="server" ID="btnInterviewSupport" Text="View Details" OnClick="btnInterviewSupport_Click"/>
                                    </div>
                                  </div>
                              </div>
                        <br />
                           <div class="row">
                                &nbsp;
                            </div>     

                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtParticipant" MaxLength="500" placeholder="Participant-Name,Email,Mobile,ID" AutoPostBack="true" OnTextChanged="txtParticipant_TextChanged"></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtLocation" MaxLength="500" placeholder="Location" AutoPostBack="true" OnTextChanged="txtLocation_TextChanged"></asp:TextBox>
                                </div>
                                <div class="col-md-2 col-lg-2">
                                    <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                        <asp:ListItem Text="Not Replied" Value="False"></asp:ListItem>
                                        <asp:ListItem Text="Replied" Value="True"></asp:ListItem>
                                    </asp:DropDownList>
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
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="100" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender" OnRowDataBound="gv_RowDataBound">
                                    <Columns>
                                        <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                        <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                        <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                        <asp:BoundField HeaderText="Email" DataField="Email" />
                                        <asp:BoundField HeaderText="Location" DataField="Location" />
                                        <asp:BoundField HeaderText="Profile Owner Name" DataField="Employee" />
                                        <asp:BoundField HeaderText="Message" DataField="ServiceRequest" />
                                           <asp:TemplateField HeaderText="View File From Participant">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnSendFile" runat="server" Value='<%#Eval("SenderImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/PlacementServiceRequests/"+ Eval("SenderImagePath") %>' runat="server"
                                                ID="hplSendFile" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="View File From Mentor">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnReplyFile" runat="server" Value='<%#Eval("ReceiverImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/PlacementServiceRequests/"+ Eval("ReceiverImagePath") %>' runat="server"
                                                ID="hplReplyFile" Target="_blank" CssClass="btn btn-warning btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Status">
                                            <ItemTemplate>
                                                <%# (Boolean.Parse(Eval("IsReplied").ToString()) ? "Replied" : "Not Replied" )%>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Replied By" DataField="ModifiedName" />
                                  <asp:BoundField HeaderText="Replied On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                    CommandArgument='<%#Eval("PlacementServiceRequestId")%>'></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
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
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

