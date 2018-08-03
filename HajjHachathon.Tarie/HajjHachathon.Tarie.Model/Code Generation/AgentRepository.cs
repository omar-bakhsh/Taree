                
using HajjHachathon.Tarie.Model;
              
public class AgentRepository : Repository<Agent>, IAgentRepository
{
    private TarieEntities _context;

    public AgentRepository(TarieEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IAgentRepository.cs file
}
