using System;
using System.Collections.Generic;
using FootballApi.Domain.Common;
using FootballApi.Domain.Manager;
using FootballApi.Domain.Player;
using FootballApi.Domain.Referee;

namespace FootballApi.Domain.Match
{
    public class MatchEntity : Entity
    {
        public readonly string Id;
        public readonly string Name;
        public readonly ICollection<PlayerEntity> HouseTeamPlayers;
        public readonly ICollection<PlayerEntity> AwayTeamPlayers;
        public readonly ManagerEntity HouseTeamManager;
        public readonly ManagerEntity AwayTeamManager;
        public readonly RefereeEntity Referee;
        public readonly DateTime Date;

        public MatchEntity(string id, string name, List<PlayerEntity> houseTeamPlayers, List<PlayerEntity> awayTeamPlayers, ManagerEntity houseTeamManager, ManagerEntity awayTeamManager, RefereeEntity referee, DateTime date)
        {
            Id = id;
            Name = name;
            HouseTeamPlayers = houseTeamPlayers;
            AwayTeamPlayers = awayTeamPlayers;
            HouseTeamManager = houseTeamManager;
            AwayTeamManager = awayTeamManager;
            Referee = referee;
            Date = date;
        }
    }
}