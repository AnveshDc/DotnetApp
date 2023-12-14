#region ArrayBasics
//declare an Array
//string[] locations;
//declare and Initialize an Array
//string[] locations=new string[] {"Bangalore","Mysore","Delhi","Mumbai"};
////Individual values
//Console.WriteLine(locations[0]);//Bangalore
////Access all the elements of Array
////for loop
//for(int i = 0; i < locations.Length; i++)
//{

//    Console.WriteLine(locations[i]);
//}
////foreachloop
//Console.WriteLine("Foreachloop");
//foreach(string item in locations)
//{

//    Console.WriteLine(item);
//}
////while loop
//Console.WriteLine("while loop");
//int j=0;
//while (j<locations.Length)
//{
//    Console.WriteLine(locations[j]);
//    j++;
//}
////sorting an Array
//Console.WriteLine("***************Sorting**************");
//Array.Sort(locations);
//foreach(string item in locations)
//{
//    Console.WriteLine(item);
//}
////Search element in an Array
//Console.WriteLine("********************");
//string itemTobeSearched = "Mysore";
//string searchResult=Array.Find(locations,item=>item==itemTobeSearched);
//Console.WriteLine(searchResult);

////two dimensional Array
//string[,] address =
//{
//    {"HAL","Bangalore" },
//    {"Corecard","Bhopal" }
//};
#endregion

DateTime startTime;
DateTime endTime;
TimeSpan totalTime;
int[] numericValues = new int[10000];
//start timer
//startTime = DateTime.Now;
//for (int i = 0; i < numericValues.Length; i++)
//{
//    numericValues[i] = i;
//    Console.WriteLine(numericValues[i]);
//}
//endTime = DateTime.Now;
//totalTime = endTime - startTime;
//Console.WriteLine($"TotalTime Taken::{totalTime.TotalSeconds}");//8.8780583

//foreach loop
startTime = DateTime.Now;
int j=0;
//start timer

foreach(int i in numericValues)
{
    numericValues[j] = j;
    Console.WriteLine(numericValues[j]);
    j++;
    
}
endTime = DateTime.Now;
totalTime = endTime - startTime;
Console.WriteLine($"TotalTime Taken::{totalTime.TotalSeconds}");//8.84