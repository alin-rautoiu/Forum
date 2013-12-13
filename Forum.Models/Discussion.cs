using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Discussion: IEntity
    {
        public Guid Id
        {
            get;
            set;
        }

        public string Title { get; set; }
    }
}
