using Core.Entities;
using FsCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UpdateEmailDto : IDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
