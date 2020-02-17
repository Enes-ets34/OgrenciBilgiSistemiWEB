<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DuyuruEkle.aspx.cs" Inherits="WebApplication2.DuyuruEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="DropDownList1" runat="server" Width="300px">DUYURU SAHİBİ</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="300px"></asp:DropDownList>
            </div>
            <br>
            <div>
                <asp:Label for="TxtDuyuruBaslik" runat="server">DUYURU BAŞLIĞI </asp:Label>
                <asp:TextBox ID="TxtDuyuruBaslik" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <asp:Label for="TxtDuyuruicerik" runat="server" Width="500px">İÇERİK</asp:Label>
                <textarea id="TxtDuyuruicerik" rows="6" class="form-control" runat="server" Width="500px"></textarea>
            </div>
        </div>
         <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" />
    </form>
</asp:Content>
