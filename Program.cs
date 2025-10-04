/*
Name: Kate
Date: 
Lab: Lab 6 Mad Libs
*/

Console.Clear();
Console.WriteLine("This is Mad Libs. When you are dong providing the requested words\nI will build them into a funny story for you.\nEnter the requested word types as they appear.");
Console.WriteLine("Press any key to begin");
Console.ReadKey(true);

string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";
string[] storyWords = originalStory.Split(' ');

string newStory = "";

string wordPrompt = "";
bool multiWordsPrompt = false; //assumes prompt words are single first, if true then there are multiple words

foreach (string word in storyWords)
{
    if (word.StartsWith("(")) //Find start of prompt words
    {
        wordPrompt = word;
        multiWordsPrompt = true;

        if (word.EndsWith(")")) //single word for prompt
        {
            string wordType = wordPrompt.Trim('(', ')');
            Console.Write($"Please give me a {wordType}: ");
            string userWord = Console.ReadLine().ToLower();
            newStory += userWord + " ";
            multiWordsPrompt = false;
        }

    }
    else if (multiWordsPrompt) //multi words prompt
    {
        wordPrompt += " " + word;

        if (word.EndsWith(")"))
        {
            string wordType = wordPrompt.Trim('(', ')');
            Console.Write($"Please give me a {wordType}: ");
            string userWord = Console.ReadLine().ToLower();
            newStory += userWord + " ";
            multiWordsPrompt = false;
        }
    }

    else //other words
    {
        newStory += word + " ";
    }
    }
    Console.WriteLine(newStory);
