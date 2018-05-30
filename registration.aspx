<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication1.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
      <h1>הרשמה</h1>
        <div class="">
            <asp:Label AssociatedControlID="FirstName" runat="server">FirstName</asp:Label>
            <asp:TextBox ID="FirstName" CssClass="inputText" runat="server"></asp:TextBox>
        </div>
        <div class="">
            <asp:Label AssociatedControlID="LastName" runat="server">LastName</asp:Label>
            <asp:TextBox ID="LastName" CssClass="inputText" runat="server"></asp:TextBox>
        </div>
        <div class="">
            <asp:Label AssociatedControlID="DateOfbirth" runat="server">Date Of Birth</asp:Label>
            <asp:Calendar ID="DateOfbirth" AutoPostBack="false" runat="server"></asp:Calendar>
        </div>
        <div class="">
            <asp:Label AssociatedControlID="UserName" runat="server">UserName</asp:Label>
            <asp:TextBox ID="UserName" CssClass="inputText" runat="server"></asp:TextBox>
        </div>
        <div class="">
            <asp:Label AssociatedControlID="Email" runat="server">Email Address</asp:Label>
            <asp:TextBox ID="Email" CssClass="inputText" TextMode="Email" runat="server"></asp:TextBox>
        </div>
        <div class="">
            <asp:Label AssociatedControlID="Password" runat="server">Password</asp:Label>
            <asp:TextBox ID="Password" AutoPostBack="false"  CssClass="inputText"  TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div class="">
            <asp:Label AssociatedControlID="RePassword" runat="server">Secound PassWord</asp:Label>
            <asp:TextBox ID="RePassword" AutoPostBack="false"  CssClass="inputText"  TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div class="">
            <asp:Label AssociatedControlID="List" runat="server">משתמש לפי ID</asp:Label>
            <asp:DropDownList ID="List"
                AutoPostBack="true"
                runat="server"  onselectedindexchanged="GetUsersById">
                <asp:ListItem Selected="True" Value="ID"> </asp:ListItem>
                <asp:ListItem Value="1">id 1</asp:ListItem>
                <asp:ListItem Value="2">id 2</asp:ListItem>
                <asp:ListItem Value="3">id 3</asp:ListItem>
                <asp:ListItem Value="4">id 4</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="">
            <asp:CheckBox ID="Approval" CssClass="checkbox"
                AutoPostBack="false"
                Text="Approval"
                TextAlign="Right"
                runat="server" />
        </div>
        <div class="">
            <asp:RadioButton ID="Male" GroupName="RegularMenu"
                Text="Male" BackColor="Blue" runat="server" CssClass="inline-rb" />
            <asp:RadioButton ID="Female" GroupName="RegularMenu"
                Text="Female" BackColor="Red" runat="server" CssClass="inline-rb" />
        </div>
        <div style="margin-top: 20px;">
            <asp:Button ID="RegisrationSubmit" CssClass="buttons" Text="Submit"  OnClick="RegisrationSubmit_Click" runat="server" />
            <asp:Label ID="RegisrationLabel" runat="server"></asp:Label>
        </div>
        <div style="margin-top: 20px;">
            <asp:Button ID="Rest" CssClass="buttons" Text="Reset"  OnClick="ResetButton_Click" runat="server" />
            <asp:Label ID="LabelReset" runat="server"></asp:Label>
        </div>
        <br />
    </div>
</asp:Content>
