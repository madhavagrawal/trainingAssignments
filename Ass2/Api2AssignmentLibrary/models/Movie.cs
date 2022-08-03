using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api2AssignmentLibrary.models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }

        public string Lang { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Actor { get; set; }

        public string Director { get; set; }



    }
}
