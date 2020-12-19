namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
      CreateMap<User, UserFirDetailedDto>();
        .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
        .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge())); 
      CreateMap<User, UserForListDto>();
      CreateMap<Photo, PhotosForDetailedDto>();  
      .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge())); 
    }
}