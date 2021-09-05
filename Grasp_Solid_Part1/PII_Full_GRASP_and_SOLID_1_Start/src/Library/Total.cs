namespace Full_GRASP_And_SOLID.Library
{
    public class Total
    {
        p
        public Total(Recipe recipe)
        {
            this.recipe = recipe;
        }
        
        public int CalcularTotal()
        {
            foreach(step in recipe.steps)
            {
                cantidad = step.Quantity;
                producto = step.Input;
                tiempo = step.Time;
                equipamiento = step.Equipment;

                Total = (producto.UnitCost * cantidad) + (equipamiento.HourlyCost * tiempo)
            }
        }
    }
}