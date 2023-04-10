using Singleton;

var b1 = LazyLoadBalancer.GetInstance();
var b2 = LazyLoadBalancer.GetInstance();
var b3 = LazyLoadBalancer.GetInstance();
var b4 = LazyLoadBalancer.GetInstance();
// Same instance?
if (b1 == b2 && b2 == b3 && b3 == b4) {
    Console.WriteLine("Same instance\n");
}
// Load balance 15 server requests
var balancer = LazyLoadBalancer.GetInstance();
for (var idx = 0; idx < 15; idx++) {
    var server = balancer.GetServer();
    Console.WriteLine("Dispatch Request to: " + server);
}
// Wait for user
Console.ReadKey();