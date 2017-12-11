using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaminoCub.Figures
{
    public class Cub
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
    }
}
