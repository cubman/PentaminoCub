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

        SortedSet<Cub> priorityInOperations;

        List<Pentamino> pentaminoes;

        public Solution(int p_size)
        {
            pentaminoes = Enumerable.Repeat(-1, p_size * p_size).Select((_, i) => new Pentamino(i + 1)).ToList();

            cub = new Cub(p_size);
            solution = new Cub(p_size);

            this.p_size = p_size;

            priorityInOperations.Add(cub);
        }

        public void solve()
        {
            countSolution();
        }

        private void countSolution()
        {
            Point3D start = new Point3D(0, 0, 0);

            if (priorityInOperations.Count == 0)
                return;

            Cub c = priorityInOperations.First();

            if (c.isGathered())
            {
                solution = c;
                printSolution();

                return;
            }

            foreach(var fun in Pentamino.functions)
            {
                countSolution();
            }
        }

        public void printSolution()
        {
            solution.print();
        }
    }
}
