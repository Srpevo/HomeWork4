using System.Numbers; //for numbering
using Nullable.Collections; //for list and array
using School; //for Student class

Numbering.AddNumberingWithColor(1, ConsoleColor.Green);

NullableList TestList = new(); //you can choose the size but the default is 10


//var Lis = TestList.FillList().GetList(); //call a method from a method /write null to fill with empty space
var Lis = TestList.AutoFill().GetList(); //you can use autofill 
//TestList.PrintList(); //and you can also call the print function from the object

foreach (var l in Lis)
{
    Console.WriteLine(l ?? "Empty!");
}

Numbering.AddNumberingWithColor("2 and 3", ConsoleColor.Green);

NullableArray TestArray = new(); //you can choose the size but the default is 20

var Arr = TestArray.FillArray().GetArray(); //exit for break / you can also write print to print the array
//TestArray.PrintArray(); //and you can also call the print function from the object / null == 0

//foreach (var item in Arr)
//{
//    Console.WriteLine(item ?? 0);
//}

Numbering.AddNumberingWithColor(4, ConsoleColor.Green);

try
{
    SchoolStudents school = new(2); //you can choose the size /all your given tasks are performed by one instance of the class 
    school.AddStudentsData(); //The date of birth must be filled in correctly so that the age matches the date and so that the format is correct /if filled in incorrectly the method throws an exception
    Console.WriteLine("/////////////////////");
    school.ShowAllStudentData();
}
catch(Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}







