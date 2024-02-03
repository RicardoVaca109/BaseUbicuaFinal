using ConsoleApp2.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Utils
{
    public class UtilDb
    {
        public UbicuaDbContext _context;
        public UtilDb()
        {
            _context = new UbicuaDbContext();
        }

        public void add(Dato dato)
        {
            try
            {
                _context.Datos.Add(dato);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
