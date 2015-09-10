<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OSWAPDemoWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>A run around the OWASP Top Ten</h1>
        <p class="lead">This site deliberately demonstrates insecure coding practices. Nothing here should be taken as best practice.</p>
        <p>Whilst the site is written in <a href="https://asp.net">asp.net</a> every framework is vulnerable to the demonstrated problems.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Sensitive Data Exposure</h2>
            <p>
                <a href="Web.config.bak" class="btn btn-default" >Example »</a>
            </p>
        </div>
    </div>

</asp:Content>
