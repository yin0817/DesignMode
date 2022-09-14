// See https://aka.ms/new-console-template for more information
using FactoryPattern;

ShapeFactory.GetShape("Rectangle")?.Draw();

ShapeFactory.GetShape("Square")?.Draw();

ShapeFactory.GetShape("Circle")?.Draw();
