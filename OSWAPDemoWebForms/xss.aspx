<%@ Page Title="XSS" Language="C#" AutoEventWireup="true" CodeBehind="xss.aspx.cs" MasterPageFile="~/Site.Master" Inherits="OSWAPDemoWebForms.xss" validateRequest="false"  %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>The Imaginary BBS</h1>
    </div>

    <div class="container">
        <asp:Table ID="MessagesList" runat="server" CssClass="table table-striped">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Title</asp:TableHeaderCell>
                <asp:TableHeaderCell>Views</asp:TableHeaderCell>
                <asp:TableHeaderCell>Posted On</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </div>

    <div class="form-horizontal">
        <h2>Add a new post</h2>
        <div class="form-group">
            <asp:Label ID="TitleLabel" runat="server" AssociatedControlID="MessageTitle" CssClass="col-sm-1 control-label" Text="Title" />
            <div class="col-sm-11">
                <asp:TextBox ID="MessageTitle" runat="server" CssClass="form-control" placeholder="Title" autofocus required />
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-1 col-sm-11">
                <asp:Button runat="server" CssClass="btn btn-default" Text="Post" OnClick="Post_Click" />
            </div>
        </div>
    </div>

    <div class="container">
        <p>Titles to try</p>
        <ul>
            <li>&lt;script&gt;window.alert('XSS')&lt;/script&gt;p0wned</li>
            <li>&lt;script&gt;window.alert(document.cookie)&lt;/script&gt;p0wned</li>
            <li>&lt;script&gt;document.location.href="https://www.youtube.com/watch?v=dQw4w9WgXcQ"&lt;/script&gt;p0wned</li>
        </ul>
    </div>
</asp:Content>