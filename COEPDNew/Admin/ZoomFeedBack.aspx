<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ZoomFeedBack.aspx.cs" Inherits="Admin_ZoomFeedBack" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

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
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
       
        function alertmeSave() {
            Swal.fire(
                'Zoom FeedBack successfully Added',
                '',
                'success'
            )
        }
      
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                                FeedBack Inputs :
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtFeedBack" runat="server" MaxLength="5000" Height="100" TextMode="MultiLine" ></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">                                
                                <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />                                
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                              </div>   
                        </div>
                        </div>
                    </div>
                </div>   
               </div>
           </div>  
      <!-- Row End -->
            
</asp:Content>

