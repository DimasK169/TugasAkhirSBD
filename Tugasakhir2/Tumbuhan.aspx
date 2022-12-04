<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Tumbuhan.aspx.cs" Inherits="Tugasakhir2.bootstrap.Tumbuhan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <asp:Label ID="Label1" runat="server" Text="Form Tumbuhan"></asp:Label>
        <div class="row mb-3">
            <label for="TxtNamaLatin" class="col-sm-2 col-form-label">ID Tumbuhan</label>
            <div class="col-sm-10">
               <asp:TextBox ID="TxtTumbuhanID" CssClass= "form-control" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div class="row mb-3">
            <label for="TxtNamaLatin" class="col-sm-2 col-form-label">Nama Latin</label>
            <div class="col-sm-10">
               <asp:TextBox ID="TxtNamaLatin" CssClass= "form-control" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div class="row mb-3">
            <label for="TxtNamaUmum" class="col-sm-2 col-form-label">Nama Umum</label>
            <div class="col-sm-10">
                <asp:TextBox ID="TxtNamaUmum" CssClass= "form-control" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div class="row mb-3">
            <label for="TxtKlasifikasiId" class="col-sm-2 col-form-label">ID Klasifikasi</label>
            <div class="col-sm-10">
               <asp:TextBox ID="TxtKlasifikasiID" CssClass= "form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row mb-3">
            <label for="TxtKegunaanId" class="col-sm-2 col-form-label">ID Kegunaan</label>
            <div class="col-sm-10">
                <asp:TextBox ID="TxtKegunaanID" CssClass= "form-control" runat="server"></asp:TextBox>
            </div>
        </div>
    <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" />
    <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
    <asp:Button ID="btnClear" runat="server" Text="CLEAR" OnClick="btnClear_Click" />
    </div>
    <asp:GridView ID="T_GridView" runat="server" HorizontalAlign="Center"></asp:GridView>
    <asp:GridView ID="TKl_GridView" runat="server" HorizontalAlign="Center"></asp:GridView>
    <asp:GridView ID="TKe_GridView" runat="server" HorizontalAlign="Center"></asp:GridView>
</asp:Content>
