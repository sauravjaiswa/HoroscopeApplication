using HoroscopeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Repository
{
    public interface IHistoryRepository
    {
        void AddHistory(string id, History history);
        IList<History> GetHistories(string id);
        History GetHistory(string id, DateTime searchedTime);
        void RemoveHistories(string id);
    }
}
