﻿using StudentPortal.Application.Handlers;
using StudentPortal.Core.Entities;

namespace StudentPortal.Application.Pipelines
{
    public class CourseEnrollmentPipeline : ICourseEnrollmentPipeline
    {
        private readonly IRequestHandler? _firstHandler;

        public CourseEnrollmentPipeline(IEnumerable<IRequestHandler> handlers)
        {
            // Chain handlers dynamically
            IRequestHandler? currentHandler = null;
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
        public void Process(CourseEnrollmentRequest request)
        {
            _firstHandler?.Handle(request);
        }

    }
}
