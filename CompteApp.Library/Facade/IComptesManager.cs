using ODDO.Clients.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteApp.Library.Facade
{
    public interface IComptesManager
    {
        //CRUD
        void OuvrirCompte(Compte e);
        Compte FindById(string id);
        IEnumerable<Compte> FindAll();
        void Update(Compte c);
        void Delete(string id);
    }
}
