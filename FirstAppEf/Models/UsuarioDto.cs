﻿using System.Reflection.Metadata.Ecma335;

namespace FirstAppEf.Models
{
    public class UsuarioDto
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
