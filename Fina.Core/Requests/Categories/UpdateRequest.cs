﻿using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories
{
    public class UpdateRequest : Request
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Título inválido")]
        [MaxLength(80, ErrorMessage = "O título deve conter até 80 caractéres.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Descrição inválida")]
        public string? Description { get; set; }
    }
}
