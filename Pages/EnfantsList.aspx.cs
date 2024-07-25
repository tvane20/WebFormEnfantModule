// EnfantsList.aspx.cs
using System;
using WebFormEnfant.Models;
using WebFormEnfant.BLL;
using System.Web.UI.WebControls;

namespace WebFormEnfant
{
    public partial class EnfantsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEnfantsRepeater();
            }
            EnfantsRepeater.ItemCommand += EnfantsRepeater_ItemCommand;
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            // Redirection vers la page d'ajout
            Response.Redirect("AddEnfant.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int enfantId = Convert.ToInt32(btn.CommandArgument);

            try
            {
                EnfantBLL enfantBLL = new EnfantBLL();
                enfantBLL.DeleteEnfant(enfantId);
                BindEnfantsRepeater(); // Rebind the repeater to reflect the deletion
            }
            catch (ApplicationException ex)
            {
                ErrorMessageLabel.Text = ex.Message;
                ErrorMessageLabel.Visible = true;
            }
        }

        protected void btnDetails_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int enfantId = Convert.ToInt32(btn.CommandArgument);

            // Redirection vers la page de détails en passant l'ID de l'enfant dans la query string
            Response.Redirect($"EnfantDetails.aspx?id={enfantId}");
        }


        private void BindEnfantsRepeater()
        {
            try
            {

            EnfantBLL enfantBLL = new EnfantBLL();
            EnfantsRepeater.DataSource = enfantBLL.GetAllEnfants();
            EnfantsRepeater.DataBind();
            }
            catch (ApplicationException ex)
            {
                ErrorMessageLabel.Text = ex.Message;
                ErrorMessageLabel.Visible = true;
            }

        }
        protected void EnfantsRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"EditEnfant.aspx?id={id}");
            }
        }

    }
}
