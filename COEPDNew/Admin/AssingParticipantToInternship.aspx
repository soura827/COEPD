<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"
    CodeFile="AssingParticipantToInternship.aspx.cs" Inherits="AssingParticipantToInternship" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Assign Participant To Internship
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">

                        <div class="col-lg-3 col-md-2">
                            <asp:DropDownList ID="ddlBatchType" runat="server" required="required" AutoPostBack="true"
                                OnSelectedIndexChanged="ddlBatchType_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlLocation" runat="server" required="required" AutoPostBack="true"
                                OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlTrainer" runat="server" required="required" AutoPostBack="true"
                                OnSelectedIndexChanged="ddlTrainer_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlBatch" runat="server"></asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            &nbsp;
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnsubmit" runat="server" Text="Go" OnClick="btnsubmit_Click" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6">
                            <div class="row col-lg-offset-3">
                                <h4>Available Participants
                                </h4>
                            </div>
                            <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" OnRowCommand="gv_RowCommand">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="Assign To InternShip " CommandName="cmdAdd"
                                                CssClass="btn btn-primary" CommandArgument='<%#Eval("ParticipantId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                                </div>
                        </div>
                        <div class="col-lg-6 col-md-6">
                            <div class="row">
                                <div class="col-lg-3 col-md-3">
                                    &nbsp;
                                </div>
                                <div class="col-lg-3 col-md-3">
                                   <h4>Internship Batch</h4>
                                </div>
                                <div class="col-lg-6 col-md-6">
                                    <asp:DropDownList ID="ddlInternBatch" runat="server"></asp:DropDownList>                                    
                                    <h5><asp:Label ID="lblIntern" runat="server" Text="" ForeColor="Red"></asp:Label></h5>
                                </div>
                            </div>
                            <div class="row">
                                &nbsp;
                            </div>
                            <div class="row col-lg-4">
                                <h4>Internship Participants
                                </h4>
                            </div>
                            <asp:GridView ID="gvAssign" runat="server" AutoGenerateColumns="False" Width="100%"
                                OnRowCommand="gvAssign_RowCommand">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                     <asp:BoundField HeaderText="Internship Batch" DataField="InternDate" DataFormatString="{0: dd/MM/yyyy}" />
                                    <asp:TemplateField HeaderText="Remove " ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="Remove From Internship " CommandName="cmdRemove"
                                                CssClass="btn btn-info" CommandArgument='<%#Eval("ParticipantId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
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
</asp:Content>