// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var count = NumberOfBlows("2113");
Console.WriteLine(count);
Console.ReadLine();

static int NumberOfBlows(string str) 
{
    var strengthList = new List<int>();
	for (int i = 0; i < str.Length; i++)
	{
		strengthList.Add(int.Parse(str[i].ToString()));
	}

	int blowCounter = 0;
	while (strengthList.Any(x => x != 0))
	{
        int miniCounter = 0;
        for (int i = 0; i < strengthList.Count; i++)
        {
			if (strengthList[i] != 0 || miniCounter > 0)
			{
				strengthList[i] = strengthList[i] == 0 ? 0 : strengthList[i] - 1;
				miniCounter++;
            }
			if (miniCounter == 3)
			{
				break;
			}
			if (strengthList.All(x => x == 0))
			{
				break;
			}
        }
		blowCounter++;
    }
	return blowCounter;
}
