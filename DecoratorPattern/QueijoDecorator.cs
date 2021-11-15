using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string BuscarTipo()
        {
            var pizza = base.BuscarTipo();
            pizza += "\r\n com extra de queijo";
            return pizza;
        }
    }
}
