using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public void Delete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetAll()
        {
            throw new NotImplementedException();
        }

        public Message2 GetByID(int id)
        {
            return _message2Dal.GetByID(id);
        }

        public List<Message2> GetInBoxListByWriter(int id)
        {
            return _message2Dal.GetInboxWithMessageByWriter(id);
        }

        public List<Message2> GetListAll(Expression<Func<Message2, bool>> filter)
        {
            return _message2Dal.GetAll();
        }

      

        public void Update(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void Insert(Message2 t)
        {
            _message2Dal.Insert(t);
        }

        public List<Message2> GetSendBoxListByWriter(int id)
        {
            return _message2Dal.GetSendboxWithMessageByWriter(id);
        }
    }
}
