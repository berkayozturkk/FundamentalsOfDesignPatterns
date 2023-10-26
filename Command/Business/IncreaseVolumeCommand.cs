namespace Command.Business
{
    class IncreaseVolumeCommand : ICommand
    {
        private Television tv;

        public IncreaseVolumeCommand(Television tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.IncreaseVolume();
        }
    }
}
