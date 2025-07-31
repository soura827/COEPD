<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="NurturingAvilableSlotsSearchAll.aspx.cs" Inherits="Admin_NurturingAvilableSlotsSearchAll" EnableEventValidation="false"%>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ui-widget-content .ui-icon {
            /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/
            /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
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
                        Nurturing Available Slots
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtEmployee" MaxLength="500" placeholder="Employee-Name,Mobile" AutoPostBack="true" OnTextChanged="txtEmployee_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtParticipate" MaxLength="500" placeholder="Participant-Name,Email,Mobile" AutoPostBack="true" OnTextChanged="txtParticipate_TextChanged"></asp:TextBox>
                        </div>
                          <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtlocation" MaxLength="500" placeholder="Search by Location" AutoPostBack="true" OnTextChanged="txtlocation_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtNurturingProcessStageTaskName" MaxLength="100" placeholder="Task Name" AutoPostBack="true" OnTextChanged="txtNurturingProcessStageTaskName_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Text="Slots Booked" Value="True"></asp:ListItem>
                                <asp:ListItem Text="Slots Available" Value="False"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <%--<div class="col-lg-2 col-md-2">
                            <asp:Label runat="server" ID="lblTargetDate" Text="Select Slot Dates:"></asp:Label>
                        </div>--%>
                        <div class="col-lg-1 col-md-1">
                            <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        
                        <div class="col-lg-1 col-md-1">
                            <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlSlotStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSlotStatus_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <%--<div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>--%>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" PageSize ="100000" Width="100%"  HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" OnRowCommand="gv_RowCommand" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                <Columns>

                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Employee" DataField="Employee" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                    <asp:BoundField HeaderText="Participant Email" DataField="Email" />
                                    <asp:BoundField HeaderText="Participant Mobile" DataField="Mobile" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:BoundField HeaderText="Task Name" DataField="NurturingProcessStageTaskName" />
                                    <asp:BoundField HeaderText="Slot Date" DataField="SlotDate" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Start Time" DataField="SlotStartTime" DataFormatString="{0: hh:mm tt}" />
                                    <asp:BoundField HeaderText="End Time" DataField="SlotEndTime" DataFormatString="{0: hh:mm tt}" />
                                    <%-- <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsSlotAssigned").ToString()) ? "Slot Booked" : "Slot Available" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
                                    <asp:BoundField HeaderText="Slot Status" DataField="SlotStatus" />
                                    <asp:BoundField HeaderText="Slot Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />




                                    <asp:TemplateField HeaderText="Action">

                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkConduct" runat="server" Text="Conduct" CommandName="cmdConduct"
                                                CssClass="btn btn-info" CommandArgument='<%#Eval("NurturingProcessId")%>' Visible='<%#(Boolean.Parse(Eval("IsSlotAssigned").ToString())? true:false) %>'></asp:LinkButton>
                                            <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" Text="Delete Slot" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("NurturingProcessSlotsId")%>' Visible='<%#(Boolean.Parse(Eval("IsSlotAssigned").ToString()) ? false:true) %>' OnClientClick="return confirm('Are you sure you want to delete this Slot?');"></asp:LinkButton>
                                        </ItemTemplate>



                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Change Slot">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkChangeSlot" runat="server" Text="Change Slot" CommandName="cmdChangeSlot"
                                                CommandArgument='<%#Eval("NurturingProcessSlotsId") %>' Visible='<%#(Boolean.Parse(Eval("IsSlotAssigned").ToString()) ? true:false) %>' OnClientClick="return confirm('Are you sure you want to Change this Slot?')"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                           <%-- <div>
                                <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                            </div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>

    <script type="text/javascript">
        $(document).ready(function ($) {

            $("input[id$=txtFromDate]").datepicker({
                value: new Date().toDateString(),
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                dateFormat: 'dd/mm/yy',
                //maxDate: "0",
            });

            $("input[id$=txtToDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                //maxDate: "0"
            });
        });
    </script>
</asp:Content>

