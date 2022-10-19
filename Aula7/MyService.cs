namespace Aula7
{
    internal class MyService<TClass>
    {
        public void Execute<TParam>(TParam param) where TParam : Animal
        {
            Console.WriteLine(param.Eat());
        }
    }
}