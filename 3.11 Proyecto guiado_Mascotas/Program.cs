﻿// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }


    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do

{
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");
    readResult = Console.ReadLine();
    menuSelection = readResult.ToLower();
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            // List all of our current pet information
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount++;

                }
            }
            //control para añadir otra mascota
            if (petCount < maxPets)
            {
                while (anotherPet == "y" && petCount < maxPets)
                {
                    petCount = petCount + 1;
                    //en caso de que se pueda agregar otra mascota porque el máximo de mascotas lo permita
                    if (petCount < maxPets)
                    {
                        Console.WriteLine("Do yout want another pet (y/n)");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                anotherPet = readResult.ToLower();
                            }
                            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                            //nos ayudamos siempre de un bool para salir de los bucles
                            bool validEntry = false;
                            //añadimos si es un perro o gato
                            do
                            {
                                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalSpecies = readResult.ToLower();
                                    if (animalSpecies != "dog" && animalSpecies != "cat")
                                    {
                                        validEntry = false;
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }

                            } while (validEntry == false);
                            //añadimos el id del animal de forma auto
                            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                            //añadimos la edad del animal
                            do
                            {
                                int agePet;
                                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalAge = readResult;
                                    if (animalAge != "?")
                                    {
                                        validEntry = int.TryParse(animalAge, out agePet);
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);
                            //añade descripcion física del animal
                            do
                            {
                                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPhysicalDescription = readResult.ToLower();
                                    if (animalPhysicalDescription == "")
                                    {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }

                            } while (animalPhysicalDescription == "");
                            //añade descripción personal del animal
                            do
                            {
                                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPhysicalDescription = readResult.ToLower();
                                    if (animalPhysicalDescription == "")
                                    {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }

                            } while (animalPhysicalDescription == "");
                            //añade nombre del animal
                            do
                            {
                                Console.WriteLine("Enter nickname for the pet");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalNickname = readResult.ToLower();
                                    if (animalNickname == "")
                                    {
                                        animalNickname = "tbd";
                                    }
                                }
                            } while (animalNickname == "");
                            //agrega los items que hemos generado
                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                            ourAnimals[petCount, 2] = "Age: " + animalAge;
                            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                        } while (anotherPet != "y" && anotherPet != "n");

                    }
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            //readResult = Console.ReadLine();
            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;
        case "3":
            int petAge;
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != null && ourAnimals[i, 0] != "ID #: ")
                {

                    while (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 4] == "Physical description: ")
                    {
                        do
                        {
                            Console.WriteLine("Introduce la edad de la mascota" + ourAnimals[i, 0]);
                            readResult = Console.ReadLine();
                            if (readResult != null && readResult.Trim() != "")
                            {
                                animalAge = readResult;
                            }

                        } while (!int.TryParse(animalAge, out petAge) || string.IsNullOrEmpty(animalAge));
                        do
                        {
                            Console.WriteLine("Introduce una descripción física de la mascota" + ourAnimals[i, 0]);
                            readResult = Console.ReadLine();
                            if (readResult != null && readResult.Trim() != "")
                            {
                                animalPhysicalDescription = readResult;
                            }
                        } while (string.IsNullOrEmpty(animalPhysicalDescription));

                        ourAnimals[i, 2] = "Age: " + animalAge;
                        ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                    }
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            break;
        case "4":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != null && ourAnimals[i, 0] != "ID #: ")
                {
                    while (ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 5] == "Personality: ")
                    {
                        do
                        {
                            Console.WriteLine("Introduce un alias para la mascota " + ourAnimals[i, 0]);
                            readResult = Console.ReadLine();
                            if (readResult != null && readResult.Trim() != "")
                            {
                                animalNickname = readResult;
                            }
                        } while (string.IsNullOrEmpty(animalNickname));
                        do
                        {
                            Console.WriteLine("Introduce la personalidad de la mascota " + ourAnimals[i, 0]);
                            readResult = Console.ReadLine();
                            if (readResult != null && readResult.Trim() != "")
                            {
                                animalPersonalityDescription = readResult;
                            }
                        } while (string.IsNullOrEmpty(animalPersonalityDescription));

                        ourAnimals[i, 3] = "Nickname: " + animalNickname;
                        ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                    }
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            break;
        case "5":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;
        case "6":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;
        case "7":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;
        case "8":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;
        default:
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;

    }

} while (menuSelection != "exit");

