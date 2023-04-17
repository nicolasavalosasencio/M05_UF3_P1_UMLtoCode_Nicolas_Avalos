using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalStore
{
    public abstract class Person
    { 
        public int Id;
        public string Name;
        public string Phone;
        public string Email;
        
    }  

    public abstract class Customer:Person
    {
        public DateTime Registration;
        private int CreditScore;
    }
    public abstract class Employee:Person
    {
        public enum Type {Finanzas, Contabilidad, Marketing, Other }
        public Type Departament;
        private float Salary;
    }
    public abstract class Account:Customer
    {
        public string IBAN;
        internal float Amount;
        public abstract bool Upload(string path) Transaction;
       
    }
    public abstract class Incesting:Account
    {
        public float Interest;
        // public **** ApplyInterest;
    }
    public abstract class Savings:Account
    {
        private float ProtectedAmount;
        // public *** LiberateSavings
    }
}

