//Adição com conversão implicita
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//Concatenação
string firstName = "Bob";
int widgetSold = 7;
Console.WriteLine(firstName + " sold " + widgetSold + " widgets.");
//Bob sold 7 widgets.
Console.WriteLine(firstName + " sold " + widgetSold + 7 + " widgets.");
//Bob sold 77 widgets.

//Adição explicita 
Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets.");
//Bob sold 14 widgets.