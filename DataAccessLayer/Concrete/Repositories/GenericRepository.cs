﻿using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        BlogContext db= new BlogContext();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object=db.Set<T>();
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            db.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            db.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            db.SaveChanges();
        }
    }
}
