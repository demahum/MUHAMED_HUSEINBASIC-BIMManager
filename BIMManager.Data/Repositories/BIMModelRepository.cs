using BIMManager.Data.Abstract;
using BIMManager.Models.Entities;

namespace BIMManager.Data.Repositories
{
    public class BIMModelRepository : EntityBaseRepository<BIMModel>, IBIMModelRepository
    {
        public BIMModelRepository(BIMManagerContext context) : base(context) {}
    }
}
