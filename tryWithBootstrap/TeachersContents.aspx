<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherDash.Master" AutoEventWireup="true" CodeBehind="TeachersContents.aspx.cs" Inherits="tryWithBootstrap.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container ">
        <div class="card o-hidden border-0 shadow-lg my-5 ">
            
            <div class="card-body p-0 " >
                <!-- Nested Row within Card Body -->
                <div class="row">
                    <div class="col-lg-5 d-none d-lg-block">
                        <div class="p-5">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Add File</h1>
                            </div>
                            <div class="user">
                                <div class="form-group">
                                    <div class="mb-3">
                                        <asp:DropDownList CssClass="form-control form-control-user" ID="cmbActivity" placeholder="Activities" runat="server">
                                            <asp:ListItem></asp:ListItem>
                                            <asp:ListItem>Assignment</asp:ListItem>
                                            <asp:ListItem>Note</asp:ListItem>
                                            <asp:ListItem>Video</asp:ListItem>
                                        </asp:DropDownList>

                                    </div>
                                   
                                </div>
                                <div class="form-group">
                                    <asp:FileUpload CssClass="form-control form-control-user" ID="FileUpload1" runat="server" />
                                    
                                </div>
                                <div class="form-group">
                                     <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnSave" runat="server" Text="Save" onClick="btnSave_Click1" />
                                    <hr />
                                    <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                                
                                </div>
                               
                               
                            </div>
                        </div>
                    </div>
               
                    <div class="col-lg-7">
                        <div class="p-5">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Add Content</h1>
                            </div>
                            <div class="user">
                                
                             <div class="mb-3">
                                <asp:TextBox CssClass="form-control form-control-user" ID="txtTitle" placeholder="Title" runat="server"></asp:TextBox>
                                    
                            </div>
                            <div class="mb-3">
                                <asp:TextBox ID="txtContent" runat="server" CssClass="form-control form-control-user"  placeholder="Add Content Here" Style="height: 440px" TextMode="MultiLine"></asp:TextBox>
                                    
                            </div>  
                                
                            <div class=" mb-3">
                                <asp:Button CssClass="btn btn-primary btn-user btn-block mb-4" ID="btnAdd" runat="server" Text="Add Post" OnClick="btnAdd_Click" />
                                   
                            </div>
                            <div class="mb-3">
                                <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnClearPost" runat="server" Text="Clear" OnClick="btnClearPost_Click" />

                            </div>
                           </div>
                        </div>
                    </div>
                </div>
              </div>
            </div>
        </div>
</asp:Content>
