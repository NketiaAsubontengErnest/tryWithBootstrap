<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="tryWithBootstrap.Manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content="'/>

    <title>Manage Account</title>

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet"/>

    <!-- Custom styles for this template-->
    <link href="css/sb-admin-2.min.css" rel="stylesheet"/>
</head>
<body class="bg-gradient-primary">
    <div class="container">
        <form id="form1"  runat="server">
            <div class="card o-hidden border-0 shadow-lg my-5 ">
                <div class="card-body p-0 " >
                    <!-- Nested Row within Card Body -->
                    <div class="row">
                        <div class="col-lg-5 d-none d-lg-block bg-register-image">
                            <div class="p-5">
                                <div class="text-center">
                                    <h1 class="h4 text-gray-900 mb-4">Details</h1>
                                </div>
                                <hr class="h-100" />
                                <div class="form-group">
                                    <label for="txtID">ID: <asp:TextBox CssClass="form-control form-control-user" ID="txtID" runat="server" ReadOnly="true"></asp:TextBox>
                                    </label> 
                               
                                </div>
                                 <div>
                                    <asp:Image CssClass="img-thumbnail img-fluid" BorderStyle="Groove" Style="height:100px; width:100px" ID="Image1" runat="server" />
                                </div>
                                <div>
                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                                </div>
                                <div class="form-group"></div>
                                <div class="form-group">
                                    <label for="txtID">First Name:</label>  <asp:TextBox CssClass="form-control form-control-user" ID="txtFirstName" runat="server" ReadOnly="true"></asp:TextBox>
                                  
                                </div>
                                <div class="form-group">
                                    <label for="txtID">Second Name:</label>  <asp:TextBox CssClass="form-control form-control-user" ID="txtSecondName" runat="server" ReadOnly="true"></asp:TextBox>
                                  
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="btnSave" runat="server" CssClass="btn btn-outline-primary" Text="Save Change" OnClick="btnSave_Click" />
                                </div>
                            </div>



                        </div>
                    
                        <div class="col-lg-7">
                            <div class="p-5">
                                <div class="text-center">
                                    <h1 class="h4 text-gray-900 mb-4">CHANGE PASSWORD</h1>
                                </div>
                                <hr class="h-100" />
                                <div class="user">
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control form-control-user" ID="txtOldPassword" placeholder="Old Password" runat="server"></asp:TextBox>
                                    
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox type="Password" CssClass="form-control form-control-user" ID="txtNewPassword" placeholder="New Password" runat="server"></asp:TextBox>
                                    
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox type="Password" CssClass="form-control form-control-user" ID="txtConfirmNew" placeholder="Confirm New Password" runat="server"></asp:TextBox>
                                    
                                    </div>
                                
                                    <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnChange" runat="server" Text="Change" OnClick="btnChange_Click" />
                                    <hr />
                                    <asp:Button CssClass="btn btn-primary btn-user btn-block" ID="btnClear" runat="server" Text="Clear" />
                                
                                </div>
                            </div>
                        </div>

                    
                    </div>
                </div>
            </div>
    
   
        </form>

    </div>
    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="js/sb-admin-2.min.js"></script>
</body>
</html>
