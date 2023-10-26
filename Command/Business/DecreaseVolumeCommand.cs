namespace Command.Business
{
    class DecreaseVolumeCommand : ICommand
    {
        private Television tv;

        public DecreaseVolumeCommand(Television tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.DecreaseVolume();
        }
    }
}
