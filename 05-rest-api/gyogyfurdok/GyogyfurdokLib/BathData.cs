namespace GyogyfurdokLib
{
    public record BathData(string? Id, string? Name, string? City, string? ZipCode, string? County)
    {
        public int? IdAsInt => Utils.NullableStringToNullableInt(Id);
        public int? ZipCodeAsInt => Utils.NullableStringToNullableInt(ZipCode);
    }
}
