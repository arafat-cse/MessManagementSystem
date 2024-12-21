using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagementSystem
{
    public class MessRepository: IRepository
    {
        private readonly Dictionary<int, Mess> _mms = new Dictionary<int, Mess>();
        private int _messtid = 1;

        public void Create(IEntity entity)
        {
            var Mess = entity as Mess;
            Mess.Id = _messtid++;
            _mms[Mess.Id] = Mess;
        }
        public IEntity Read(int id)
        {
            _mms.TryGetValue(id, out var mess);
            return mess;
        }
        public void Update(IEntity entity)
        {
            var Mess = entity as Mess;
            _mms[Mess.Id] = Mess;
        }
        public void Delete(int id)
        {
            _mms.Remove(id);
        }

    }



}

