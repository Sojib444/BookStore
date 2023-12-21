using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using Acme.BookStore.Web.Pages.Authors;
using AutoMapper;
using static Acme.BookStore.Web.Pages.Authors.EditModal;
using static Acme.BookStore.Web.Pages.Books.CreateModal;
using static Acme.BookStore.Web.Pages.Books.EditModal;

namespace Acme.BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.

        CreateMap<BookDto, CreateUpdateBookDto>();

        CreateMap<CreateModal.CreateAuthorViewModel, CreateAuthorDto>();

        CreateMap<AuthorDto, EditAuthorViewModel>();

        CreateMap<EditAuthorViewModel, UpdateAuthorDto>();

        CreateMap<CreateBookViewModel, CreateUpdateBookDto>();

        CreateMap<BookDto, EditBookViewModel>();

        CreateMap<EditBookViewModel, CreateUpdateBookDto>();
    }
}
