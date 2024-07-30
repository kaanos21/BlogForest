using AutoMapper;
using BlogForest.DtoLayerr.BlogDto;
using BlogForest.EntityLayer.Concrete;

namespace BlogForest.WebUI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Blog,CreateBlogDto>();
            CreateMap<CreateBlogDto,Blog>();
        }
    }
}
