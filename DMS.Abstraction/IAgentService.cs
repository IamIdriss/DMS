using DMS.Domain.Entities;

namespace DMS.Abstraction;
public interface IAgentService
{
    public Task AddAgentAsync(Agent agent);
    public Task UpdateAgentAsync(Agent agent);
    public Task DeleteAgentAsync(int agentId);
    public Task<IEnumerable<Agent>> GetAllAgentsAsync();
    public Task<Agent> GetAgentByIdAsync(int agentId);
}

