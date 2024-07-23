void Main()
{
    // List of insults
    List<string> insults = new List<string>()
    {
        "You look like what morning breath smells like.",
        "If you tried to give me CPR I would probably throw myself back under water",
        "I am not a fan of you",
        "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
        "I'd rather walk than be on the same plane as you",
        "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
        "Do you have to be so...like that?",
    };

    Random rnd = new Random();

    //List to store used insults
    List<int> usedInsults = new List<int>();

    // Loop to print 3 random insults
    while (usedInsults.Count < 3)
    {
        int index = rnd.Next(insults.Count);
        if (!usedInsults.Contains(index))
        {
            usedInsults.Add(index);
            Console.WriteLine(insults[index]);
        }
    }
}

Main();
