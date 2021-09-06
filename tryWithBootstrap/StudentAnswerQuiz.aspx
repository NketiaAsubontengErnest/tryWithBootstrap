<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAnswerQuiz.aspx.cs" Inherits="tryWithBootstrap.StudentAnswerQuiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Quiz</title>

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>

    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>

    <!-- Custom styles for this template-->
    <link href="css/sb-admin-2.min.css" rel="stylesheet"/>
    <link href="css/sb-admin-2.min.css" rel="stylesheet"/>
</head>
<body class="bg-gradient-primary" onload="startCountdown(50);">
    <form id="form1" runat="server">
    <script>
       function startCountdown(timeLeft) {
           var interval = setInterval(countdown, 1000);
           update();

           function countdown() {
               if (--timeLeft > 0) {
                   update();
               } else {
                   clearInterval(interval);
                   update();
                   completed();
               }
           }

           function update() {
               hours = Math.floor(timeLeft / 3600);
               minutes = Math.floor((timeLeft % 3600) / 60);
               seconds = timeLeft % 60;

               document.getElementById('lblTimer').innerHTML = '' + hours + ':' + minutes + ':' + seconds;
           }
           function completed() {
               document.getElementById('btnSubmit').click();
           }
       }

    </script>
 
        <!-- Topbar -->
                <nav class="navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow">
                    <!-- Topbar Search -->
                    <div class="navbar-nav text-center ml-auto ">
                        <h1 class="h3 mb-4 text-gray-800 text-center ">Quiz</h1>
                    </div>
                   <ul class="navbar-nav ml-auto">
                        <!-- Nav Item - User Information -->
                        <li class="nav-item dropdown no-arrow">
                            <a class="nav-link dropdown-toggle" href="#" id="userDropdown" role="button"
                                data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                <asp:Label ID="lblID" CssClass="mr-2 d-none d-lg-inline text-gray-600 small" runat="server" Text="Label"></asp:Label>
                                
                                <asp:Image ID="Image1" CssClass="img-profile rounded-circle" runat="server" />
                                
                            </a>
                            <!-- Dropdown - User Information -->
                            <div class="dropdown-menu dropdown-menu-right shadow animated--grow-in"
                                aria-labelledby="userDropdown">
                                <div class="dropdown-divider"></div>
                                <a class="dropdown-item" href="~/LoginForm.aspx" data-toggle="modal" data-target="#logoutModal">
                                    <i class="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"></i>
                                    Logout
                                </a>
                            </div>
                        </li>

                    </ul>

                </nav>
                <!-- End of Topbar -->
        <div class="container-fluid">
            <div class="card shadow mb-4"> 
               
                <asp:Label class="h3 mb-4 text-gray-800 ml-auto" ID="lblTimer" runat="server" Text="Label">

                </asp:Label> <asp:Label class="h3 mb-4 text-gray-800 ml-auto" ID="Label1" runat="server" Text="Results" ></asp:Label>

            </div>
        </div>
        
         <div class="container-fluid">
            <div class="card shadow mb-4"> 
                <div class="card-body">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                        <table>
                            <tr>
                                <td>
                                    <%# Eval("ID")%>. <%# Eval("Question") %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h4>Select one: </h4>
                                </td>
                            </tr>
                                <tr>
                                    <td>
                                        <asp:RadioButton ID="RadOption1" runat="server" Text='<%#Eval("Option1")%>' GroupName="rdExam"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:RadioButton ID="RadOption2" runat="server" Text='<%#Eval("Option2")%>' GroupName="rdExam"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:RadioButton ID="RadOption3" runat="server" Text='<%#Eval("Option3")%>' GroupName="rdExam"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:RadioButton ID="RadOption4" runat="server" Text='<%#Eval("Option4")%>' GroupName="rdExam"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblCorrect" runat="server" Text='<%#Eval("Answer")%>' Visible ="false"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblSelectedAns" runat="server" CssClass="labels" Text='<%#Eval("Answer")%>' Visible ="false"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            </ItemTemplate>
                   </asp:Repeater>
                </div>
            </div>
        </div>
        <div class="container-fluid">
            <div class="card shadow mb-4"> 
                <div class="card-body">
                     <a class="btn btn-success btn-icon-split" target="Button1_Click">
                        <span class="icon text-white-50">
                            <i class="fas fa-check"></i>
                        </span>
                          <asp:Button CssClass="text" ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"   />
                    </a>
                 </div>
            </div>
        </div>
    </form>
</body>
</html>
