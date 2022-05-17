using DMS.Domain.Entities;

namespace DMS.Dto.Extention
{
    public static class AgentExtension
    {
        
        public static AgentDto ToAgentDto(this Agent agent)
        {
            return new AgentDto()
            {
                DepartmentId = agent.DepartmentId,
                FirstName = agent.FirstName,
                LastName = agent.LastName,  
                Id = agent.Id,
                DepartementName = agent.Department?.Name
            };
        }
        public static IEnumerable<AgentDto> ToAgentDtos(this IEnumerable<Agent> agents)
        {
            var agentDtos = new List<AgentDto>();
            foreach (var agent in agents)
            {
                agentDtos.Add(agent.ToAgentDto());
            }
            return agentDtos;
        }
   
    }
}
