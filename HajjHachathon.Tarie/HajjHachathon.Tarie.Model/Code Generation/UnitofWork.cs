using System;
using HajjHachathon.Tarie.Model;

public class UnitOfWork : IUnitOfWork
{
    private TarieEntities _context;

    public UnitOfWork(TarieEntities context)
    {
        _context = context;
    }

	//Delete this default constructor if using an IoC container
	public UnitOfWork()
	{
		_context = new TarieEntities();
	}
	
    public IImageRepository Images
    {
        get { return new ImageRepository(_context); }
    }

    public ISysdiagramRepository sysdiagrams
    {
        get { return new SysdiagramRepository(_context); }
    }

    public IClass1Repository Class1s
    {
        get { return new Class1Repository(_context); }
    }

    public ICaseRepository Cases
    {
        get { return new CaseRepository(_context); }
    }

    public IAgentRepository Agents
    {
        get { return new AgentRepository(_context); }
    }

    
    public void Save()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
