using FootballApi.Domain.Common;

namespace FootballApi.Domain.Player
{
    public interface IPlayerRepository : ICrudRepository<PlayerEntity>
    {
    }
}