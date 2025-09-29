namespace ExtensionMethod
{
    public readonly record struct Person(string Name, int Age)
    {
        public override string ToString() => $"{Name} ({Age})";
    }
}
