//Kent Tupas
//10/18/2022
// github mini challenge 6
//

Console.Clear();
string user;
string input = "yes";
bool num = true;
bool num2;
int vaildnum = 0;


while(input == "yes"){
    Console.WriteLine("Enter whole number");
    user = Console.ReadLine();

    num2 = Int32.TryParse(user, out vaildnum);
    if(num2 == true){
        if(vaildnum % 2 == 0){
            Console.WriteLine($"{vaildnum} It's an even number");
        }else{
            Console.WriteLine(" It's an odd number");
        }
    }else{
        Console.WriteLine("Not a Number, Try Again");
    }
Console.WriteLine("Want to try again");
input = Console.ReadLine();
}