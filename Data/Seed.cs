namespace DatingApp.API.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext context)
        {
         if(!context.Users.Any())
         {
             var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
             var users = JsonConvert.DeserializeObject<List<User>>(userData);
             foreach (var user in users)
             {
                 byte[] passwordhash,passwordSalt;
                 CreatePasswordHash("password", out passwordhash, out passwordSalt);

                 user.passwordhash = passwordhash;
                 user.passwordSalt = passwordSalt;
                 user.Username = user.Username.ToLower();
                 context.Users.Add(user); 
             }

             context.SaveChanges();
         }
        }

        private static void CreatePasswordHash(string password,out byte[] passwordhash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordhash =  hmac.ComputeHas(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}