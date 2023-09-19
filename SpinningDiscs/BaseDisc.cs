namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public List<string> Contents { get; set; }
        // public IEnumerable<string> Contents { get; set; } = Enumerable.Empty<string>();
        public string Type { get; set; }
        public double StorageCapacity { get; set; }
        public double StorageUsed { get; set; }
        public double StorageAvailable { get; set; }


        public BaseDisc(string name, List<string> contents, string type, double storageCapacity)
        {
            Name = name;
            Contents = contents;
            Type = type;
            StorageCapacity = storageCapacity;
            StorageUsed = 0;
            StorageAvailable = StorageCapacity - StorageUsed;
        }

        public void LaserData(double dataSize)
        {
            if (StorageAvailable < dataSize)
            {
                Console.WriteLine("Not enough storage available.");
            }
            else
            {
                StorageUsed += dataSize;
                StorageAvailable -= dataSize;
                Console.WriteLine($"Data {dataSize} added. Remaining storage: {StorageAvailable}");
            }
        }
        public string StringContents { get; set; }
        public void ReadContent()
        {
            int i = 1;
            foreach (var item in Contents)
            {
                Console.WriteLine($"{i}: {item}");
                i++;
            }
        }

        public void ReadDiscInfo()
        {
            Console.WriteLine($"Disc: {Name}\nContent Length: {Contents}\nType: {Type}\nStorage Capacity: {StorageCapacity}\n{StringContents}");
        }


    }
}
