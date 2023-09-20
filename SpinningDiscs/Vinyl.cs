using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinningDiscs
{
    public class Vinyl : BaseDisc, IOpticalDisc
    {
        public string Type = "Viynl";
        public double MaxSpeed = 78;
        public double MinSpeed = 33.33;

        public Vinyl(string name, List<string> contents, string contentType, double storageCapacity) : base(name, contents, contentType, storageCapacity)
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
