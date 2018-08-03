            using System;

public interface IUnitOfWork : IDisposable
{
    IImageRepository Images { get; }
    ISysdiagramRepository sysdiagrams { get; }
    IClass1Repository Class1s { get; }
    ICaseRepository Cases { get; }
    IAgentRepository Agents { get; }
    void Save();
}
