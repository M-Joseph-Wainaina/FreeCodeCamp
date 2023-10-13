var pairOne = new List<int>()  {5, 6};
var pairTwo = new List<int>()  {1, 3};
var pairThree = new List<int>()  {2, 3};
var pairFour = new List<int>()  {3, 6};
var pairFive = new List<int>()  {15, 12};
var pairSix = new List<int>() {5, 7};

var parentChildPairs = new List<List<int>>() {
   pairOne,
   pairTwo,
   pairThree,
   pairFour,
   pairFive,
   pairSix
};
var childrensParents = new List<List<int>>();
var item = new List<int>();

foreach(var pairs in parentChildPairs)
{
  
    

    int key = pairs[1];
    //Console.WriteLine(key);
    // for(int j = 1; j < 6; j++)
    // {
    //     int item = parentChildPairs[j][1];
    //     item == key;
    //     Console.WriteLine(item);
    // }
    item.Add(key);
    foreach( var pair in parentChildPairs)
    {
        if (pair[0] == key) item.Add(item[0]);

    }
    childrensParents.Add(item); 

}

for(int i = 0; i < childrensParents.Count; i++)
{
    for(int j = 0; j < childrensParents[i].Count; j++)
    {
        Console.Write(childrensParents[i][j] + " ");
    }
    Console.WriteLine();
}



 
