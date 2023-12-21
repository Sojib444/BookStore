using Acme.BookStore.Books;
using Volo.Abp.Application.Dtos;

namespace BookStoreUnitTest
{
    public class BookService
    {
        private readonly IBookAppService bookAppService;

        public BookService(IBookAppService bookAppService)
        {
            this.bookAppService = bookAppService;
        }

        public Task<PagedResultDto<BookDto>> GetBooks(PagedAndSortedResultRequestDto request)
        {
           return bookAppService.GetListAsync(request);
        }
    }
}
