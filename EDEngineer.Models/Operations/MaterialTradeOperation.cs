namespace EDEngineer.Models.Operations
{
    public class MaterialTradeOperation : JournalOperation
    {
        public string IngredientRemoved { get; set; }
        public int RemovedQuantity { get; set; }

        public string IngredientAdded { get; set; }
        public int AddedQuantity { get; set; }
        
        public override void Mutate(State state)
        {
            state.Cargo.IncrementCargo(IngredientRemoved, -1 * RemovedQuantity);
            state.Cargo.IncrementCargo(IngredientAdded, AddedQuantity);
        }
    }
}