﻿﻿using System.Threading.Tasks;

  namespace FootballApi.Domain.Statistics
{
    public interface IStatisticsMinutesService
    {
        Task<StatisticsMinutes> GetAsync();
    }
}