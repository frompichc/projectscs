using System;
using System.Collections.Generic;

public class cardHolder
{
    string cardNumber;
    int pinNumber;
    string firstName;
    string lastName;
    double balance;
    
    public cardHolder(string cardNumber,
                        int pinNumber,
                        string firstName,
                        string lastName,
                        double balance)
    {
        this.cardNumber = cardNumber;
        this.pinNumber = pinNumber;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    
    public string getCardNumber() {
        return cardNumber;
    }
    
    public int getPinNumber() {
        return pinNumber;
    }
    
    public string getFirstName() {
        return firstName;
    }
    
    public string getLastName() {
        return lastName;
    }
    
    public double getBalance() {
        return balance;
    }
    
    public void setCardNumber(string newCardNumber) {
        cardNumber = newCardNumber;
    }
    
    public void setPinNumber(int newPinNumber) {
        pinNumber = newPinNumber;
    }
    
    public void setFirstName(string newFirstName) {
        firstName = newFirstName;
    }
    
    public void setLastName(string newLastName) {
        lastName = newLastName;
    }
    
    public void setBalance(double newBalance) {
        balance = newBalance;
    }

    public static void Main(string [] args)
    {
        void printOption()
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Exit ATM");
        }

        void deposit(cardHolder currentUser) {
            Console.WriteLine("Please enter the amount to deposit.");
            double deposit = currentUser.getBalance();
            deposit += double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your deposit. Your current balance is" + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("Please enter the amount to withdraw.");
            double deposit = currentUser.getBalance();
            if (deposit > currentUser.getBalance()) {
                Console.WriteLine("Insuficient founds");
            } else {
                deposit -= double.Parse(Console.ReadLine());
                currentUser.setBalance(deposit);
                Console.WriteLine("Thank you for using or services. Your current balance is " + currentUser.getBalance());
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Your current balance is " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4578965412547852",1234, "Fredy", "Rompich", 0.0));

        Console.WriteLine("Welcome to ATM");
        Console.WriteLine("Please insert your card: ");
        string debitCardNumb = Console.ReadLine();
        cardHolder currentUser;
        currentUser = cardHolders.Find(x => x.cardNumber == debitCardNumb);
        if (currentUser == null) {
            Console.WriteLine("Card not recognized, please try again");
        } else {
            Console.WriteLine("Please enter  your PIN Number: ");
            int pinUser = int.Parse(Console.ReadLine());
            if (pinUser != currentUser.getPinNumber()) {
                Console.WriteLine("Wrong PIN");
            } else {
                Console.WriteLine("Welcome " + currentUser.getFirstName() + " "+ currentUser.getLastName());
                int userOption = 0;
                while(userOption != 4) {
                    printOption();
                    userOption = int.Parse(Console.ReadLine());
                    switch (userOption)
                    {
                        case 1:
                            deposit(currentUser);
                            break;
                        case 2:
                            withdraw(currentUser);
                            break;
                        case 3:
                            balance(currentUser);
                            break;
                    }
                }

            }

        }
    }
}
