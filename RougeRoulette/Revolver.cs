using System;

namespace Rouge_Roulette
{
    class Revolver
    {
        public bool[] chambers;
        public Random random;

        public Revolver()
        {
            chambers = new bool[6]; // 6 chambers in the revolver
            random = new Random();
            Reload(); // Place a bullet in one of the chambers randomly
        }

        public void Reload()
        {
            // Reset all chambers to empty
            for (int i = 0; i < chambers.Length; i++)
            {
                chambers[i] = false;
            }

            // Randomly place the bullet in one of the chambers
            int bulletChamber = random.Next(6);
            chambers[bulletChamber] = true;
        }

        public bool Shoot(int playerHealth)
        {
            // Randomly select a chamber
            int selectedChamber = random.Next(6);

            // Check if the selected chamber contains the bullet
            if (chambers[selectedChamber])
            {
                // Player gets shot
                playerHealth -= 30; // Decrement player's health
                return true;
            }
            else
            {
                return false; // Player survives
            }
        }
    }
}
