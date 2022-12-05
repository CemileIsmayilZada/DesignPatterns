using DesignPattern;
using DesignPattern.AdapterPattern;
using DesignPattern.BridgePattern;
using DesignPattern.BridgePattern.Implementations;
using DesignPattern.BridgePattern.Interfacess;
using DesignPattern.CompositePattern.Implemeantatioss;
using DesignPattern.StrategyPattern;
using DesignPattern.StrategyPattern.Implementations;
using DesignPattern.TemplateMethodPattern;
using DesignPattern.TemplateMethodPattern.Inherits;

//Prototype

//Employee emb1=new Employee(2,3,4,5,6,7,8,9,9);
//Employee emb2=emb1.GetClone();
//emb2.Age = 12;



//Adapter---------------------------

//Adaptee adaptee=new Adaptee();
//Adapter adapter = new Adapter(adaptee);
//adapter.sum();
//adapter.subtract();


//Bridge----------------------------


//Abstraction abstraction = new Abstraction(new CiyelemMurebbe());//Getdim ciyelem murebbesi aldim
//abstraction.CallingOperation();

//Strategy--------------------------

//Context context = new Context();//1 ci  usul
//context.SetStrategy(new MoveLeft());

//Context context1=new Context(new MoveRight()); //2ci usul
//context1.Operation() ;


//Template--------------------------

//Client client = new Client();
//client.ClientCall(new Nokia());


//Composite-------------------------

CompositeMember compositeMember = new CompositeMember("Nene");

compositeMember.AddMember(new MiddleMember("Ana"));
compositeMember.AddMember(new MiddleMember("Dayi"));

MiddleMember middleMember = new MiddleMember("Xala");
middleMember.AddMember(new MiddleMember("Emil"));
middleMember.AddMember(new MiddleMember("Sevinc"));
middleMember.AddMember((new MiddleMember("Zehra")));

compositeMember.AddMember(middleMember);
compositeMember.ExecuteOrder();
