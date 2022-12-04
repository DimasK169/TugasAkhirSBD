<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RecycleTanaman.aspx.cs" Inherits="Tugasakhir2.RecycleTanaman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
        <div class="row mb-3">
            <label for="TxtCari" class="col-sm-2 col-form-label">ID Tumbuhan</label>
            <div class="col-sm-10">
                <asp:TextBox ID="TxtIdDeletedTumbuhan" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonRestore" runat="server" Text="Restore" OnClick="ButtonRestore_Click" style="height: 29px" />
                <asp:Button ID="ButtonClick" runat="server" Text="Delete" OnClick="ButtonDelete_Click" />
            </div>
        </div>
         <div class="row mb-3">
            <label for="TxtNamaLatin" class="col-sm-2 col-form-label">ID Kegunaan</label>
            <div class="col-sm-10">
               <asp:TextBox ID="TxtIdDeletedKegunaan" CssClass= "form-control" runat="server" ></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Restore" OnClick="ButtonRestoreKegunaan_Click" style="height: 29px" />
                <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="ButtonDeleteKegunaan_Click" />
            </div>
        </div>
        <asp:GridView ID="GridViewDeleted" runat="server" HorizontalAlign="Center"></asp:GridView>
        <asp:GridView ID="GridViewDeletedKegunaan" runat="server" HorizontalAlign="Center"></asp:GridView>
    </div>
</asp:Content>
