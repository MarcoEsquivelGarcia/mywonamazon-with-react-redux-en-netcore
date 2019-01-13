using System;
using System.Collections.Generic;

namespace EntityFrameworkDBModel.Context
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
    }
}
