using HoroscopeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HoroscopeApplication.Repository
{
    public class HistoryRepository : IHistoryRepository
    {
        private static readonly Dictionary<string, Queue<History>> _searchHistory = new Dictionary<string, Queue<History>>();
        public void AddHistory(string id, History history)
        {
            if (!_searchHistory.ContainsKey(id))
            {
                _searchHistory[id] = new Queue<History>();
            }

            if (_searchHistory[id].Count == 5)
            {
                _searchHistory[id].Dequeue();
            }

            history.Id = _searchHistory[id].Count() + 1;
            _searchHistory[id].Enqueue(history);
        }

        public IList<History> GetHistories(string id)
        {
            var histories = _searchHistory.GetValueOrDefault(id);

            return histories == null ? null : histories.ToList();
        }

        public History GetHistory(string id, int historyId)
        {
            var history = _searchHistory[id].FirstOrDefault(h => h.Id == historyId);

            return history;
        }

        public void RemoveHistories(string id)
        {
            _searchHistory[id].Clear();
        }
    }
}
