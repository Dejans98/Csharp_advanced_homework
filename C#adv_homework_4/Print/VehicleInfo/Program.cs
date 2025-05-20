using VehicleInfo.Helper;
using VehicleInfo.Vehicles;

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

VehicleExtensions.Drive(car);
VehicleExtensions.Whellie(motorBike);
VehicleExtensions.Sail(boat);
VehicleExtensions.Fly(plane);