using System;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public CD(string name, List<string> contents, string type, double storageCapacity) : base(name, contents, type, storageCapacity)
        {

        }
        // TODO: Implement your custom interface.
        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }

        public void LaserRead()
        {
            Console.WriteLine("Maybe someday I will be able to play the music contained within this CD...");
        }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}

