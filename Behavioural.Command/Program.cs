using Behavioural.Command;

var bulb = new RemoteBulb();

var remoteControl = new RemoteControl();

var turnOnCommand = new TurnOnCommand(bulb);
var turnOffCommand = new TurnOffCommand(bulb);

remoteControl.Submit(turnOnCommand);
remoteControl.Submit(turnOffCommand);