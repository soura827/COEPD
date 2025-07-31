<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="HrServiceRequest.aspx.cs" Inherits="Participant_HrServiceRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'Hr Service Desk received your request. Thanks. You will receive response in 24 working hours.',
                '',
                'success'
            )
        }
        function alertmeDuplicate() {
            Swal.fire(
                'Hr Service Desk aleardy received your request. Thanks. You will receive response in 24 working hours.',
                '',
                'warning'
            )
        }
        function alertmeBeforeEscalation() {
            Swal.fire(
                'You can escalate on this Service Request only after 32 hours.',
                '',
                'warning'
            )
        }
        function alertmeAfterEscalation() {
            Swal.fire(
                'You can Escalate only before 2 days of Response of Service Request.',
                '',
                'warning'
            )
        }
    </script>
    <style type="text/css">
        #ltlNews {
            font-size: 100px;
            font-family: 'Roboto';
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>--%>
    <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">--%>
    <%--<ContentTemplate>--%>
    <div class="row">

        <div class="col-lg-6 col-md-6">
            <div class="widget">
                <div class="form-horizontal no-margin">
                    <div class="widget-header">
                        <div class="title">
                            Contact Hr Team (Service Request Minimum 100 characters)
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <asp:TextBox ID="txtChat" runat="server" required="" TextMode="MultiLine" Height="200px"
                                placeholder="Dear Nurturing Team, I (StudentName), of Batch (Batch date) have completed 26 Online exams with 90% on (Date). Please verify these exams and Score. Kindly assign me the first Capstone project on waterfall approach. I will start working on Capstone Projects." AutoPostBack="true" OnTextChanged="txtChat_TextChanged">
                            </asp:TextBox>
                            <asp:RegularExpressionValidator ID="retxtChat" runat="server" ControlToValidate="txtChat" ValidationExpression="^[\s\S]{100,}$" ErrorMessage="Enter Service Request in detail - Minimum 100 characters" ForeColor="Red" Font-Bold="true"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="form-group" id="divUpload" runat="server">
                        <label class="col-sm-3 control-label">
                            Upload File (Optional):
                        </label>
                        <div class="col-sm-4">
                            <asp:FileUpload ID="flUpload" runat="server" />
                            <%--<asp:RequiredFieldValidator runat="server" ID="ReqFileUpload" ControlToValidate="flUpload" ErrorMessage="Upload Question Paper" ForeColor="Red" Font-Names="Verdana" Font-Size="10"></asp:RequiredFieldValidator>--%>
                        </div>
                        <div class="col-sm-3">
                            <small>( Max 10 MB )</small>
                        </div>
                    </div>
                    <%--<div class="form-group">
                        <label id="lblcount" style="background-color:#E2EEF1;color:Red;font-weight:bold;">140</label>
                    </div>--%>
                    <div class="form-group">
                        <div class="col-sm-offset-3 col-sm-9">
                            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Send Service Request" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <asp:Label ID="lblService" runat="server" Text="Note: Please refer to library section and check your required info is available. You can send next service request only after 24 hours, please ensure you kept all information in this message. Enter Service Request in detail (Minimum 100 characters)."></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div class="col-lg-6 col-md-6">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Previous Service Requests & Resolutions
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
                                                <img class="avatar" alt="" src="../img/profile.png" />
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Participant")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy hh:mm tt}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Chat") %></span>
                                                </div>
                                            </li>
                                        </asp:Panel>
                                        <asp:Panel ID="PnlOut" runat="server" Visible="false">
                                            <li class="out">
                                                <img class="avatar" alt="" src="../img/profile.png">
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Employee")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy hh:mm tt}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Chat") %>
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
        </div>

    </div>
    <div class="row">
        <div class="col-lg-6 col-md-6">
            <div class="widget">
                <div class="form-horizontal no-margin">
                    <div class="widget-header">
                        <div class="title">
                            Do you want to Escalate?
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-3 control-label">
                            Last Service Request
                        </label>
                        <div class="col-sm-9">
                            <h5>:
                                <asp:Label ID="lblLastServiceRequest" runat="server"></asp:Label>
                            </h5>
                            <asp:HiddenField ID="hdnNurturingChatId" runat="server" />
                            <asp:HiddenField ID="hdnCreatedOn" runat="server" />
                        </div>
                    </div>
                    <div class="form-group" id="divAttachments" runat="server">
                        <label class="col-sm-2 control-label">
                            Attachments
                        </label>
                        <div class="col-sm-9">
                            <h5>
                                <asp:HyperLink ID="hplSentFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">View File From Participant </asp:HyperLink>
                                <asp:HyperLink ID="hplReplyFile" runat="server" CssClass="btn btn-primary btn-sm" Target="_blank">View File From Mentor </asp:HyperLink>
                            </h5>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-3 col-sm-9">
                            <asp:Button ID="btnEscalate" runat="server" Text="Escalate" SkinID="delete" CssClass="btn btn-warning btn-md" UseSubmitBehavior="false" CausesValidation="false" OnClick="btnEscalate_Click" />
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        jQuery(document).ready(function () {

            $("[id*=btnSubmit]").click(function () {
                var mesg = $("[id*=txtChat]").val();

                if (mesg.length < 100) {
                    alert('Please describe your challenge completly in Service Request in  minimum 100 Characters.');
                    $("[id*=txtChat]").focus();
                    //return false;
                }
            });
        });
    </script>
    <%--        </ContentTemplate>

    </asp:UpdatePanel>--%>
</asp:Content>

