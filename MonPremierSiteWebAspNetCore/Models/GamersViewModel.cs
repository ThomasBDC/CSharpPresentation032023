namespace MonPremierSiteWebAspNetCore.Models
{
    public class GamersViewModel
    {
        public GamersViewModel(List<Gamer> gamers)
        {
            Gamers = gamers;
        }

        public List<Gamer> Gamers { get; }
    }
}
