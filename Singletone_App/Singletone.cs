using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone_App
{
    class Singletone
    {
        private static Singletone _instance;
        private static object locker = new object();
        private static int _id = 0;
        public int Number { get; set; }

        protected Singletone()
        {
            _id++;
            Number = _id;
        }

        public static Singletone GetInstance()
        {
            if (_instance == null)
                lock (locker)
                {
                    if (_instance == null)
                        _instance = new Singletone();
                }
            return _instance;
        }

    }
}
