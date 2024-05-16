using Project.Core;

namespace Project.Data
{
    public class ProgramRepository : IProgrmRepository
    {
        public Task<IEnumerable<Programs>> GetProgramsAsync(string employerID)
        {
            throw new NotImplementedException();
        }
    }
}