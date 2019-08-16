﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using EP.CursoMVC.Domain.Interfaces.Repository;
using EP.CursoMVC.Infra.Data.Contexts;

namespace EP.CursoMVC.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        // protected
        protected CursoMvcContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new CursoMvcContext();
            DbSet = Db.Set<TEntity>();

        }

        public virtual  TEntity Adicionar(TEntity obj)
        {
              var objReturn = DbSet.Add(obj);
              SaveChanges();
              return objReturn;
        }
        public virtual  TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }
        /* public IEnumerable<TEntity> ObterTodos( int t, int s)
        {
            return DbSet.Take(t).Skip(s).ToList();
        }*/
        public virtual  TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);

            entry.State = EntityState.Modified;

            SaveChanges();
            return obj;
        }
        public virtual void Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }


        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }


    }
}