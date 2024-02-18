# Interface Segregation Principle (ISP)

**Definition:**
The Interface Segregation Principle is one of the SOLID principles of object-oriented programming and design. It emphasizes that a class should not be forced to implement interfaces it does not use. In other words, a class should only be required to implement methods that are relevant to its behavior. This principle aims to prevent the creation of overly large and unmanageable interfaces.

**Real-World Example:**
Consider a scenario in a business setting where employees have roles with specific responsibilities. Assume there are two interfaces, `Workable` and `Manageable`. A basic employee might implement both interfaces, as they can both work and be managed. However, a manager might only need to implement the `Manageable` interface because they don't perform the same tasks as a regular worker. Similarly, a janitor may implement only the `Workable` interface, as they contribute to the workforce but may not be involved in managerial activities.

**Key Points and Benefits:**

1. **Avoidance of Unnecessary Dependencies:**
   - Interface Segregation Principle helps avoid unnecessary dependencies between classes and interfaces. Classes should not be burdened with implementing methods they do not need, reducing unnecessary coupling.

2. **Clearer Contracts:**
   - Interfaces become more focused and provide clearer contracts to the classes that implement them. This makes it easier for developers to understand and implement the required behavior.

3. **Promotes Single Responsibility:**
   - By having smaller and more specific interfaces, ISP promotes the Single Responsibility Principle. Each interface is associated with a specific role or set of responsibilities.

4. **Enhanced Maintainability:**
   - Smaller interfaces are easier to maintain. When a new requirement arises, it's easier to add a new interface rather than modifying an existing large interface.

5. **Encourages Composition over Inheritance:**
   - ISP encourages using composition over inheritance. Instead of creating monolithic interfaces, you can compose smaller interfaces to achieve the desired functionality.

6. **Flexibility and Adaptability:**
   - Classes can adapt more easily to changes. When a new requirement arises, classes can implement new interfaces without being affected by unrelated changes in other parts of the system.

7. **Facilitates Testing:**
   - Classes that implement smaller interfaces are often easier to test. Unit tests can focus on specific aspects of behavior without being complicated by irrelevant methods.

In summary, Interface Segregation Principle aims to create more modular, maintainable, and flexible code by designing interfaces that are specific to the needs of the classes that implement them. It helps in achieving a clearer and more focused design that aligns with the responsibilities of individual classes.
