﻿using DataAccessLayer.Abstaract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concretes;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameworkRepos
{
    public class EFNewsLetterRepository : GenericRepository<NewsLetter>, INewsLetterDal
    {
        public EFNewsLetterRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
