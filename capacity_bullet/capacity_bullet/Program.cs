using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace capacity_bullet
{
    using System;

    namespace capacity_bullet
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Gun gun = new Gun(10, 5, false);
                int secim;

                do
                {
                    Console.WriteLine("0 - informasiya almaq ucun ");
                    Console.WriteLine("1 - ates acmaq ucun ");
                    Console.WriteLine("2 - getreaminbullet methodu ucun ");
                    Console.WriteLine("3 - reload methodu ucun ");
                    Console.WriteLine("4 - chagefiremodemethodu ucun ");
                    Console.WriteLine("5 - proqramdan cixmaq ucun ");

                   
                    secim = Convert.ToInt32(Console.ReadLine());

                    switch (secim)
                    {
                        case 0:
                            Console.WriteLine($" {gun.GetRemainBulletCount()}");
                            gun.ChangeFireMode();
                            break;
                        case 1:
                            gun.Shoot();
                            break;
                        case 2:
                            Console.WriteLine($" {gun.GetRemainBulletCount()}");
                            break;
                        case 3:
                            gun.Reload();
                            break;
                        case 4:
                            gun.ChangeFireMode();
                            break;
                        case 5:
                            Console.WriteLine("Programdan cixildi");
                            break;
                        default:
                            Console.WriteLine("Secim yanlisdir");
                            break;
                    }
                } while (secim != 5); 
            }
        }

        public class Gun
        {
            private int capacityBullet;
            private int currentBullet;
            private bool fireMood;

            public Gun(int capacityBullet, int currentBullet, bool fireMood)
            {
                this.capacityBullet = capacityBullet;
                this.currentBullet = currentBullet;
                this.fireMood = fireMood;
            }

            public void Shoot()
            {
                if (currentBullet > 0)
                {
                    if (fireMood)
                    {
                        Console.WriteLine("avto atis 1 gulle atildi ");
                        currentBullet--;
                    }
                    else
                    {
                        Console.WriteLine("Atis rejimi tekli ");
                    }
                }
                else
                {
                    Console.WriteLine("Daraq bosdur.");
                }
            }

            public int GetRemainBulletCount()
            {
                return currentBullet;
            }

            public void Reload()
            {
                currentBullet = capacityBullet;
                Console.WriteLine("Daraq dolduruldu.");
            }

            public void ChangeFireMode()
            {
                fireMood = !fireMood;
                Console.WriteLine(fireMood ? "Atis modu auto" : "Atis modu tekli");
            }
        }
    }

}

