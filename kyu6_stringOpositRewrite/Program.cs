// Stop gninnipS My sdroW!

// Write a function that takes in a string of one or more words, 
// and returns the same string, but with all five or more letter 
// words reversed (Just like the name of this Kata). 
// Strings passed in will consist of only letters and spaces. 
// Spaces will be included only when more than one word is present.

// Examples:

// spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
// spinWords( "This is a test") => returns "This is a test" 
// spinWords( "This is another test" )=> returns "This is rehtona test"

//принимаем строку
//делаем массив строк
//проверяем, какой элемент массива содержит больше 5 символов
//если объект содержит больше 5 символов, делаем из него стрингбилдер
//переворачиваем стрингбилдер
//записываем стрингбилдер в элемент массива строк (если его можно так сделать)
//сворачиваем массив обратно в строку


using System.Globalization;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Text;

Console.Clear();

string finLine = "это финальная проверка как работает переворот строк здесь и тут";
Console.WriteLine(finLine);
string[] finLineMass = stringToWordMass(finLine);
for(int i=0; i<finLineMass.Length; i++)
{
   if (finLineMass[i].Length >=5)
   {
      finLineMass[i] = reLineString(finLineMass[i]);
   }
   else
   {
      finLineMass[i] = finLineMass[i];
   }

}
finLine = massStringToString(finLineMass);
Console.WriteLine(finLine);



string reLineString(string line)    //готовый метод переворота строки
{
   StringBuilder sbLine = new StringBuilder();
   for (int i=line.Length-1; i>=0; i--)
   {
      sbLine.Append(line[i]);
   }
   line = sbLine.ToString();
   return line;
}


string[] stringToWordMass(string inString)      //готовый метод преобразования строки в массив строк
{
   string[] stringMass = inString.Split(new char[]{' '});
   return stringMass;
}

string massStringToString(string[] inStringMass)      //готовый метод склеивания строки из массива строк
{
   string line = string.Join(' ', inStringMass);
   return line;
}
