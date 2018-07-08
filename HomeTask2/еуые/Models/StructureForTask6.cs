using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace еуые.Models
{
    public class StructureForTask6
    {
        private Post post;
        private Comment longestComment;
        private Comment coolestComment;
        private int specifiedPostComment;
        private bool checker;

        public Post Post { get { return post; } set { post = value; } }
        public Comment LongestComment { get { return longestComment; } set { longestComment = value; } }
        public Comment CoolestComment { get { return coolestComment; } set { coolestComment = value; } }
        public int SpecifiedComment { get { return specifiedPostComment; }  set { specifiedPostComment = value; } }

        public bool Checker { get { return checker; } set { checker = value; } }

        public StructureForTask6()
        {

        }
    }
}