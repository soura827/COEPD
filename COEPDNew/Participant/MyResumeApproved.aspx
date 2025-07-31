<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master"
    AutoEventWireup="true" CodeFile="MyResumeApproved.aspx.cs" Inherits="MyResumeApproved" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-sm-8 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Approved Resume
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                       <div class="form-group">
                            <label class="col-sm-4 control-label">
                                Hr Status
                            </label>
                            <div class="col-sm-8">
                                 <h5>
                                    <asp:Label ID="lblHrStatus" runat="server" Text=""></asp:Label></h5>
                            </div>
                        </div>
                        <div class="form-group" id="divGrid" runat="server">
                            <label class="col-sm-4 control-label">
                              Sample  Questions
                            </label>
                            <div class="col-sm-8">
                                <asp:GridView ID="gv" runat="server" CellPadding="2" ForeColor="#333333" OnRowCommand="gv_RowCommand" GridLines="Horizontal" AutoGenerateColumns="false"   >
                                   <Columns>
                                       <asp:BoundField HeaderText="File Name" DataField="SampleQuestionsName"  />
                                       <asp:TemplateField HeaderText="Action" ItemStyle-Width="30%">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkDownload" runat="server"  CommandName="cmdDownload"
                                            CommandArgument='<%#Eval("SampleQuestionsPath")%>' Text="Download" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                   </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                         <div class="form-group" id="divSampleQustns" runat="server">
                            <label class="col-sm-4 control-label">
                                Sample Questions Request?
                            </label>
                            <div class="col-sm-8">
                                <asp:Button ID="btnSampleQuestions" runat="server" CssClass="btn btn-success btn-sm"  OnClick="btnSampleQuestions_Click"  Text="Yes" UseSubmitBehavior="false" /> &nbsp; &nbsp; &nbsp;<asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                              Participant Resume
                            </label>
                            <div class="col-sm-8">
                                <asp:HyperLink ID="hplResumeView" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">View</asp:HyperLink>
                                <asp:HyperLink ID="hplResumeDownload" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank">Download</asp:HyperLink>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                               Approved By
                            </label>
                            <label class="col-sm-8">
                                    <asp:Label ID="lblApprovedBy" runat="server" Text=""></asp:Label>
                            </label>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                               Approved Date
                            </label>
                            <label class="col-sm-8">
                                    <asp:Label ID="lblApprovedDate" runat="server"  Text=""></asp:Label>
                            </label>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                                Job Experience Domain 
                            </label>
                            <label class="col-sm-8">
                                <h5>
                                    <asp:Label ID="lblJobExpDomain" runat="server" Text=""></asp:Label></h5>
                            </label>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                                Job Expected Domain 
                            </label>
                            <label class="col-sm-8">
                                <h5>
                                    <asp:Label ID="lblJobExpectedDomain" runat="server" Text=""></asp:Label></h5>
                            </label>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                                Exp In Years
                            </label>
                            <label class="col-sm-8">
                                <h5>
                                    <asp:Label ID="lblExpInYears" runat="server" Text=""></asp:Label></h5>
                            </label>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                                Expected Salary
                            </label>
                            <label class="col-sm-8">
                                <h5>
                                    <asp:Label ID="lblExpectedSalary" runat="server" Text=""></asp:Label></h5>
                            </label>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                                Prefered Locations 
                            </label>
                            <label class="col-sm-8">
                                <h5>
                                    <asp:Label ID="lblPreferedLocations" runat="server" Text=""></asp:Label></h5>
                            </label>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                                List of Competencies 
                            </label>
                            <label class="col-sm-8">
                                <h5>
                                    <asp:Label ID="lblListOfCompetencies" runat="server" Text=""></asp:Label></h5>
                            </label>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                                Skills
                            </label>
                            <label class="col-sm-8">
                                <h5>
                                    <asp:Label ID="lblSkills" runat="server" Text=""></asp:Label></h5>
                            </label>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-4 control-label">
                                Comments
                            </label>
                            <div class="col-sm-8">
                                <h5>
                                    <asp:Label ID="lblComments" runat="server" Text=""></asp:Label></h5>
                            </div>
                        </div>
                       <div class="form-group">
                            <label class="col-sm-4 control-label">
                               
                            </label>
                            <div class="col-sm-8">
                                <h5>
                                <asp:Button ID="btnBackToDashboard" runat="server" SkinID="delete" CssClass="btn btn-danger btn-md" Text="Back To Dashboard" OnClick="btnBackToDashboard_Click" UseSubmitBehavior="false" />
                                    
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-4 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Chats
                    </div>
                </div>
                <div class="widget-body" style="height: 350px; overflow-y: scroll">
                    <div class="viewport">
                        <div class="overview">
                            <ul class="chats">
                                <asp:Repeater ID="rp" runat="server" OnItemDataBound="rp_OnItemDataBound">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnRoleId" runat="server" Value='<%# Eval("RoleId")%>' />
                                        <asp:Panel ID="pnlIn" runat="server" Visible="false">
                                            <li class="in">
                                                <img class="avatar" alt="" src="../img/student1.png" />
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Participant")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
                                                    </span><span class="body">
                                                        <%# Eval("ResumeChat") %></span>
                                                </div>
                                            </li>
                                        </asp:Panel>
                                        <asp:Panel ID="PnlOut" runat="server" Visible="false">
                                            <li class="out">
                                                <img class="avatar" alt="" src="../img/mentor.jpg">
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Employee")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
                                                    </span><span class="body">
                                                        <%# Eval("ResumeChat") %>
                                                    </span>
                                                </div>
                                            </li>
                                        </asp:Panel>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
             <div class="widget">
                <div class="form-horizontal no-margin">
                    <div class="widget-header">
                        <div class="title">
                            Contact Evaluator
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Height="100px"
                                placeholder="Enter Details">
                            </asp:TextBox>
                            <asp:HiddenField ID="hdnId" runat="server" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-3 col-sm-9">
                            <asp:Button ID="btnSend" runat="server" Text="Send Request" UseSubmitBehavior="false"
                                OnClick="btnSend_Click" />
                        </div>
                    </div>
                </div>
            </div>
    </div>
    <!-- Row End -->
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
        <script type="text/javascript">
        jQuery(document).ready(function () {

            $("[id*=btnSend]").click(function () {
                var mesg = $("[id*=txtNotes]").val();

                if (mesg.length == 0) {
                    alert('Please Enter your Query');
                    $("[id*=txtNotes]").focus();
                    //return false;
                }
            });
        });
    </script>
</asp:Content>
