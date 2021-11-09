using HoroscopeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HoroscopeApplication.Repository
{
    public class HistoryRepository : IHistoryRepository
    {
        private static readonly Dictionary<string, Queue<History>> _searchHistory = new Dictionary<string, Queue<History>>();
        public bool AddHistory(string id, History history)
        {
            if (!_searchHistory.ContainsKey(id))
            {
                return false;
            }

            if (_searchHistory[id].Count == 5)
            {
                _searchHistory[id].Dequeue();
            }

            _searchHistory[id].Enqueue(history);

            return true;
        }

        public IList<History> GetHistories(string id)
        {
            var histories = _searchHistory[id].ToList();

            return histories;
        }

        public History GetHistory(string id, DateTime searchedTime)
        {
            throw new NotImplementedException();
        }

        public void RemoveHistory(string id, DateTime searchedTime)
        {
            throw new NotImplementedException();
        }
    }
}
