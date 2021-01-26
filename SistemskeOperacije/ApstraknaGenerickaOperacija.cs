using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using DbBroker;
namespace SistemskeOperacije
{
    public abstract class ApstraknaGenerickaOperacija
    {
        protected abstract object Execute(DomenskiObjekat domenskiObjekat);
        protected abstract void Validate(DomenskiObjekat domenskiObjekat);
        protected abstract object Execute(List<DomenskiObjekat> domenskiObjekat);
        protected abstract void Validate(List<DomenskiObjekat> domenskiObjekat);

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
            catch (Exception)
            {
                broker.Rollback();

            }
            finally
            {
                broker.CloseConnection();
            }
            return res;
        }

        

        public object ExecuteSO(List<DomenskiObjekat> domenskiObjekti)
        {
            object res = null;

            try
            {
                Validate(domenskiObjekti);
                broker.OpenConnection();
                broker.BeginTransaction();

                res = Execute(domenskiObjekti);

                broker.Commit();
            }
            catch (Exception)
            {
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
