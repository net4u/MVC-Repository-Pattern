using MvcRepositoryDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace MvcRepositoryDemo.Repository
{
    public class ToDoRepository : IToDoRepository
    {
        private ToDoContext context; //db context

        public ToDoRepository(ToDoContext context)
        {
            this.context = context;  //assigning db context
        }

        public IEnumerable<Todo> Get()
        {
            return context.Todoes.ToList();
        }

        public Todo GetByID(int? Id)
        {
            return context.Todoes.Find(Id);
            //return context.Todoes.Find(p => p.Id == Id);
        }

        public void Add(Todo todo)
        {
            context.Todoes.Add(todo);
        }

        public void Delete(int Id)
        {
            Todo todo = context.Todoes.Find(Id);
            context.Todoes.Remove(todo);
        }

        public void Update(Todo todo)
        {
            context.Entry(todo).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
    }   
}