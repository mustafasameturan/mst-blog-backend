using AutoMapper;
using MstBlog.Core.Entities;
using MstBlog.Core.Models.Contact;
using MstBlog.Core.Models.Post;
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
        
        CreateMap<Post, ListPostModel>().ReverseMap();
        CreateMap<Post, AddPostModel>().ReverseMap();
        
        CreateMap<User, UserModel>().ReverseMap();
    }
}
