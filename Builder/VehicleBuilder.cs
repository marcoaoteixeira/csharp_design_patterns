namespace Builder {

    public abstract class VehicleBuilder {

        public Vehicle Vehicle { get; }

        protected VehicleBuilder(string vehicleType) => Vehicle = new(vehicleType);

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
