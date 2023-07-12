using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace App.ALL.EntityFramework.Repositories
{
    public abstract class ALLRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ALLDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ALLRepositoryBase(IDbContextProvider<ALLDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ALLRepositoryBase<TEntity> : ALLRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ALLRepositoryBase(IDbContextProvider<ALLDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
