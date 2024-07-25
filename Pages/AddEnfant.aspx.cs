// AddEnfant.aspx.cs
using System;
using WebFormEnfant.Models;
using WebFormEnfant.BLL;

namespace WebFormEnfant
{
    public partial class AddEnfant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Code de chargement de la page, si nécessaire
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Créer un nouvel objet EnfantModel avec les valeurs du formulaire
                EnfantModel newEnfant = new EnfantModel
                {

                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    TutorName = TutorNameTextBox.Text,
                    CIN = CINTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Address = AddressTextBox.Text,
                    Province = ProvinceTextBox.Text,
                    City = CityTextBox.Text,
                    Email = EmailTextBox.Text
                    // Assignez les autres propriétés en utilisant les valeurs des contrôles
                };

                // Appeler la couche BLL pour ajouter l'enfant à la base de données
                EnfantBLL enfantBLL = new EnfantBLL();
                enfantBLL.AddEnfant(newEnfant);

                // Rediriger ou notifier l'utilisateur que l'ajout a réussi
                Response.Redirect("EnfantsList.aspx");
            }
        }
    }
}
