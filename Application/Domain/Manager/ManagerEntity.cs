﻿﻿using FootballApi.Domain.Common;

  namespace FootballApi.Domain.Manager
{
    public class ManagerEntity : Entity
    {
        public readonly string Id;
        public readonly string Name;
        public readonly string TeamName;
        public readonly int YellowCards;
        public readonly int RedCards;

        public ManagerEntity(string id, string name, string teamName, int yellowCards, int redCards)
        {
            Id = id;
            Name = name;
            TeamName = teamName;
            YellowCards = yellowCards;
            RedCards = redCards;
        }
    }
}