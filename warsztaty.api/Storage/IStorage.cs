﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warsztaty.API.Storage
{
    public interface IStorage
    {
        void Add(string key);
        List<string> GetAll();
    }

    public class InMemoryDb : IStorage
    {
        private readonly List<string> addedKeys = new List<string>();

        public void Add(string key)
        {
            addedKeys.Add(key);
        }

        public List<string> GetAll() => new List<string>(addedKeys);
    }
}
