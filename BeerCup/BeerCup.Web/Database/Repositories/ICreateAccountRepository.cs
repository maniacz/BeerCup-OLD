using BeerCup.Web.DTOs;

namespace BeerCup.Web.Controllers.Repositories
{
    public interface ICreateAccountRepository
    {
        void Add(CreateAccountRequestDto newAccount);

        void Save();
    }
}