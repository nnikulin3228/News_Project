using AutoMapper;
using News.Objects.DtoModels;
using News.Objects.Models;

public class MapperProfile : Profile{
    public MapperProfile(){
        CreateMap<PostDto, Post>();
    }
}