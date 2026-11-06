using RacingSimulator;
using RacingSimulator.Models;
using RacingSimulator.Patterns;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("ru-RU");

Console.WriteLine("==================================================");
Console.WriteLine("   ГОНОЧНЫЙ СИМУЛЯТОР (Вариант 26)");
Console.WriteLine("==================================================\n");

// ----------------------------------------------------
// ДЕМО 1: Паттерн Prototype (Клонирование трасс из реестра)
// ----------------------------------------------------
Console.WriteLine("--- 1. Демонстрация паттерна Prototype ---");

var trackRegistry = new TrackRegistry();

// Настройка базовых шаблонов трасс различных типов
trackRegistry.RegisterTemplate("ring", new Track("Кольцо", "Базовый автодром", 5.2, "Ясно", 10));
trackRegistry.RegisterTemplate("serpentine", new Track("Горный серпантин", "Базовый серпантин", 14.0, "Сухо", 5));
trackRegistry.RegisterTemplate("straight", new Track("Прямая", "Базовый дрэг-стрип", 2.5, "Солнечно", 1));

// Клонирование и видоизменение трасс под индивидуальные условия
Track raceTrack1 = trackRegistry.CreateTrack("ring");
raceTrack1.Name = "Ночной Ле-Ман";
raceTrack1.Weather = "Сильный ливень";
raceTrack1.Laps = 15;

Track raceTrack2 = trackRegistry.CreateTrack("serpentine");
raceTrack2.Name = "Альпийская срезка";
raceTrack2.Weather = "Снег и туман";
raceTrack2.Laps = 8;

Console.WriteLine($"[Трасса 1]: {raceTrack1}");
Console.WriteLine($"[Трасса 2]: {raceTrack2}\n");

Console.WriteLine("--- 2. Демонстрация паттерна Factory Method ---");

VehicleFactory sportsFactory = new SportsCarFactory();
VehicleFactory suvFactory = new SuvCarFactory();
VehicleFactory formulaFactory = new FormulaCarFactory();

Car sportsCar = sportsFactory.CreateCar();
Car suvCar = suvFactory.CreateCar();
Car formulaCar = formulaFactory.CreateCar();

Console.WriteLine($"Создано транспортное средство: {sportsCar}");
Console.WriteLine($"Создано транспортное средство: {suvCar}");
Console.WriteLine($"Создано транспортное средство: {formulaCar}\n");

Console.WriteLine("--- 3. Симуляция гонки ---");

Console.WriteLine($"\n Заезд #1. Трасса: {raceTrack1.Name} ({raceTrack1.Weather})");
sportsCar.Race();

Console.WriteLine($"\n Заезд #2. Трасса: {raceTrack2.Name} ({raceTrack2.Weather})");
suvCar.Race();

Console.WriteLine("\nВсе сценарии успешно выполнены. Нажмите Enter для выхода.");
Console.ReadLine();