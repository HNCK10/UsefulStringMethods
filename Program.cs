// See https://aka.ms/new-console-template for more information
String fullname = "Lance Hancock";
fullname = fullname.ToUpper(); //So you reassign firstname to a new variable
                               //which is uppercase
Console.WriteLine("My name is "+fullname);
//-------------------------------------------------------------------------
//Now we are going to use ToLower();
fullname = fullname.ToLower();
Console.WriteLine("My name is "+fullname+" and is now lowercase");
//-------------------------------------------------------------------------
//For this next example we will use a phone number
String phoneNumber = "081-213-4792";
//What we are going to do is replace these dashes with another character
//To do this we need to use the replace method
phoneNumber = phoneNumber.Replace("-","/");
Console.WriteLine(phoneNumber);
//To remove the dashes you can just add an empty space to the second parameter
phoneNumber = "081-213-4792";
phoneNumber = phoneNumber.Replace("-","");
Console.WriteLine(phoneNumber);
//Next we have the insert method, we can insert a character or a string
//at a given point in another string, this point is known as an index.
//Lets say for example we want to take our fullname and make it a 
//username by adding an @ sign as the prefix
String userName = fullname.Insert(0,"@");
Console.WriteLine(userName);
//This does not need to be an @ sign and can be something like 'Mr.'
userName = fullname.Insert(0, "Mr.");
Console.WriteLine(userName);
//This next example is not a method but a property, although
//it is stored in the same place as methods for strings
//We are going to be accessing the length property
//Since it is a property you do not add the parenthesis ()
//as you only add those with methods
//If you need the length you can assign it to a variable
Console.WriteLine(fullname.Length);
//An example of a use-case is if someone is creating a username
//and the max length is 12 characters
//-----------------------------------------------------------
//Next method is the substring method
//You can take a section from an original string and create an
//entirely new string, by specifying a position and how many
//characters needed to extract from the given position
//Lets create two new names from the fullname method, first name and last name
String firstName = fullname.Substring(0,5);
Console.WriteLine(firstName);
String lastName = fullname.Substring(6, 7);
Console.WriteLine(lastName);
Console.ReadKey();
