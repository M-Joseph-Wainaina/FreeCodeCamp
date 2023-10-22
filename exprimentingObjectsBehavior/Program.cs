using models;

//mutables 
Animal Cow = new Animal();
Cow.name = "Gracie";

var OtherCow = Cow;

Cow.name = "NotGracie";

Console.WriteLine(OtherCow.name);

//Immutables
string animal1 = "Gracie";
string animal2 = animal1;
animal1 = "NotGracie";

Console.WriteLine(animal2);

int num1 = 10;
int num2 = num1;
num1 = 20;

Console.WriteLine(num2        );
