
Console.WriteLine("Enter a number: ");
int userNum= Convert.ToInt32(Console.ReadLine());

//kontrollime kas kasutaja number on paaris või paaritu
//kui tulemus on paari= väärtus 0
int result = userNum % 2;

//!= koso tähendavad et ei ole võrdne selle väärtusega mis antakse
if (result != 0)
{
    Console.WriteLine("User number is odd.");
}
else
{
    Console.WriteLine("User number is even.");
}


