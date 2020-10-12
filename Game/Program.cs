using System;
using System.Collections.Generic;
using Units;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier1 = new Soldier(100, "Soldier1", 5, 3);
            Soldier soldier2 = new Soldier(100, "Soldier2", 5, 3);
            Doctor doctor1 = new Doctor(50, "Doctor1", -3, 4);
            FireSoldier fireMan = new FireSoldier(150, "fireman", 6, 5, new List<Unit> {doctor1, soldier1, soldier2});

            List<Unit> units = new List<Unit>{soldier1, soldier2, doctor1, fireMan};

            foreach (var unit in units)
            {
                Console.WriteLine(unit.GetInfo());
            }
        }
    }
}
