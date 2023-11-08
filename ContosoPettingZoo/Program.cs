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
    foreach(var animal in pettingZoo)
    {
        Console.Write(animal + " ,");
    }
}

// AssignGroup();