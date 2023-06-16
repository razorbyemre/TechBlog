﻿using DataAccessLayer.Abstaract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IUserService : IGenericService<AppUser>
    {
        Task<List<AppUser>> GetUserAsync();
    


    }
}
