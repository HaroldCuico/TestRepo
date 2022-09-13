namespace ConsoleApp1TestRepo
{
    class Coffee
    {
        private double volume;
        private string type;
        private bool hot;

        public Coffee(double vol, string type, bool hot)
        {
            this.Volume = vol;
            this.Type = type;
            this.Hot = hot;
        }

        public double Volume { get { return volume; } set { volume = value; } }
        public string Type { get { return type; } set { type = value; } }
        public bool Hot { get { return hot;} set { hot = value; } }

        public override string ToString() { return $"{type} - {volume}L - Hot: {hot}"; }

    }
}
