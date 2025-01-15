Console.OutputEncoding = System.Text.Encoding.Unicode;
int playerHealth = 100;
int playerDamage = 3;
int enemyHealth = 50;
int enemyDamage = 10;

while (playerHealth > 0 && enemyHealth > 0)
{
    playerHealth -= enemyDamage;
    enemyHealth -= playerDamage;
    if (enemyHealth < 0)
    {
        enemyHealth = 0;
    }
    if (playerHealth < 0)
    {
        playerHealth = 0;
    }
    Console.WriteLine(playerHealth + " Гравець");
    Console.WriteLine(enemyHealth + " Ворог");

    if (playerHealth == 0 && enemyHealth == 0)
    {
        Console.WriteLine("Нічия!");
        break;
    }

   else if (enemyHealth == 0)
    {
        Console.WriteLine("Ви виграли!");
    }

    else if(playerHealth == 0)
    {
        Console.WriteLine("Ви програли!");
    }

}
