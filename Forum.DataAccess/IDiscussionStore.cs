using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataAccess
{
    public interface IDiscussionStore
    {
        Discussion Get(Guid id);
        IQueryable<Discussion> All();
    }
}
