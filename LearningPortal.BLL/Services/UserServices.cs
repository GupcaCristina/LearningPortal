using AutoMapper;
using LearningPortal.BLL.Interfaces;
using LearningPortal.DAL.Interfaces;
using LearningPortal.Domain;
using LearningPortal.DTO;

namespace LearningPortal.BLL.Services
{
    public class UserServices : IUserServices
    {
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserServices(IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserDetailsDTO GetUserDetails(string id)
        {
            var user = _userRepository.GetUserById(id);
            var userDetails = _mapper.Map<UserDetailsDTO>(user);

            return userDetails;
        }

    }
}
