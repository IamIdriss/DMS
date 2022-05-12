using DMS.Abstraction;
using DMS.Data.GenericRepository;
using DMS.Domain.Entities;

namespace DMS.Services
{
    public class AgentService : IAgentService
    {
        private readonly IGenericRepository<Agent> _agentsRepository;
        public AgentService(IGenericRepository<Agent> agentsRepository)
        {
            _agentsRepository = agentsRepository;
        }
        public async Task AddAgentAsync(Agent agent)
        {
            await _agentsRepository.InsertAsync(agent);
        }

        public Task DeleteAgentAsync(int agentId)
        {
            throw new NotImplementedException();
        }

        public Task<Agent> GetAgentByIdAsync(int agentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Agent>> GetAllAgentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAgentAsync(Agent agent)
        {
            throw new NotImplementedException();
        }
    }
}
