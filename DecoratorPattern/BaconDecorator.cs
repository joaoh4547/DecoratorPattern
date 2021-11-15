using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {

        }
        public override string BuscarTipo()
        {

            var pizza =  base.BuscarTipo();
            pizza += "\r\n com extra de bacon";
            return pizza;
        }
    }
}
