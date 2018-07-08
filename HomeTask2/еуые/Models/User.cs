using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace еуые.Models
{
    public class User
    {
        private int id;
        private DateTime createdAt;
        private string name;
        private string avatar;
        private string email;
        public List<Post> posts = new List<Post>();
        public List<Todo> todos = new List<Todo>();
        public Adress adress;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } }
        public string Avatar { get { return avatar; } }
        public string Email { get { return email; } }

        public User(int id, DateTime createdAt, string name, string avatar, string email)
        {
            this.id = id;
            this.createdAt = createdAt;
            this.name = name;
            this.avatar = avatar;
            this.email = email;
        }
    }
}