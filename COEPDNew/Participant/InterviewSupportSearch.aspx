<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="InterviewSupportSearch.aspx.cs" Inherits="Participant_InterviewSupportSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Interview Support
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <%--<div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtParticipant" MaxLength="250" placeholder="Search By Participant" AutoPostBack="true" OnTextChanged="txtParticipant_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="250" placeholder="Search By location" AutoPostBack="true" OnTextChanged="txtLocation_TextChanged"></asp:TextBox>
                        </div>--%>
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Text="Sent" Value="True"></asp:ListItem>
                                <asp:ListItem Text="Pending" Value="False"></asp:ListItem>

                            </asp:DropDownList>
                        </div>
                        <%--<div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtEvaluatedBy" MaxLength="500" placeholder="Evaluated/Approved By" AutoPostBack="true" OnTextChanged="txtEvaluatedBy_TextChanged"></asp:TextBox>
                        </div>--%>

                        <%--<div class="col-lg-3  col-md-3">
                            <asp:Button ID="btnAdd" runat="server" SkinID="addnew" AutoPostBack="True" CausesValidation="false" OnClick="btnAdd_Click" />
                        </div>--%>

                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>

                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" Width="100%" PageSize="50" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender" OnRowDataBound="gv_RowDataBound">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Name" DataField="Participant" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Profile Owner" DataField="ProfileOwner" />
                                    <asp:BoundField HeaderText="Company Name" DataField="CompanyName" />
                                    <asp:BoundField HeaderText="Interview Status" DataField="InterviewStatus"  />
                                    <%--<asp:BoundField HeaderText="Location" DataField="Location" ItemStyle-Width="150px" />--%>
                                    <asp:TemplateField HeaderText="Case Study">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnSendFile" runat="server" Value='<%#Eval("CaseStudyPath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/InterviewSupport/"+ Eval("CaseStudyPath") %>' runat="server"
                                                ID="hplSendFile" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Inputs">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnReplyFile" runat="server" Value='<%#Eval("CaseStudyReplyPath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/InterviewSupport/"+ Eval("CaseStudyReplyPath") %>' runat="server"
                                                ID="hplReplyFile" Target="_blank" CssClass="btn btn-warning btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Requested On" DataField="CreatedOn" ItemStyle-Width="150px" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Interview Date" DataField="TargetDate" ItemStyle-Width="150px" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Sent By" DataField="ModifiedName" />
                                    <asp:BoundField HeaderText="Inputs Sent On" DataField="ModifiedOn" ItemStyle-Width="150px" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsApproved").ToString()) ? "Sent" : "Pending" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Green" Text="View" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("InterviewSupportId")%>'></asp:LinkButton>
                                            <%-- <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("RequestFAQsId")%>' OnClientClick="return confirm('Are you sure you want to delete this FAQs Request?');"></asp:LinkButton>--%>
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
                        <div>
                            <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                        </div>
                    </div>
                    <br />

                    <div class="row">
                        <div class="col-sm-offset-5 col-sm-10">
                            <asp:Button runat="server" ID="btnBack" Text="Back To Resume Submissions" OnClick="btnBack_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>

