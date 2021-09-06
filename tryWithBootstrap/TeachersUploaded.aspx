<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherDash.Master" AutoEventWireup="true" CodeBehind="TeachersUploaded.aspx.cs" Inherits="tryWithBootstrap.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Begin Page Content -->
    <div class="container-fluid">
         <div class="card shadow mb-4"> 
            <h1 class="h3 mb-4 text-gray-800 text-center">My Uploads</h1>
        </div>
    </div>
        <div class="container-fluid">
            <div class="card shadow mb-4"> 
               
                <!-- Page Heading -->
                
                <div class="card-body">
                     <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                             <table>
                                 <tr>
                                     <td>
                                         <h2><b><%# Eval("Title") %></b></h2>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td><%# Eval("Content") %></td>
                                 </tr>
                             </table>
                             <br />
                         </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
         </div>

        <div class="card shadow mb-4"> 
            <div class="card-body">
                <div class="card-header" style="height:40px">
                    <h3 class="m-0 font-weight-bold text-primary">Teachers List</h3>
                </div>
                <div class="table-responsive">
                    <asp:GridView CssClass="table table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 1; width:100%" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                       <Columns>
                            <asp:BoundField DataField="Text" HeaderText="File Name" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                </div>
            </div>
        </div>
        <!-- /.container-fluid -->
   
</asp:Content>
