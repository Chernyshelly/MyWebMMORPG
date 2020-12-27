using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using WebMMO.Models;

namespace WebMMO.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Register(string user, string message)
        {
            bool canRegister = true;
            string reply;
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    if (u.Name == user)
                    {
                        canRegister = false;
                    }
                }
                if (canRegister)
                {
                    User newUser = new User { Name = user, Age = 33 };
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    reply = "successReg";
                }
                else
                {
                    reply = "failReg";
                }
            }
            await Clients.Caller.SendAsync("ReceiveMessage", user, reply);
        }
        public async Task Login(string user, string message)
        {
            string reply = $"{user} is trying to login with password: {message}";
            await Clients.Caller.SendAsync("ReceiveMessage", user, reply);
        }
    }
}
