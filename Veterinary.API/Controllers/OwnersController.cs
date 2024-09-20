using Microsoft.AspNetCore.Mvc;
using Veterinary.API.Data;

namespace Veterinary.API.Controllers
{


    [ApiController]
    [Route("/api/owners")]
    public class OwnersController:ControllerBase
    {


        private readonly DataContext _context;
        public OwnersController(DataContext context)
        {

            _context = context;
                
        }


    }
}
