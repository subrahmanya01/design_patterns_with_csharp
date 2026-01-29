using Behavioural.ChainOfResposibility;

var hdfcAccount = new HdfcBank(1000);

var iciciAccount = new IciciBank(309002);

hdfcAccount.SetSuccessor(iciciAccount);

hdfcAccount.Pay(2000);