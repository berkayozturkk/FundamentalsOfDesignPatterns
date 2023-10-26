namespace Command.Business
{
    class TurnOnCommand : ICommand
    {
        private Television tv;

        public TurnOnCommand(Television tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.TurnOn();
        }
    }
}
