using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormEnfant.Models;

namespace WebFormEnfant.BLL
{
    public class EnfantBLL
    {
        private EnfantDAL enfantDAL = new EnfantDAL();

        public List<EnfantModel> GetAllEnfants()
        {
            return enfantDAL.GetAllEnfants();
        }

        public void AddEnfant(EnfantModel enfant)
        {
            enfantDAL.AddEnfant(enfant);
        }

        // Ajoutez ici d'autres méthodes pour CRUD (Create, Update, Delete)

        public EnfantModel GetEnfantById(int id)
        {
            return enfantDAL.GetEnfantById(id);
        }

        public void UpdateEnfant(EnfantModel enfant)
        {
            enfantDAL.UpdateEnfant(enfant);
        }

        public void DeleteEnfant(int id)
        {
            try
            {
                enfantDAL.DeleteEnfant(id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur lors de la suppression de l'enfant.", ex);
            }
        }

    }
}