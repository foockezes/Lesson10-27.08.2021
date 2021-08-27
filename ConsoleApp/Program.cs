using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar ps = new PassengerCar()
            {
                Character = "Авто",
                Type = "лековой",
                Model = "Tayota",
                DateOfManufacture = 1997,
                Place = 4
                
            };
            ps.GetPasCar();
            CargoCar cr = new CargoCar()
            {
                Character = "Авто",
                Type = "Грузовой",
                Model = "Mercedes",
                DateOfManufacture = 2009,
                LiftingC = 600
            };
            cr.GetCargo();
            CargoAirplane ca = new CargoAirplane()
            {
                Character = "Самалет",
                Type = "Грузовой",
                Model = "Антей",
                DateOfManufacture = 1991,
                LiftingC = 15000
            };
            ca.GetCarPlane();
            PassengerAeroplane pa = new PassengerAeroplane()
            {
                Character = "Самалет",
                Type = "пасажирский",
                Model = "Airbus",
                DateOfManufacture = 1985,
                Place = 185
            };
            pa.GetPasPlane();
        }
    }
    class Transport
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public double DateOfManufacture { get; set; }
        public Transport() { }
        public Transport(string type, string model, double dom)
        {
            Type = type;
            Model = model;
            DateOfManufacture = dom;
        }
    }
    class Auto : Transport
    {
        public string Character { get; set; }
        public Auto() { }
        public Auto(string character)
        {
            Character = character;
        }
    }
    class Plane : Transport
    {
        public string Character { get; set; }
        public Plane() { }
        public Plane(string character)
        {
            Character = character;
        }
    }
    class Train : Transport
    {
        public string Character { get; set; }
        public Train() { }
        public Train(string character)
        {
            Character = character;
        }
    }
    class PassengerCar : Auto
    {
        public double Place { get; set; }


        public PassengerCar() { }
        public PassengerCar(double place)
        {
            Place = place;
        }
        public void GetPasCar()
        {
            Console.WriteLine($"вид транспориа: {Character}, тип транспорта: {Type}, вместимость пассажиров: {Place}, модел: {Model}, дата выпуска: {DateOfManufacture}");
        }
    }
    class CargoCar : Auto
    {
        public double LiftingC { get; set; }
        public CargoCar() { }
        public CargoCar(double LC)
        {
            LiftingC = LC;
        }
        public void GetCargo()
        {
            Console.WriteLine($"вид транспориа: {Character}, тип транспорта: {Type}, Грузоподемность {LiftingC}, модел: {Model}, дата выпуска: {DateOfManufacture}");
        }
    }
    class CargoAirplane : Plane
    {
        public double LiftingC { get; set; }
        public CargoAirplane() { }
        public CargoAirplane(double LC)
        {
            LiftingC = LC;
        }
        public void GetCarPlane()
        {
            Console.WriteLine($"вид транспориа: {Character}, тип транспорта: {Type}, Грузоподемность {LiftingC}, модел: {Model}, дата выпуска: {DateOfManufacture}");
        }
    }
    class PassengerAeroplane : Plane
    {
        public double Place { get; set; }
        public PassengerAeroplane() { }
        public PassengerAeroplane(double LC)
        {
            Place = LC;
        }
        public void GetPasPlane()
        {
            Console.WriteLine($"вид транспориа: {Character}, тип транспорта: {Type}, вместимость пассажиров: {Place}, модел: {Model}, дата выпуска: {DateOfManufacture}");
        }
    }
}
