                
using HajjHachathon.Tarie.Model;
              
public class CaseRepository : Repository<Case>, ICaseRepository
{
    private TarieEntities _context;

    public CaseRepository(TarieEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ICaseRepository.cs file
}
