<%@ Page Title="" Language="C#" MasterPageFile="~/StudentDashboard.Master" AutoEventWireup="true" CodeBehind="StudentViewQuiz.aspx.cs" Inherits="tryWithBootstrap.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
         <div class="card shadow mb-4"> 
             <br />
            <h1 class="h3 mb-4 text-gray-800 text-center">Access Quiz</h1>
        </div>
    </div>
    <div class="container-fluid">
         <div class="card shadow mb-4"> 
             <br />
             <div class="card-body text-center">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                <a href="StudentAnswerQuiz.aspx" class="btn btn-primary btn-icon-split">
                    <span class="icon text-white-50">
                        <i class="fas fa-flag"></i>
                    </span>
                    <asp:Button CssClass="text" ID="btnStartQuiz" runat="server" Text="Attempt Quiz" OnClick="btnStartQuiz_Click"  />
                </a>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
            </div>
        </div>
    </div>
</asp:Content>
