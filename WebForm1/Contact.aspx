<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        Medj Salem<br />
        Ain oussera BP:124, Djelfa  <br />
        <abbr title="Phone">Phone:</abbr>
        (213)678132691
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:myname1955@hotmail.com">myname1955@hotmail.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:myname1955@hotmail.com">myname1955@hotmail.com</a>
    </address>
</asp:Content>
