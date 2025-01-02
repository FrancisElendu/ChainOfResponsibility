using StudentPortal.Core.Entities.Interfaces;
using StudentPortal.Core.GenericRepositories;

namespace StudentPortal.Application.GenericHandlers
{
    // Example Handler: Save to Database
    public class SaveToDatabaseHandler<TRequest, TEntity> : HandlerBase<TRequest>
        where TRequest : IRequest<TEntity>
    {
        private readonly IRepository<TEntity> _repository;

        public SaveToDatabaseHandler(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public override void Handle(TRequest request)
        {
            try
            {
                var entity = request.ToEntity();
                _repository.AddAsync(entity).Wait();
                Console.WriteLine($"{typeof(TEntity).Name} saved to database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in {this.GetType().Name}: {ex.Message}");
            }
            finally
            {
                base.Handle(request);
            }
        }
    }
}
