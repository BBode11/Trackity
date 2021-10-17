using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trackity.Models;
using Microsoft.EntityFrameworkCore;

namespace Trackity.Models
{
    public class Type
    {
        public string TypeId { get; set; }
        public string Name { get; set; }
    }
}
