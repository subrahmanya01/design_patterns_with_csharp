namespace Behavioural.Template
{
    internal abstract class CaffineBeverage
    {
        public void Prepare()
        {
            BoilWater();
            AddIngrediants();
            PourInCup();
            InformItsReady();
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public abstract void AddIngrediants();

        protected void PourInCup()
        {
            Console.WriteLine("Pouring in Cup...");
        }

        protected virtual void InformItsReady()
        {
            Console.WriteLine($"{this.GetType().Name} is Ready....");
            Console.WriteLine(".................................");
        }
    }
}
