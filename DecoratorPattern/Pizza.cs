using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    public class Pizza : IPizza
    {
        public string BuscarTipo()
        {
            var pizza = "Pizza normal";
            return pizza;
        }
    }
}
