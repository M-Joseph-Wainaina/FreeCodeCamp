using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

RandomizeAnimals();

void RandomizeAnimals()
{
    Random random = new Random();

    int a, b;
    string temp;

    for(int i = 0; i < pettingZoo.Length; i++)
    {
        a = random.Next(pettingZoo.Length);
        b = random.Next(pettingZoo.Length);

        temp = pettingZoo[a];
        pettingZoo[a] = pettingZoo[b];
        pettingZoo[b] = temp;
    }
    
}

var animalGroups = AssignGroup();

string[,] AssignGroup(int group = 6)
{
    string[,] groups = new string[group, pettingZoo.Length/group];

    int count = 0;
    for(int i = 0; i < group; i++)
    {
        for(int j = 0; j < pettingZoo.Length/group; j++)
        {
            groups[i, j] = pettingZoo[count];
            count++;
        }
    }

    return groups;
}

printGroup(animalGroups);

void printGroup(string[,] animalGroups)
{
    for(int i = 0; i < animalGroups.GetLength(0); i++)
    {
        for(int j = 0; j < animalGroups.GetLength(1); j++)
        {
            Console.Write(animalGroups[i, j] + " ,");
        }
        Console.WriteLine();
    }
}

