﻿using System;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public string Type = "DVD";
        public double MaxSpeed = 78;
        public double MinSpeed = 33.33;
        public DVD(string name, List<string> contents, string contentType, double storageCapacity) : base(name, contents, contentType, storageCapacity)
        {

        }
        // TODO: Implement your custom interface.
        public void SpinDisc()
        {
            Console.WriteLine($"A {Type} spins at a rate of {MinSpeed} - {MaxSpeed}rpm.");
        }

        public void LaserRead()
        {
            Console.WriteLine($"Maybe someday I will be able to play the {ContentType} contained within this {Type}...\nBut instead, here are the contents:\n{ReadContent(Contents)}");
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}

