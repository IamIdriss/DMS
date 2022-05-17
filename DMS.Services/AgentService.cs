using DMS.Abstraction;
using DMS.Data;
using DMS.Data.GenericRepository;
using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DMS.Services
{
    public class AgentService : IAgentService
    {
        private readonly IGenericRepository<Agent> _agentsRepository;
        private AppDbContext _context;


        public AgentService(IGenericRepository<Agent> agentsRepository, AppDbContext context)
        {
            _agentsRepository = agentsRepository;
            _context = context;
        }
        public async Task AddAgentAsync(Agent agent)
        {
            await _agentsRepository.InsertAsync(agent);
        }

        public Task DeleteAgentAsync(int agentId)
        {
            throw new NotImplementedException();
        }

        public async Task<Agent> GetAgentByIdAsync(int agentId)
        {
            return await _agentsRepository.GetByIdAsync(agentId);   
        }

        public async Task<IEnumerable<Agent>> GetAllAgentsAsync()
        {
          // return  await _agentsRepository.GetAllAsync();
          return _context.Agents.Include(t => t.Department).ToList();
        }

        public Task UpdateAgentAsync(Agent agent)
        {
            throw new NotImplementedException();
        }
    }
}
