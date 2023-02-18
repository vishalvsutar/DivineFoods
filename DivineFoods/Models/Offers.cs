using System;
namespace DivineFoods.Models
{
	public class Offers
	{
        public Offers(int id, string name, string image, string description)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}

