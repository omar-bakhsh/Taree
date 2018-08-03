
    
using HajjHachathon.Tarie.Model;
              
public class ImageRepository : Repository<Image>, IImageRepository
{
    private TarieEntities _context;

    public ImageRepository(TarieEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IImageRepository.cs file
}
