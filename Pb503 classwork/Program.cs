namespace Pb503_classwork
{
    internal class Program
    {
        //console.clear
        static void Main(string[] args)
        {
            Weapon weapon1 = new Weapon()
            {                
                ShootMode = Mode.Single,               
                MagazineCapacity = 30,
                CurrentBullet = 30,
            };

            if (weapon1.ShootMode == Mode.Single)
            {
                weapon1.MagazineCapacity = 7;
                weapon1.CurrentBullet = 7;
            }
            if (weapon1.ShootMode == Mode.Burst)
            {
                weapon1.MagazineCapacity = 18;
                weapon1.CurrentBullet = 18;
            }
            if (weapon1.ShootMode == Mode.Single)
            {
                weapon1.MagazineCapacity = 7;
                weapon1.CurrentBullet = 7;
            }


            Weapon weapon2 = new Weapon()
            {
                ShootMode = Mode.Burst,
                MagazineCapacity = 21,
                CurrentBullet = 21,
            };

            Weapon weapon3 = new Weapon()
            {
                ShootMode = Mode.Automatic,
                MagazineCapacity = 30,
                CurrentBullet = 30,
            };

            //Console.WriteLine($"weapon1: {weapon1.ToString()}");
            //weapon1.Shoot();
            //weapon1.Shoot();

            //Console.Write("darağın tam dolması üçün lazım olan güllə sayı: ");
            //Console.WriteLine(weapon1.GetRemainBulletCount());

            //Console.Write("Current magazine bullet after reload: ");
            //Console.WriteLine(weapon1.Reload());

            //Console.WriteLine();
            //weapon1.ChangeFireMode("bur");

            //weapon1.Shoot();

            //Console.Write("darağın tam dolması üçün lazım olan güllə sayı: ");
            //Console.WriteLine(weapon1.GetRemainBulletCount());
            //Console.Write("Current magazine bullet after reload: ");
            //Console.WriteLine(weapon1.Reload());
            //Console.WriteLine(weapon1.ToString());
            //weapon2.Shoot();
            //weapon3.Fire();


          

            

            int menuNumber;

            do
            {
                menuNumber = Convert.ToInt32(Console.ReadLine());
                switch (menuNumber)
                {
                    case 0:
                        Console.WriteLine("Get information");

                        Console.WriteLine($"weapon1: {weapon1.ToString()}");
                        Console.WriteLine($"weapon1: {weapon2.ToString()}");
                        Console.WriteLine($"weapon1: {weapon3.ToString()}");
                        break;
                    case 1:
                        if (weapon1)
                        Console.WriteLine("Method Shoot");
                        weapon1.Shoot();
                        break;
                }

            } while (menuNumber != 6);



        }
    }
}
