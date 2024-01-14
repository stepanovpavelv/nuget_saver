namespace NugetSaver.Domain;

public sealed record SearchSettings(List<string> Sources, 
                                    List<string> TargetFrameworks, 
                                    bool AllowPrerelease,
                                    bool AllowUnlisted);