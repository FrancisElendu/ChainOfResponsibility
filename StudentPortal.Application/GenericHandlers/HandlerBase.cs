using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Application.GenericHandlers
{
    // Base Handler Abstract Class
    public abstract class HandlerBase<TRequest> : IHandler<TRequest>
    {
        private IHandler<TRequest>? _nextHandler;

        public virtual void Handle(TRequest request)
        {
            _nextHandler?.Handle(request);
        }

        public IHandler<TRequest> SetNext(IHandler<TRequest> next)
        {
            _nextHandler = next;
            return _nextHandler;
        }
    }
}
