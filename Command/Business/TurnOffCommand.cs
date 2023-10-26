namespace Command.Business
{
    class TurnOffCommand : ICommand
    {
        private Television tv;

        public TurnOffCommand(Television tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.TurnOff();
        }
    }
}
