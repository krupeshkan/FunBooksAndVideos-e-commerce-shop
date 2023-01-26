using FunBooksAndVideos.Model.Entities;

namespace FunBooksAndVideos.Repository.Interfaces
{
    public interface IOrderGenerateRepository
    {
        bool GenerateOrder(Order order);
    }
}
