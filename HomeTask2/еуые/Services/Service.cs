using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using еуые.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace еуые.Services
{
    public class Service
    {
        private static List<User> users;
        public Service()
        {
            string user = GetJson("https://5b128555d50a5c0014ef1204.mockapi.io/users");
            string post = GetJson("https://5b128555d50a5c0014ef1204.mockapi.io/posts");
            string todo = GetJson("https://5b128555d50a5c0014ef1204.mockapi.io/todos");
            string comment = GetJson("https://5b128555d50a5c0014ef1204.mockapi.io/comments");
            string adres = GetJson("https://5b128555d50a5c0014ef1204.mockapi.io/address");

            List<Todo> todos = JsonConvert.DeserializeObject<List<Todo>>(todo);
            List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(comment);
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(post);
            List<Adress> adress = JsonConvert.DeserializeObject<List<Adress>>(adres);
            users = JsonConvert.DeserializeObject<List<User>>(user);

            foreach (Post p in posts)
            {
                var t = comments.Where(c => c.PostId == p.Id);
                foreach (var elem in t)
                {
                    p.comments.Add(elem);
                }
            }
            foreach (User u in users)
            {
                var t = posts.Where(p => p.UserId == u.Id);
                var ad = adress.Where(a => a.UserId == u.Id).Select(a=>a);
                u.adress = ad.FirstOrDefault();
                foreach (var elem in t)
                {
                    u.posts.Add(elem);
                }
                var t1 = todos.Where(ts => ts.UserId == u.Id);
                foreach (var elem in t1)
                {
                    u.todos.Add(elem);
                }
            //    Console.WriteLine(u.adress.Id);
            }
        }

        public static string GetJson(string url)
        {
            string data = @"";
            using (HttpClient client1 = new HttpClient())
            {
                data += client1.GetStringAsync(url).Result;
            }
            return data;
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}