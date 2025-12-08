namespace GyogyfurdokLib
{
    public static class Utils
    {
        public static int? NullableStringToNullableInt(string? value) =>
            int.TryParse(value, out int val) ? val : null;
    }
}
