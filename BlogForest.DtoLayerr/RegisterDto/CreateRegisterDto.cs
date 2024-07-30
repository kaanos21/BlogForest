using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DtoLayerr.RegisterDto
{
    public class CreateRegisterDto
    {
        public string Name { get; set; }
        public string SurnName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
