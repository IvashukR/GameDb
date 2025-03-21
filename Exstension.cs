
using Microsoft.EntityFrameworkCore;

public static class Exstension
{
    public static void AddDb(this IServiceCollection serviceDescriptors)
    {
        serviceDescriptors.AddDbContext<PlayerContext>(o => {
            o.UseNpgsql("Host=ep-twilight-cloud-a5gtlbrt-pooler.us-east-2.aws.neon.tech;Database=DbScorec;Username=DbScorec_owner;Password=npg_Toj68gvyDSfh;SSLMode=Require"
);

        });
    }

}