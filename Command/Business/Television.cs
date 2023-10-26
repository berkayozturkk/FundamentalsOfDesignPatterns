namespace Command.Business
{
    class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("Television is ON.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Television is OFF.");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Volume increased.");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Volume decreased.");
        }
    }
}
