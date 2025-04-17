using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDevopsApp
{
    public interface IDocument
    {
        public int DocId { get; set; }
        public string Title { get; set; }   

        public string Description { get; set; }
        public string Author { get; set; }
        public string Type { get; set; } 
    }
}
