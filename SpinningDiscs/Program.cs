using SpinningDiscs;
List<string> list = new List<string>
{
    "intro", "body", "closing"
};

Console.WriteLine(list[0] + " " + list[1] + " " + list[2]);

DVD dvd = new DVD("Video", list, "DVD", 50);
CD cd = new CD();

dvd.SpinDisc();
dvd.ReadDiscInfo();
dvd.ReadContent();
dvd.LaserData(25);
// TODO: Declare and initialize a CD and a DVD object.

// TODO: Call each CD and DVD method to verify that they work as expected.