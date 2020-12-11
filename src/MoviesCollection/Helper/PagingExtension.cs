using MoviesCollection.Models;

namespace MoviesCollection.Helper
{
    public static class PagingExtension
    {
        public static PagedResult<MovieDetailModel> ToPagedResult(this MovieResponseModel moviesResponseModel)
        {
            return new PagedResult<MovieDetailModel>()
            {
                PageCount = moviesResponseModel.total_pages,
                RowCount = moviesResponseModel.total_results,
                CurrentPage = moviesResponseModel.page,
                Results = moviesResponseModel.results,
                PageSize = 20
            };
        }
    }
}
