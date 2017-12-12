using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaminoCub.Figures
{
    public class Cub : IComparable
    {
        List<List<List<int>>> cub = new List<List<List<int>>>();
        public int size { get; }

        public List<int> filledLayers { get; private set; }
        int pentaminoesAmount = 0;

        public Cub(int size)
        {
            for (int i = 0; i < size; ++i)
            {
                List<List<int>> layer = new List<List<int>>();

                for (int j = 0; j < size; ++j)
                {
                    List<int> line = Enumerable.Repeat(-1, size).ToList();
                    layer.Add(line);
                }
                cub.Add(layer);
            }
            
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

            cp.pentaminoesAmount = pentaminoesAmount;

            return cp;
        }

        void addPoint(int layer)
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
                cost += tens * (i + 1) * filledLayers[i];
                tens *= 10;
            }

            return cost;
        }

        public bool isFreePosition(Point3D point)
        {
            return cub[point.z][point.y][point.x] == -1;
        }

        public void print()
        {
            for (int i = 0; i < size; ++i)
            {
                Console.Out.WriteLine("{0} слой", i + 1);
                for (int j = 0; j < size; ++j)
                {
                    for (int k = 0; k < size; ++k)
                        Console.Out.Write("{0} ", cub[k][j][i]);
                    Console.Out.WriteLine();
                }
            }
        }

        public bool isGathered()
        {
            bool res = true;
            foreach (var line in filledLayers)
                res &= (line == size * size);

            return res;
        }

        public int CompareTo(object obj)
        {
            Cub c = (Cub)obj;
            return hueristicCost() - c.hueristicCost();
        }

        public void setPoints(Point3D[] points)
        {
            foreach (var pnt in points)
            {
                cub[pnt.z][pnt.y][pnt.x] = pentaminoesAmount;
                ++filledLayers[pnt.z];
            }

            ++pentaminoesAmount;
        }

        public Point3D findFreePlace()
        {
            for (int i = 0; i < size; ++i)
                if (filledLayers[i] != size * size)
                {
                    for (int j = 0; j < size; ++j)
                        for (int k = 0; k < size; ++k)
                            if (cub[i][j][k] == -1)
                                return new Point3D(k, j, i);
                    throw new Exception();
                }

            return new Point3D(-1, -1, -1);
        }
    }
}
