<%@ Page Title="Editer un Enfant" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEnfant.aspx.cs" Inherits="WebFormEnfant.EditEnfant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleContent" runat="server">
    Editer un Enfant
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editer un Enfant</h2>
    <asp:Panel ID="EditEnfantPanel" runat="server">
       <div class="bs-callout bs-callout-warning hidden">
    <h4>Attention!</h4>
    <p>Il semble avoir des champs invalide! :(</p>
</div>

<div class="bs-callout bs-callout-info hidden">
    <h4>Yay!</h4>
    <p>Tout est bon, vous pouvez soumettre le formulaire :)</p>
</div>

<div class="form-group">
    <asp:Label ID="FirstNameLabel" runat="server" Text="First Name:" AssociatedControlID="FirstNameTextBox"></asp:Label>
    <asp:TextBox ID="FirstNameTextBox" runat="server" CssClass="form-control" required="" data-parsley-trigger="change" />
</div>
<div class="form-group">
    <asp:Label ID="LastNameLabel" runat="server" Text="Last Name:" AssociatedControlID="LastNameTextBox"></asp:Label>
    <asp:TextBox ID="LastNameTextBox" runat="server" CssClass="form-control" required="" data-parsley-trigger="change" />
</div>
<div class="form-group">
    <asp:Label ID="TutorNameLabel" runat="server" Text="Tutor Name:" AssociatedControlID="TutorNameTextBox"></asp:Label>
    <asp:TextBox ID="TutorNameTextBox" runat="server" CssClass="form-control" required="" data-parsley-trigger="change" />
</div>
<div class="form-group">
    <asp:Label ID="CINLabel" runat="server" Text="CIN:" AssociatedControlID="CINTextBox"></asp:Label>
    <asp:TextBox ID="CINTextBox" runat="server" CssClass="form-control" required="" data-parsley-trigger="change" />
</div>
<div class="form-group">
    <asp:Label ID="PhoneLabel" runat="server" Text="Phone:" AssociatedControlID="PhoneTextBox"></asp:Label>
    <asp:TextBox ID="PhoneTextBox" runat="server" CssClass="form-control" data-parsley-type="digits" data-parsley-length="[10, 15]" required="" data-parsley-trigger="change" />
</div>
<div class="form-group">
    <asp:Label ID="AddressLabel" runat="server" Text="Address:" AssociatedControlID="AddressTextBox"></asp:Label>
    <asp:TextBox ID="AddressTextBox" runat="server" CssClass="form-control" required="" data-parsley-trigger="change" />
</div>
<div class="form-group">
    <asp:Label ID="ProvinceLabel" runat="server" Text="Province:" AssociatedControlID="ProvinceTextBox"></asp:Label>
    <asp:TextBox ID="ProvinceTextBox" runat="server" CssClass="form-control" required="" data-parsley-trigger="change" />
</div>
<div class="form-group">
    <asp:Label ID="CityLabel" runat="server" Text="City:" AssociatedControlID="CityTextBox"></asp:Label>
    <asp:TextBox ID="CityTextBox" runat="server" CssClass="form-control" required="" data-parsley-trigger="change" />
</div>
<div class="form-group">
    <asp:Label ID="EmailLabel" runat="server" Text="Email:" AssociatedControlID="EmailTextBox"></asp:Label>
    <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control" data-parsley-type="email" required="" data-parsley-trigger="change" />
</div>
        <asp:Button ID="SaveButton" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="SaveButton_Click" />
        <asp:Button ID="CancelButton" runat="server" Text="Annuler" CssClass="btn btn-secondary" OnClick="CancelButton_Click" />
    </asp:Panel>
</asp:Content>
