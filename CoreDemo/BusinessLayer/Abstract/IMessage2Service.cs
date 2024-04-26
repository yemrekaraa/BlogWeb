﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessage2Service : IGenericDal<Message2>
    {
        List<Message2> GetInBoxListByWriter(int id);
        List<Message2> GetSendBoxListByWriter(int id);
    }
}