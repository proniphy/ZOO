namespace Zoo.Insects
{
    public class Fly : Insect
    {
        public int BuzzFrequency { get; set; }

        public Fly(string name, int age, int weight, bool canFly, int buzzFrequency)
            : base(name, age, weight, canFly)
        {
            BuzzFrequency = buzzFrequency;
            Status = new HealthStatus(true, "Vaccinated");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Buzzing at {BuzzFrequency}Hz...");
        }
    }
}
