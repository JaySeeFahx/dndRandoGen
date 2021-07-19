using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dndRandoGen
{
    public class Base
    { 
        public List<RandomCharacter> characters { get; set; }
    }
    class SavedCharacters
    {
        private static string jsonLoc = "data\\SavedCharacters.json";
        private static string logLoc = "data\\log.txt";

        public void Display()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = SaveMenu();
            }
        }

        public bool SaveMenu()
        {
            

            Console.WriteLine("From here you can either:");
            Console.WriteLine("1) Save the current character.");
            Console.WriteLine("2) View saved characters.");
            Console.WriteLine("3) Delete saved characters.");
            Console.WriteLine("4) Return to the previous menu.");
            Console.Write("Now, which do you choose... :");

            string input = Console.ReadLine();
            int switchCall = int.Parse(input);

            switch (switchCall)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    Console.Clear();
                    return false;
                default:
                    Console.WriteLine("Please choose carefully! The option you chose isn't valid. Press any key to return to the main menu!\n");
                    Console.ReadKey();
                    return true;

            }
    }
    /*catch (FileNotFoundException ex)    
        {
            Console.WriteLine("FILE NOT FOUND: " + ex);
            File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": FILE NOT FOUND: " + ex);
        }
        catch (JsonException ex)    
        {
            Console.WriteLine("INVALID JSON: " + ex);
            File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID JSON: " + ex);
        }
        catch (Exception ex)    
        {
            Console.WriteLine("ERROR: " + ex);
            File.AppendAllText(logLocation, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": ERROR: " + ex);
        }*/
}
