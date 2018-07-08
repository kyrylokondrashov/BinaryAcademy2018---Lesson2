using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using еуые.Models;
using еуые.Services;

namespace еуые.BuisnessLogic
{
    public static class Tasks
    {
        public static Service userServive;

        public static List<Post> Task1(User specificUser)
        {
            List<Post> result = specificUser.posts;
            return result;
        }

        public static List<Comment> Task2(User specificUser)
        {

            var commentList = specificUser.posts.SelectMany(p => p.comments.Where(c => c.Body.Length < 50));
            List<Comment> result = new List<Comment>();
            foreach (var c in commentList)
            {
                result.Add(c);
            }
            return result;

        }

        public static List<Todo> Task3(User specificUser)
        {
            var todoComplete = specificUser.todos.Where(p => p.ISComplete == true).Select(p => p);
            List<Todo> todos = new List<Todo>();
            foreach (var t in todoComplete)
            {
                todos.Add(t);
            }

            return todos;
        }

        public static List<User> Task4()
        {
            userServive = new Service();
            List<User> users = userServive.GetUsers();
            var res = users.OrderBy(x => x.Name).ThenBy(x => x.todos.OrderByDescending(t => t.Name.Length));
            List<User> filtredUser = new List<User>();
            foreach (var elem in res)
            {
                filtredUser.Add(elem);
            }
            return filtredUser;

        }

        public static StructureForTask5 Task5(int i)
        {
            userServive = new Service();
            List<User> users = userServive.GetUsers();
            var structure = users.Where(u => u.Id == i).Select(
                                                            u => new
                                                            {
                                                                User = u,
                                                                LastPost = u.posts.OrderByDescending(t => t.CreatedAt).FirstOrDefault(),
                                                                LastPostComments = (u.posts.OrderByDescending(t => t.CreatedAt).FirstOrDefault()).comments.Count,
                                                                FailedTodo = u.todos.Where(t => t.ISComplete == false).Count(),
                                                                PopularPostComment = u.posts.Where(p => p.Body.Length > 80).OrderByDescending(p => p.comments.Count).FirstOrDefault(),
                                                                PopularPostLike = u.posts.OrderByDescending(p => p.Likes).DefaultIfEmpty().FirstOrDefault()
                                                            }).FirstOrDefault();


            StructureForTask5 resultStructure = new StructureForTask5();
            resultStructure.User = structure.User;
            resultStructure.LastPost = structure.LastPost;
            resultStructure.CommentLastPost = structure.LastPostComments;
            resultStructure.UncompletedTodo = structure.FailedTodo;
            resultStructure.MostCommentPost = structure.PopularPostComment;
            resultStructure.MostLikesPost = structure.PopularPostLike;
            return resultStructure;
        }







        public static StructureForTask6 Task6(int i)
        {
            userServive = new Service();
            List<User> users = userServive.GetUsers();
            var structure = (users.SelectMany(u => u.posts)).Where(x => x.Id == i).Select(p => new
            {
                PostRes = p,
                LargestComment = p.comments.OrderByDescending(x => x.Body.Length).FirstOrDefault(),
                PopularComment = p.comments.OrderByDescending(x => x.Likes).FirstOrDefault(),
                Checker = p.Body.Length < 80 || p.Likes < 0 ? true : false,
                CommentWithSpecificConditions = p.Body.Length < 80 || p.Likes < 0 ? p.comments.Count : 0
            }).FirstOrDefault();
            StructureForTask6 structureResult = new StructureForTask6();
            structureResult.Post = structure.PostRes;
            structureResult.LongestComment = structure.LargestComment;
            structureResult.LongestComment = structure.LargestComment;
            structureResult.Checker = structure.Checker;
            structureResult.SpecifiedComment = structure.CommentWithSpecificConditions;
            return structureResult;
        }
    }
}
