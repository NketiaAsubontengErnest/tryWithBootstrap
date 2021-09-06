<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherDash.Master" AutoEventWireup="true" CodeBehind="TeacherAddQuiz.aspx.cs" Inherits="tryWithBootstrap.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container ">
        <div class="card o-hidden border-0 shadow-lg my-5 ">
            
            <div class="card-body p-0 " >
                <!-- Nested Row within Card Body -->
                    
                        <div class="p-5">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Add A Quiz</h1>
                            </div>
                            <div class="user">
                                <div class="form-group">
                                    <asp:TextBox ID="txtQuestion" runat="server" CssClass="form-control form-control-user"  placeholder="Add Content Here" Style="height: 200px" TextMode="MultiLine"></asp:TextBox>
                                    
                                </div>
                                
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control form-control-user" ID="txtOption1" placeholder="Option 1" runat="server"></asp:TextBox>
                                    
                                </div>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control form-control-user" ID="txtOption2" placeholder="Option 2" runat="server"></asp:TextBox>
                                    
                                </div>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control form-control-user" ID="txtOption3" placeholder="Option 3" runat="server"></asp:TextBox>
                                    
                                </div>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control form-control-user" ID="txtOption4" placeholder="Option 4" runat="server"></asp:TextBox>
                                    
                                </div>
                                <div class="form-group">
                                        <asp:DropDownList CssClass="form-control form-control-user" ID="cmbCorrectOption" placeholder="Activities" runat="server">
                                            <asp:ListItem>Option 1</asp:ListItem>
                                            <asp:ListItem>Option 2</asp:ListItem>
                                            <asp:ListItem>Option 3</asp:ListItem>
                                            <asp:ListItem>Option 4</asp:ListItem>
                                        </asp:DropDownList>

                                    </div>
                                
                                
                                <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnAdd" runat="server" Text="Add Quiz" OnClick="btnAdd_Click1" />
                                <hr />
                                <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                                
                            </div>
                        </div>
                    
                </div>
                
                    
               
        </div>

    </div>
</asp:Content>
