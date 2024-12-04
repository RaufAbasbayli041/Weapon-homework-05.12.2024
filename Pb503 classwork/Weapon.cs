using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb503_classwork
{
    public class Weapon
    {
        public Mode ShootMode { get; set; }
        public int MagazineCapacity { get; set; }
        public int CurrentBullet { get; set; }


        public void Shoot()
        {
            if (ShootMode == Mode.Single)
            {
                if (CurrentBullet > 0)
                {
                    CurrentBullet -= 1;
                    Console.WriteLine("shoot");
                    Console.WriteLine($"Current bullet = {CurrentBullet}");
                }
                else
                {
                    Console.WriteLine("bowdur");
                }
            }

            else if (ShootMode == Mode.Burst)
            {
                if (CurrentBullet > 0)
                {
                    CurrentBullet -= 3;
                    Console.WriteLine("shoot shoot shoot");
                    Console.WriteLine($"Current bullet = {CurrentBullet}");
                }
                else
                {
                    Console.WriteLine("bowdur");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void Fire()
        {
            if (ShootMode == Mode.Automatic)
            {
                if (CurrentBullet > 0)
                {
                    CurrentBullet = 0;
                    Console.WriteLine("fire");
                    Console.WriteLine($"Current bullet = {CurrentBullet}");
                }
                else
                {
                    Console.WriteLine("bowdur");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public int GetRemainBulletCount()
        {
            return MagazineCapacity - CurrentBullet;
        }

        public int Reload()
        {
            return MagazineCapacity;
        }

        public void ChangeFireMode(string lastMode)
        {
            if (string.IsNullOrEmpty(lastMode))
            {
                throw new CustomExceptions("error,enter right weapon mode");
            }
            if (Mode.Burst.ToString().ToLower().Contains("bu") && lastMode.ToLower().Contains("bu"))
            {
                ShootMode = Mode.Burst;
                Console.WriteLine("Weapon has changed to burst mode");
            }
            else if (Mode.Single.ToString().ToLower().Contains("si") && lastMode.ToLower().Contains("si"))
            {
                ShootMode = Mode.Single;
                Console.WriteLine("Weapon has changed to single mode");
            }
            else if (Mode.Automatic.ToString().ToLower().Contains("au") && lastMode.ToLower().Contains("au"))
            {
                ShootMode = Mode.Automatic;
                Console.WriteLine("Weapon has changed to automatic mode");
            }

        }

        public override string ToString()
        {
            return $"Shoot mode - {ShootMode}, magazine capacity - {MagazineCapacity}";
        }
    }
}
