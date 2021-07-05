using MongoDB.Driver;

namespace Avanade.SubTCSE.Projeto.Domain.Base.MongoDB
{
    public interface IMongoDBContext
    {
        IMongoCollection<TEntity> GetCollection<TEntity>(string collection);
    }
}

//ACID