using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModelLibrary;

namespace _20200430_MVCDemo
{
    class ConsoleController
    {
        #region =====----- PRIVATE DATA ------======

        private readonly Model _m;
       
        #endregion

        #region =====----- CTOR ------======

        public ConsoleController(Model m)
        {
            _m = m;
        }

        #endregion

        #region =======-------- EVENT'S --------==========

        public event DataChanged Changed
        {
            add
            {
                _m.Changed += value;
            }
            remove
            {
                _m.Changed -= value;
            }
        }

        #endregion

        // named iterator
        public IEnumerable<int> GetPositiveData()
        {
            for (int i = _m.Count - 1; i >= 0; i--)
            {
                int result = _m[i];

                if (result < 0)
                {
                    yield break;    // окончание формирование результирующего набора данных
                }

                // result ---> IEnumerable<int>
                yield return result;
            }
        }

        public IEnumerable<int> GetData()
        {
            for (int i = _m.Count - 1; i >= 0; i--)
            {
                yield return _m[i];
            }
        }

        public void Add(int val)
        {
            _m.Add(val);
        }

        public void Delete(int itemId)
        {
            _m.RemoveItems(itemId);
        }
    }
}
