﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Data;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
    public class TreeTypeService : ITreeTypeService
    {
        private readonly IRepository<TreeType> repository;
        public TreeTypeService(IRepository<TreeType> repository)
        {
            this.repository = repository;
        }
        public void Delete(int id)
        {
            var treetypeToDelete = repository.Find(id);
            if (treetypeToDelete != null)
            {
                repository.Delete(treetypeToDelete);
            }
        }

        public TreeType Find(int id)
        {
            return repository.Find(id);
        }

        public TreeType Find(Expression<Func<TreeType, bool>> where)
        {
            return repository.Find(where);
        }

        public TreeType FindByName(string name)
        {
            return repository.Find(r => r.Name.Contains(name));
        }

        public IEnumerable<TreeType> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<TreeType> GetAll(Expression<Func<TreeType, bool>> where)
        {
            return repository.GetAll(where);
        }

        public void Insert(TreeType treetype)
        {
            repository.Insert(treetype);
        }

        public void Update(TreeType treetype)
        {
            repository.Update(treetype);
        }
    }
}
