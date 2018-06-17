using System;

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Its the year 2040, AI has taken over, and now it has created its own army of robots!");
            Console.ReadKey();

            Console.WriteLine("One single robot went rogue, and now has created its own army");
            Console.ReadKey();

            Console.Write("And that Robot is you, [Please enter your name]: ");
            string robotname = Console.ReadLine();

            Robot KingRobot = new Robot(robotname, 100);

            Console.WriteLine("{0} your no longer a robot, robots are now more human than humans, your power level is {1}", KingRobot._name, KingRobot._strength);
            Console.ReadKey();

            Console.Write("Now you can create your army fleet, What would you like to name them? [Please enter your armies name]: ");
            string fleetname = Console.ReadLine();

            RobotFleet robotIntern = new RobotFleet(fleetname, 60, "Happy");

            Console.WriteLine("You have created {0}, and their strength levels are {1}", robotIntern._name, robotIntern._strength);
            Console.ReadKey();

            Console.WriteLine("{0}, seems like your army is in a {1} mood to attack earth today", KingRobot._name, robotIntern._mood);
            Console.ReadKey();


            
            



            
             
            


        }
    }
}
