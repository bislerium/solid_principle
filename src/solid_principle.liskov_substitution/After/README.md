# Problem

The **Liskov Substitution Principle (LSP)** states that objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. The problem arises when this principle is violated, typically due to incorrect inheritance relationships.

In the Before example provided:

- A `Square` class inherits from a `Rectangle` class.
- The `Square` class attempts to enforce that the width and height are always equal, ensuring that it represents a square.
- This violates the LSP because, in a general sense, a `Square` is not substitutable for a `Rectangle` without causing unexpected behavior.

When an object of type `Square` is assigned to a variable of type `Rectangle`, issues may arise. For instance, if the width and height are set independently, as is common for a `Rectangle`, the `Square` object might not maintain its intended behavior.

# Solution

To adhere to the Liskov Substitution Principle, a solution involves rethinking the design to avoid unexpected behaviors when substituting subclasses for their superclasses. In this context, it often means reconsidering the use of inheritance.

One approach is to design classes based on interfaces or abstract classes that define a common contract (e.g., an `IShape` interface with a `CalculateArea` method). Concrete classes such as `Rectangle` and `Square` can then implement this interface or extend the abstract class.

By designing classes based on shared contracts rather than relying solely on inheritance, the LSP is more likely to be preserved. In the corrected example, both `Rectangle` and `Square` implement the `IShape` interface, ensuring that they can be used interchangeably without violating the expected behavior specified by the
