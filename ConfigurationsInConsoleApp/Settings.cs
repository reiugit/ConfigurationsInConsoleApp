namespace ConfigurationsInConsoleApp;

public record ParentSettings(ChildrenSettings ChildrenSettings = null!);

public record ChildrenSettings(List<string> ChildrenList = null!);
