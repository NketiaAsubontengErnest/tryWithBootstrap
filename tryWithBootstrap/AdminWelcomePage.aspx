<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="AdminWelcomePage.aspx.cs" Inherits="tryWithBootstrap.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- Illustrations -->
    <div class="card shadow mb-4">
        <asp:Panel ID="Panel1" runat="server">
            <div class="card-header py-3 dash">
            <center>
                <h1 class="m-0 font-weight-bold text-primary" >Welcome to Admin Dashboard</h1>
            </center>                      
        </div>
        </asp:Panel>
    </div>

</asp:Content>
