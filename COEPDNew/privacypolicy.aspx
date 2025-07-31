<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true"
    CodeFile="privacypolicy.aspx.cs" Inherits="privacypolicy" %>

<%@ Register Src="Controls/NewsAll.ascx" TagName="NewsAll" TagPrefix="uc1" %>
<%@ Register Src="Controls/Locations.ascx" TagName="Locations" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" Runat="Server">
    Privacy Policy - COEPD
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="canonical" href="https://www.coepd.com/privacypolicy.html" />
    <meta name="description" content="coepd pivacy policy" />
    <meta name="keywords" content="pivacy policy" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="Server">
    <div id="recent-updates">
        <div class="container">
            <div class="col-md-12">
                <uc1:NewsAll ID="NewsAll" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content start -->
    <div id="inner-cont">
        <div class="container">
            <div class="col-md-9">
                <div>
                    <h1 class="title-blue">
                        COEPD - Privacy Policy
                    </h1>
                    <p>
                        <strong>Information Practices</strong></p>
                    <p>
                        COEPD had taken every possible precaution to ensure the accuracy of the information
                        on its website; the content is subject to change at any point of time. We would
                        not stand responsible for any damages arising out of the use of the content available
                        on this server.</p>
                    <p>
                        We assure that all our downloadable training content are free of Virus. However,
                        Center of Excellence for Professional Development (COEPD) can accept no liability
                        for damages if accessed through unsafe media or unsecured network resulting virus
                        infection.</p>
                    <p>
                        <strong>Information collected by Center of Excellence for Professional Development (COEPD):</strong>
                    </p>
                    <p>
                        The information provided by you is totally under your control</p>
                    <p>
                        No third party will be given access of your information for any kind of marketing
                        or sold or exchanged.
                    </p>
                    <p>
                        Receiving offers from us thru email is solely at your discretion
                    </p>
                    <p>
                        Browsing our website can be done without registration. We randomly may collect and
                        store the information that you willingly disclose to us and access our free tests
                        and discussion forums. We do not share your personal information with any third
                        party. We do not collect information from sources like email databases, private/
                        public organization or bodies about our visitors</p>
                    <p>
                        The information collected by us will only be used to contact you to inform you about
                        new products or provide support on your issues via email or telephone. You can unsubscribe
                        at any point if you do not want us to contact you via email.</p>
                    <p>
                        Your personal information such as name, telephone number, address(s), e-mail address
                        credit card number, expiration, and CVV number is stored with us and is required
                        when you purchase our online products or register for classroom training. All transactions
                        are done under highly secured encryption environment (SSL) by our payment gateway
                        service provider and we do not store any such information on our servers.</p>
                    <p>
                        <strong>Information</strong></p>
                    <p>
                        The cookie that we use is a small text file which resides in your computer hard
                        drive. It is normally used to track website performance and enhance your online
                        experience of our website.</p>
                    <p>
                        <strong>External Links</strong></p>
                    <p>
                        COEPD website may include links to other websites that are not owned or controlled
                        by COEPD and are purely for educational purpose. You agree that Center of Excellence
                        for Professional Development (COEPD) provides links to such websites solely as a
                        convenience and takes no obligation for the content or availability of such websites,
                        and that Center of Excellence for Professional Development does not endorse such
                        websites or any products or services associated therewith. Your use of such websites
                        will be subject acceptance of their terms of use.</p>
                    <p>
                        <strong>Copyright information</strong></p>
                    <p>
                        You are permitted to copy or print the contents of our website provided, you use
                        it only for personal use. Center of Excellence for Professional Development holds
                        the copyright to all the material/contents on this website. For the purpose other
                        than permitted by the law, a written permission of the copyright holder must be
                        obtained.
                    </p>
                    <p>
                        <strong>Sharing your personal information</strong></p>
                    <p>
                        For anyone who have purchased any of the COEPD’s course(s), we may ask you for testimonial.
                        These testimonials will be displayed on our website, photos and videos or in our
                        social media channels such as Facebook, YouTube or Flickr only with your authorization.
                        You should be aware that your publicly identifiable information could be used to
                        send you promotional, unsolicited messages and we are not responsible for your personal
                        information which you have chosen to display.</p>
                    <p>
                        If you do not want us to publish your pictures/testimonials on our website or on
                        our social media channels, you can write a mail to <a href="mailto:support@coepd.com"
                            target="_top">support@coepd.com</a></p>
                    <p>
                        <strong>Personal Information Corrections</strong></p>
                    <p>
                        You can contact us if you notice that the information we are holding is incorrect
                        or incomplete. Please send us a mail to <a href="mailto:support@coepd.com" target="_top">
                            support@coepd.com</a></p>
                    <p>
                        <strong>Changes to Privacy Policy</strong></p>
                    <p>
                        This privacy policy terms may change time to time and we reserve the right to change
                        the terms of this privacy policy as and when required. All our registered users
                        will be notified by email when we update the privacy policy.</p>
                    <p>
                        <strong>Privacy Policy Questions?</strong></p>
                    <p>
                        If you have any questions regarding Privacy Policy, Please write to <a href="mailto:support@coepd.com"
                            target="_top">support@coepd.com</a> if you have any questions regarding Privacy
                        Policy</p>
                </div>
            </div>
            <div class="col-md-3 our-locations">
                <uc2:Locations ID="Locations" runat="server" />
            </div>
        </div>
    </div>
    <!-- Inner page Content End -->
</asp:Content>
