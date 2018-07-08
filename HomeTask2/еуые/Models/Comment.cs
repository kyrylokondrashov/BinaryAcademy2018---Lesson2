using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace еуые.Models
{
    public class Comment
    {
        private int id;
        private DateTime createdAt;
        private string body;
        private int postId;
        private int userId;
        private int likes;

        public int PostId { get { return postId; } }
        public int Id { get { return id; } }
        public DateTime CreatedAt { get { return createdAt; } }

        public int UserId { get { return userId; } }

        public string Body { get { return body; } }
        public int Likes { get { return likes; } }

        public Comment(int id, DateTime createdAt, string body, int postId, int userId, int likes)
        {
            this.id = id;
            this.createdAt = createdAt;
            this.body = body;
            this.postId = postId;
            this.userId = userId;
            this.likes = likes;
        }
    }
}