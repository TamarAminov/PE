using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class UserRepository : IRepository<User>
    {

        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            this._context = context;
        }
        public User AddItem(User item)
        {
            _context.Users.ToList().Add(item);
            _context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
           _context.Users.ToList().Remove(GetById(id));
            _context.save();
        }

        public List<User> GetAll()
        {
           return _context.Users.ToList();
        }

        public User GetById(int id)
        {
                return (User)_context.Users.FirstOrDefault(x => x.UserID == id);
        }

        public void UpdateItem(int id, User item)
        {
            var user = GetById(id);
            user.UserPhone=item.UserPhone;
            user.UserName=item.UserName;
            user.UserPasswordHash=item.UserPasswordHash;
            user.UserEmail=item.UserEmail;
            user.UserEvents=item.UserEvents;
            _context.save();
        }
    }
}
