using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility5
{
    public class ManagerBuilder: IManagerBuilder
    {
        private readonly List<Manager> _managers = new List<Manager>();

        public void AddManager(Manager manager)
        {
            _managers.Add(manager);
        }

        public Manager Build()
        {
            Manager currentManager = null;
            for (int i = _managers.Count - 1; i >= 0; i--)
            {
                if (currentManager != null)
                {
                    _managers[i].NextManager = currentManager;
                }

                currentManager = _managers[i];
            }

            return currentManager;
        }
    }
}
