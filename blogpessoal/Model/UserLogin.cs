﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace blogpessoal.Model
{
    // classe auxiliar para login
    public class UserLogin
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string? Foto { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;

    }
}







