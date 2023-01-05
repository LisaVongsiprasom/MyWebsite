using PersonalWebsite.Models;

namespace PersonalWebsite
{
    public class AboutRepository
    {
        private List<AboutViewModel> _about;

        public AboutRepository()
        {
            CreateMockAbout();
        }
        private void CreateMockAboutList()
        {
            _about = new List<AboutViewModel>();
            _about.Add(new AboutViewModel { Id = 1, Name = "Steve", Course = "AHBC C#" });
            _about.Add(new AboutViewModel { Id = 2, Name = "Mary", Course = "AHBC C#" });
            _about.Add(new AboutViewModel { Id = 3, Name = "David", Course = "AHBC C#" });
            _about.Add(new AboutViewModel { Id = 4, Name = "Kate", Course = "AHBC C#" });
        }
        public IEnumerable<AboutViewModel> CreateMockAbout()
        {
            return _about;
        }

    }
}
