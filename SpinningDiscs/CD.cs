namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public string Type = "CD";
        public double MaxSpeed = 500;
        public double MinSpeed = 200;
        public CD(string name, List<string> contents, string contentType, double storageCapacity) : base(name, contents, contentType, storageCapacity)
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
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}

