                
using HajjHachathon.Tarie.Model;
              
public class Class1Repository : Repository<Class1>, IClass1Repository
{
    private TarieEntities _context;

    public Class1Repository(TarieEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IClass1Repository.cs file
}
