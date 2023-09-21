/* The hero and the monster will start with 10 health points.
 * All attacks will be a value between 1 and 10.
 * The hero will attack first.
 * Print the amount of health the monster lost and their remaining health.
 * If the monster's health is greater than 0, it can attack the hero.
 * Print the amount of health the hero lost and their remaining health.
 * Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
 * Print the winner.
 */

Random generator = new Random();

int attacks = 0;
int hero = 10;
int monster = 10;

do {

    attacks = generator.Next(1, 11);
    monster -= attacks;
    Console.WriteLine($"Monster was damaged and lost {attacks} health and now has {monster} health.");
    
    if (monster <= 0) break;
    attacks = generator.Next(1, 11);
    hero -= attacks;
    Console.WriteLine($"Hero was damaged and lost {attacks} health and now has {hero} health.");

} while(hero > 0);

string winner = monster > 0 ? "Monster" : "Hero";
Console.WriteLine($"{winner} wins");