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
            while (priorityInOperations.Count != 0)
            {
                Cub c = priorityInOperations.pop();
                Point3D start = c.findFreePlace();

                Console.Out.WriteLine("{0} {1} {2} {3} {4} - {5}", 
                    c.filledLayers[0], c.filledLayers[1], c.filledLayers[2], c.filledLayers[3], c.filledLayers[4], priorityInOperations.Count);

                if (c.isGathered())
                {
                    solution = c;
                    printSolution();

                    return;
                }

                foreach (var fun in Pentamino.functions)
                {
                    Tuple<bool, Point3D[]> res = fun(start, c);
                    if (res.Item1)
                    {
                        Cub cp = c.copy();

                        cp.setPoints(res.Item2);
                        priorityInOperations.push(cp);
                    }

                }
            }
        }

        public void printSolution()
        {
            solution.print();
        }
    }
}
