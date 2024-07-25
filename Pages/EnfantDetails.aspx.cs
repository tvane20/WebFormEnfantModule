using System;
using WebFormEnfant.Models;
using WebFormEnfant.BLL;

namespace WebFormEnfant
{
    public partial class EnfantDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int enfantId;
                if (int.TryParse(Request.QueryString["id"], out enfantId))
                {
                    DisplayEnfantDetails(enfantId);
                }
                else
                {
                    // Gérer le cas où l'ID n'est pas valide
                    Response.Redirect("EnfantsList.aspx");
                }
            }
        }

        private void DisplayEnfantDetails(int id)
        {
            try
            {
                EnfantBLL enfantBLL = new EnfantBLL();
                EnfantModel enfant = enfantBLL.GetEnfantById(id);

                FirstNameValue.Text = enfant.FirstName;
                LastNameValue.Text = enfant.LastName;
                TutorNameValue.Text = enfant.TutorName;
                CINValue.Text = enfant.CIN;
                PhoneValue.Text = enfant.Phone;
                AddressValue.Text = enfant.Address;
                ProvinceValue.Text = enfant.Province;
                CityValue.Text = enfant.City;
                EmailValue.Text = enfant.Email;
            }
            catch (ApplicationException ex)
            {
                // Gérer les exceptions et afficher les messages d'erreur
                // Optionnellement, rediriger vers la liste ou afficher un message d'erreur
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            // Redirection vers la liste des enfants
            Response.Redirect("EnfantsList.aspx");
        }
    }
}
