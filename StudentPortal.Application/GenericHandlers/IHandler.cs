using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Application.GenericHandlers
{
    // Base Handler Interface
    public interface IHandler<TRequest>
    {
        IHandler<TRequest> SetNext(IHandler<TRequest> next);
        void Handle(TRequest request);
    }
}
