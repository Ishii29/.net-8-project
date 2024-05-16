using Project.Core;

namespace Project.Data
{
    public interface IProgrmRepository
    {
        Task<IEnumerable<Programs>> GetProgramsAsync(string employerID);
    }
}