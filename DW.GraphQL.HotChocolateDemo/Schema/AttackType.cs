namespace DW.GraphQL.HotChocolateDemo.Schema
{
    public class AttackType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public int PP { get; set; }
    }
}
