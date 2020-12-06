using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Done By: Elliot Brown-Ford
namespace BankAccount

{
   
    public partial class FrmTestAccounts : Form
    {
       

        public FrmTestAccounts()
        {
            InitializeComponent();
        }


        private void btnTest_Click(object sender, EventArgs e)
        {
            // create a display string variable and initialize to an empty string
            string emptyString = "";
            // create two bank account objects using both constructors - with valid data
            BankAccount noName = new BankAccount(123, 100);
            BankAccount withAName = new BankAccount(234, 200, "J Doe");
            // test one of the objects - get accessors --> add output to display string
            string bank = noName.Balance;
            emptyString += "The Bank Balance of This Account: " + bank + "\n\n";

            string account = noName.AccountNumber.ToString();
            emptyString += "The Account Number of this account: " + account + "\n\n";

            string theDate = noName.DateOpen;
            emptyString += "The Day of Opened Account: " + theDate + "\n\n";

            // test one of the objects - set accessors  --> add output to display string
            string myName = "Elliot Brown-Ford";
             string showMyName = noName.ClientName = myName;
            emptyString =  emptyString + "Name of the Client: " + showMyName + "\n\n";





            // test one of the objects - methods  --> add output to display string

            decimal amount = 234;
            noName.Deposit(amount);

            emptyString += "The Amount of the Deposit: " + amount + "\n" +"The Balance After the Deposit of this Account: " 
                + noName.Balance + "\n\n";

            decimal amounts = 200;
            noName.Withdraw(amounts);

            emptyString += "The Amount of the Withdrawn: " + amounts +"\n" + " The Balance After the Withdrawn of this Account: " + noName.Balance + "\n\n";

            // show display string to user - use bank name in caption of message box
            MessageBox.Show(emptyString, BankAccount.BankName);


            /*****************************Next Test*********************************/
            // reset display string to empty string
            string emptierString = "";

            // create one account using the 3 parameter constructor - invalid name

            BankAccount invalidAccount = new BankAccount(345, 300, "");

            // use get accessor to check name  --> add output to display string
            string wrongName = invalidAccount.ClientName;
            emptierString += wrongName + "\n\n ";

            // use set accessor to set invalid name  --> add output to display string
            string showWrongName = invalidAccount.ClientName = "";
            emptierString += invalidAccount + "\n\n";
            // use set accessor to set valid name  --> add output to display string
            string showWrongsName = invalidAccount.ClientName = "J Doe";
            emptierString += "Name of the Client: " + showWrongsName + "\n\n";

            string accBanks = invalidAccount.Balance;
            emptierString += "The Bank Balance of This Account: " + accBanks + "\n\n";

            string accAccounts = invalidAccount.AccountNumber.ToString();
            emptierString += "The Account Number of this account: " + accAccounts + "\n\n";

            string accDates = invalidAccount.DateOpen;
            emptierString += "The Date for today is: " + accDates + "\n\n";

            // show display sgtring to user - use bank name in caption of message box
            MessageBox.Show(emptierString, BankAccount.BankName);
        }
    }
    public class BankAccount
    {
        private string name;
        protected decimal balance;
        private int accNumber;
        private DateTime open;
        public const string BankName = "The Brown-Ford Bank";

        public string ClientName
        {
            get
            {
                return this.name;
            }
            set { this.name = "Unknown"; }
        }
        public  string Balance
        {
            get
            {
                return balance.ToString("C2");
            }
        }
        public int AccountNumber
        {
            get
            {
                return accNumber;
            }
        }
        public  string DateOpen
        {
            get
            {
                return this.open.ToLongDateString();
            }

        }
        public BankAccount(int accountNumber, decimal startBalance)
        {
                this.accNumber = accountNumber;
                this.open = DateTime.Now;
                this.balance = startBalance;
                this.name = "Unknown";
        }

        public BankAccount(int accountNumber, decimal startBalance, string nameOfClient)
        {

            if (nameOfClient != null)
            {
                this.name = nameOfClient;
                this.open = DateTime.Now;
                this.accNumber = accountNumber;
                this.balance = startBalance;
            }
            else
            {
                this.open = DateTime.Now;
                this.accNumber = 0;
                this.name = "Invaild Name";
                this.balance = 0;
            }

        }

        public void Deposit(decimal amount)
        {

            if (amount <= 0)
            {
                MessageBox.Show("Please use a value higher than the value 0.");
            }
            else
            {
                balance += amount;
                 
            }
           
        }

        public void Withdraw(decimal amount)
        {

            if (amount <= 0)
            {
                MessageBox.Show("Please use a value higher than the value 0.");
            }
            
            
                balance -= amount;
            

        }
    }
}


















