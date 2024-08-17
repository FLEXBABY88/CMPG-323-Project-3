using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public class ProjectsRepository : GenericRepository<Project>, IProjectsRepository
    {
        public ProjectsRepository(TechtrendsContext context): base(context)
        {

        }
        public Project GetMostRecentProject()
        {
            return _context.Projects.OrderByDescending(product => product.ProjectCreationDate).FirstOrDefault();
        }
    }
}
