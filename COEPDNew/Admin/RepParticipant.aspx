<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="RepParticipant.aspx.cs" Inherits="RepParticipant" EnableEventValidation="false" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        table caption{
            background-color:#5D7B9D;
            color:white;
            font-size:16px;
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="box-theme">
        <!-- Row Start -->
        <div class="row">
            <div class="col-lg-12 col-md-12">
                <div class="widget">
                    <div class="widget-header">
                        <div class="title">
                            Participant
                        </div>
                    </div>
                    <div class="widget-body">
                        <div class="row">
                            <div class="col-lg-2 col-md-2">
                                <label>Select Course</label>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:DropDownList ID="ddlCourse" runat="server" required="" >
                                </asp:DropDownList>
                            </div>
                            <div class="col-lg-2 col-md-2">
                                <label>Select Batch Type</label>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:DropDownList ID="ddlBatchType" runat="server" required="" >
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="Row">
                            &nbsp;
                        </div>
                        <div class="row">
                            <div class="col-lg-2 col-md-2">
                                <label>Select Location</label>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:DropDownList ID="ddlLocation" runat="server" required="" >
                                </asp:DropDownList>
                            </div>
                            <div class="col-lg-2 col-md-2">
                                <label>Select Trainer</label>
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <asp:DropDownList ID="ddlTrainer" runat="server"  required="" >
                                </asp:DropDownList>
                            </div>
                            <div class="col-lg-1 col-md-1">
                                <asp:Button ID="btnSubmit" runat="server" Text="Find" OnClick="btnSubmit_Click" />
                            </div>
                            <div class="col-lg-1 col-md-1">
                                <%--<asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />--%>
                            </div>
                        </div>
                    <div class="row">
                        &nbsp;
                    </div>

                    <div class="row" >
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False"
                            Width="100%">
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="BatchDate" DataField="StartDate" DataFormatString="{0:dd MMM yyyy}"
                                    ItemStyle-Width="100px" />
                                <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                <asp:BoundField HeaderText="Email" DataField="Email" />
                                <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                <asp:BoundField HeaderText="Location" DataField="Location" />
                            </Columns>

                            <EmptyDataTemplate>
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
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
