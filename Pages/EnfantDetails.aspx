<%@ Page Title="Détails de l'Enfant" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnfantDetails.aspx.cs" Inherits="WebFormEnfant.EnfantDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleContent" runat="server">
    Détails de l'Enfant
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-4">
        <div class="card mt-4">
            <div class="card-header bg-primary text-white">
                <h4 class="text-center">Détails de l'Enfant : <asp:Label ID="LastNameLabel" runat="server" CssClass="text-light" /></h4>
            </div>
            <div class="card-body">
                <dl class="row">
                    <dt class="col-sm-3">Prénom :</dt>
                    <dd class="col-sm-9">
                        <asp:Label ID="FirstNameValue" runat="server"  />
                    </dd>

                    <dt class="col-sm-3">Nom :</dt>
                    <dd class="col-sm-9">
                        <asp:Label ID="LastNameValue" runat="server"  />
                    </dd>

                    <dt class="col-sm-3">Nom du Tuteur :</dt>
                    <dd class="col-sm-9">
                        <asp:Label ID="TutorNameValue" runat="server"  />
                    </dd>

                    <dt class="col-sm-3">CIN :</dt>
                    <dd class="col-sm-9">
                        <asp:Label ID="CINValue" runat="server"  />
                    </dd>

                    <dt class="col-sm-3">Téléphone :</dt>
                    <dd class="col-sm-9">
                        <asp:Label ID="PhoneValue" runat="server"  />
                    </dd>

                    <dt class="col-sm-3">Adresse :</dt>
                    <dd class="col-sm-9">
                        <asp:Label ID="AddressValue" runat="server"  />
                    </dd>

                    <dt class="col-sm-3">Province :</dt>
                    <dd class="col-sm-9">
                        <asp:Label ID="ProvinceValue" runat="server"  />
                    </dd>

                    <dt class="col-sm-3">Ville :</dt>
                    <dd class="col-sm-9">
                        <asp:Label ID="CityValue" runat="server"  />
                    </dd>

                    <dt class="col-sm-3">Email :</dt>
                    <dd class="col-sm-9">
                        <asp:Label ID="EmailValue" runat="server"  />
                    </dd>
                </dl>
            </div>
            <div class="card-footer text-center">
                <asp:Button ID="BackButton" runat="server" Text="Retour à la liste" CssClass="btn btn-secondary mx-2" OnClick="BackButton_Click" />
            </div>
        </div>
    </div>
</asp:Content>
