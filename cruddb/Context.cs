using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace cruddb
{
    public class Context : DbContext
    {
        private static Context context = null;
        public Context() : base("DbConnection") { }
        public static Context GetContext()
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }
        public DbSet<General> General { get; set; }
    }
}
