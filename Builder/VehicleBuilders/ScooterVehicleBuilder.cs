namespace Builder.VehicleBuilders {
    public sealed class ScooterVehicleBuilder : VehicleBuilder {

        public ScooterVehicleBuilder()
            : base("Scooter") { }

        public override void BuildFrame() {
            Vehicle["frame"] = "Scooter Frame";
        }
        public override void BuildEngine() {
            Vehicle["engine"] = "50 cc";
        }
        public override void BuildWheels() {
            Vehicle["wheels"] = "2";
        }
        public override void BuildDoors() {
            Vehicle["doors"] = "0";
        }
    }
}
