using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace еуые.Models
{
    public class Post
    {
        private int id;
        private DateTime createdAt;
        private string title;
        private string body;
        private int likes;
        private int userId;
        public List<Comment> comments = new List<Comment>();
        public int Id { get { return id; } set { id = value; } }
        public int UserId { get { return userId; } }
        public int Likes { get { return likes; } }
        public DateTime CreatedAt { get { return createdAt; } }
        public String Title { get { return title; } }
        public String Body { get { return body; } }

        [JsonConstructor]
        public Post(int id, DateTime createdAt, string title, string body, int likes, int userId)
        {
            this.id = id;
            this.createdAt = createdAt;
            this.title = title;
            this.body = body;
            this.likes = likes;
            this.userId = userId;
        }
    }
}