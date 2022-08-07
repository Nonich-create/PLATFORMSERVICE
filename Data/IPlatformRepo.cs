using PLATFORMSERVICE.Models;

namespace PLATFORMSERVICE.Data
{
    public interface IPlatformRepo
    {
        bool SaveChange();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }
}
