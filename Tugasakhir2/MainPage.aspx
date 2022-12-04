<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Tugasakhir2.bootstrap.MainPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <div class="row mb-3">
            <label for="TxtKegunaanID" class="col-sm-2 col-form-label">Cari Tumbuhan</label>
            <div class="col-sm-10">
                <asp:TextBox ID="TxtCari" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonCari" runat="server" Text="Cari" OnClick="ButtonCari_Click" />
                <asp:Button ID="ButtonReset" runat="server" Text="Reset" OnClick="ButtonReset_Click" />
            </div>
        </div>
        <asp:GridView ID="GridView" runat="server" HorizontalAlign="Center"></asp:GridView>
    </div>
</asp:Content>
