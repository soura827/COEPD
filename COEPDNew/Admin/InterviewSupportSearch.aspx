<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="InterviewSupportSearch.aspx.cs" Inherits="Admin_InterviewSupportSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtParticipant" MaxLength="250" placeholder="Participant-Name,Email,Mobile,Reference NO." AutoPostBack="true" OnTextChanged="txtParticipant_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="250" placeholder="Search By location" AutoPostBack="true" OnTextChanged="txtLocation_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Text="Pending" Value="False"></asp:ListItem>
                                <asp:ListItem Text="Sent" Value="True"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <%--<div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtEvaluatedBy" MaxLength="500" placeholder="Evaluated/Approved By" AutoPostBack="true" OnTextChanged="txtEvaluatedBy_TextChanged"></asp:TextBox>
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
                                    <asp:BoundField HeaderText="Email" DataField="Email" />
                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile"/>
                                    <asp:BoundField HeaderText="Location" DataField="Location" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Profile Owner" DataField="ProfileOwner" />
                                    <asp:BoundField HeaderText="Batch" DataField="StartDate" DataFormatString="{0: dd MMM yyyy}"  />
                                    <asp:BoundField HeaderText="Trainer" DataField="Employee"  />
                                    <asp:BoundField HeaderText="Total Exp." DataField="TotalExperience" />
                                     <asp:BoundField HeaderText="Rel. Exp." DataField="RelevantExperience" />
                                     <asp:BoundField HeaderText="Experience Domain" DataField="JobExperienceDomain" />
                                     <asp:BoundField HeaderText="Expected Domain" DataField="JobExpectedDomain" />
                                    <asp:BoundField HeaderText="Company Name" DataField="CompanyName"  />
                                    <asp:BoundField HeaderText="Interview Status" DataField="InterviewStatus"  />
                                    <asp:TemplateField HeaderText="Casestudy">
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
                                     <asp:BoundField HeaderText="Target Date" DataField="TargetDate" ItemStyle-Width="150px" DataFormatString="{0: dd MMM yyyy}" />
                                     <asp:TemplateField HeaderText="Assign To Mentor" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkAssign" runat="server" SkinID="Orange" Text="Assign To Mentor" CommandName="cmdAssign"
                                                CommandArgument='<%#Eval("InterviewSupportId")%>' Visible='<%#(Boolean.Parse(Eval("IsMentorAssigned").ToString()) ? false:true) %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Assigned To" DataField="MentorName" />
                                    <asp:BoundField HeaderText="Assigned On" DataField="MentorAssignedOn" ItemStyle-Width="150px" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Sent By" DataField="ModifiedName"  />
                                    <asp:BoundField HeaderText="Inputs Sent On" DataField="ModifiedOn" ItemStyle-Width="150px" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                     <asp:TemplateField HeaderText="Is Mentor Assigned">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsMentorAssigned").ToString()) ? "Assigned" : "Not Assigned" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsApproved").ToString()) ? "Sent" : "Pending" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Interview Support" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Green" Text="Send Interview Support" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("InterviewSupportId")%>' Visible='<%#(Boolean.Parse(Eval("IsApproved").ToString()) ? false:true) %>'></asp:LinkButton>
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
                </div>
        </div>
    </div>
    </div>
</asp:Content>

