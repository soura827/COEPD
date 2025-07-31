<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="EmployeeExamReport.aspx.cs" Inherits="Admin_EmployeeExamReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        User Exam Report
                    </div>
                </div>

                <div class="widget-body">
                    <div class="row">
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtEmployee" MaxLength="500" placeholder="Employee-Name,Email,Mobile" AutoPostBack="true" OnTextChanged="txtEmployee_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtEmployee_TextChanged">
                            </asp:DropDownList>
                        </div>
                         <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" Enabled="false">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlTopic" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtEmployee_TextChanged">
                            </asp:DropDownList>
                        </div>
                        </div>
                    <br />
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" OnPageIndexChanging="gv_PageIndexChanging" PageSize="20" AllowPaging="true">
                                 <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="Sno" />
                                    <asp:BoundField HeaderText="Employee" DataField="Fullname" />
                                    <%--<asp:BoundField HeaderText="Location" DataField="Location"  />--%>
                                    <asp:BoundField HeaderText="ExamId" DataField="ExamId" />
                                    <asp:BoundField HeaderText="Category" DataField="Category" />
                                    <asp:BoundField HeaderText="Topic" DataField="Topic" />
                                    <asp:BoundField HeaderText="TotalQuestions" DataField="TotalQuestions" />
                                    <asp:BoundField HeaderText="CorrectAnswers" DataField="CorrectAnswers" />
                                    <asp:BoundField HeaderText="%" DataField="MarksPersontage" />
                                    <asp:BoundField HeaderText="StartDate" DataField="StartDate" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Start Time" DataField="StartTime" DataFormatString="{0:hh:mm tt}" />
                                    <asp:TemplateField HeaderText="End Time">
                                        <ItemTemplate>
                                            <%#Eval("EndTime", "{0:hh:mm tt}") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Duration">
                                        <ItemTemplate>
                                            <%#Eval("Duration", "{0:hh:mm tt}") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:BoundField HeaderText="Exam Retake Count" DataField="RetakeExamCount" />
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" Font-Size="Large" />
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

