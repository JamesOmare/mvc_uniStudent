using System;
using System.Data.Entity;

namespace MyUniversity.Models
{
    public class University
    {
        public int ID { get; set; }
        public string Institute { get; set; }
        public DateTime dateofreporting { get; set; }
        public string Course { get; set; }
        public string Department { get; set; }
        public decimal year { get; set; }
    }

    public class UniversityDBContext : DbContext
    {
        public DbSet<University> Universities { get; set; }
    }

}