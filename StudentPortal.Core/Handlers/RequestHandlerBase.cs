using StudentPortal.Core.Entities;

namespace StudentPortal.Core.Handlers
{
    public abstract class RequestHandlerBase : IRequestHandler
    {
        private IRequestHandler? _nextHandler;
        public virtual void Handle(CourseEnrollmentRequest request)
        {
            _nextHandler?.Handle(request);
        }

        public IRequestHandler SetNext(IRequestHandler next)
        {
            _nextHandler = next;
            return _nextHandler;

        }
    }
}
