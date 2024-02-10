// See https://aka.ms/new-console-template for more information

using designPattern.Adapter;
using designPattern.Builder;
using designPattern.ChainOfResponsibility;
using designPattern.Decorator;
using designPattern.Facade;
using designPattern.Factory;
using designPattern.Flyweight;
using designPattern.Prototype;
using designPattern.Proxy;
using designPattern.Singleton;

namespace ProbSolv
{

    class Program
    {
        static void WriteColoredLine(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {

            #region singleton
            //Task task1 = Task.Factory.StartNew(() =>
            //{
            //    Counter counter1 = Counter.GetInstance();
            //    counter1.AddOne();
            //    Console.WriteLine("counter 1:" + counter1.count.ToString());
            //});
            //Task task2 = Task.Factory.StartNew(() =>
            //{
            //    Counter counter2 = Counter.GetInstance();
            //    counter2.AddOne();
            //    Console.WriteLine("counter 2:" + counter2.count.ToString());
            //});
            #endregion

            #region prototype
            //EmployeePrototype tempEmp1 = new TempEmployee();
            //tempEmp1.Name = "temp employee 1";
            //tempEmp1.Id = 1;
            //tempEmp1.EmpAddress = new Address { City = "City 1", Building = "B1", StreetName = "street name" };

            //EmployeePrototype tempEmp2 = tempEmp1.DeepCopy();

            //Console.WriteLine("======== Temp Emp 1 Original Values==============");
            //Console.WriteLine(tempEmp1.ToString());
            //Console.WriteLine("======== Temp Emp 2 Original copy==============");
            //Console.WriteLine(tempEmp2.ToString());

            //tempEmp2.EmpAddress.City = "new city";
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("========== Temp Emp 1 After Change ===========");
            //Console.WriteLine(tempEmp1.ToString());
            //Console.WriteLine("========== Temp Emp 2 =================");
            //Console.WriteLine(tempEmp2.ToString());

            #endregion

            #region Builder

            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //sb.AppendLine("Word 1");
            //sb.AppendLine("Word 2");

            //WriteColoredLine(sb.ToString(), ConsoleColor.Cyan);

            //Console.WriteLine("******** builder Pattern****",ConsoleColor.Yellow);
            //Director director = new Director();
            //IBuilder carBuilder = new Car("Jeep");
            //IBuilder mototrCycleBuilder = new MotorCycle("Honda");

            //// Making Car
            //director.Constructor(carBuilder);
            //Product car = carBuilder.GetVehicle();
            //WriteColoredLine($"Car {car.Show()}");

            //// Making MotorCycle
            //director.Constructor(mototrCycleBuilder);
            //Product motorCycle = mototrCycleBuilder.GetVehicle();
            //WriteColoredLine($"MotorCycle {motorCycle.Show()}");

            #endregion

            #region Factory Mehtod

            //string cardNumber, bankCode;
            //BankFactory bankFactory = new BankFactory();

            //WriteColoredLine("Enter your card number", ConsoleColor.Cyan);
            //cardNumber = Console.ReadLine();
            //bankCode = cardNumber.Substring(0, 6);
            //IBank bank = bankFactory.GetBank(bankCode);
            //IPaymentCard paymentCard = bankFactory.GetPaymentCard("12");

            //WriteColoredLine(bank.Withdrow());
            //WriteColoredLine(paymentCard.GetName());


            #endregion

            #region Abstract Factory

            #endregion

            #region Structural Patterns

            #region Proxy
            //SMSServiceProxy proxy = new SMSServiceProxy();
            //WriteColoredLine(proxy.SerndSMS("123", "0786514", "message 1"));
            //WriteColoredLine(proxy.SerndSMS("123", "0786514", "message 1"));
            //WriteColoredLine(proxy.SerndSMS("123", "0786514", "message 1"));
            #endregion

            #region Decorator
            //ConcreteSMSService smsService = new ConcreteSMSService();
            //NotificationEmailDecorator emailDecorator = new NotificationEmailDecorator();

            //emailDecorator.SetService(smsService);
            //WriteColoredLine(emailDecorator.SendSMS("123","01236578","Message 1"));
            #endregion

            #region Adapter
            //Employee employee = new Employee();
            //MachineOperator machineOperator = new MachineOperator();
            //machineOperator.BasicSalary = 1200;
            //employee.Name = "Test";
            //employee.BasicSalary = 1000;
            //SalaryAdapter salaryCalculator = new SalaryAdapter();
            //var salary = salaryCalculator.CalcSalary(machineOperator);
            //WriteColoredLine(salary.ToString());
            #endregion

            #region Facade
            // create Basket
            //ShoppingBasket basket = new ShoppingBasket();
            //basket.AddItem(new BasketItem { ItemId = "123",ItemPrice = 50, Quantity = 3});
            //basket.AddItem(new BasketItem { ItemId = "654",ItemPrice = 40, Quantity = 4  });

            //PurchaseOrder order = new PurchaseOrder();
            //order.CreateOrder(basket, "name : Yahya, Bank: 136975241, mobile: 32652314");
            #endregion

            #region Flyweight
            //DiscountCalcFactory discount = new DiscountCalcFactory();
            //var calculater = discount.GetDiscountCalc("day");
            //var val = calculater.GetDiscountValue(DateTime.Now.Date);
            //WriteColoredLine(val.ToString());

            #endregion

            #region Chain Of Responsibilty
            //JobApplication jobApplication = new JobApplication();
            //jobApplication.ApplicationName = "Yahya";
            //jobApplication.JobTitle = "Great Job";
            //jobApplication.JobCode = "255";
            //jobApplication.Comments = new System.Text.StringBuilder();

            //HREvalHandler hREvalHandler = new HREvalHandler();
            //TechnicalEvalHandler technicalEvalHandler = new TechnicalEvalHandler();

            //hREvalHandler.SetNext(technicalEvalHandler);
            //hREvalHandler.HandleRequest(jobApplication);

            //Console.WriteLine(jobApplication.Comments);
            #endregion

            #endregion


            Console.ReadLine();
        }

    }
}
