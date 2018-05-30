<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="imgcontainer">
   <h1>התחבר למערכת</h1>
        <img src="img_avatar2.png" alt="Avatar" class="avatar">
  </div>
    <div class="container">
        <p><%=loginAttem%>:נסיונות התחברות</p>
        <div class="form-group">
            <asp:Label AssociatedControlID="UserName" runat="server">User Name</asp:Label>
            <asp:TextBox ID="UserName" CssClass="inputText" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label AssociatedControlID="Password" runat="server">PassWord</asp:Label>
            <asp:TextBox ID="Password" AutoPostBack="false" CssClass="inputText" TextMode="Password" runat="server"></asp:TextBox>
        </div>
         <div style="margin-top: 20px;">
            <asp:Button ID="LoginSubmit" CssClass="buttons" Text="Submit"  OnClick="LoginSubmit_Click" runat="server" />
            <asp:Label ID="LoginLabel" runat="server"></asp:Label>
        </div>
        <br />
    </div>

</asp:Content>
