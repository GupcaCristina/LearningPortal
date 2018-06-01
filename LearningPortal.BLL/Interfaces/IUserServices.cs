using LearningPortal.DTO;

namespace LearningPortal.BLL.Interfaces
{
    public interface IUserServices
    {
        UserDetailsDTO GetUserDetails(string id);

    }
}
