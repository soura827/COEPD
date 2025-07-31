<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master"
    AutoEventWireup="true" CodeFile="MyResume.aspx.cs" Inherits="MyResume" %>
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
                        My Resume
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            
                            <div class="col-sm-3">
                                <label class="col-sm-12 text-right">
                                    <i><span style="color: red">*</span> indicates manditory field</i>
                                </label>
                            </div>
                            <div class="col-sm-3"></div>
                            <div class="col-sm-6">
                                <label class="col-sm-12 text-right">
                                    <i><span style="color: red">Note</span>: Resumes can be uploaded/Modified until it is approved</i>
                                </label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3" style="text-align: right">
                                Resume Status
                            </label>
                            <label Id="lblStatus" runat="server" class="col-sm-9">
                               
                            </label>
                            
                        </div>
                         <div class="form-group" Id="divGrid" runat="server">
                            <label class="col-sm-3 control-label">
                              Sample  Resume
                            </label>
                            <div class="col-sm-9">
                                <div class="table-responsive">
                                <asp:GridView ID="gv" runat="server" CellPadding="2" ForeColor="#333333" OnRowCommand="gv_RowCommand" GridLines="Horizontal" AutoGenerateColumns="false"   >
                                   <Columns>
                                       <asp:BoundField HeaderText="File Name" DataField="SampleResumeName"  />
                                       <asp:TemplateField HeaderText="Action" ItemStyle-Width="30%">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" CommandName="cmdDownload"
                                            CommandArgument='<%#Eval("SampleResumePath")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                   </Columns>
                                   
                                </asp:GridView>
                                    </div>
                          </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Job Experience Domain 
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtExperienceDomain" runat="server" palceholder="Enter Experience Domain" Text="Banking"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Job Expected Domain 
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtJobExpectedDomain" runat="server" placeholder="Enter Expected Domain" Text="Banking"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Exp In Years<span style="color: red">*</span>
                            </label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="ddlExpInYears" runat="server">
                                    <asp:ListItem Text="-- select --" Value="" ></asp:ListItem>
                                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                    <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                    <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                    <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                    <asp:ListItem Text="15" Value="15"></asp:ListItem>
                                    <asp:ListItem Text="16" Value="16"></asp:ListItem>
                                    <asp:ListItem Text="17" Value="17"></asp:ListItem>
                                    <asp:ListItem Text="18" Value="18"></asp:ListItem>
                                    <asp:ListItem Text="19" Value="19"></asp:ListItem>
                                    <asp:ListItem Text="20" Value="20"></asp:ListItem>
                                    <asp:ListItem Text="21" Value="21"></asp:ListItem>
                                    <asp:ListItem Text="22" Value="22"></asp:ListItem>
                                    <asp:ListItem Text="23" Value="23"></asp:ListItem>
                                    <asp:ListItem Text="24" Value="24"></asp:ListItem>
                                    <asp:ListItem Text="25" Value="25"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Expected Salary
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtExpectedSalary" Type="number" placeholder="Enter Expected Salary" min="0" runat="server" Text=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Prefered Locations 
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtPreferedLocation" placeholder="Enter Prefered Locations" runat="server" Text=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                List of Competencies 
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtListOfCompetencies" palceholder="Enter Competencies" runat="server" Text=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Skills<span style="color: red">*</span>
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtSkills" runat="server" placeholder="Enter Your Skills" Text=""></asp:TextBox>
                            </div>
                        </div>
                             <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Uploded Resume
                            </label>
                            <div class="col-sm-9">
                                <asp:HyperLink ID="hp1ViewResumeFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">View</asp:HyperLink>
                                <asp:HyperLink ID="hplDownLoadFile" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank">Download</asp:HyperLink>
                            </div>
                        </div>
                        <div class="form-group" id="FileUpload1" runat="server">
                            <label class="col-sm-3 control-label">
                                Upload New Profile<span style="color: red">*</span>
                            </label>
                            <div class="col-sm-9">
                                <asp:FileUpload ID="flUpload" runat="server" /><small>(Max 10 MB)</small>
                            </div>
                        </div>
                        <div class="form-group" id="divResumeRequest" runat="server">
                            <label class="col-sm-3 control-label">
                                Sample Resumes Required?
                            </label>
                            <div class="col-sm-9">
                                <asp:Button ID="btnSampleResumes" runat="server" CssClass="btn btn-success btn-sm"  OnClick="btnSampleResumes_Click"  Text="Yes" UseSubmitBehavior="false" /> &nbsp; &nbsp; &nbsp;<asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Comments
                            </label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txtComments" runat="server" TextMode="MultiLine" placeholder="Enter Your Comments Here" Text=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnSubmit" runat="server" Text="Update Profile" OnClick="btnSubmit_Click" OnClientClick="return confirm('Your profile already existing. Do you want to replace it?');" />
                                <%--<asp:Button ID="btnCancel" runat="server" SkinID="delete" CssClass="btn btn-warning btn-md" Text="Clear All" UseSubmitBehavior="false" />--%>
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
                            <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Height="200px"
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