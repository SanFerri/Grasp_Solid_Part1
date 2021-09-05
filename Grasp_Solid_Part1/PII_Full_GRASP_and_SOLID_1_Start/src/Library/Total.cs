using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class Total                   // Designamos la responsabilidad de calcular el total a una nueva clase por el principio de responsabilidad única, las demás ya tienen su propia y única responsabilidad. Colabora con la clase Recipe ya que esta provee toda la información necesaria para calcular el total.
    {
        
        Recipe recipe { get; set; }           

        public Total(Recipe recipe)
        {
            this.recipe = recipe;
        }
        
        public double CalcularTotal()            // Este método se encarga de calcular el costo total de una receta.
        {
            double gasto = 0;
            foreach(Step step in recipe.steps)   // Recorre la lista de steps en un objeto recipe.
            {
                double cantidad = step.Quantity;
                Product producto = step.Input;
                double tiempo = step.Time/60;
                Equipment equipamiento = step.Equipment;

                gasto += producto.UnitCost * cantidad + equipamiento.HourlyCost * tiempo;
                
            }
            return gasto;
        }
    }
}