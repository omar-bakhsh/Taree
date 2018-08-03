                
using HajjHachathon.Tarie.Model;
              
public class SysdiagramRepository : Repository<sysdiagram>, ISysdiagramRepository
{
    private TarieEntities _context;

    public SysdiagramRepository(TarieEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ISysdiagramRepository.cs file
}
