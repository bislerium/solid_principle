# Problem Scenario: Notification Service

In the initial design of the `NotificationService`, the class was tightly coupled to specific implementations of notification senders (`EmailSender`, `PushNotificationSender`, `SMSSender`). This tight coupling made the system less flexible and harder to extend, as any change or addition to the notification senders required modifications to the `NotificationService` itself.

## Solution Applying Dependency Inversion Principle:

### Abstraction: `INotificationSender`

An abstraction is introduced in the form of the `INotificationSender` interface. This interface declares a method (`Notify`) that represents the common behavior for sending notifications.

### Refactored Design

- Each specific notification sender (`EmailSender`, `PushNotificationSender`, `SMSSender`) now implements the `INotificationSender` interface.

- The high-level module (`NotificationService`) no longer directly depends on specific implementations but relies on the abstraction.

## Benefits of this Approach

1. **Decoupling:** The high-level module is decoupled from the low-level modules. The `NotificationService` does not need to know the details of each notification sender, promoting a more modular and maintainable system.

2. **Extensibility:** New notification senders can be introduced without modifying existing code. The `NotificationService` remains open for extension, adhering to the Open-Closed Principle.

3. **Testability:** Components become more testable. The `NotificationService` can be tested independently, and mock objects can be used to simulate the behavior of notification senders during testing.

4. **Reduced Risk of Changes:** Changes in the implementation of specific notification senders have minimal impact on the `NotificationService`. This reduces the risk of unintended consequences when modifications are made.

5. **Promotes Abstraction:** The use of an interface (`INotificationSender`) encourages a design approach that focuses on what needs to be done (sending a notification) rather than how it is implemented. This promotes clearer and more understandable code.

In summary, the Dependency Inversion Principle aims to create a more adaptable and modular design by introducing abstractions, allowing high-level modules to depend on those abstractions rather than specific implementations.
