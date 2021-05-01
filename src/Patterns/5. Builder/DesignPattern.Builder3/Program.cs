using System;

namespace DesignPattern.Builder3
{
    class Program
    {
        static void Main(string[] args)
        {
            PhonePartBuilder highPartBuilder = new HighPhonePartBuilder();
            PhoneFactory phoneFactory = new PhoneFactory(highPartBuilder);

            Phone highPhone = phoneFactory.BuildPhone();
            highPhone.Show();

            Console.WriteLine();
            phoneFactory.SetPhoneBuilder(new LowPhonePartBuilder());
            Phone lowPhone = phoneFactory.BuildPhone();
            lowPhone.Show();
        }
    }
}
