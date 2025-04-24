```mermaid
classDiagram
    class IPaymentStrategy {
        +bool Pay(double amount)
    }

    class CreditCardPaymentStrategy {
        +bool Pay(double amount)
    }

    class DebitCardPaymentStrategy {
        +bool Pay(double amount)
    }

    class CashPaymentStrategy {
        +bool Pay(double amount)
    }

    class PaymentContext {
        -IPaymentStrategy strategy
        +void SetPaymentStrategy(IPaymentStrategy strategy)
        +bool Pay(double amount)
    }

    IPaymentStrategy <|.. CreditCardPaymentStrategy
    IPaymentStrategy <|.. DebitCardPaymentStrategy
    IPaymentStrategy <|.. CashPaymentStrategy
    PaymentContext --> IPaymentStrategy
