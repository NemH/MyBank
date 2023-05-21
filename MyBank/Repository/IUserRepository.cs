using MyBank.Model;

namespace MyBank.Repository
{
    public interface IUserRepository<T> where T : Person
    {
        void Create(T user);
        void Update(T user);
        void Delete(string email);
        void Save();
        void Load();
    }
}
