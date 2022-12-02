namespace MauiApp1.DependencyInjection
{
    public interface IHelloWorldClass
    {
        string Execution();
    }

    public class HelloWorldlClass : IHelloWorldClass
    {
        public string Execution()
        {
            return $"{DateTime.Now} Hello World !!!";
        }
    }
}