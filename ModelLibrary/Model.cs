using System;
using System.Collections.Generic;
using System.Net;
//using System.Text;
//using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Model
    {
        private List<int> _items = new List<int> {0, 12, -4, 7, 90, 887};

        private DataChanged _changed;

        public event DataChanged Changed    // Событие, возникающее при изменении данных в модели
        {
            add
            {
                _changed += value;
            }
            remove
            {
                _changed -= value;
            }
        }

        protected virtual void OnChanged()
        {
            if (_changed != null)
            {
                _changed(this, new EventArgs());
            }
        }

        #region ---===   CRUD   ===---
        
        public bool Add(int arg)
        {
            _items.Add(arg);

            OnChanged();    // !!! произошло изменение данных

            return true;
        }

        public bool RemoveItems(int itemsId)
        {
            if (itemsId <= _items.Count - 1)
            {
                _items.RemoveAt(itemsId);

                OnChanged();
            }
            return true;
        }

        #endregion

        public int Count
        {
            get 
            {
                return _items.Count;
            }
        }     

        public int this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;

                OnChanged();    // !!! произошло изменение данных
            }
        }
    }
}
