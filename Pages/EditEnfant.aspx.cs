using System;
using WebFormEnfant.Models;
using WebFormEnfant.BLL;

namespace WebFormEnfant
{
    public partial class EditEnfant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                EnfantBLL enfantBLL = new EnfantBLL();
                EnfantModel enfant = enfantBLL.GetEnfantById(id);

                if (enfant != null)
                {
                    FirstNameTextBox.Text = enfant.FirstName;
                    LastNameTextBox.Text = enfant.LastName;
                    TutorNameTextBox.Text = enfant.TutorName;
                    CINTextBox.Text = enfant.CIN;
                    PhoneTextBox.Text = enfant.Phone;
                    AddressTextBox.Text = enfant.Address;
                    ProvinceTextBox.Text = enfant.Province;
                    CityTextBox.Text = enfant.City;
                    EmailTextBox.Text = enfant.Email;
                    ViewState["EditId"] = enfant.Id;
                }
                else
                {
                    // Gérer le cas où l'enfant n'est pas trouvé
                    Response.Redirect("EnfantsList.aspx");
                }
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int id = Convert.ToInt32(ViewState["EditId"]);
                EnfantModel updatedEnfant = new EnfantModel
                {
                    Id = id,
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    TutorName = TutorNameTextBox.Text,
                    CIN = CINTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Address = AddressTextBox.Text,
                    Province = ProvinceTextBox.Text,
                    City = CityTextBox.Text,
                    Email = EmailTextBox.Text
                };

                EnfantBLL enfantBLL = new EnfantBLL();
                enfantBLL.UpdateEnfant(updatedEnfant);

                // Rediriger ou notifier l'utilisateur que l'édition a réussi
                Response.Redirect("EnfantsList.aspx");
            }
        }
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Rediriger vers la page de la liste des enfants
            Response.Redirect("EnfantsList.aspx");
        }
    }
}
