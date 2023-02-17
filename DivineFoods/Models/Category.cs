using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DivineFoods.Models
{
	public class Category
	{
        public Category(int id, int name, string image)
        {
            Id = id;
            Name = name;
            Image = image;
        }

        public int Id { get; set; }
		public int Name { get; set; }
		public string Image { get; set; }

	}
}

