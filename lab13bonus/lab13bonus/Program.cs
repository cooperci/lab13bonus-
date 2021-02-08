using System;

namespace lab13bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] gameCharacters = new GameCharacter[5];

            gameCharacters[0] = new Warrior(" gun", "ciarrawarrior", 10, 10);
            gameCharacters[1] = new Warrior(" gun", "timwarrior", 6, 18);
            gameCharacters[2] = new Wizard(44, 12, "wizkid", 10, 10);
            gameCharacters[3] = new Wizard(28, 44, "wizzy", 4, 7);
            gameCharacters[4] = new Wizard(67, 77, "wizz", 8, 9);
            for (int i = 0; i < gameCharacters.Length; i++)
            {
                if (gameCharacters[i] != null)
                { gameCharacters[i].Play(); }
            }
        }

    }
}
