<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="AdminCheckList.aspx.cs" Inherits="tryWithBootstrap.WebForm5" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="card shadow mb-4"> 
            <div class="card-body">
                <div class="card-header" style="height:40px">
                            <h3 class="m-0 font-weight-bold text-primary">Student List</h3>
                        </div>
                <div class="table-responsive">
                     <asp:GridView ID="StudentGridView" CssClass="table table-bordered" CellSpacing="0" CellStyle-Height="0" style="height:2px"  runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="0" GridLines="Vertical" OnRowEditing="StudentGridView_RowEditing" DataKeyNames="ID" OnRowCancelingEdit="StudentGridView_RowCancelingEdit" OnRowUpdating="StudentGridView_RowUpdating1" OnRowDeleting="StudentGridView_RowDeleting" ShowHeaderWhenEmpty="True">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns >   
                           <asp:BoundField DataField="Index_No" HeaderText="Index No" ReadOnly="True" />        
                           <asp:BoundField DataField="F_Name" HeaderText="First Name" />   
                           <asp:BoundField DataField="S_Name" HeaderText="Second Name" />        
                           <asp:BoundField DataField="Teacher_Name" HeaderText="Teacher Name" />        
                           <asp:CommandField ButtonType="Image" CancelImageUrl="~/images/images/cancel.png" EditImageUrl="~/images/images/edit.png" ShowEditButton="True" UpdateImageUrl="~/images/images/Update.png" ControlStyle-Width="20px" ControlStyle-Height="20px" >    
                            
                        <ControlStyle Height="20px" Width="20px"></ControlStyle>
                                    </asp:CommandField>
                                    <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/images/delete.png" ShowDeleteButton="True" ControlStyle-Width="20px" ControlStyle-Height="20px" >
                        <ControlStyle Height="20px" Width="20px"></ControlStyle>
                        </asp:CommandField>
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
    </div>
   <%-- <div class="container-fluid">--%>
        <div class="card shadow mb-4"> 
            <div class="card-body">
                <div class="card-header" style="height:40px">
                    <h3 class="m-0 font-weight-bold text-primary">Teachers List</h3>
                </div>
                <div class="table-responsive">
                     <asp:GridView ID="TeachersGridView" runat="server" CssClass="table table-bordered" CellSpacing="0" CellStyle-Height="0" style="height:2px" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="0" GridLines="Vertical" OnRowCancelingEdit="TeachersGridView_RowCancelingEdit" OnRowEditing="TeachersGridView_RowEditing" OnRowUpdating="TeachersGridView_RowUpdating" OnRowDeleting="TeachersGridView_RowDeleting">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="Staff_ID" HeaderText="Staff ID" ReadOnly="True" />
                            <asp:BoundField DataField="F_Name" HeaderText="First Name" />
                            <asp:BoundField DataField="S_Name" HeaderText="Second Name" />
                            <asp:BoundField DataField="Subject" HeaderText="Subject" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:CommandField ButtonType="Image" CancelImageUrl="~/images/images/cancel.png" EditImageUrl="~/images/images/edit.png" ShowEditButton="True" UpdateImageUrl="~/images/images/Update.png" ControlStyle-Width="20px" ControlStyle-Height="20px">
                            <ControlStyle Height="20px" Width="20px"></ControlStyle>
                                        </asp:CommandField>
                                        <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/images/delete.png" ShowDeleteButton="True" ControlStyle-Width="20px" ControlStyle-Height="20px" >
                            <ControlStyle Height="20px" Width="20px"></ControlStyle>
                                        </asp:CommandField>
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
    <%--</div>--%>
                      
                                               
</asp:Content>
