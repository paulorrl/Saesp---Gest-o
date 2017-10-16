using SAESP.Gestao.Infra.Data.Contexts;

namespace SAESP.Gestao.Infra.Data.Transactions
{
    public class Uow : IUow
    {
        private readonly SaespContext _context;

        public Uow(SaespContext context)
        {
            this._context = context;
        }

        public void Commit()
        {
            // this._context.SaveChanges();
        }

        public void Rollback()
        {
            // Not implement! =)

            /* 
             * No caso do Entity...
             * ... o rollback é relizado pelo mesmo
             * 
             * Em outras tecnologias, precisaremos verificar.
             */
        }
    }
}