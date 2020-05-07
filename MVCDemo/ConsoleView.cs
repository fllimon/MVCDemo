using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200430_MVCDemo
{
    // View
    class ConsoleView
    {
        #region ======----- PRIVATE DATA -------======

        private readonly ConsoleController _ctrl;
        private bool _isActiveModelFlag = false;

        #endregion

        #region ======------ CTOR --------=====

        public ConsoleView(ConsoleController ctrl)
        {
            _ctrl = ctrl;
        }

        #endregion

        private void Print(object sender, EventArgs args)
        {
            Print(_ctrl.GetData());
        }

        public void Print()
        {
            Print(_ctrl.GetData());
        }

        public void Print(IEnumerable<int> items)
        {
            int oldXPos = Console.CursorLeft;
            int oldYPos = Console.CursorTop;

            Console.SetCursorPosition(0, 10);

            foreach (int item in items)
            {
                Console.Write("{0} ", item);
            }

            Console.SetCursorPosition(oldXPos, oldYPos);
        }

        public void Pause()
        {
            Console.Write("Press any key to continue...");

            Console.ReadKey();
        }

        public void ShowMenu(string[] items)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public UserAction GetUserChoice()
        {
            UserAction result = UserAction.NoAction;

            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        result = UserAction.Exit;
                        break;
                    case ConsoleKey.P:
                        result = UserAction.Print;
                        break;
                    case ConsoleKey.I:
                        result = UserAction.NewData;
                        break;
                    case ConsoleKey.D:
                        result = UserAction.DeleteData;
                        break;
                    case ConsoleKey.U:
                        result = UserAction.ActiveModel;

                        if (!_isActiveModelFlag)
                        {
                            _isActiveModelFlag = true;
                        }
                        else
                        {
                            _isActiveModelFlag = false;
                        }

                        break;
                }
            }

            return result;
        }

        public void ChekedChangeActiveModel()
        {
            if (_isActiveModelFlag)
            {
                _ctrl.Changed += Print;
            }
            else
            {
                _ctrl.Changed -= Print;
            }
        }
    }
}
