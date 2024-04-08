using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lanfi
{
    [Table("user")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

    }

    [Table("Connections")]
    public class Connections
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string IP { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
