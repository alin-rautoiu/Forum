using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataAccess
{
    public class InMemoryDiscussionStore: IDiscussionStore
    {
        static Dictionary<Guid, Discussion> discussions;

        static InMemoryDiscussionStore()
        {
            discussions = new Dictionary<Guid, Discussion>();
            var discussion = new Discussion { Id = Guid.NewGuid(), Title = "Despre oameni" };
            discussion.Messages.Add(new Message { Id = Guid.NewGuid(), DiscussionId = discussion.Id, Author = "Coco", Content = "Au doua picioare" });
            discussion.Messages.Add(new Message { Id = Guid.NewGuid(), DiscussionId = discussion.Id, Author = "Roco", Content = "Au doua urechi" });
            discussion.Messages.Add(new Message
            {
                Id = Guid.NewGuid(),
                DiscussionId = discussion.Id,
                Author = "Moco",
                Content = @"Lorem ipsum dolor sit amet,
                consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            });
            discussions.Add(discussion.Id, discussion);
            discussion = new Discussion { Id = Guid.NewGuid(), Title = "Despre tigri" };
            discussion.Messages.Add(new Message { Id = Guid.NewGuid(), DiscussionId = discussion.Id, Author = "Kiki", Content = "Au patru picioare" });
            discussion.Messages.Add(new Message { Id = Guid.NewGuid(), DiscussionId = discussion.Id, Author = "Riki", Content = "Au o coada" });
            discussion.Messages.Add(new Message
            {
                Id = Guid.NewGuid(),
                DiscussionId = discussion.Id,
                Author = "Miki",
                Content = @"Lorem ipsum dolor sit amet,
                consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            });
            discussions.Add(discussion.Id, discussion);
        }

        public Models.Discussion Get(Guid id)
        {
            return discussions[id];
        }


        public IQueryable<Discussion> All()
        {
            return discussions.Values.AsQueryable();
        }
    }
}
