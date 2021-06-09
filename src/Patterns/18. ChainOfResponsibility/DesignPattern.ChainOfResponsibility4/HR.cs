using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility4
{
    public class HR
    {
        private List<Manager> _managers = new List<Manager>();

        public void AddManager(Manager manager)
        {
            _managers.Add(manager);
        }

        public Manager GetManager()
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
