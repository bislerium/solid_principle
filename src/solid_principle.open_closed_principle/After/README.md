# OCP-Compliant Solution: Shipping Costs Calculation

**Abstract Product Class:**

- Introduces an abstract `Product` class with an abstract method `CalculateShippingCost()`.
- Serves as the base for all product types, defining a common contract for calculating shipping costs.

**Concrete Product Classes (`StandardProduct`, `OverSizedProduct`, `FragileProduct`):**

- Implement the `Product` class and provide their own specific implementation of the `CalculateShippingCost` method.
- Each product type encapsulates its shipping cost logic, ensuring a clear separation of concerns.

**Shipping Calculator:**

- Accepts any object of type `Product` and calculates the shipping cost by invoking the `CalculateShippingCost` method.
- The `ShippingCalculator` class remains closed for modification and open for extension, adhering to the Open-Closed Principle.

**Benefits:**

1. **Extensibility:**
   - New product types can be introduced by creating additional classes that inherit from the abstract `Product` class. This allows for the easy extension of the system without modifying existing code.

2. **Maintainability:**
   - Changes related to shipping cost calculations for specific product types are isolated within their respective classes. This reduces the risk of introducing errors or unintended side effects when extending the system.

3. **Flexibility:**
   - Each product type has the flexibility to define its own shipping cost calculation logic, promoting a modular and easily extensible design.

By adhering to the Open-Closed Principle in this scenario, the design allows for seamless extension with new product types while maintaining the existing shipping calculation logic. It promotes a more modular, maintainable, and flexible system, crucial for adapting to changing requirements in a scalable manner.
