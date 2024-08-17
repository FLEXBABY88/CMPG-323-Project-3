
using TelemetryPortal_MVC.Models;


namespace TelemetryPortal_MVC.Repository
{
    public interface IProjectsRepository : IGenericRepository<Project>
    {
        Project GetMostRecentProject();
      
    }
}
