using System.Net.Mime;

namespace SpinningDiscs
{
    public class FloppyDisc : BaseDisc, IOpticalDisc
    {
        public string Type = "Floppy Disc";
        public double MaxSpeed = 78;
        public double MinSpeed = 33.33;
        public FloppyDisc(string name, List<string> contents, string contentType, double storageCapacity) : base(name, contents, contentType, storageCapacity)
        {

        }

        public void SpinDisc()
        {
            Console.WriteLine($"A {Type} spins at a rate of {MinSpeed} - {MaxSpeed}rpm.");
        }

        public void LaserRead()
        {
            Console.WriteLine($"Maybe someday I will be able to play the {ContentType} contained within this {Type}...\nBut instead, here are the contents:\n{ReadContent(Contents)}");
        }
    }
}
