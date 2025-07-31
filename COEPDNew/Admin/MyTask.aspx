<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="MyTask.aspx.cs" Inherits="Task" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-8 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Task Name
                            </label>
                            <div class="col-sm-10">
                                <asp:Label runat="server" ID="lblText"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Priority
                            </label>
                            <div class="col-sm-10">
                                <asp:Label ID="lblPriority" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Description
                            </label>
                            <div class="col-sm-10">
                                <asp:Label ID="lblDescription" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                &nbsp;
                            </label>
                            <div class="col-sm-10">
                                <asp:Button ID="btnProgress" runat="server" Text="In Progress" OnClick="btnProgress_Click" />
                                <asp:Button ID="btnComplete" runat="server" Text="Completed" OnClick="btnComplete_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-4 col-md-12">
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
                                <asp:Repeater ID="rp" runat="server" OnItemDataBound="rp_ItemDataBound">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnInserted" runat="server" Value='<%# Eval("InsertedBy")%>' />
                                        <asp:Panel ID="pnlIn" runat="server" Visible="false">
                                            <li class="in">
                                                <img class="avatar" alt="" src="../img/profile.png" />
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Employee")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Description") %></span>
                                                </div>
                                            </li>
                                        </asp:Panel>
                                        <asp:Panel ID="PnlOut" runat="server" Visible="false">
                                            <li class="out">
                                                <img class="avatar" alt="" src="../img/profile.png">
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("AssignedEmployee")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Description") %>
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
    </div>
    <asp:HiddenField ID="hdnEmpId" runat="server" />
    <asp:HiddenField ID="hdnPriorityId" runat="server" />

    <div class="form-group">
        <div class="col-lg-offset-1 col-sm-10">
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
