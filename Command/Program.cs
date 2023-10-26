using Command.Business;

Television tv = new Television();
TurnOnCommand turnOnCommand = new TurnOnCommand(tv);
TurnOffCommand turnOffCommand = new TurnOffCommand(tv);
IncreaseVolumeCommand increaseVolumeCommand = new IncreaseVolumeCommand(tv);
DecreaseVolumeCommand decreaseVolumeCommand = new DecreaseVolumeCommand(tv);

RemoteControl remote = new RemoteControl();

remote.SetCommand(turnOnCommand);
remote.PressButton(); 

remote.SetCommand(increaseVolumeCommand);
remote.PressButton(); 

remote.SetCommand(decreaseVolumeCommand);
remote.PressButton(); 

remote.SetCommand(turnOffCommand);
remote.PressButton();