﻿﻿using FootballApi.Domain.Common;

  namespace FootballApi.Domain.Referee
{
    public class RefereeEntity : Entity
    {
        public readonly string Id;
        public readonly string Name;
        public readonly int MinutesPlayed;

        public RefereeEntity(string id, string name, int minutesPlayed)
        {
            Id = id;
            Name = name;
            MinutesPlayed = minutesPlayed;
        }
    }
}