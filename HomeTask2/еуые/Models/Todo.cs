using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace еуые.Models
{
    public class Todo
    {
        private int id;
        private DateTime createdAt;
        private string name;
        private bool isComplete;
        private int userId;


        public int UserId { get { return userId; } }
        public int Id { get { return id; } }
        public DateTime CreatedAt { get { return createdAt; } }
        public bool ISComplete { get { return isComplete; } }
        public string Name { get { return name; } }

        public Todo(int id, DateTime createdAt, string name, bool isComplete, int userId)
        {
            this.id = id;
            this.createdAt = createdAt;
            this.name = name;
            this.isComplete = isComplete;
            this.userId = userId;
        }
    }
}