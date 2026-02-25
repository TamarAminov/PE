using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _repository;
        public UserController(IRepository<User> repository)
        {
            _repository = repository;
        }
        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public User Post(User value)
        {
            return _repository.AddItem(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id,User value)
        {
            _repository.UpdateItem(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.DeleteItem(id);
        }
    }
}
