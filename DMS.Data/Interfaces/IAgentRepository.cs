using DMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Data.Interfaces
{
    public interface IAgentRepository 
    {
        //PagedResult<Agent> GetAgents(string? name, int page);
        Task<Agent?> GetAgent(int Id);
        Task<Agent> AddAgent(Agent agent);
        Task<Agent?> UpdateAgent(Agent agent);
        Task<Agent?> DeleteAgent(int Id);
    }
}
