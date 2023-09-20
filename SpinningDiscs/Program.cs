using SpinningDiscs;
List<string> dvdList = new List<string>
{
    "intro", "body", "closing"
};

List<string> cdList = new List<string> { "Track1", "Track2", "Track3", "Track4", "Track5" };


DVD dvd = new DVD("Video", dvdList, "DVD", 50);
CD cd = new CD("Music", cdList, "CD", 1.6);

dvd.SpinDisc();
dvd.ReadDiscInfo();
dvd.LaserData(25);
dvd.LaserRead();

cd.SpinDisc();
cd.ReadDiscInfo();
cd.LaserRead();
cd.LaserData(0.8);
// TODO: Declare and initialize a CD and a DVD object.

// TODO: Call each CD and DVD method to verify that they work as expected.