<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="NurturingChat.aspx.cs" Inherits="Admin_NurturingChat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                      'Resolution Sent Successfully',
                      '',
                      'success'
                    )
        }
         </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <%-- <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>
    <!-- Row Start -->
    <div class="row">
        <div class="col-sm-6 col-xs-12 col-sm-offset-2">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Previous Service Requests & Resolutions
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
                                                        <%# Eval("Employee")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
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
                                                        <%# Eval("Participant")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
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
            <div class="widget" id="divMenterinputs" runat="server">
                <div class="form-horizontal no-margin">
                    <div class="widget-header">
                        <div class="title">
                            Resolution
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <asp:TextBox ID="txtChat" runat="server" TextMode="MultiLine" Height="120px"
                                placeholder="Enter Resolution in detail.">
                            </asp:TextBox>
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
                        <div class="form-group" id="divUpload" runat="server">
                            <label class="col-sm-2 control-label">
                                Upload File
                            </label>
                            <div class="col-sm-4">
                                <asp:FileUpload ID="flUpload" runat="server" />
                                <%--<asp:RequiredFieldValidator runat="server" ID="ReqFileUpload" ControlToValidate="flUpload" ErrorMessage="Upload Question Paper" ForeColor="Red" Font-Names="Verdana" Font-Size="10"></asp:RequiredFieldValidator>--%>
                            </div>
                            <div class="col-sm-6">
                                <small>( Max 10 MB )</small>
                            </div>
                        </div>
                    <div class="form-group">
                        <div class="col-sm-offset-3 col-sm-9">
                            <asp:Button ID="btnSend" runat="server" Text="Send Resolution" UseSubmitBehavior="false"
                                OnClick="btnSend_Click" />
                            <asp:Button ID="btnBack" runat="server" Text="Back To List" UseSubmitBehavior="false"
                                OnClick="btnBack_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
             <%--</ContentTemplate>
    </asp:UpdatePanel>--%>
    <!-- Row End -->
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function () {

            $("[id*=btnSend]").click(function () {


                var mesg = $("[id*=txtChat]").val();

                if (mesg.length == 0) {
                    alert('Please Enter Resolution');
                    $("[id*=txtChat]").focus();
                    //return false;
                }


            });
        });
    </script>
</asp:Content>

