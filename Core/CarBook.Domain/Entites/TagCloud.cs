using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entites
{
    public class TagCloud
    {

        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
		public Blog Blog { get; set; }
	}
}
