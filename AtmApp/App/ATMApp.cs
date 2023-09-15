using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtmApp.Domain.Component;
using AtmApp.Domain.Enums;
using AtmApp.Domain.Interfaces;
using AtmApp.UI;

namespace AtmApp.App
{
    public class ATMApp : IUserLogin, IUserPerform, ITransaction
    {
        private List<UserAccount> userAccountList;
        private UserAccount? currentAccount;
        private List<Transaction> listOfTransaction;
        private const long minBalance = 50000;
        private readonly AppScreen screen;
        public ATMApp()
        {
            screen = new AppScreen();
        }

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>()
            {
                new UserAccount{Id = 1, UserFullName = "Fish Can Swim", UserId = 77882664, UserBalance = 0},
                new UserAccount{Id = 2, UserFullName = "Pig Can Fly", UserId = 22244288, UserBalance = 0},
                new UserAccount{Id = 3, UserFullName = "Bao Bao", UserId = 8889993366, UserBalance = 0}
            };
            listOfTransaction = new List<Transaction>();
        }
        public void Run()
        {
            CheckLogIn();
            ProcessMenuChoose();
        }
        public void CheckLogIn()
        {
            bool isValidLogin = false;
            while(isValidLogin == false) {
                UserAccount userInput = AppScreen.UserLoginForm();
                foreach(UserAccount account in userAccountList){
                    currentAccount = account;
                    if(userInput.UserId.Equals(currentAccount.UserId)){
                        currentAccount.TotalLogin++;
                        if(currentAccount.TotalLogin > userAccountList.Count){
                            Environment.Exit(0);
                        } else {
                            currentAccount.TotalLogin = 0;
                            isValidLogin = true;
                            break;
                        }
                    }    
                }
            }
        }
        public void ProcessMenuLogin()
        {
            AppScreen.ScreenLogin();
            switch(Validator.Convert<int>("choose")){
                case (int)LoginMenu.Login:
                    Run();
                break;
                case (int)LoginMenu.Exit:
                    Utility.PrintMessage("\nThank You & See You Again");
                break;
                default: break;
            }
        }
        private void ProcessMenuChoose()
        {
            AppScreen.ScreenAppMenu(currentAccount);
            switch(Validator.Convert<int>("choose"))
            {
                case (int)AppMenu.CheckBalance:
                    CheckBalance();
                    ProcessMenuChoose();
                break;
                case (int)AppMenu.HandleDeposite:
                    HandleDeposite();
                    ProcessMenuChoose();
                break;
                case (int)AppMenu.HandleWithdraw:
                    HandleWithdraw();
                    ProcessMenuChoose();
                break;
                case (int)AppMenu.Transfer:
                    var transMoney = screen.TransferForm();
                    ProcessTransfer(transMoney);
                    ProcessMenuChoose();
                break;
                case (int)AppMenu.BackToScreen:
                    Utility.PrintMessage("\nThank you for using our service\n");
                    ProcessMenuLogin();
                break;
                default: break;
            }
        }

        public void CheckBalance()
        {
            if(currentAccount.UserBalance <= 0)
            {
                Utility.PrintMessage($"\nYour Account has: {currentAccount.UserBalance} VND");
                Utility.PrintMessage("\nPlease Deposit");
                ProcessMenuChoose();
            }else {
                Utility.PrintMessage($"\nYour Account has: {currentAccount.UserBalance} VND\n");
            }
        }

        public void HandleDeposite()
        {
            var transaction_amt = Validator.Convert<long>("amount");
            while(transaction_amt <= 0)
            {
                Console.Write("Re-");
                transaction_amt = Validator.Convert<long>("amount");
            }
            InsertTransaction(currentAccount.Id,TransactionType.Deposit,transaction_amt);
            currentAccount.UserBalance += transaction_amt;
            Utility.PrintMessage($"\nYour Account has: {currentAccount.UserBalance} VND\n");
        }

        public void HandleWithdraw()
        {
            long transaction_amt = 0;
            long selecOption = AppScreen.OptionAmount();
            if(selecOption == -1){
                ProcessMenuChoose();
                return;
            } else if(selecOption != 0){
                transaction_amt = selecOption;
            } else {
                transaction_amt = Validator.Convert<long>("amount");
            }
            if(transaction_amt <= 0 || transaction_amt %10000 != 0) {
                Utility.PrintMessage("Please Re-Enter");
                return;
            }
            if(transaction_amt > currentAccount.UserBalance){
                Utility.PrintMessage("Your account is not enough to perform");
                return;
            }
            if((currentAccount.UserBalance - transaction_amt) < minBalance){
                Utility.PrintMessage($"The balance in your account must be greater than {minBalance}");
                return;
            }
            InsertTransaction(currentAccount.Id,TransactionType.Withdraw,-transaction_amt);
            currentAccount.UserBalance -= transaction_amt;
            Utility.PrintMessage($"\nYour Account has: {currentAccount.UserBalance} VND\n");
        }

        public void InsertTransaction(long _UserIdBank, TransactionType _transType, long _transAmount)
        {
            var transaction = new Transaction()
            {
                TransactionId = Utility.GetTransactionId(),
                UserIdBank = _UserIdBank,
                TransactionType = _transType,
                TransactionAmount = _transAmount
            }; 
            listOfTransaction.Add(transaction);
        }
        private void ProcessTransfer(Transfer _Transfer)
        {
            if(_Transfer.TransferAmount <= 0){
                Utility.PrintMessage("Please Re-Enter");
                return;
            }
            if(_Transfer.TransferAmount > currentAccount.UserBalance){
                Utility.PrintMessage("Transfer failed. Your account is not enough to perform.");
                return;
            }
            if((currentAccount.UserBalance - _Transfer.TransferAmount) < minBalance){
                Utility.PrintMessage($"Transfer failed. The balance in your account must be greater than {minBalance}");
                return;
            }
            // Dùng thư viện Linq để bắt một thứ trong một thùng có điều kiện (trường hợp này là bắt tài khoản ng nhận tiền có trùng trong List Account có trước hay không)
            var checkUserIdRecieve = (from recieveId in userAccountList where recieveId.UserId == _Transfer.ReceiveUserId select recieveId).FirstOrDefault();
            if(checkUserIdRecieve == null){
                Utility.PrintMessage("\nRecipient accounts do not match. Please try again\n");
                return;
            }
            InsertTransaction(currentAccount.Id, TransactionType.Transfer, -_Transfer.TransferAmount);
            currentAccount.UserBalance -= _Transfer.TransferAmount;
            InsertTransaction(checkUserIdRecieve.Id, TransactionType.Transfer,_Transfer.TransferAmount);
            checkUserIdRecieve.UserBalance += _Transfer.TransferAmount;
            Utility.PrintMessage($"\nYou have transfer {_Transfer.TransferAmount} VND into account {checkUserIdRecieve.UserFullName}: {checkUserIdRecieve.UserId}\n");
            Utility.PrintMessage($"\nYour Account has: {currentAccount.UserBalance} VND\n");
        }
    }
}