<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="ActivityTaskInputs.aspx.cs" Inherits="Participant_ActivityTaskInputs" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">
        .modal {
            text-align: center;
            padding: 0 !important;
        }

            .modal:before {
                content: '';
                display: inline-block;
                height: 100%;
                vertical-align: middle;
                margin-right: -4px;
            }

        .modal-dialog {
            display: inline-block;
            text-align: left;
            vertical-align: middle;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <!-- Row Start -->
            <div class="row">
                <div class="col-lg-12 col-md-12">
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
                                        Task Title:
                                        </label>
                                    <div class="col-sm-5 control-label">
                                    <asp:Label ID="lblDescription" runat="server"></asp:Label>
                                        </div>
                                    <%--<label class="col-sm-1 control-label">
                                        Involved Employees:
                                        </label>--%>
                                    <%--<div class="col-sm-2 Control-label">
                                    <asp:Label ID="lblInvolvedEmployees" runat="server"></asp:Label>
                                        </div>--%>
                                    <%--<label class="col-sm-1 control-label">
                                        Involved Participants:
                                        </label>
                                    <div class="col-sm-2 control-label">
                                    <asp:Label ID="lblInvolvedParticipants" runat="server"></asp:Label>
                                        </div>--%>
                                </div>
                                <br />
                                <div class="form-group">
                                    <div class="col-sm-offset-4 col-sm-10">
                                        <asp:Button ID="btnStartActivity" runat="server" Text="Start Task" OnClick="btnStartActivity_Click"></asp:Button>
                                    </div>
                                </div>
                                <br />
                                <div>
                                    <label class="col-sm-2 control-label">
                                        <span style="color: Red; font-size: 24px;">*</span>    Enter Your Inputs:
                                    </label>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtActivityInputs" required="" runat="server" Placeholder="Enter your inputs here" TextMode="MultiLine" Height="250px"></asp:TextBox>
                                    </div>
                                </div>
                                    <%--    <div class="form-group" >
                                        <label class="col-sm-2" >
                                           <span style="color:red;"> *</span>Date To WorkOn</label>
                                        
                                        <div class="col-sm-3">
                                            <asp:TextBox ID="txtFollowupdate" runat="server" ></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label class="col-sm-2">
                                            <span style="color:red;"> *</span>  Description
                                        </label>
                                        <div class="col-sm-4">
                                            <asp:TextBox ID="txtfollowupdescription" runat="server" TextMode="MultiLine" ></asp:TextBox>
                                        </div>
                                        <div class="col-sm-4">
                                            <asp:TextBox ID="txtfollowup" runat="server" TextMode="MultiLine" Visible="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <br />
                                <br />--%>
                                <%--<div class="form-group">
                                    <label class="col-sm-2">
                                        Start Time <span style="color:red;"> *</span>  
                                    </label>
                                    <label class="col-sm-2">
                                        End Time <span style="color:red;"> *</span>  
                                    </label>
                                </div>--%>
                                <div class="form-group">
                                    <label class="col-sm-2 ">
                                     <span style="color:red; font-size:24px;"> *</span>   Start Time:
                                    </label>
                                    <div class="col-sm-10">
                                        <div class="row">
                                            <div class="col-lg-1 col-md-1">
                                                <asp:TextBox ID="txtsHours" runat="server" type="number" Required="" OnTextChanged="txtsHours_TextChanged" Placeholder="HH"
                                                    Width="70px" min="0" max="11"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-1 col-md-1">
                                                <asp:TextBox ID="txtsmints" runat="server" type="number" Required="" OnTextChanged="txtsmints_TextChanged" Placeholder="MM"
                                                    Width="70px" min="0" max="59" MaxLength="2"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-2 col-md-2">
                                                <asp:DropDownList ID="ddlEStartAMPM" runat="server">
                                                    <asp:ListItem Text="AM" Value="AM"></asp:ListItem>
                                                    <asp:ListItem Text="PM" Value="PM"></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                 <div class="form-group">
                                    <label class="col-sm-2 ">
                                     <span style="color:red; font-size:24px;"> *</span>   End Time:
                                    </label>
                                    <div class="col-sm-10">
                                        <div class="row">
                                            <div class="col-lg-1 col-md-1">
                                                <asp:TextBox ID="txtEHours" runat="server" type="number" Required="" OnTextChanged="txtEHours_TextChanged" Placeholder="HH" Width="70px"
                                                    min="0" max="11"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-1 col-md-1">
                                                <asp:TextBox ID="txtEmints" runat="server" type="number" Required="" OnTextChanged="txtEmints_TextChanged" Placeholder="MM" Width="70px"
                                                    min="0" max="59" MaxLength="2"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-2 col-md-2">
                                                <asp:DropDownList ID="ddlEEndAMPM" runat="server">
                                                    <asp:ListItem Text="AM" Value="AM"></asp:ListItem>
                                                    <asp:ListItem Text="PM" Value="PM"></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                    <div class="form-group">
                                        <div class="col-sm-offset-4 col-sm-10">
                                            <%--<asp:Button ID="btnEndActivity" runat="server" Text="End Task" OnClick="btnEndActivity_Click" />--%>
                                            <asp:Button ID="btnBackToList" runat="server" Text="Back To Tasks" UseSubmitBehavior="false" OnClick="btnBackToList_Click" />
                                            <asp:Button ID="btnUpdate" runat="server" Text="Update Task" OnClick="btnUpdate_Click" />
                                            <%--<button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#myModal" id="btnbutton" runat="server">FollowUp</button>--%>
                                        </div>
                                        <br />
                                        <br />
                                    </div>

                                    <div class="row">
                                        &nbsp;
                                    </div>
                                    <div>
                                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                                    </div>
                                    <div class="row">
                                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="4" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                            <Columns>
                                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                                <asp:BoundField HeaderText="Task Inputs" DataField="ActivityInteractionInputs" />
                                                <asp:BoundField HeaderText="Inputs Entered By" DataField="Fullname" />
                                                <asp:BoundField HeaderText="Inputs Entered On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                            </Columns>
                                        </asp:GridView>
                                        <div>
                                            <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                                        </div>
                                    </div>

                                    <div class="container">
                                        <!-- Trigger the modal with a button -->
                                        <%-- <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Open Modal</button>--%>
                                        <!-- Modal -->
                                        <div class="modal fade" id="myModal" role="dialog">
                                            <div class="modal-dialog">
                                                <!-- Modal content-->
                                                <div class="modal-content">
                                                    <%--<div class="modal-header">
                                                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                                                    <h4 class="modal-title">Follow Up</h4>
                                                </div>--%>
                                                    <div class="modal-body">
                                                        <p style="font-size: 20px; font-family: 'Times New Roman', Times, serif;">Are You Sure Go for Followup?</p>
                                                    </div>
                                                    <div class="modal-footer">
                                                        <asp:Button ID="Button1" runat="server" Text="Yes" OnClick="btnsubmit_Click" />
                                                        <asp:Button ID="Button2" runat="server" Text="No" OnClick="btncancel_Click" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                            </div>
                        </div>
                    </div>
                </div>
                </div>
        </ContentTemplate>
        <%--<Triggers>
            <asp:PostBackTrigger ControlID="btnStartActivity" />
        </Triggers>--%>
    </asp:UpdatePanel>
</asp:Content>

