using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.NewFolder
{
    public class Contact
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nickName { get; set; }
        public string place { get; set; }
        public DateTime dateCreated { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
