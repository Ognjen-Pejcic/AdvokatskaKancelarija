using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using DbBroker;
using System.Windows.Forms;

namespace SistemskeOperacije
{
    public abstract class ApstraknaGenerickaOperacija
    {
        protected abstract object Execute(DomenskiObjekat domenskiObjekat);
        protected abstract void Validate(DomenskiObjekat domenskiObjekat);

        protected Broker broker = new Broker();

        public object ExecuteSO(DomenskiObjekat domenskiObjekat)
        {
            object res = null;

            try
            {
                Validate(domenskiObjekat);
                broker.OpenConnection();
                broker.BeginTransaction();

                res = Execute(domenskiObjekat);

                broker.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                broker.Rollback();

            }
            finally
            {
                broker.CloseConnection();
            }
            return res;
        }


    }
}
