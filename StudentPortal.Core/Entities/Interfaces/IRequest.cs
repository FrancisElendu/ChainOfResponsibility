using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Core.Entities.Interfaces
{
    // Request Interface
    public interface IRequest<TEntity>
    {
        TEntity ToEntity();
    }
}
