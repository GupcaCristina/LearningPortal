using System;
using System.Collections.Generic;
using System.Text;

namespace LearningPortal.Domain
{
    interface IEntity<TId>
    {
        TId Id { get; set; }
    }   
}
