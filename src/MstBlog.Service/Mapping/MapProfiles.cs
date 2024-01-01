using AutoMapper;
using MstBlog.Core.Domain;
using MstBlog.Core.Entities;
using MstBlog.Core.Enums;
using MstBlog.Core.Models.Contact;
using MstBlog.Core.Models.Post;
using MstBlog.Core.Models.PostContent;
using MstBlog.Core.Models.Project;
using MstBlog.Core.Models.Subscribe;
using MstBlog.Core.Models.User;

namespace MstBlog.Service.Mapping;

public class MapProfiles : Profile
{
    public MapProfiles()
    {
        CreateMap<Project, ListProjectsModel>().ReverseMap();
        CreateMap<Project, AddProjectModel>().ReverseMap();

        CreateMap<Contact, ListContactModel>().ReverseMap();
        CreateMap<Contact, AddContactModel>().ReverseMap();
        
        CreateMap<Subscribe, ListSubscribeModel>().ReverseMap();
        CreateMap<Subscribe, AddSubsribeModel>().ReverseMap();

        CreateMap<Post, ListPostModel>()
            .ForMember(dest => dest.FullName, opt
                => opt.MapFrom(src => src.User.FullName))
            .ForMember(dest => dest.PostCategories, opt
                => opt.MapFrom(src => src.PostCategories.Select(pt => EnumHelper.GetDisplayName(pt.CategoryType))));
        
        CreateMap<ListPostModel, ListPostFilterModel>()
            .ForMember(dest => dest.Data, opt => opt.MapFrom(src => new List<ListPostModel> { src }))
            .ForMember(dest => dest.RecordsTotal, opt => opt.MapFrom(src => 1))
            .ForMember(dest => dest.RecordsFiltered, opt => opt.MapFrom(src => 1));

        CreateMap<Post, GetPostByIdModel>()
            .ForMember(dest => dest.UserInformations.UserId, opt
                => opt.MapFrom(src => src.User.Id))
            .ForMember(dest => dest.UserInformations.FullName, opt
                => opt.MapFrom(src => src.User.FullName));

        CreateMap<PostContent, GetPostContentModel>().ReverseMap();
        
        CreateMap<Post, AddPostModel>().ReverseMap();
        
        CreateMap<User, UserModel>().ReverseMap();
    }
}
