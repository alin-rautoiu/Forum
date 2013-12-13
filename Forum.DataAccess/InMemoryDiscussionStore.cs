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
            discussion.Messages.Add(new Message { Id = Guid.NewGuid(), Author = "Coco", Content = "Au doua picioare" });
            discussion.Messages.Add(new Message { Id = Guid.NewGuid(), Author = "Roco", Content = "Au doua urechi" });
            discussions.Add(discussion.Id, discussion);
            discussion = new Discussion { Id = Guid.NewGuid(), Title = "Despre tigri" };
            discussion.Messages.Add(new Message { Id = Guid.NewGuid(), Author = "Kiki", Content = "Au patru picioare" });
            discussion.Messages.Add(new Message { Id = Guid.NewGuid(), Author = "Riki", Content = "Au o coada" });
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
