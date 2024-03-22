/*
You are tasked with designing a system for a fast-food restaurant chain. 
The restaurant offers various types of meals, including burgers, pizzas, and sandwiches. 
The management wants to introduce flexibility in adding new types of meals in the future without modifying existing code. 
They also want to ensure that each meal type follows a consistent creation process while allowing 
for customization based on regional preferences.

Implement the Factory Method design pattern to fulfill these requirements. 
Define an abstract class, MealCreator, which declares a method for creating meals. 
Create concrete subclasses for each meal type (e.g., BurgerCreator, PizzaCreator, SandwichCreator) 
that implement the creation method to produce their respective meals. 
Ensure that the creation method is customizable for each subclass to accommodate 
regional variations in ingredients or preparation methods.
*/

using FP.Patterns.Factory.Exercice4.Factories;

Console.WriteLine("Welcome to Fast Food Restaurant!\n");
MealCreator burgerCreator = new BurgerCreator();
MealCreator pizzaCreator = new PizzaCreator();
MealCreator sandwichCreator  = new SandwichCreator();

Console.WriteLine("Ordering and preparing meals:\n");
Console.WriteLine("Preparing Burger:");
burgerCreator.PrepareCookServe();

Console.WriteLine("\nPreparing Pizza:");
pizzaCreator.PrepareCookServe();

Console.WriteLine("\nPreparing Sandwich:");
sandwichCreator.PrepareCookServe();
