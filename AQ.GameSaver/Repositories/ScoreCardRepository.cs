using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Cards.Enums.PermanentCardEnums;
using AQ.GameSaver.Repository.Interfaces;
using AQ.GameSaver.Score_Card;

namespace AQ.GameSaver.Repositories
{
    public sealed class ScoreCardRepository : IRepository<ScoreCard>
    {
        public static readonly ScoreCardRepository _instance = new ScoreCardRepository();
        private List<ScoreCard> _scoreCards;


        private ScoreCardRepository()
        {
            _scoreCards = new List<ScoreCard>();
            LoadData();
        }

        public void Add(ScoreCard scoreCard)
        {
            _scoreCards.Add(scoreCard);
        }

        public void Delete(Guid id)
        {
            var scoreCardToRemove = _scoreCards.Find(x => x.Id == id);
            _scoreCards.Remove(scoreCardToRemove);

        }

        public IEnumerable<ScoreCard> GetAll()
        {
            return _scoreCards;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        private void LoadData()
        {
        }
    }
}
