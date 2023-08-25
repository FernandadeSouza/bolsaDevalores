using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Aula1
{
    class MyDbContext:DbContext

    {
        public MyDbContext() : base ("name=MyDbContext") { }

    }
}
