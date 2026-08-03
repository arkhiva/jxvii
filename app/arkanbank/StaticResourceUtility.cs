public static class StaticResourceUtility {

    public static T Get<T>(string key) where T : class {
        return (Application.Current.Resources[key] as T)!;
    }
}