using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPortal.Domain
{
    public abstract class Entity<TId>
    {
        public TId Id { get; set; }
    }
}
