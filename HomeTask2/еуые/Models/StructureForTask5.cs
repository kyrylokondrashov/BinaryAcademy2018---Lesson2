using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace еуые.Models
{
    public class StructureForTask5
    {
        private User user;
        private Post lastPost;
        private int commentLastPost;
        private int uncompletedTodo;
        private Post mostCommentPost;
        private Post mostLikesPost;

        public User User { get { return user; } set { user = value; } }
        public Post LastPost { get { return lastPost; } set { lastPost = value; } }
        public int CommentLastPost { get { return commentLastPost; } set { commentLastPost = value; }  }
        public int UncompletedTodo { get { return uncompletedTodo; }set { uncompletedTodo = value; } }
        public Post MostCommentPost { get { return mostCommentPost; } set { mostCommentPost = value; } }
        public Post MostLikesPost { get { return mostLikesPost; } set { mostLikesPost = value; } }

        public StructureForTask5()
        {

        }
    }
}