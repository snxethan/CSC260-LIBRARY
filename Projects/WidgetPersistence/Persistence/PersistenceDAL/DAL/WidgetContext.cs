using Microsoft.EntityFrameworkCore;
using PersistenceDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceDAL.DAL
{
    public class WidgetContext : DbContext
    {
        public WidgetContext(DbContextOptions<WidgetContext> options) : base (options)
        {
            
        }

        public DbSet<Widget> Widgets { get; set; }
    }
}
