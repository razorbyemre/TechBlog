﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstaract
{
    public interface IMessageDal : IGenericRepository<Message>
    {
        List<Message> GetInboxtWithMessageByWriter(int id);
        List<Message> GetSendboxWithMessageByWriter(int id);

    }
}
