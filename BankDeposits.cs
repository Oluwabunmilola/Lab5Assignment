using System;

namespace Lab5Assignment
{
public abstract class Bank
{
public abstract void getBalance();
}
public class BankA : Bank
{
public override void getBalance()
{
 Console.WriteLine("Your deposit is 100$");
}      
}
public class BankB : Bank
{
public override void getBalance()
{
 Console.WriteLine("Your deposit is 150$");
}
}
public class BankC : Bank
{
public override void getBalance()
{
 Console.WriteLine("Your deposit is 200$");
}    
}
}



    