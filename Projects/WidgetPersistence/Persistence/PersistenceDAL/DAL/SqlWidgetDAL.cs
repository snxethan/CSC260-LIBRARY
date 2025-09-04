using Microsoft.EntityFrameworkCore;
using PersistenceDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersistenceDAL.DAL
{
    public class SqlWidgetDAL : IWidgetDAL
    {
        private readonly WidgetContext context;

        public SqlWidgetDAL(string conn)
        {
            var builder = new DbContextOptionsBuilder<WidgetContext>();
            builder.UseSqlServer(conn);

            context = new WidgetContext(builder.Options);

            context.Database.EnsureCreated();
        }

        public void AddWidget(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return;

            var widget = new Widget { Name = name.Trim() };
            context.Widgets.Add(widget);
            context.SaveChanges();
        }

        public void DeleteAllWidgets()
        {
            //remove all rows
            context.Widgets.RemoveRange(context.Widgets);
            context.SaveChanges();
        }

        public void DeleteWidget(int id)
        {
            var entity = context.Widgets.Find(id);
            if (entity == null) return;

            context.Widgets.Remove(entity);
            context.SaveChanges();
        }

        public Widget GetWidget(int id)
        {
            // AsNoTracking for read-only queries
            return context.Widgets.AsNoTracking().FirstOrDefault(w => w.Id == id);
        }

        public Widget GetWidget(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;

            var needle = name.Trim();
            return context.Widgets.AsNoTracking().FirstOrDefault(w => w.Name == needle);
        }

        public List<Widget> GetWidgets()
        {
            return context.Widgets.AsNoTracking()
                                  .OrderBy(w => w.Id)
                                  .ToList();
        }

        public void UpdateWidget(int id, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return;

            var entity = context.Widgets.FirstOrDefault(w => w.Id == id);
            if (entity == null) return;

            entity.Name = name.Trim();
            context.SaveChanges();
        }
    }
}
