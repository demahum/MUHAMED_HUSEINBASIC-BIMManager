using BIMManager.Models.Entities;

namespace BIMManager.Data.Abstract
{
    public interface IProjectRepository : IEntityBaseRepository<Project> {}
    public interface IBIMModelRepository : IEntityBaseRepository<BIMModel> {}
}
