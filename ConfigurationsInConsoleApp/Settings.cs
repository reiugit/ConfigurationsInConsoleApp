namespace ConfigurationsInConsoleApp;

public record ParentSettings(ChildrenSettings? ChildrenSettings);

public record ChildrenSettings(List<string>? ChildrenList);
