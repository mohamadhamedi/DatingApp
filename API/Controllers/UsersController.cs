using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
   
    public class UsersController : BaseApiController
    {
        private readonly DataContext _dataContext;

        public UsersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IEnumerable<AppUser>> GetUsers()
        {
            return await _dataContext.Users.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<AppUser> GetUser(int id)
        {
            return await _dataContext.Users.FindAsync(id);
        }
    }
}
