<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="MesajOlustur.aspx.cs" Inherits="WebApplication2.MesajOluştur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TxtGonderen" runat="server" Width="300px">GÖNDEREN</asp:Label>
                 <asp:TextBox ID="TxtGonderen" runat="server" CssClass="form-control" Width="300px" Enabled="False"></asp:TextBox>
            </div>
            <br>
            <div>
                <asp:Label for="TxtAlici" runat="server">ALICI </asp:Label>
                <asp:TextBox ID="TxtAlici" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
            <br>    
            <div>
                <asp:Label for="TxtBaslik" runat="server" Width="500px">BAŞLIK</asp:Label>
                <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
            <br>    
            <div>
                 <asp:Label for="Txticerik" runat="server" Width="500px">İÇERİK</asp:Label>
                 <asp:TextBox ID="Txticerik" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
         <asp:Button ID="BtnGonder" runat="server" Text="GÖNDER" OnClick="BtnGonder_Click" />
    </form>
</asp:Content>
