using System.Linq;
namespace GadgetEmporium.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
