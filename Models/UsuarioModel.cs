﻿using Prefeituras.Enuns;
using System.ComponentModel.DataAnnotations;

namespace Prefeituras.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Login é obrigatorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "E-mail é obrigatorio")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha é obrigatorio")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Perfil é obrigatorio")]
        public PerfilEnum? Perfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
