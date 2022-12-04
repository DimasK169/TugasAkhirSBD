<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Kegunaan.aspx.cs" Inherits="Tugasakhir2.Tabel.Kegunaan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <asp:Label ID="Label1" runat="server" Text="Form Kegunaan"></asp:Label>
        <div class="row mb-3">
            <label for="TxtKegunaanID" class="col-sm-2 col-form-label">ID Kegunaan</label>
            <div class="col-sm-10">
               <asp:TextBox ID="TxtKegunaanID" CssClass= "form-control" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div class="row mb-3">
            <label for="TxtNamaLatin" class="col-sm-2 col-form-label">Jenis Kegunaan</label>
            <div class="col-sm-10">
               <asp:TextBox ID="TxtKegunaan" CssClass= "form-control" runat="server" ></asp:TextBox>
            </div>
        </div>
            <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" />
    <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
    <asp:Button ID="btnClear" runat="server" Text="CLEAR" OnClick="btnClear_Click" />
    <asp:GridView id="Ke_GridView" runat="server" HorizontalAlign="Center"></asp:GridView>

        </div>
</asp:Content>
