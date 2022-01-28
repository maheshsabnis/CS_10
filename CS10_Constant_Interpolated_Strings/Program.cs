namespace CS10_ConstantStringInterpolation;

public static class ConstaniStringInterpolation
{
    private const string BaseUrl = "/data/api";

    public static class Urls
    {
        public const string GetAll = $"{BaseUrl}/Employees";
        // C# 10 Constant String Interpolation
        public const string GetById = $"{BaseUrl}/{{eno:guid}}";
        // Traditional Concatination
        public const string GetByName = BaseUrl + "/{name:string}";
        // Earlier
        public static readonly string GetByLastName  = $"{BaseUrl}/{{eno:guid}}";
    }
}

