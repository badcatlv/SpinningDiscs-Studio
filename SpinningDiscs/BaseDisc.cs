using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public List<string> Contents { get; set; } = new List<string>();
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

        public string Result { get; set; }
        public string ReadContent(List<string> strings)
        {
            //StringBuilder sb = new StringBuilder();
            int i = 1;
            foreach (var item in strings)
            {
                Result += i + ": " + item +"\n";
                i++;
                //sb.Append(item);
                //sb.Append("\n");
            }
            //Result = sb.ToString().Trim();
            return Result;

        }
        

        public void ReadDiscInfo()
        {
            Console.WriteLine($"\nDisc: {Name}\nContent Length: {Contents.Count}\nContents:\n{ReadContent(Contents)}Type: {Type}\nStorage Capacity: {StorageCapacity}");
        }


    }
}
