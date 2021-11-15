using DecoratorPattern.Interfaces;
namespace DecoratorPattern
{
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string BuscarTipo()
        {
            var pizza = _pizza.BuscarTipo();
            return pizza;
        }
    }
}
