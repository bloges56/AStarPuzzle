using HW1._8_Puzzle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.AStar
{
    class Frontier
    {
        Queue<Node> frontier;


        public Frontier()
        {
            frontier = new Queue<Node>();
        }

        public Queue<Node> getFrontier()
        {
            return frontier;
        }

        public void add(Node n)
        {
            frontier.Enqueue(n);
            IEnumerable<Node> sortedFrontier = frontier.OrderBy(node => node.getMisplacedTiles() + node.getCost());
            frontier = new Queue<Node>(sortedFrontier);
        }
    }
}
