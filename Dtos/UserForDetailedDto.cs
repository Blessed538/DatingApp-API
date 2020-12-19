namespace DatingApp.API.Dtos
{
    public class UserForDetailedDto
    {

        public string PhotoUrl {get; set;}
        public string Country {get; set;}
        public ICollection<PhotosForDetailedDto> Photos {get; set;}
    }
}