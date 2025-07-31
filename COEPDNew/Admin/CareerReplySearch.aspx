<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="CareerReplySearch.aspx.cs" Inherits="CareerReplySearch" %>
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
                        COEPD Job Opening Responses 
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <%--we are getting  required Fileds(aspirants)  from database displaying in GridView as per requirement --%>
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" OnRowDataBound="gv_RowDataBound"
                            Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("CareerReplyId")%>' OnClientClick="return confirm('Are you sure you want to delete this COEPD Job Response?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Name" DataField="Name" />
                                <asp:BoundField HeaderText="Father's Name" DataField="FatherName" visible="false"/>
                                <asp:BoundField HeaderText="Email" DataField="ReasonForChange" />
                                <asp:BoundField HeaderText="Mobile" DataField="ResidentialAddress" />
                                <asp:TemplateField HeaderText="View Resume">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkView" runat="server" CommandName="cmdView" SkinID="view" Text="View"
                                            CommandArgument='<%#Eval("CareerReplyId") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Download Resume">
                                    <ItemTemplate>
                                        <asp:HyperLink runat="server" ID="hplFile" Target="_blank" CssClass="btn btn-info btn-xs" NavigateUrl='<%# "~/UserDocs/" + Eval("ImagePath")%>'>Download</asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:BoundField HeaderText="Date Of Application" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="Position Applied for" DataField="AppliedFor" />
                                <asp:BoundField HeaderText="Years Of Relevant Experience" DataField="RelavantExperience" />
                            </Columns>
                            <EmptyDataTemplate><%--This Template is uded to display the message when no records find--%>
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
    <!-- Row End -->
    <div class="container">
        <!-- Trigger the modal with a button -->
        <!-- Modal -->
        <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h2>
                            <asp:Label ID="lblName" runat="server"></asp:Label></h2>
                    </div>
                    <div class="modal-body">
                        <div class="widget-body">
                            <div class="form-horizontal no-margin">
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Date of Birth
                                    </label>
                                    <div class="col-sm-3">
                                        <h5>
                                            <asp:Label ID="lblDOB" runat="server"></asp:Label></h5>
                                    </div>
                                    <label class="col-sm-3 control-label">
                                        Qualifications
                                    </label>
                                    <div class="col-sm-3">
                                        <h5>
                                            <asp:Label ID="lblQualification" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Email
                                    </label>
                                    <div class="col-sm-3">
                                        <h5>
                                            <asp:Label ID="lblReason" runat="server"></asp:Label></h5>
                                    </div>                                   
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Date of Application
                                    </label>
                                    <div class="col-sm-4">
                                        <h5>
                                            <asp:Label ID="lblDateOfApplication" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Mobile
                                    </label>
                                    <div class="col-sm-9">
                                        <h5>
                                            <asp:Label ID="lblAddress" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Post Applied For
                                    </label>
                                    <div class="col-sm-9">
                                        <h5>
                                            <asp:Label ID="lblAppliedFor" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Total Experience
                                    </label>
                                    <div class="col-sm-3">
                                        <h5>
                                            <asp:Label ID="lblTotalExp" runat="server"></asp:Label></h5>
                                    </div>
                                    <label class="col-sm-3 control-label">
                                        Relavent Experience
                                    </label>
                                    <div class="col-sm-3">
                                        <h5>
                                            <asp:Label ID="lblRelevantExp" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Skills
                                    </label>
                                    <div class="col-sm-9">
                                        <h5>
                                            <asp:Label ID="lblSkills" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Strengths
                                    </label>
                                    <div class="col-sm-9">
                                        <h5>
                                            <asp:Label ID="lblStrengths" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Company Address
                                    </label>
                                    <div class="col-sm-9">
                                        <h5>
                                            <asp:Label ID="lblCompanyAddress" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Present CTC
                                    </label>
                                    <div class="col-sm-3">
                                        <h5>
                                            <asp:Label ID="lblPresentCTC" runat="server"></asp:Label></h5>
                                    </div>
                                    <label class="col-sm-3 control-label">
                                        Expected CTC
                                    </label>
                                    <div class="col-sm-3">
                                        <h5>
                                            <asp:Label ID="lblExpectedCTC" runat="server"></asp:Label></h5>
                                    </div>
                                </div>
                                <%-- <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Resume
                                    </label>
                                    <div class="col-sm-3">
                                        <asp:HyperLink ID="hplFile" runat="server" Target="_blank" CssClass="btn btn-info btn-xs">Download</asp:HyperLink>
                                    </div>
                                </div>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>