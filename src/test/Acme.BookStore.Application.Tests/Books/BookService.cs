using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    public class BookService
    {
        private readonly IBookAppService bookAppService;

        public BookService(IBookAppService bookAppService)
        {
            this.bookAppService = bookAppService;
        }

        public Task<PagedResultDto<BookDto>> GetBooks(PagedAndSortedResultRequestDto input)
        {
            return bookAppService.GetListAsync(input);
        }
    }
}
