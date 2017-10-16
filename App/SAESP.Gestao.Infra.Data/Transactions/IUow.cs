namespace SAESP.Gestao.Infra.Data.Transactions
{
    public interface IUow
    {
        void Commit();

        void Rollback();
    }
}