using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace H5ServersideProgrammering.Areas.TodoList.Models
{
    public partial class ToDoList
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Du skal skrive en titel", MinimumLength = 1)]
        public string Titel { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Du skal skrive en titel", MinimumLength = 1)]
        public string Description { get; set; }
        public string User { get; set; }
    }
}
