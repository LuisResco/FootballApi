﻿﻿using System.Threading.Tasks;

  namespace FootballApi.Domain.Statistics
{
    public interface IStatisticsCardsService
    {
        Task<StatisticsCard> GetAsync(string redcards);
    }
}