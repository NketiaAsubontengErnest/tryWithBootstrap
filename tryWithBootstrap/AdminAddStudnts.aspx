<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="AdminAddStudnts.aspx.cs" Inherits="tryWithBootstrap.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container ">
        <div class="card o-hidden border-0 shadow-lg my-5 ">
            
            <div class="card-body p-0 " >
                <!-- Nested Row within Card Body -->
                <div class="row">
                    <div class="col-lg-7">
                        <div class="p-5">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Add A Student</h1>
                            </div>
                            <div class="user">
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox CssClass="form-control form-control-user" ID="txtID" placeholder="Student ID" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox CssClass="form-control form-control-user" ID="txtFirstName" placeholder="First Name" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox CssClass="form-control form-control-user" ID="txtLastName" placeholder="Last Name" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control form-control-user" ID="txtEmail" placeholder="Email Address" runat="server"></asp:TextBox>
                                    
                                </div>
                                <div class="form-group">
                                    <asp:DropDownList CssClass="form-control form-control-user" ID="cmbTeacher" placeholder="Teacher" runat="server"></asp:DropDownList>
                                    
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        
                                        <asp:TextBox CssClass="form-control form-control-user" ID="txtDefaultPassword" placeholder="Password" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox CssClass="form-control form-control-user" ID="txtConfirmPass" placeholder="Confirm Password" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                
                                <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnAdd" runat="server" Text="Add Student"  OnClick="btnAdd_Click"/>
                                <hr />
                                <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnClear" runat="server" Text="Clear" />
                                
                            </div>
                        </div>
                    </div>
                </div>
                
                    
                <div class="col-lg-5 d-none d-lg-block bg-register-image">
                        
                </div>
            </div>
        </div>

    </div>
</asp:Content>
