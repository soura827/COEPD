<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AssignNurturingTaskSearch.aspx.cs" Inherits="Admin_AssignNurturingTaskSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
         .ui-widget-content .ui-icon {
    /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/ 
    /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
     background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")      
            !important;}
    .ui-widget-header .ui-icon {
    /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/ 
    background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")  
        !important;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                       Assign Nurturing Task
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtParticipant" MaxLength="500" placeholder="Participant-Name,Email,Mobile,ID" AutoPostBack="true" OnTextChanged="txtParticipant_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="500" placeholder="Location" AutoPostBack="true" OnTextChanged="txtLocation_TextChanged"></asp:TextBox>
                        </div>
                        <%--<div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtExam" MaxLength="250" placeholder="Exam" AutoPostBack="true" OnTextChanged="txtExam_TextChanged"></asp:TextBox>
                        </div>--%>
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlNurturingProcessStage" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStage_SelectedIndexChanged">
                                <asp:ListItem Text="--Select Stage--" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlNurturingProcessStageTask" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStageTask_SelectedIndexChanged">
                                <asp:ListItem Text="--Select Stage Task--" Value=""></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                         <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Text="Pending/Evaluated" Value="False"></asp:ListItem>
                                <asp:ListItem Text="Approved" Value="True"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtEvaluatedBy" MaxLength="500" placeholder="Evaluated/Approved By" AutoPostBack="true" OnTextChanged="txtEvaluatedBy_TextChanged"></asp:TextBox>
                        </div>
                        </div>
                    <br />
                    <div class="row">
                        <%--<div class="col-lg-2 col-md-2">
                            <asp:Label runat="server" ID="lblTargetDate" Text="Select Target Date:"></asp:Label>
                        </div>
                          <div class="col-lg-2 col-md-2">
                             <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>--%>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtExamScore" MaxLength="5" placeholder="Score" AutoPostBack="true" OnTextChanged="txtExamScore_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                             <asp:TextBox runat="server" ID="txtAssignedByName" Placeholder="Search by Assigned By" OnTextChanged="txtParticipant_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                       
                        <div class="col-md-1 col-lg-1">
                            <asp:Button runat="server" ID="btnAdd" Text="Assign Task" SkinID="btnGreen" OnClick="btnAdd_Click" CausesValidation="false" /> 
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                     <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="50" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnRowDataBound="gv_RowDataBound" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender" >
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Participant" DataField="Participant" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:BoundField HeaderText="Exam" DataField="NurturingProcessStageName" />
                                    <asp:BoundField HeaderText="Exam Category" DataField="NurturingProcessStageTaskName" />
                                    <asp:TemplateField HeaderText="Question Paper">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnSendFile" runat="server" Value='<%#Eval("SenderImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/NurturingTask/"+ Eval("SenderImagePath") %>' runat="server"
                                                ID="hplSendFile" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Answer sheet">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnReplyFile" runat="server" Value='<%#Eval("ReceiverImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/AssignNurturingTask/"+ Eval("ReceiverImagePath") %>' runat="server"
                                                ID="hplReplyFile" Target="_blank" CssClass="btn btn-warning btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Assigned By" DataField="Fullname" />
                                    <asp:BoundField HeaderText="Assigned Date" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy }" />
                                    <asp:BoundField HeaderText="Target Date" DataField="TargetDate" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Task Assigned To" DataField="TaskAssignedTo" />
                                    <asp:BoundField HeaderText="Slot Date" DataField ="SlotDate" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="SlotStartTime" DataField="SlotStartTime" DataFormatString="{0: hh:mm tt}" />
                                    <asp:BoundField HeaderText="SlotEndTime" DataField="SlotEndTime" DataFormatString="{0: hh:mm tt}" />
                                    <asp:BoundField HeaderText="Completed On" DataField="TaskCompletedOn" DataFormatString="{0: dd MMM yyyy }" />
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsApproved").ToString()) ? "Evaluated" : "Pending" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:BoundField HeaderText="Evaluated By" DataField="EvaluatedBy" />
                                    <asp:BoundField HeaderText="Evaluated On" DataField="EvaluatedOn" DataFormatString="{0: dd MMM yyyy }" />
                                    <asp:BoundField HeaderText="Approved By" DataField="ApprovedBy" />
                                    <asp:BoundField HeaderText="Approved On" DataField="ApprovedOn" DataFormatString="{0: dd MMM yyyy }" />
                                    <asp:BoundField HeaderText="Score" DataField="ExamScore" DataFormatString="{0:##.#}" />
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                       <%-- <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" Text="Evaluate" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("AssignNurturingTaskId")%>'></asp:LinkButton>
                                        </ItemTemplate>--%>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                             <div>
                              <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                          </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
    
</asp:Content>

