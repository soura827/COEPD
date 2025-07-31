<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true"
    CodeFile="Calendar.aspx.cs" Inherits="Calendar" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Calendar
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <%-- <div id='calendar'></div>--%>
                        <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" Width="100%"
                            CssClass="table table-bordered table-responsive" SelectionMode="None">
                            <DayHeaderStyle  />
                        </asp:Calendar>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
    <!-- Main Container end -->
    <script src="../js/jquery.js" type="text/javascript"></script>
    <script src="../js/bootstrap.min.js" type="text/javascript"></script>
    <script src="../js/jquery.scrollUp.js" type="text/javascript"></script>
    <!-- Calendar JS -->
    <script src='../js/fullcalendar/jquery-ui.custom.min.js' type="text/javascript"></script>
    <script src='../js/fullcalendar/fullcalendar.min.js' type="text/javascript"></script>
    <!-- Custom JS -->
    <script type="text/javascript">
        //ScrollUp
        $(function ($) {
            $.scrollUp({
                scrollName: 'scrollUp', // Element ID
                topDistance: '300', // Distance from top before showing element (px)
                topSpeed: 300, // Speed back to top (ms)
                animation: 'fade', // Fade, slide, none
                animationInSpeed: 400, // Animation in speed (ms)
                animationOutSpeed: 400, // Animation out speed (ms)
                scrollText: 'Top', // Text for element
                activeOverlay: false, // Set CSS color to display scrollUp active point, e.g '#00FFFF'
            });
        });

        //Tooltip
        $('a').tooltip('hide');

        //Popover
        $('.popover-pop').popover('hide');

        //Dropdown
        $('.dropdown-toggle').dropdown();

        $(document).ready(function ($) {

            var date = new Date();
            var d = date.getDate();
            var m = date.getMonth();
            var y = date.getFullYear();

            var calendar = $('#calendar').fullCalendar({
                header: {
                    left: 'prev,next today',
                    center: 'title',
                    right: 'month'
                },
                selectable: true,
                selectHelper: true,
                //select: function (start, end, allDay) {
                //    var title = prompt('Event Title:');
                //    if (title) {
                //        calendar.fullCalendar('renderEvent',
                //          {
                //              title: title,
                //              start: start,
                //              end: end,
                //              allDay: allDay
                //          },
                //          true // make the event "stick"
                //        );
                //    }
                //    calendar.fullCalendar('unselect');
                // },
                // editable: true,
                events: function (start, end, callback) {
                    $.ajax({
                        type: "POST",
                        url: "JobService.asmx/GetCurrentTime",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (doc) {

                            //alert("Success");
                            var events = [];
                            // alert(doc.d);
                            var obj = $.parseJSON(doc.d);
                            //console.log(obj);
                            $(obj).each(function () {
                                events.push({

                                    title: alert("hai"),
                                    start: new Date(obj.StartDate),
                                    end: new Date(obj.StartDate),
                                });
                            });
                            //callback(events);
                            callback && callback(events);
                        },
                        error: function (xhr, status, error) {

                            alert(xhr.responseText);
                        }
                    });
                }
            });

        });

        //$(function ($) {
        //    $.ajax({
        //        type: "POST",
        //        url: "Calendar.aspx/GetCurrentTime",
        //        data: '{"name":"  narasimha  "}',
        //        contentType: "application/json; charset=utf-8",
        //        dataType: "json",
        //        success: OnSuccess,
        //        failure: function (response) {
        //            alert(response.d);
        //        }
        //    });
        //    function OnSuccess(response) {
        //        alert(response.d);
        //    }
        //})

    </script>
</asp:Content>