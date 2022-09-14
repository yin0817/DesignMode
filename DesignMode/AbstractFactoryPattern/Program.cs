// See https://aka.ms/new-console-template for more information
//获取形状工厂
using AbstractFactoryPattern;

var shapeFactory = FactoryProducer.GetFactory("SHAPE");

//获取形状为 Circle 的对象
var shape1 = shapeFactory?.GetShape("Circle");

//调用 Circle 的 draw 方法
shape1?.Draw();

//获取形状为 Rectangle 的对象
var shape2 = shapeFactory?.GetShape("Rectangle");

//调用 Rectangle 的 draw 方法
shape2?.Draw();

//获取形状为 Square 的对象
var shape3 = shapeFactory?.GetShape("Square");

//调用 Square 的 draw 方法
shape3?.Draw();

//获取颜色工厂
var colorFactory = FactoryProducer.GetFactory("COLOR");

//获取颜色为 Red 的对象
var color1 = colorFactory?.GetColor("Red");

//调用 Red 的 fill 方法
color1?.Fill();

//获取颜色为 Green 的对象
var color2 = colorFactory?.GetColor("Green");

//调用 Green 的 fill 方法
color2?.Fill();

//获取颜色为 Blue 的对象
var color3 = colorFactory?.GetColor("Blue");

//调用 Blue 的 fill 方法
color3?.Fill();
