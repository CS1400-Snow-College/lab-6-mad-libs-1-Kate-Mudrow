/*
Name: Kate
Date: 
Lab: Lab 6 Mad Libs
*/

Console.Clear();
Console.WriteLine("This is Mad Libs. When you are done providing the requested words\nI will build them into a funny story for you.\nEnter the requested word types as they appear.");
Console.WriteLine("Press any key to begin");
Console.ReadKey(true);
Console.Clear();

string originalStory = "Last weekend, my friends and I went camping at (place). The drive started out fine, but our GPS led us down a (adjective) dirt road. After getting stuck in the mud, we spent (number) hours trying to push the car out, all while laughing like (plural noun). We even got an audience of (adjective) squirrels! When we finally made it to camp, we realized we forgot the (noun). So, we decided to (verb) with a (animal) and use it as a shelter. The (adjective) rainstorm didn’t help, and we ended up soaked. At least we roasted some (food item) over the campfire… until someone’s (noun) caught on fire. By the end, we were (emotion) , but it was definitely an unforgettable trip!";
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

        if (word.EndsWith(")"))//single word for prompt
        {
            string wordType = wordPrompt.Trim('(', ')', '.');
            if ("aeiou".Contains(char.ToLower(wordType[0]))) //word type starts with vowel
            {
                Console.Write($"Please give me an {wordType}: ");
                string userWord = Console.ReadLine().ToUpper();
                newStory += userWord + " ";
                multiWordsPrompt = false;
            }
            else
            {
                Console.Write($"Please give me a {wordType}: ");
                string userWord = Console.ReadLine().ToUpper();
                newStory += userWord + " ";
                multiWordsPrompt = false;
            }
        }
        else if (word.EndsWith(").")) //punctuation
        {
            string wordType = wordPrompt.Trim('(', ')', '.');
            if ("aeiou".Contains(char.ToLower(wordType[0]))) //word type starts with vowel
            {
                Console.Write($"Please give me an {wordType}: ");
                string userWord = Console.ReadLine().ToUpper();
                newStory += userWord + ". ";
                multiWordsPrompt = false;
            }
            else
            {
                Console.Write($"Please give me a {wordType}: ");
                string userWord = Console.ReadLine().ToUpper();
                newStory += userWord + ". ";
                multiWordsPrompt = false;
            }
        }

    }
    else if (multiWordsPrompt) //multi words prompt
    {
        wordPrompt += " " + word;
        if (word.EndsWith(")"))
        {
            string wordType = wordPrompt.Trim('(', ')', '.');
           if ("aeiou".Contains(char.ToLower(wordPrompt[0]))) //word type starts with vowel
            {
                Console.Write($"Please give me an {wordType}: ");
                string userWord = Console.ReadLine().ToUpper();
                newStory += userWord + " ";
                multiWordsPrompt = false;
            }
            else
            {
                Console.Write($"Please give me a {wordType}: ");
                string userWord = Console.ReadLine().ToUpper();
                newStory += userWord + " ";
                multiWordsPrompt = false;
            }
        }
        else if (word.EndsWith(").")) //punctuation
        {
            string wordType = wordPrompt.Trim('(', ')', '.');
         if ("aeiou".Contains(char.ToLower(wordPrompt[0]))) //word type starts with vowel
            {
                Console.Write($"Please give me an {wordType}: ");
                string userWord = Console.ReadLine().ToUpper();
                newStory += userWord + ". ";
                multiWordsPrompt = false;
            }
            else
            {
                Console.Write($"Please give me a {wordType}: ");
                string userWord = Console.ReadLine().ToUpper();
                newStory += userWord + ". ";
                multiWordsPrompt = false;
            }
        }
    }
    else
    {
        newStory += word + " ";
    }
}
Console.WriteLine("Here is the new story:");
Console.Write(newStory);

