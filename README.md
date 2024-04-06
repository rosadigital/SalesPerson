## SalespersonDemo Documentation

### Overview
The `SalespersonDemo` program demonstrates object instantiation using two classes: `RealEstateSalesperson` and `GirlScout`. It showcases the utilization of the `SalesSpeech()` method appropriately for each object and the execution of the `MakeSale()` method multiple times with each object. The final contents of each object's data fields are displayed to provide a comprehensive understanding of their functionality.

### Classes and Interfaces
1. **`Program`**
   - This class contains the `Main()` method, where instances of `RealEstateSalesperson` and `GirlScout` are created and their methods are invoked to demonstrate their functionality.

2. **`Salesperson` (Abstract Class)**
   - This abstract class represents a generic salesperson and includes properties for the first and last names.
   - The constructor requires both first and last names.
   - It contains a method to retrieve the full name of the salesperson by concatenating the first and last names.
   - The `SalesSpeech()` method is declared as abstract, indicating that it must be implemented by derived classes.

3. **`RealEstateSalesperson` (Derived from `Salesperson`, Implements `ISellable` Interface)**
   - This class represents a real estate salesperson and includes properties for the total value sold, total commission earned, and commission rate.
   - It initializes the commission rate through its constructor.
   - The `SalesSpeech()` method displays a sales speech appropriate for a real estate agent.
   - The `MakeSale()` method accepts the dollar value of a house as input, updates the total value sold and total commission earned based on the commission rate.

4. **`ISellable` (Interface)**
   - This interface defines two methods: `SalesSpeech()` and `MakeSale()`.
   - Both `RealEstateSalesperson` and `GirlScout` classes implement this interface.

5. **`GirlScout` (Derived from `Salesperson`, Implements `ISellable` Interface)**
   - This class represents a Girl Scout and includes a property to hold the number of boxes of cookies sold.
   - The `SalesSpeech()` method displays a sales speech appropriate for a Girl Scout selling cookies.
   - The `MakeSale()` method accepts the number of boxes of cookies sold as input and updates the total boxes sold accordingly.

### Usage
1. Instantiate objects of `RealEstateSalesperson` and `GirlScout` classes.
2. Invoke the `SalesSpeech()` method to display an appropriate sales speech for each object.
3. Execute the `MakeSale()` method with different parameters to simulate multiple sales.
4. Display the final contents of each object's data fields to verify the correctness of the operations performed.

### Sample Code Snippet
```csharp
RealEstateSalesperson realEstateAgent = new RealEstateSalesperson("John", "Rosa", 0.05);
realEstateAgent.SalesSpeech();
realEstateAgent.MakeSale(200000);
Console.WriteLine($"Real Estate Agent: {realEstateAgent.GetFullName()}");
Console.WriteLine($"Total Value Sold: ${realEstateAgent.TotalValueSold}");
Console.WriteLine($"Total Commission Earned: ${realEstateAgent.TotalCommissionEarned}");
```

### Conclusion
The `SalespersonDemo` program effectively demonstrates the usage of classes, inheritance, abstract classes, interfaces, and method implementations in C#. It provides a clear example of how different types of salespersons can be modeled and utilized in a sales context.