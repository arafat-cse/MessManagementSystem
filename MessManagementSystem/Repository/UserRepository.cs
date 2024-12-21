using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagementSystem
{
    public class UserRepository:IRepository
    {
        private readonly Dictionary<int, User> _MessUsers = new Dictionary<int, User>();
        private int _currentId = 1;
        public void Create(IEntity entity)
        {
            var User = entity as User;
            User.Id = _currentId++;
            _MessUsers[User.Id] = User;
        }
        public IEntity Read(int id)
        {
            _MessUsers.TryGetValue(id, out var user);
            return user;
        }

        public void Update(IEntity entity)
        {
            var user = entity as User;
            _MessUsers[user.Id] = user;
        }

        public void Delete(int id)
        {
            _MessUsers.Remove(id);
        }
    }
}
