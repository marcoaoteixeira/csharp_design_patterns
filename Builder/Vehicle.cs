namespace Builder {
    public sealed class Vehicle {
        private string _type;
        private Dictionary<string, string> _parts = new();
        
        public Vehicle(string type) {
            _type = type;
        }

        public string this[string key] {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show() {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _type);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}
