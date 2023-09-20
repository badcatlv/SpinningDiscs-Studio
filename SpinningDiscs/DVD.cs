using System;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {

        public DVD(string name, List<string> contents, string type, double storageCapacity) : base(name, contents, type, storageCapacity)
        {

        }
        // TODO: Implement your custom interface.
        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }

        public void LaserRead()
        {
            Console.WriteLine($"Maybe someday I will be able to play the video contained within this DVD...\nBut here are the contents:\n{ReadContent(Contents)}");
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}

