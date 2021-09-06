<%@ Page Title="" Language="C#" MasterPageFile="~/StudentDashboard.Master" AutoEventWireup="true" CodeBehind="StudentsUpload.aspx.cs" Inherits="tryWithBootstrap.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
         <div class="card shadow mb-4"> 
             <br />
            <h1 class="h3 mb-4 text-gray-800 text-center">Submit an Activity A File</h1>
        </div>
    </div>
    <div class="col-lg-5 d-none d-lg-block">
        <div class="p-5">
            <div class="text-center">
                
            </div>
            <div class="user">
                
                <div class="form-group">
                    <asp:FileUpload CssClass="form-control form-control-user" ID="FileUpload1" runat="server" />
                                    
                </div>
                <div class="form-group">
                        <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnSave" runat="server" Text="Save"  />
                    <hr />
                    <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click"  />
                                
                </div>
                               
                               
            </div>
        </div>
    </div>
</asp:Content>
