using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TestRepo
{
    class Coffee
    {
        private int volume;
        private string type;
        private bool hot;

        public int Volume { get; set; }
        public string Type { get; set; }
        public bool Hot { get; set; }

        public string toString() { return $"{type} - {volume}L - Hot: {hot}"; }

    }
}
