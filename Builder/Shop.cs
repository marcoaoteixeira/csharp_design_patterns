namespace Builder {

    public sealed class Shop {

        public void Construct(VehicleBuilder builder) {
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildDoors();
        }
    }
}
