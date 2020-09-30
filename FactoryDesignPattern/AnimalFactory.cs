namespace FactoryDesignPattern
{
    public class AnimalFactory
    {
        public IAnimal CreateAnimal(int petType)
        {
            IAnimal animal;
            switch (petType)
            {
                case 1:
                    animal = new Dog();
                    break;
                case 2:
                    animal = new Cat();
                    break;
                default:
                    animal = new Dumbass();
                    break;
            }

            return animal;
        }
    }
}
