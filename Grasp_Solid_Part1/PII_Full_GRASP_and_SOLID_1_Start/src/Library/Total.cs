using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class Total
    {
        
        Recipe recipe { get; set; }

        public Total(Recipe recipe)
        {
            this.recipe = recipe;
        }
        
        public void CalcularTotal()
        {
            double gasto = 0;
            foreach(Step step in recipe.steps)
            {
                double cantidad = step.Quantity;
                Product producto = step.Input;
                double tiempo = step.Time/60;
                Equipment equipamiento = step.Equipment;

                gasto += producto.UnitCost * cantidad + equipamiento.HourlyCost * tiempo;
                
            }
            Console.WriteLine(gasto);
        }
    }
}