using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaminoCub.Figures
{
    public class Cub : IComparable
    {
        List<List<List<int>>> cub;
        public int size { get; }

        List<int> filledLayers;

        public Cub(int size)
        {
            List<int> line = Enumerable.Repeat(-1, size).ToList();
            List<List<int>> layer = Enumerable.Repeat(line, size).ToList();
            cub = Enumerable.Repeat(layer, size).ToList();

            filledLayers = Enumerable.Repeat(0, size).ToList();

            this.size = size;
        }

        public Cub copy()
        {
            Cub cp = new Cub(size);

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                    for (int k = 0; k < size; ++k)
                        cp.cub[i][j][k] = cub[i][j][k];


                cp.filledLayers[i] = filledLayers[i];
            }

            return cp;
        }

        public void addPoint(int layer)
        {
            if (layer >= size || layer < 0 || filledLayers[layer] < 0 || filledLayers[layer] > size)
                throw new IndexOutOfRangeException();

            ++filledLayers[layer];
        }

        public void dropPoint(int layer)
        {
            if (layer >= size || layer < 0 || filledLayers[layer] < 0 || filledLayers[layer] > size)
                throw new IndexOutOfRangeException();

            --filledLayers[layer];
        }

        public int hueristicCost()
        {
            int tens = 10, cost = 0, size = filledLayers.Count - 1;
            for (int i = size; i >= 0; --i)
            {
                cost += tens * i * filledLayers[size - i];
                tens *= 10;
            }

            return cost;
        }

        public bool isFreePosition(Point3D point)
        {
            return cub[point.x][point.y][point.z] == 0;
        }

        public void print()
        {
            for (int i = 0; i < size; ++i)
            {
                Console.Out.WriteLine("{0} слой", i + 1);
                for (int j = 0; j < size; ++j)
                {
                    for (int k = 0; k < size; ++k)
                        Console.Out.Write("{0} ", cub[i][j][k]);
                    Console.Out.WriteLine();
                }
            }
        }

        public bool isGathered()
        {
            bool res = true;
            foreach (var line in filledLayers)
                res &= line == size * size;

            return res;
        }

        public int CompareTo(object obj)
        {
            Cub c = (Cub)obj;
            return c.hueristicCost() - hueristicCost();
        }
    }
}
