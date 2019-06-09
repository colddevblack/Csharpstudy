using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Segundodotnet.Models;
using System.Data.Entity;

namespace Segundodotnet.DataAccess
{
    public class ArtistaContext: DbContext
    {
        public DbSet<ArtistaModel> Artistadb { get; set; }


   
    }
}