using AspNetCoreHero.Results;

namespace OptimaDesk.Application.Interfaces
{
    public interface IPaginationHelper
    {
        Task<PaginatedResult<T>> ApplyPaginationAsync<T>(
            IQueryable<T> query,
            int? pageNumber,
            int? pageSize,
            CancellationToken cancellationToken = default);
    }
}
