using MvcRepositoryDemo.Models;
using System;
using System.Collections.Generic;

namespace MvcRepositoryDemo.Repository
{
    public interface IToDoRepository : IDisposable
    {
        IEnumerable<Todo> Get();
        Todo GetByID(int? Id);
        void Add(Todo todo);
        void Delete(int Id);
        void Update(Todo todo);
        void Save();
    }
}