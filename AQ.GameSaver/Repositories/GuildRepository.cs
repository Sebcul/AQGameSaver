using System;
using System.Collections.Generic;
using AQ.GameSaver.Guilds;
using AQ.GameSaver.Repository.Interfaces;

namespace AQ.GameSaver.Repositories
{
    public sealed class GuildRepository : IRepository<Guild>
    {
        public static readonly GuildRepository _instance = new GuildRepository();
        private List<Guild> _guilds;


        private GuildRepository()
        {
            _guilds = new List<Guild>();
        }

        public void Add(Guild guild)
        {
            _guilds.Add(guild);
        }

        public void Delete(Guid id)
        {
            var guildToRemove =_guilds.Find(x => x.Id == id);
            _guilds.Remove(guildToRemove);

        }

        public IEnumerable<Guild> GetAll()
        {
            return _guilds;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
