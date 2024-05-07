using System;
namespace NursiwatTumaLB-426;
{
    class Program
    {
        static void Main()
        {

            // Create character using factory
            CharacterFactory factory = new BertolfFactory();
            Character character = factory.CreateCharacter();

            // Attach observer to character
            IObserver observer = new CharacterObserver(character);
            character.Attach(observer);
            
            int Magielevel = 5;
            int Goldmünzen = 35;
            string Waffe = "Zauberstab, Besen";
            int Waffenstärke = 20;
            int Stamina = 100;
            int HP = 100;
            int Rüstung = 20;
            int Reputation = 50;
            int Eingabe = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("                                               ");
                Console.WriteLine("Charakter:" + "Bertolf der Barmharzige");
                Console.WriteLine("Magielevel: " + Magielevel);
                Console.WriteLine("GoldMünzen: " + Goldmünzen);
                Console.WriteLine("Waffe(n): " + Waffe);
                Console.WriteLine("Stamina: " + Stamina);
                Console.WriteLine("HP: " + HP);
                Console.WriteLine("Rüstung: " + Rüstung);
                Console.WriteLine("Reputation: " + Reputation);
                Console.WriteLine("|-------------------------|");
                Console.WriteLine("| Ort: Dorf mit 3 Häusern |");
                Console.WriteLine("|-------------------------|");
                Console.WriteLine("");
                Console.WriteLine("Du bist in einem kleinen Dorf mit nur 3 Häusern. Du siehst, wie ein Dorfbewohner ausgeraubt wurde und wie der Räuber versucht wegzurennen. Was machst du?");
                Console.WriteLine("");
                Console.WriteLine("Optionen: 1: Ignorieren.    2: Dem Dorfbewohner helfen.    3: Dem Dorfbewohner 5 Goldmünzen anbieten.");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                if (Eingabe == 1)
                {
                    Reputation -= 10;
                }
                else if (Eingabe == 2)
                {
                    Magielevel += 10;
                    Reputation += 10;
                }
                else if (Eingabe == 3)
                {
                    Reputation += 10;
                    Goldmünzen += 10;
                }
                else
                {
                    Console.WriteLine("Eingabe ungültig, bitte erneut eingeben.");
                    continue;
                }
                Console.Clear();
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("                                               ");
                Console.WriteLine("Charakter:" + "Bertolf der Barmharzige");
                Console.WriteLine("Magielevel: " + Magielevel);
                Console.WriteLine("GoldMünzen: " + Goldmünzen);
                Console.WriteLine("Waffe(n): " + Waffe);
                Console.WriteLine("Stamina: " + Stamina);
                Console.WriteLine("HP: " + HP);
                Console.WriteLine("Rüstung: " + Rüstung);
                Console.WriteLine("Reputation: " + Reputation);
                Console.WriteLine("|-------------------------|");
                Console.WriteLine("| Ort:  Stadt in der Nähe |");
                Console.WriteLine("|-------------------------|");
                Console.WriteLine("");
                Console.WriteLine("Du beschließt dich in eine Stadt in der Nähe zu gehen. Dort ist ein Schmied, der dir Rüstung geben kann. Er hat eine große Auswahl, aber die Rüstung, die dir am besten gefällt, ist eine Eisenbrustplatte für 15 Goldmünzen.");
                Console.WriteLine("");
                Console.WriteLine("Optionen: 1: Rüstung Kaufen.    2: Keine Rüstung kaufen.    3: Rüstung klauen.");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                if (Eingabe == 1)
                {
                    Goldmünzen -= 15;
                    Rüstung += 20;
                }
                else if (Eingabe == 3)
                {
                    Reputation -= 30;
                    Rüstung += 20;
                }
                Console.Clear();
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("                                               ");
                Console.WriteLine("Charakter:" + "Bertolf der Barmharzige");
                Console.WriteLine("Magielevel: " + Magielevel);
                Console.WriteLine("GoldMünzen: " + Goldmünzen);
                Console.WriteLine("Waffe(n): " + Waffe);
                Console.WriteLine("Stamina: " + Stamina);
                Console.WriteLine("HP: " + HP);
                Console.WriteLine("Rüstung: " + Rüstung);
                Console.WriteLine("Reputation: " + Reputation);
                Console.WriteLine("|-------------------------------|");
                Console.WriteLine("| Ort: Seitengasse in der Stadt |");
                Console.WriteLine("|-------------------------------|");
                Console.WriteLine("");
                Console.WriteLine("Du wurdest auf der Straße von einem Räuber ausgeraubt und merkst, dass dir 5 Goldmünzen fehlen. Du drehst deinen Kopf nach links und rechts, um zu sehen, was los ist. Du siehst ihn noch knapp um die Ecke rennen, was machst du?");
                Console.WriteLine("");
                Console.WriteLine("Optionen: 1: Hinterher rennen.    2: Die Garde Nach Hilfe fragen.    3: Aufgeben.");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                if (Eingabe == 1)
                {
                    Stamina -= 5;
                    Goldmünzen += 10;
                }
                else if (Eingabe == 2)
                {
                    Goldmünzen += 5;
                }
                Console.Clear();
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("                                               ");
                Console.WriteLine("Charakter:" + "Bertolf der Barmharzige");
                Console.WriteLine("Magielevel: " + Magielevel);
                Console.WriteLine("GoldMünzen: " + Goldmünzen);
                Console.WriteLine("Waffe(n): " + Waffe);
                Console.WriteLine("Stamina: " + Stamina);
                Console.WriteLine("HP: " + HP);
                Console.WriteLine("Rüstung: " + Rüstung);
                Console.WriteLine("Reputation: " + Reputation);
                Console.WriteLine("|-------------------------|");
                Console.WriteLine("| Ort: Waldrand Der Stadt |");
                Console.WriteLine("|-------------------------|");
                Console.WriteLine("");
                Console.WriteLine("Du bist nun im Wald in der Nähe der Stadt. Du siehst, wie um dich herum ein dicker Nebel sich bildet. Du siehst eine weiße Gestalt auf einem Pferd auf dich zu kommen. Sie reitet immer schneller auf dich zu, was machst du?");
                Console.WriteLine("");
                Console.WriteLine("Optionen: 1: Kämpfen.    2: Wegrennen.    3: Interaktion mit Gestalt.");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                if (Eingabe == 1)
                {
                    HP -= 10;
                    Rüstung += 20;
                    Magielevel += 5;
                    Waffenstärke += 20;
                }
                else if (Eingabe == 2)
                {
                    Stamina -= 10;
                }
                else if (Eingabe == 3)
                {
                    HP -= 20;
                }
                Console.Clear();
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("                                               ");
                Console.WriteLine("Charakter:" + "Bertolf der Barmharzige");
                Console.WriteLine("Magielevel: " + Magielevel);
                Console.WriteLine("GoldMünzen: " + Goldmünzen);
                Console.WriteLine("Waffe(n): " + Waffe);
                Console.WriteLine("Stamina: " + Stamina);
                Console.WriteLine("HP: " + HP);
                Console.WriteLine("Rüstung: " + Rüstung);
                Console.WriteLine("Reputation: " + Reputation);
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("| Ort: Irgendwo im Wald |");
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("");
                Console.WriteLine("Du hast dich im Wald verlaufen und hast die Hoffnung verloren. Du findest einen Wegweiser, der auf 2 Richtungen zeigt. Westen: Gaga Kingdom, bevor du das Königreich erreichst, musst du durch einen magischen Feuerwald, der von Dämonen besetzt ist. Osten: Jade Kingdom, bevor du das Königreich erreichst, musst du durch einen Sumpf gehen, wo der Schlangenkönig lebt.");
                Console.WriteLine("");
                Console.WriteLine("Optionen: 1: Osten.    2: Westen.    3: Random.");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                if (Eingabe == 1)
                {
                    Stamina -= 10;
                    Console.Clear();
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("                                               ");
                    Console.WriteLine("Charakter:" + "Bertolf der Barmharzige");
                    Console.WriteLine("Magielevel: " + Magielevel);
                    Console.WriteLine("GoldMünzen: " + Goldmünzen);
                    Console.WriteLine("Waffe(n): " + Waffe);
                    Console.WriteLine("Stamina: " + Stamina);
                    Console.WriteLine("HP: " + HP);
                    Console.WriteLine("Rüstung: " + Rüstung);
                    Console.WriteLine("Reputation: " + Reputation);
                    Console.WriteLine("|------------|");
                    Console.WriteLine("| Ort: Sumpf |");
                    Console.WriteLine("|------------|");
                    Console.WriteLine("");
                    Console.WriteLine("Du kommst etwas außer Atem im Sumpf an und dir fällt auf, dass es anstrengender ist zu laufen, weil die Füße immer einsinken (-10 Stamina). Du siehst eine riesige Schlange, die eine Krone trägt. Du weißt, dass wegrennen sehr wahrscheinlich nicht gut für dich enden würde. Deine beste Option ist es gegen ihn zu kämpfen. Wofür entscheidest du dich?");
                    Console.WriteLine("");
                    Console.WriteLine("Optionen: 1: Kämpfen.    2: Wegrennen.    3: Frieden Schließen.");
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    if (Eingabe == 1)
                    {
                        Stamina -= 30;
                        Magielevel += 10;
                        HP -= 20;
                    }
                    else if (Eingabe == 2)
                    {
                        Stamina -= 10;
                    }
                }
                else if (Eingabe == 2)
                {
                    Stamina -= 10;
                    Console.Clear();
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("                                               ");
                    Console.WriteLine("Charakter:" "Bertolf der Barmharzige");
                    Console.WriteLine("Magielevel: " + Magielevel);
                    Console.WriteLine("GoldMünzen: " + Goldmünzen);
                    Console.WriteLine("Waffe(n): " + Waffe);
                    Console.WriteLine("Stamina: " + Stamina);
                    Console.WriteLine("HP: " + HP);
                    Console.WriteLine("Rüstung: " + Rüstung);
                    Console.WriteLine("Reputation: " + Reputation);
                    Console.WriteLine("|----------------|");
                    Console.WriteLine("| Ort: Feuerwald |");
                    Console.WriteLine("|----------------|");
                    Console.WriteLine("");
                    Console.WriteLine("Du hast dich entschieden in den Feuerwald zu gehen. Wie vorhergesehen, erwartet dich mächtige Dämonen. Wegzurennen ist keine gute Option, was machst du?");
                    Console.WriteLine("");
                    Console.WriteLine("Optionen: 1: Bekämpfen.    2: Wegrennen.    3: Frieden Schließen.");
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    if (Eingabe == 1)
                    {
                        Stamina -= 30;
                        Magielevel += 10;
                        HP -= 20;
                    }
                    else if (Eingabe == 2)
                    {
                        Stamina -= 10;
                    }
                }
                else if (Eingabe == 3)
                {
                    Random random = new Random();
                    int ortsauswahl = random.Next(1, 3);
                    if (ortsauswahl == 1)
                    {
                        Stamina -= 10;
                        Console.Clear();
                        Console.WriteLine("|---------------------------------------------|");
                        Console.WriteLine("|                                             |");
                        Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                        Console.WriteLine("|                                             |");
                        Console.WriteLine("|---------------------------------------------|");
                        Console.WriteLine("                                               ");
                        Console.WriteLine("Charakter:" + "Bertolf der Barmharzige");
                        Console.WriteLine("Magielevel: " + Magielevel);
                        Console.WriteLine("GoldMünzen: " + Goldmünzen);
                        Console.WriteLine("Waffe(n): " + Waffe);
                        Console.WriteLine("Stamina: " + Stamina);
                        Console.WriteLine("HP: " + HP);
                        Console.WriteLine("Rüstung: " + Rüstung);
                        Console.WriteLine("Reputation: " + Reputation);
                        Console.WriteLine("|------------|");
                        Console.WriteLine("| Ort: Sumpf |");
                        Console.WriteLine("|------------|");
                        Console.WriteLine("");
                        Console.WriteLine("Du kommst etwas außer Atem im Sumpf an und dir fällt auf, dass es anstrengender ist zu laufen, weil die Füße immer einsinken (-10 Stamina). Du siehst eine riesige Schlange, die eine Krone trägt. Du weißt, dass wegrennen sehr wahrscheinlich nicht gut für dich enden würde. Deine beste Option ist es gegen ihn zu kämpfen. Wofür entscheidest du dich?");
                        Console.WriteLine("");
                        Console.WriteLine("Optionen: 1: Kämpfen.    2: Wegrennen.    3: Frieden Schließen.");
                        Eingabe = Convert.ToInt32(Console.ReadLine());
                        if (Eingabe == 1)
                        {
                            Stamina -= 30;
                            Magielevel += 10;
                            HP -= 20;
                        }
                        else if (Eingabe == 2)
                        {
                            Stamina -= 10;
                        }
                    }
                    else
                    {
                        Stamina -= 10;
                        Console.Clear();
                        Console.WriteLine("|---------------------------------------------|");
                        Console.WriteLine("|                                             |");
                        Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                        Console.WriteLine("|                                             |");
                        Console.WriteLine("|---------------------------------------------|");
                        Console.WriteLine("                                               ");
                        Console.WriteLine("Charakter:" + "Bertolf der Barmharzige");
                        Console.WriteLine("Magielevel: " + Magielevel);
                        Console.WriteLine("GoldMünzen: " + Goldmünzen);
                        Console.WriteLine("Waffe(n): " + Waffe);
                        Console.WriteLine("Stamina: " + Stamina);
                        Console.WriteLine("HP: " + HP);
                        Console.WriteLine("Rüstung: " + Rüstung);
                        Console.WriteLine("Reputation: " + Reputation);
                        Console.WriteLine("|----------------|");
                        Console.WriteLine("| Ort: Feuerwald |");
                        Console.WriteLine("|----------------|");
                        Console.WriteLine("");
                        Console.WriteLine("Du hast dich entschieden in den Feuerwald zu gehen. Wie vorhergesehen, erwartet dich mächtige Dämonen. Wegzurennen ist keine gute Option, was machst du?");
                        Console.WriteLine("");
                        Console.WriteLine("Optionen: 1: Bekämpfen.    2: Wegrennen.    3: Frieden Schließen.");
                        Eingabe = Convert.ToInt32(Console.ReadLine());
                        if (Eingabe == 1)
                        {
                            Stamina -= 30;
                            Magielevel += 10;
                            HP -= 20;
                        }
                        else if (Eingabe == 2)
                        {
                            Stamina -= 10;
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|         Willkommen zu unserem Spiel         |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("                                               ");
                Console.WriteLine("Charakter:" + "Bertolf der Barmharzige");
                Console.WriteLine("Magielevel: " + Magielevel);
                Console.WriteLine("GoldMünzen: " + Goldmünzen);
                Console.WriteLine("Waffe(n): " + Waffe);
                Console.WriteLine("Stamina: " + Stamina);
                Console.WriteLine("HP: " + HP);
                Console.WriteLine("Rüstung: " + Rüstung);
                Console.WriteLine("Reputation: " + Reputation);
                Console.WriteLine("|--------------------------|");
                Console.WriteLine("| Ort: Ende des Abenteuers |");
                Console.WriteLine("|--------------------------|");
                Console.WriteLine("");
                Console.WriteLine("Das Abenteuer ist zu Ende. Möchtest du nochmal spielen?");
                Console.WriteLine("");
                Console.WriteLine("Optionen: 1: Ja.    2: Nein.");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                if (Eingabe == 2)
                    break;
            }
        }
    }
}