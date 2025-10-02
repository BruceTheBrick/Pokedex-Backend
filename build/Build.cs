using Nuke.Common;

namespace Pokedex;

class Build : NukeBuild
{
    public static int Main ()
    {
        return Execute<Build>(x => x.Compile);
    }

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    Target Clean
    {
        get
        {
            return _ => _
                .Before(Restore)
                .Executes(() =>
                {
                });
        }
    }

    Target Restore
    {
        get
        {
            return _ => _
                .Executes(() =>
                {
                });
        }
    }

    Target Compile
    {
        get
        {
            return _ => _
                .DependsOn(Restore)
                .Executes(() =>
                {
                });
        }
    }
}