using Mod02_01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_01.DAL
{
    public class OperaContext : DbContext
    {
        public DbSet<Opera> Operas { get; set; }
    }
}
