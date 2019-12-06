﻿﻿using FootballApi.Domain.Common;

  namespace FootballApi.Domain.Player
{
    public class PlayerEntity : Entity
    {
        public readonly string Id;
        public readonly string Name;
        public readonly int Number;
        public readonly string TeamName;
        public readonly int YellowCards;
        public readonly int RedCards;
        public readonly int MinutesPlayed;

        public PlayerEntity(string id, string name, int number, string teamName, int yellowCards, int redCards, int minutesPlayed)
        {
            Id = id;
            Name = name;
            Number = number;
            TeamName = teamName;
            YellowCards = yellowCards;
            RedCards = redCards;
            MinutesPlayed = minutesPlayed;
        }
    }
}