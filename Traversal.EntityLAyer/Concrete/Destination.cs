﻿namespace Traversal.EntityLayer.Concrete
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public string CoverImage { get; set; }
        public string Image2 { get; set; }
        public string LongDescription { get; set; }
        public bool DescriptionIsActive { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
