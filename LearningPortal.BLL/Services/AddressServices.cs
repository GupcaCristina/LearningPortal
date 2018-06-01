
using LearningPortal.DAL.Interfaces;
using LearningPortal.Domain;

namespace LearningPortal.BLL.Services
{
    public class AddressServices
    {
        private IRepository<Address> _addressRepository;

        public AddressServices(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }
    
    }
}
