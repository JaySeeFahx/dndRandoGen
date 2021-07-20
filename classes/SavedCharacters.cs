using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace dndRandoGen
{
    public class Base
    {
        public List<RandomCharacter> characters { get; set; }
    }
    class SavedCharacters
    {
        private static string jsonLoc = "..\\..\\..\\data\\SavedCharacters.json";
        private static string logLoc = "..\\..\\..\\data\\log.txt";

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
            Console.WriteLine("\nFrom here you can either:");
            Console.WriteLine("1) Save current character.");
            Console.WriteLine("2) View saved characters.");
            Console.WriteLine("3) Delete saved characters.");
            Console.WriteLine("4) Return to main menu.");
            Console.Write("Now, which do you choose... :");

            string input = Console.ReadLine();
            int switchCall = int.Parse(input);

            switch (switchCall)
            {
                case 1:
                    Save();
                    Display();
                    return true;
                case 2:
                    SeeList();
                    Display();
                    return true;
                case 3:
                    Display();
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

        public void Save()
        {

            Console.WriteLine("What is the name of your character?");
            string name = Console.ReadLine();
            
        }

        //updates json file

        public static void SeeList()
        {
            var json = JsonConvert.DeserializeObject<Base>(File.ReadAllText(jsonLoc));
            try
            {
                if (json != null)
                {
                    if (json.characters != null && json.characters.Count > 0)
                    {
                        foreach (var c in json.characters)
                        {
                            foreach (var prop in c.GetType().GetProperties())
                            {
                                Console.WriteLine("{0} -> {1}", prop.Name, prop.GetValue(c, null));
                            }
                        }
                    }
                    else 
                    {
                        Console.WriteLine("There are currently no characters in the save file.");
                    }
                }
                else
                {
                    Console.WriteLine("There are currently no files for a saved character.");
                }
            }
            catch (FileNotFoundException ex)    
            {
                Console.WriteLine("FILE NOT FOUND: " + ex);
                File.AppendAllText(logLoc, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": FILE NOT FOUND: " + ex);
            }
            catch (JsonException ex)    
            {
                Console.WriteLine("INVALID JSON: " + ex);
                File.AppendAllText(logLoc, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID JSON: " + ex);
            }
            catch (Exception ex)    
            {
                Console.WriteLine("ERROR: " + ex);
                File.AppendAllText(logLoc, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": ERROR: " + ex);
            }
        }
        public static void AddToJson()
        { 
        
        }

        public static void RemoveFromJson()
        {

        }
    }
}

/*catch (FileNotFoundException ex)
    {
        Console.WriteLine("FILE NOT FOUND: " + ex);
        File.AppendAllText(logLoc, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": FILE NOT FOUND: " + ex);
    }
    catch (JsonException ex)
    {
        Console.WriteLine("INVALID JSON: " + ex);
        File.AppendAllText(logLoc, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": INVALID JSON: " + ex);
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR: " + ex);
        File.AppendAllText(logLoc, Environment.NewLine + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": ERROR: " + ex);
    }
*/

