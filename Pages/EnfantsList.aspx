<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnfantsList.aspx.cs" Inherits="WebFormEnfant.EnfantsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleContent" runat="server">
    Liste d'enfants
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Contrôle Label pour afficher les messages d'erreur -->
    <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red" Visible="False"></asp:Label>

    <div class="card shadow mb-4">

        <div class="card-header py-3 clearfix">

            <asp:Button ID="btnAddNew" runat="server" Text="Ajouter un Enfant" OnClick="btnAddNew_Click" CssClass="btn btn-primary float-right" />
            <h6 class="m-0 font-weight-bold text-primary float-left">Liste des Enfants</h6>
        </div>

        <div class="card-body">
            <div class="table-responsive">



                <asp:Repeater ID="EnfantsRepeater" runat="server">

                    <HeaderTemplate>
                        <table id="EnfantsTable" class="table">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>First Name</th>
                                    <th>Last Name</th>
                                    <th>Tutor Name</th>
                                    <th>CIN</th>
                                    <th>Phone</th>
                                    <th>Address</th>
                                    <th>Province</th>
                                    <th>City</th>
                                    <th>Email</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Id") %></td>
                            <td><%# Eval("FirstName") %></td>
                            <td><%# Eval("LastName") %></td>
                            <td><%# Eval("TutorName") %></td>
                            <td><%# Eval("CIN") %></td>
                            <td><%# Eval("Phone") %></td>
                            <td><%# Eval("Address") %></td>
                            <td><%# Eval("Province") %></td>
                            <td><%# Eval("City") %></td>
                            <td><%# Eval("Email") %></td>
                            <td>
                                 <div class="dropdown">
                                    <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        Actions
                                    </button>
                                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                                        <asp:LinkButton class="dropdown-item" ID="EditButton" runat="server" CommandName="Edit" CommandArgument='<%# Eval("Id") %>' Text="Edit" />
                                        <asp:LinkButton class="dropdown-item" ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("Id") %>' Text="Delete" OnClick="btnDelete_Click" />
                                        <asp:LinkButton class="dropdown-item" ID="btnDetails" runat="server" CommandName="Details" CommandArgument='<%# Eval("Id") %>' Text="Details" OnClick="btnDetails_Click" />
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
            </table>
       
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>

</asp:Content>
