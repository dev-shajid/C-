using System;

namespace Project
{
    class User{
        private string userName;
        private string bankId;
        private int pin;
        private double balance;

        User(string userName, string bankId, int pin, double balance){
            this.userName=userName;
            this.bankId=bankId;
            this.pin=pin;
            this.balance=balance=0;
        }

        public string getUserName(){
            return userName;
        }

        public string getBankId(){
            return bankId;
        }

        public int getPin(){
            return pin;
        }

        public double getBalance(){
            return balance;
        }

        public void setUserName(string userName){
            this.userName=userName;
        }

        public void setBankId(string bankId){
            this.bankId=bankId;
        }

        public void setPin(int pin){
            this.pin=pin;
        }

        public void setBalance(double balance){
            this.balance=balance;
        }


        static void Main(){
            void printOptions(){
                Console.WriteLine("1 - Deposite");
                Console.WriteLine("2 - Withdraw ");
                Console.WriteLine("3 - Show Balance ");
                Console.WriteLine("4 - Exit\n");
                Console.Write("\rEnter your choice:  \t");
            }

            void deposite(User currentUser){
                Console.WriteLine("How much $$ would you like to deposite? ");
                double deposite = Convert.ToDouble(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + deposite);
                Console.WriteLine("Thank you for your $$. Your new Balance is: {0}", currentUser.balance);
            }

            void withdraw(User currentUser){
                Console.WriteLine("How much $$ would you like to withdraw: ");
                double withDrawBalance = Convert.ToDouble(Console.ReadLine());
                if(currentUser.getBalance()<withDrawBalance) Console.WriteLine("Insufficient Balance ");
                else{
                    currentUser.setBalance(currentUser.getBalance()-withDrawBalance);
                    Console.WriteLine("Current Balance is: {0}\nYou're good to go! Thank You", currentUser.getBalance());
                }
            }

            void balance(User currentUser){
                Console.WriteLine($"Your current balance is ${currentUser.getBalance()}");
            }

            Console.Clear();
            List<User> users = new List<User>();
            users.Add(new User("shajid", "2104095", 1234, 150));
            users.Add(new User("zarif", "2104123", 5434, 243));
            users.Add(new User("mahi", "2104122", 4243, 362));
            users.Add(new User("yasir", "2104074", 3241, 233));

            Console.WriteLine("Welcome to Simple ATM");
            User user;
            Console.WriteLine("Please insert your debit card:");
            String debitCardNum=null;
            do
            {
                debitCardNum = Console.ReadLine().Trim();
                user = users.FirstOrDefault(a=>a.bankId==debitCardNum);
                if(user==null) Console.WriteLine("Card not recognized. Please try again!");
            } while (user == null);
            
            Console.WriteLine("Please insert your PIN:");
            int userPin=0;
            do
            {
                userPin = Convert.ToInt32(Console.ReadLine().Trim());
                if(user.getPin()==userPin) break;
                else{
                    Console.WriteLine("Wrong PIN. Please try again!");
                    userPin=0;
                }
            } while (userPin == 0);

            
            Console.WriteLine("\nWelcome {0}\n", user.getUserName());

            int option=0;
            while(true){
                printOptions();
                option=Convert.ToInt32(Console.ReadLine());

                if(option==1) deposite(user);
                else if(option==2) withdraw(user);
                else if(option==3) balance(user);
                else if(option==4) break;
                else{
                    option=0;
                    Console.WriteLine("Invalid key");
                }
            }
            Console.WriteLine("Thank You! Have a nice day");
        }
    }
}