using Kurs.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Data
{
    public partial class DbKursContext
    {
        private static DbKursContext instance;
        public static DbKursContext GetInstance
        {
            get
            {
                return instance;
            }
        }
        
        static DbKursContext()
        {
            instance = new DbKursContext();
        }

        


    }
}
