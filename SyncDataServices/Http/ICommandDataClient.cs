using PLATFORMSERVICE.Dtos;

namespace PLATFORMSERVICE.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat);
    }
}
