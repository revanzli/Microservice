﻿namespace PostService.Application.DTO_s.Post
{
    public class GetPostDto
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Postname { get; set; }
    }
}
