namespace DW.GraphQL.HotChocolateDemo.Schema.Queries
{
    public class AttackType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public int PP { get; set; }
    }
}
