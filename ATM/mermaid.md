```mermaid
classDiagram
    class ICommand {
        +void Execute()
    }

    class DepositCommand {
        -Account account
        -decimal amount
        +Execute()
    }

    class WithdrawCommand {
        -Account account
        -decimal amount
        +Execute()
    }

    class Account {
        +int AccountNumber
        +decimal AccountBalance
        +void Withdraw(decimal amount)
        +void Deposit(decimal amount)
    }

    class ATM {
        -ICommand command
        +void Action()
    }

    ICommand <|.. DepositCommand
    ICommand <|.. WithdrawCommand
    DepositCommand --> Account
    WithdrawCommand --> Account
    ATM --> ICommand
