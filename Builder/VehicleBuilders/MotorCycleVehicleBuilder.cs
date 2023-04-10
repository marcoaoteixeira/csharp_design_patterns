﻿namespace Builder.VehicleBuilders {
    public sealed class MotorCycleVehicleBuilder : VehicleBuilder {

        public MotorCycleVehicleBuilder()
            : base("MotorCycle") { }

        public override void BuildFrame() {
            Vehicle["frame"] = "MotorCycle Frame";
        }
        public override void BuildEngine() {
            Vehicle["engine"] = "500 cc";
        }
        public override void BuildWheels() {
            Vehicle["wheels"] = "2";
        }
        public override void BuildDoors() {
            Vehicle["doors"] = "0";
        }
    }
}
