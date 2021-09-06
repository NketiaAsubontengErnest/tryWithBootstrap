<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherDash.Master" AutoEventWireup="true" CodeBehind="TeacherViewResults.aspx.cs" Inherits="tryWithBootstrap.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="card shadow mb-4"> 
            <div class="card-body">
                <div class="table-responsive">
                    <asp:GridView CssClass="table table-bordered" style="width:100%" ID="MarksGridView" runat="server" AutoGenerateColumns="False"  >

                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="Student_Index" HeaderText="Student Idex" />
                            <asp:BoundField DataField="Marks" HeaderText="Marks" />
                            <asp:BoundField DataField="Submited_Time" HeaderText="Submited_Time" />
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
</asp:Content>
