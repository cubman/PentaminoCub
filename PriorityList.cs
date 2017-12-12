using PentaminoCub.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaminoCub
{
    public class PriorityList
    {
        List<Cub> cubs = new List<Cub>();

        public PriorityList() { }

        public int Count { get { return cubs.Count; } }

        public void push(Cub c)
        {
            int cnt = 0;
            foreach (var cs in cubs)
                if (c.CompareTo(cs) > 0)
                {
                    cubs.Insert(cnt, c);
                    break;
                }
                else
                    ++cnt;

            cubs.Add(c);
        }

        public Cub top()
        {
            return cubs.First();
        }

        public Cub pop()
        {
            Cub c = top();
            cubs.RemoveAt(0);

            return c;
        }
    }
}
