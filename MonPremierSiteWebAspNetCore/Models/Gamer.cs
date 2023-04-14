namespace MonPremierSiteWebAspNetCore.Models
{
    public class Gamer
    {
        public Gamer(int id, string fullName, string gamerTag)
        {
            Id = id;
            FullName = fullName;
            GamerTag = gamerTag;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string GamerTag { get; set; }
    }
}
