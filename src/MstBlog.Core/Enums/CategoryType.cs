using System.ComponentModel.DataAnnotations;

namespace MstBlog.Core.Enums;

public enum CategoryType
{
    [Display(Name=".NET Core")]
    NetCore = 1,
    [Display(Name="C#")]
    CSharp = 2,
    [Display(Name="Java")]
    Java=3,
    [Display(Name="Spring Boot")]
    SpringBoot=4,
    [Display(Name="JavaScript")]
    JavaScript = 5,
    [Display(Name="ReactJS")]
    ReactJs = 6,
    [Display(Name="Redux")]
    Redux = 7,
    [Display(Name="Tailwind CSS")]
    TailwindCss = 8
}