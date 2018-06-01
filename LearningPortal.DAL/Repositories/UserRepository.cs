using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearningPortal.DAL.Interfaces;
using LearningPortal.Domain;
using Microsoft.EntityFrameworkCore;

namespace LearningPortal.DAL.Repositories

{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
      
    
    public UserRepository(DbContext context) : base(context)
    {

    }
        public ApplicationUser GetUserById(string id)
        {
           var user= _dbset.Find(id);

            return user;
        }

    }
}
