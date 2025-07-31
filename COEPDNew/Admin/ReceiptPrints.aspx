<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ReceiptPrints.aspx.cs" Inherits="Admin_ReceiptPrints" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <%--<meta name="viewport" content="width=device-width" />--%>

    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <style type="text/css">
        .button2 {
            background-color: #0a0a23;
            color: #fff;
            border-radius: 10px;
            min-height: 35px;
            min-width: 120px;
        }

        .root {
            min-width: 100px;
            width: 100%;
        }
    </style>
    <script src="../js/html2canvas.min.js"></script>
    <script src="../js/pdfmake.min.js"></script>
    <script type="text/javascript">
        function Export() {
            html2canvas(document.getElementById('Receipt'), {
                onrendered: function (canvas) {
                    var data = canvas.toDataURL();
                    var docDefinition = {
                        content: [{
                            image: data,
                            width: 500
                        }]
                    };
                    pdfMake.createPdf(docDefinition).download("Receipt" + Date() +".pdf");
                    alert("Receipt Print Downloading Started");
                }
            });
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--    <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">--%>
    <div id="inner-cont">
        <div class="container">
            <div class="row">

                <div class="widget">
                    <div class="widget-body">
                        <div class="form-horizontal no-margin">
                            <div class="root" style="background-color: azure;">
                                <div class="row">

                                    <%-- <div class="table-responsive">--%>



                                    <table width="80%" id="Receipt">
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <div class="col-lg-12 col-md-12 col-sm-12">
                                                        <asp:Image ID="TopCoepdImage" Visible="true" runat="server" ImageUrl="~/img/Top002.png" Width="1362px" />
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div id="imgAptit" runat="server">
                                                    <div class="form-group">
                                                        <div class="col-lg-12 col-md-12 col-sm-12">
                                                            <asp:Image ID="TopAptitImage" Visible="false" runat="server" ImageUrl="~/img/TopAptIt0083.png" Width="1362px" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <div class="col-lg-12 col-md-12 col-sm-12">
                                                        <div class="text-center">
                                                            <asp:Label ID="lblTitle" runat="server">
                                                                    <h1><strong>RECEIPT</strong></h1>
                                                            </asp:Label>
                                                        </div>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <div class="col-sm-8 col-lg-8 col-md-8"></div>
                                                    <%--<label class="col-sm-1 col-lg-1 col-md-1">--%>
                                                       
                                                  <%--  </label>--%>
                                                    <div class="col-lg-4 col-md-4 col-sm-4">
                                                        <h3> <strong>Date: </strong>
                                                            <asp:Label ID="lblDate" runat="server"></asp:Label>
                                                        </h3>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <br />
                                                    <br />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <label class="col-sm-2 col-lg-2 col-sm-2">
                                                        <h3><strong>Receipt No: </strong></h3>
                                                    </label>
                                                    <div class="col-sm-2 col-lg-2 col-md-2">
                                                        <h3>
                                                            <asp:Label ID="lblNumber" runat="server"></asp:Label>
                                                        </h3>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <label class="col-sm-4 col-lg-4 col-md-4">
                                                        <h3><strong>Received With Thanks From :</strong></h3>
                                                    </label>
                                                    <div class="col-lg-7 col-sm-7 col-lg-7">
                                                        <h3>
                                                            <asp:Label ID="lblName" runat="server"></asp:Label>
                                                        </h3>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <label class="col-sm-4 col-lg-4 col-md-4">
                                                        <h3><strong>Sum of Rupees (In Words)&nbsp;&nbsp;&nbsp; :</strong></h3>
                                                    </label>
                                                    <div class="col-sm-8 col-lg-8 col-md-8 ">
                                                        <h3>
                                                            <asp:Label ID="lblAmountInWords" runat="server"></asp:Label>
                                                        </h3>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                         <tr>
                                            <td>
                                                <div class="form-group">
                                                    <label class="col-sm-4 col-lg-4 col-md-4">
                                                        <h3><strong>Service mode&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</strong></h3>
                                                    </label>
                                                    <div class="col-sm-8 col-lg-8 col-md-8 ">
                                                        <h3>
                                                            <asp:Label ID="lblServiceMode" runat="server" Text="Online"></asp:Label>
                                                        </h3>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <label class="col-sm-4 col-md-4 col-lg-4">
                                                        <h3><strong>Mode Of Payment&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:</strong></h3>
                                                    </label>
                                                    <div class="col-sm-3 col-lg-3 col-md-3">
                                                        <h3>
                                                            <asp:Label ID="lblCheque" runat="server"></asp:Label>
                                                        </h3>
                                                    </div>
                                                    <div class="col-lg-1 col-md-1 col-sm-1"></div>
                                                    <div class="col-sm-4 col-lg-4 col-md-4">
                                                        <h3>
                                                            <strong>Branch:</strong>
                                                            <asp:Label ID="lblLocation" runat="server"></asp:Label>
                                                        </h3>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <label class="col-sm-4 col-md-4 col-sm-4">
                                                        <h3><strong>Amount Received On&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:</strong></h3>
                                                    </label>
                                                    <div class="col-sm-4 col-lg-4 col-md-4">
                                                        <h3>
                                                            <asp:Label ID="lblCreatedOn" runat="server"></asp:Label>
                                                        </h3>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <div class="col-lg-4 col-md-4 col-sm-4">
                                                        
                                                    </div>
                                                    <div class="col-lg-3 col-sm-3 col-md-3"></div>
                                                    <div class="col-lg-4 col-sm-4 col-md-4">
                                                        <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblEmployee" runat="server" CssClass="auto-style26"></asp:Label>
                                                        </h3>
                                                    </div>
                                                </div>

                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <div class="col-lg-7 col-md-7 col-sm-7">
                                                        &nbsp;&nbsp;<h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>₹ </strong><asp:Label ID="lblAmount" runat="server"></asp:Label>/-</h3>
                                                        <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(Cheques Subject to realization)</h3>
                                                    </div>
                                                    <div class="col-lg-5 col-md-5 col-sm-5">
                                                        <asp:Image ID="imgCoepdstamp" runat="server" ImageUrl="~/img/stamp0061.png" CssClass="auto-style27" Width="402px" />
                                                        <asp:Image ID="imgAptitstamp" Visible="false" runat="server" ImageUrl="~/img/stampAptit0052.png" CssClass="auto-style27" Width="402px" />
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                                        <asp:Image ID="Image5" runat="server" ImageUrl="~/img/fee003.png" />

                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                    <br />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <asp:Image ID="imgCoepdbottem" Visible="true" runat="server" ImageUrl="~/img/bottem0053.png" Width="1377px" />
                                                    <asp:Image ID="imgAptitbottem" Visible="false" runat="server" ImageUrl="~/img/bottemaptit0053.png" Width="1377px" />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="form-group">
                                                    <div class="text-center">
                                                        <h5>This is System generated Receipt doesn’t require any signature
                                        <%--<asp:Label ID="lblBottemDate" runat="server" CssClass="auto-style26"></asp:Label>
                                                            <asp:Label ID="lblBottemTime" runat="server" CssClass="auto-style26"></asp:Label>--%>
                                                        </h5>

                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                <br />
                <br />
                <br />
                <br />
                <div class="col-lg-5 col-md-5 col-sm-5"></div>
                <div class="col-lg-7 col-md-7 col-sm-7"></div>
                <br />
                <br />
                <br />
                <br />
                <div class="text-center">
                    <input type="button" id="btnExport" value="Generate PDF" onclick="Export()" class="button2" />
                    &nbsp;
        <asp:Button ID="BtnCancel" runat="server" Text="Back To List" OnClick="BtnCancel_Click" BackColor="#FF6600" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

