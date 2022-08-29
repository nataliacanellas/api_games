using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (ApiJogosContext warrenContext = new())
            {
                list = warrenContext.Set<T>().ToList();
            }
            return list;
        }
        public virtual string Create(T entity)
        {
            using (ApiJogosContext warrenContext = new())
            {
                warrenContext.Add(entity);
                warrenContext.SaveChanges();
            }
            return "Criado";
        }


        public virtual string Delete(int id)
        {
            using (ApiJogosContext warrenContext = new())
            {
                warrenContext.Entry<T>(this.GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                warrenContext.SaveChanges();
            }
            return "Deletado";
        }

        public virtual T GetById(int id)
        {
            T entity = null;
            using (ApiJogosContext warrenContext = new())
            {
                entity = warrenContext.Set<T>().Find(id);
            }
            return entity;
        }

        public virtual string Update(T entity)
        {
            using (ApiJogosContext warrenContext = new())
            {
                warrenContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                warrenContext.SaveChanges();

            }
            return "Alterado";
        }
        public virtual string Modify(T entity)
        {
            using (ApiJogosContext context = new())
            {
                context.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            return "Alterado";
        }
    }
}
