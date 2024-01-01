using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MstBlog.Core.Enums;

public enum ContentType
{
    [Display(Name="Baslik")]
    Header=1,
    [Display(Name="Paragraf")]
    Paragraph=2,
    [Display(Name="Blockquote")]
    Blockquote=3,
    [Display(Name="Kart")]
    Card=4,
    [Display(Name="Kod")]
    Code=5
}