﻿using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Infra.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, Tid>
        : IBaseRepository<TEntity, Tid> where TEntity : BaseEntity<Tid>
    {
        private readonly IMongoCollection<TEntity> _collection;

        public BaseRepository(IMongoDBContext mongoDbContext, string collectionName)
        {
            _collection = mongoDbContext.GetCollection<TEntity>(collectionName);
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);

            return entity;
        }

        public async Task<List<TEntity>> FindAllAsync()
        {
            var all = await _collection.FindAsync(new BsonDocument());
            
            return await all.ToListAsync();
        }

        public async Task<TEntity> FindByIdAsync(Tid Id)
        {
            var filter = Builders<TEntity>.Filter.Eq("_id", Id);

            var result = await _collection.FindAsync(filter);
            
            return result.FirstOrDefault(); 
        }
    }
}
