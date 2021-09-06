<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherDash.Master" AutoEventWireup="true" CodeBehind="TeachersWelcome.aspx.cs" Inherits="tryWithBootstrap.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card shadow mb-4">
        <asp:Panel ID="Panel1" runat="server">
            <div class="card-header py-3 dash">
            <center>
                <h1 class="m-0 font-weight-bold text-primary" >Welcome to Teachers Dashboard</h1>
            </center>                      
        </div>
        </asp:Panel>
    </div>
</asp:Content>
