using System;

public class Player : BaseClass
{
    public Player()
    {
        // Beschermt, mag ik bij:
        getalB += 1;

        // Openbaar. mag ik bij:
        getalA += 1;

        // Prive mag ik NIET bij:
        // getalC += 1;

    }

    public void TestFunctie()
    {
        string stukjeTekst = "Hallo";

        if (stukjeTekst == "Hallo")
        {
            stukjeTekst += " Iets erbij";

            int tijdelijkGetel = 0;
            tijdelijkGetel += 1;

            {
             int genestTijdelijkGetal = 200;
             genestTijdelijkGetal += 1;

             tijdelijkGetel += 1;
            }

            // genestTijdelijkGetal bestaat hier niet meer:
            // genestTijdelijkGetal += 1;
        }

        // Bestaat hier niet meer :
        // tijdelijkGetel += 1;

        
    }
}