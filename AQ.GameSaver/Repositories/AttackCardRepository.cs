using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Cards.Enums.AttackCardEnums;
using AQ.GameSaver.Guilds;
using AQ.GameSaver.Repository.Interfaces;

namespace AQ.GameSaver.Repositories
{
    public sealed class AttackCardRepository : IRepository<AttackCard>
    {
        public static readonly AttackCardRepository _instance = new AttackCardRepository();
        private List<AttackCard> _attackCards;


        private AttackCardRepository()
        {
            _attackCards = new List<AttackCard>();
            LoadData();
        }

        public void Add(AttackCard attackCard)
        {
            _attackCards.Add(attackCard);
        }

        public void Delete(Guid id)
        {
            var attackCardToRemove = _attackCards.Find(x => x.Id == id);
            _attackCards.Remove(attackCardToRemove);

        }

        public IEnumerable<AttackCard> GetAll()
        {
            return _attackCards;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        private void LoadData()
        {
            _attackCards.Add(new AttackCard("Trusty Blade", 1, 1, AttackType.Melee, WeaponType.Sword));
        }
    }
}
