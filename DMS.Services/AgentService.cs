using DMS.Abstraction;
using DMS.Domain.Entities;

namespace DMS.Services
{
    public class AgentService : IAgentService
    {
        public Task AddAgentAsync(Agent agent)
        {
            throw new NotImplementedException();
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
