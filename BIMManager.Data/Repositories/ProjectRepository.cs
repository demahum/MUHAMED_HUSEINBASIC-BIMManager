using BIMManager.Data.Abstract;
using BIMManager.Models.Entities;

namespace BIMManager.Data.Repositories
{
    public class ProjectRepository : EntityBaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(BIMManagerContext context) : base(context) {}
    }
}
