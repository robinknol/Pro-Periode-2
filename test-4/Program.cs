using System;
using HulpClasses;
using HulpClasses.MeerClasses;

namespace test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();

            // Openbaar, mag ik bij:
            myPlayer.getalA += 1;

            // Beschemt, mag ik hier niet bij:
            // myPlayer.getalB += 1;

            // Openbaar, alleen via blauwdruk (class)
            BaseClass.staticTekst += " Grapje. :B";
            Player.staticTekst += "Nog een grapje";

            // Static kan niet via instantie benaderd worden:
            // myPlayer.staticTekst += " Dit kan niet";

            // Heeft "using HulpClasses;" nodig om te herkennen:
            HulpClassA test = new HulpClassA();
            HulpClassB test2 = new HulpClassB();

            // Heeft "using HulpClasses.MeerClasses" nodig om te herkennen
            HulpClassX nogEen = new HulpClassx();
        }
    }
}
