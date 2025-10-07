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

string originalStory = "One (adjective) evening, Marty McFly was (verb ending in -ing) in his (adjective) garage when Doc Brown burst in, (verb ending in -ing) a (adjective) (noun). He told Marty they had to (verb) to the year (number) to stop a (adjective) disaster from (verb ending in -ing) the future. Marty quickly jumped into the (adjective) DeLorean, (verb ending in -ing) the (adjective) accelerator as the machine started (verb ending in -ing). When they arrived, Marty realized he had to avoid the (adjective) (plural noun) who were (verb ending in -ing) him all over town. Meanwhile, Doc Brown was (verb ending in -ing) the (adjective) circuits to fix the time machine before it stopped (verb ending in -ing). Marty had to (verb) his parents to (verb) so his own existence wouldn’t disappear. In the thrilling finale, Marty was (verb ending in -ing) the (adjective) lightning strike to power the DeLorean and (verb) back to his own time, feeling (emotion) and ready for his next (adjective) adventure.";
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

