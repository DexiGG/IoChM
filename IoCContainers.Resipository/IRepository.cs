﻿using System;
using System.Collections.Generic;

namespace IoCConteiners.Resipository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Create(T item);
        T GetEntity(int id);
        IEnumerable<T> GetEntitysList();
        void Delete(T item);
        void Edit(T item);
    }
}
