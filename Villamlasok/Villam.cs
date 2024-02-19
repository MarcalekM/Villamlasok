using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villamlasok
{
    internal class Villam
    {
        public List<int> _orak;

        public Villam(string sor)
        {
            var v = sor.Split(';').ToList();
            _orak = new();
            foreach (var v2 in v) _orak.Add(int.Parse(v2));
        }

        public override string ToString()
        {
            string text = string.Empty;
            for (int i = 0; i < _orak.Count; i++)
            {
                text += _orak[i].ToString();
                if (i < _orak.Count-1) text += ", ";
            }
            return text;
        }
    }
}
