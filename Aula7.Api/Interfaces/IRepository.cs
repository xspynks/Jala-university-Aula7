namespace Aula7.Api.Interfaces
{
    public interface IRepository<TInstance>
    {
        void Add(TInstance instance);
        List<TInstance> GetAll();
        TInstance GetById(int id);
    }
}