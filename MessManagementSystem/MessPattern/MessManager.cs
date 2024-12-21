using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagementSystem
{
    public class MessManager : IMessManager
    {
        public IEntity CreateEntity()
        {
            return new User();
        }

    }
}
