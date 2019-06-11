using CodeWars.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class MainMethod
    {

        static void Main(string[] args)
        {
            //var directions = Solutions.dirReduc(new Direction[] { Direction.NORTH, Direction.NORTH, Direction.NORTH, Direction.NORTH, Direction.SOUTH, Direction.SOUTH, Direction.SOUTH, Direction.SOUTH, Direction.EAST});
            //for (int i = 0; i < directions.Length; i++)
            //{
            //    Console.WriteLine(directions[i]);
            //}
            var a = Solutions.FoldArray(new int[] { -9, 9, -8, 8, 66, 23 }, 1);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

        }

    }
}
