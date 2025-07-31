<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="PlacementEscalation.aspx.cs" Inherits="Participant_PlacementEscalation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                      'Escalation Sent Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeDuplicate() {
            Swal.fire('Your Escalation already received Placement Team. Thanks. You will receive response in 24 working hours.',
                '',
                'warning'
                )
        }
         </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <%--<asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>
            <div class="row">
                <div class="col-lg-6 col-md-6">
                    <div class="widget" id="divMenterinputs" runat="server">
                        <div class="form-horizontal no-margin">
                            <div class="widget-header">
                                <div class="title">
                                    Enter Escalation (Minimum 100 characters)
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <asp:TextBox ID="txtChat" runat="server" required="" TextMode="MultiLine" Height="200px"
                                        placeholder="Enter Escalation in detail (Minimum 100 characters)" AutoPostBack="true" OnTextChanged="txtChat_TextChanged">
                                    </asp:TextBox>
                                    <asp:RegularExpressionValidator ID="revtxtChat" runat="server" ValidationExpression="^[\s\S]{100,}$" ControlToValidate="txtChat" ErrorMessage="Enter Escalation in detail - Minimum 100 characters" ForeColor="Red" Font-Bold="true"></asp:RegularExpressionValidator>
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
                            <div class="form-group">
                                <div class="col-sm-offset-3 col-sm-9">
                                    <asp:Button ID="btnSend" runat="server" Text="Send Escalation"
                                        OnClick="btnSend_Click" />
                                    <asp:Button ID="btnBack" runat="server" Text="Back To Dashboard" UseSubmitBehavior="false"
                                        OnClick="btnBack_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            <div class="col-lg-6 col-md-6">
                 <div class="widget">
                    <div class="widget-header">
                        <div class="title">
                            Previous Escalations & Resolutions
                        </div>
                    </div>
                    <div class="widget-body" style="height: 300px; overflow-y: scroll">
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
                                                            <%# Eval("Escalation") %></span>
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
                                                            <%# Eval("Escalation") %>
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
            <%-- </ContentTemplate>
    </asp:UpdatePanel>--%>
         <script type="text/javascript">
        jQuery(document).ready(function () {

            $("[id*=btnSend]").click(function () {
                var mesg = $("[id*=txtChat]").val();

                if (mesg.length < 100) {
                    alert('Please Enter Escalation in detail (Minimum 100 characters).');
                    $("[id*=txtChat]").focus();
                    //return false;
                }
            });
        });
    </script>
</asp:Content>

