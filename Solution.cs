using PentaminoCub.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaminoCub
{
    public class Solution
    {
        int p_size;
        Cub cub, solution;

        PriorityList priorityInOperations = new PriorityList();

        List<Pentamino> pentaminoes;

        public Solution(int p_size)
        {
            pentaminoes = Enumerable.Repeat(-1, p_size * p_size).Select((_, i) => new Pentamino(i + 1)).ToList();

            cub = new Cub(p_size);
            solution = new Cub(p_size);

            this.p_size = p_size;

            priorityInOperations.push(cub);
        }

        public void solve()
        {
            countSolution();
        }

        private void countSolution()
        {
            if (priorityInOperations.Count == 0)
                return;

            Cub c = priorityInOperations.pop();
            Point3D start = c.findFreePlace();

            if (c.isGathered())
            {
                solution = c;
                printSolution();

                return;
            }

            foreach(var fun in Pentamino.functions)
            {
                Tuple<bool, Point3D[]> res = fun(start, c);
                if (res.Item1)
                {
                    Cub cp = c.copy();

                    cp.setPoints(res.Item2);
                    priorityInOperations.push(cp);
                }
                
            }
            countSolution();
        }

        public void printSolution()
        {
            solution.print();
        }
    }
}
