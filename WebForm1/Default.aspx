<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h3>WebCalculator</h3>
        <p class="lead">WebClalulator is a free web applications.</p>

    </div>

    <div>
        <asp:TextBox ID="TextBox1" runat="server" Columns="80" Height="80px" Rows="3" TextMode="MultiLine" Width="250px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="reset " Height="25px" Width="50px" />
        <asp:Button ID="Button18" runat="server" OnClick="Button18_Click" Text="run   " Height="25px" Width="50px" />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="7" Height="25px" Width="50px" />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="8" Height="25px" Width="50px" />
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="9" Height="25px" Width="50px" />
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="   +  " Height="25px" Width="50px" />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="4" Width="50px" Height="25px" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="5" Height="25px" Width="50px" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="6" Height="25px" Width="50px" />
        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="-" Width="50px" Height="25px" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1" Width="50px" Height="25px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" Height="25px" Width="50px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="3" Height="25px" Width="50px" />
        <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="   ^  " Height="25px" Width="50px" />
        <br />
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="0" Height="25px" Width="50px" />
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="." Height="25px" Width="50px" />
        <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="   =  " Height="25px" Width="50px" />
        <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="   x  " Width="50px" Height="25px" />
    </div>

</asp:Content>
