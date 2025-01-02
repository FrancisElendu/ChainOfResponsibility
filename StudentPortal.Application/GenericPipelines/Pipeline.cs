using StudentPortal.Application.GenericHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Application.GenericPipelines
{
    public class Pipeline<TRequest> : IPipeline<TRequest>
    {
        private readonly IHandler<TRequest>? _firstHandler;

        public Pipeline(IEnumerable<IHandler<TRequest>> handlers)
        {
            // Chain handlers dynamically
            IHandler<TRequest>? currentHandler = null;
            foreach (var handler in handlers)
            {
                if (currentHandler == null)
                {
                    _firstHandler = handler;
                    currentHandler = handler;
                }
                else
                {
                    currentHandler = currentHandler.SetNext(handler);
                }
            }
        }

        public void Process(TRequest request)
        {
            _firstHandler?.Handle(request);
        }
    }
}
