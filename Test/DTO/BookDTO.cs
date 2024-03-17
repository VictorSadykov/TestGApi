﻿namespace Test.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishedOn { get; set; }
        public string? ImageUrl { get; set; }

    }
}
