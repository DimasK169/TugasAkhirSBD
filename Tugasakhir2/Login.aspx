<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tugasakhir2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" >
    <link href="additional-file/css/global.css" rel="stylesheet" />
    <script src="bootstrap/js/bootstrap.min.js"></script>
</head>
<body>
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-4 col-sm-12"></div>
                <div class="col-md-4 col-sm-12">
                    <form class="container-form" runat="server">
                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Username</label>
                        <asp:TextBox ID="TxtUser" CssClass= "form-control" runat="server" placeholder="Masukkan Username"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Password</label>
                        <asp:TextBox ID="TxtPassword" TextMode="Password" CssClass= "form-control" runat="server" placeholder="Masukkan Password"></asp:TextBox>
                    </div>
                        <asp:Button ID="BtnLogin" OnClick="BtnLogin_Click" CssClass="btn btn-primary" runat="server" Text="Login" />
                        <asp:Label ID="LblWarining" CssClass="text-danger" runat="server"></asp:Label>
                </form>
                </div>
                <div class="col-md-4 col-sm-12"></div>
            </div>
        </div>
</body>
</html>
