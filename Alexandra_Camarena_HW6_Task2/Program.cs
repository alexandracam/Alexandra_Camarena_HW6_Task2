// Alexandra Camarena
// MIS 3013 THW 6 Task 2

Console.WriteLine("Please input a sentence: ");
string str = Console.ReadLine();
str = str.ToLower();

int nVowels = 0;
int nConsonants = 0;

for (int i = 0; i < str.Length; i++)
{ 
    char ch = str[i];
    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
    {
        nVowels++;
    }
    else if (ch >= 'a' && ch <= 'z')
    { 
        nConsonants++;
    }
}

string m = string.Format($"There were {nVowels} vowels in the sentence.");
Console.WriteLine(m);

m = string.Format($"There were {nConsonants} consonants in the sentence.");
Console.WriteLine(m);