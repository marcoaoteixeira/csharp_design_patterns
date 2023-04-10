using Builder;
using Builder.VehicleBuilders;

VehicleBuilder builder;

// Create shop with vehicle builders
var shop = new Shop();

// Construct and display vehicles
builder = new ScooterVehicleBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

builder = new CarVehicleBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

builder = new MotorCycleVehicleBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

// Wait for user
Console.ReadKey();