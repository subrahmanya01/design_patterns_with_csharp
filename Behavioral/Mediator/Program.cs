using Behavioral.Mediator;

var formMediator = new FormMediator();

var userName = new TextBox(formMediator);
var password = new TextBox(formMediator);

var button = new Button(formMediator);

formMediator.SetUserName(userName);
formMediator.SetPassword(password);
formMediator.SetButton(button);

userName.SetTextContent("Subrahmanya");
button.Click();

password.SetTextContent("Password");
button.Click();


