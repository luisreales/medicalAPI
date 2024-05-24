namespace MedicalAPI.Domain.Interfaces
{
    public interface IRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetPatientsAsync();
    }
}