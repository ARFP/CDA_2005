using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleEntity.Models
{
    [Table("users")]
    class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
