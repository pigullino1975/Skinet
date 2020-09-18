using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Baskets;

namespace Infrastructure.Data
{
    public class BasketsRepository : IBasketRepository
    {
        private readonly BasketsDbContext _context;

        public BasketsRepository(BasketsDbContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteBasketAsync(string basketId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CustomerBasket> GetBasketAsync(string basketId)
        {
            var basket = _context.CustomerBaskets.Where(c => c.Id == basketId).FirstOrDefault();
            throw new System.NotImplementedException();
        }

        public Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket)
        {
            throw new System.NotImplementedException();
        }
    }
}