﻿/*
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

using FP.Patterns.Factory.Exercice5.Factories;
using FP.Patterns.Factory.Exercice5.Meals;

Factory burgerFactory = new BurgerFactory();
IMeal burger = burgerFactory.PrepareMeal();

Factory pizzaFactory = new PizzaFactory();
IMeal pizza = pizzaFactory.PrepareMeal();

Factory sandwichFactory = new SandwichFactory();
IMeal sandwich = sandwichFactory.PrepareMeal();