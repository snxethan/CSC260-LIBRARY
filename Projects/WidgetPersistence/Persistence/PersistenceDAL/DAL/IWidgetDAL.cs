using PersistenceDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceDAL.DAL
{
    public interface IWidgetDAL
    {
        List<Widget> GetWidgets();

        Widget GetWidget(int id);

        void AddWidget(string name);

        void UpdateWidget(int id, string name);

        void DeleteWidget(int id);

        void DeleteAllWidgets();
    }
}
