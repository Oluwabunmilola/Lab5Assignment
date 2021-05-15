using System;

namespace Lab5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
         Bank bankA=new BankA();
         Bank bankB=new BankB();
         Bank bankC=new BankC();

         bankA.getBalance();
         bankB.getBalance();
         bankC.getBalance();
        }
    }
}
