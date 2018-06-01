using System;
using System.Collections.Generic;
using System.Text;
using LearningPortal.Domain;

namespace LearningPortal.DAL.Interfaces
{
    public interface IUserRepository
    {
        ApplicationUser GetUserById(string id);
    }
}
