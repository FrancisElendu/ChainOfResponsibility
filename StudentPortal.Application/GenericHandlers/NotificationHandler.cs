using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Application.GenericHandlers
{
    public class NotificationHandler<TRequest> : HandlerBase<TRequest>
        where TRequest : class
    {
        private readonly Func<TRequest, bool> _shouldNotify;
        private readonly Action<TRequest> _notify;

        public NotificationHandler(Func<TRequest, bool> shouldNotify, Action<TRequest> notify)
        {
            _shouldNotify = shouldNotify;
            _notify = notify;
        }

        public override void Handle(TRequest request)
        {
            if (_shouldNotify(request))
            {
                _notify(request);
                Console.WriteLine("Notification sent.");
            }

            base.Handle(request);
        }
    }
}
