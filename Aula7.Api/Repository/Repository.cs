using Aula7.Api.Interfaces;

namespace Aula7.Api.Repository
{
    public abstract class Repository<TInstance> : IRepository<TInstance> where TInstance : class, new()
    {
        public void Add(TInstance instance)
        {
            Console.WriteLine(instance.GetType().Name);
        }

        public TInstance GetById(int id)
        {
            return new TInstance();
        }

        public List<TInstance> GetAll()
        {
            return new List<TInstance>();
        }
    }
}