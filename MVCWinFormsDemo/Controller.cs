using System;
using System.Text;
using System.Collections.Generic;

using ModelLibrary;
using System.Windows.Forms;

namespace MVCWinFormsDemo
{
    public class Controller
    {
        const int DEFAULT_NUMBER_SIZE = 10;

        private readonly Model _m;

        public Controller(Model m)
        {
            _m = m;
        }

        public event DataChanged Changed    // Событие, возникающее при изменении данных в модели
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

        public string GetData()    // Read
        {
            StringBuilder result = new StringBuilder(_m.Count * DEFAULT_NUMBER_SIZE);

            for (int i = 0; i < _m.Count; i++)
            {
                result.AppendFormat("{0} ", _m[i]);
            }

            return result.ToString();
        }

        public void Add(int val)
        {
            _m.Add(val);
        }

        //public void Add(string data)
        //{
        //    string[] strNumbers = data.Split(' ', ',', ';');

        //    foreach (var item in strNumbers)
        //    {
        //        if (item == string.Empty)
        //        {
        //            continue;
        //        }

        //        try
        //        {
        //            int newValue = int.Parse(item);

        //            _m.Add(newValue);
        //        }
        //        catch (FormatException)
        //        {
        //            MessageBox.Show(string.Format("<{0}> - isn't int value!!!", item), "Wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }            
        //}

        public bool Add(string data, out string errorMessage)
        {
            bool ok = true;

            errorMessage = string.Empty;

            string[] strNumbers = data.Split(' ', ',', ';');

            foreach (var item in strNumbers)
            {
                if (item == string.Empty)
                {
                    continue;
                }

                try
                {
                    int newValue = int.Parse(item);

                    _m.Add(newValue);
                }
                catch (FormatException)
                {
                    ok = false;

                    errorMessage = string.Format("<{0}> - isn't int value!!!", item);                    
                }
            }            

            return ok;
        }
    }
}
