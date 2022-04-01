using DataAccessDemo.DbAccess;

namespace PlatformAPIDemo
{
    public static class RegisterServices
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
            builder.Services.AddSingleton<ITeamData, TeamData>();
            builder.Services.AddSingleton<IEventData, EventData>();
            builder.Services.AddSingleton<IChallengeData, ChallengeData>();
            builder.Services.AddSingleton<ITeamInChallengeData, TeamInChallengeData>();
            builder.Services.AddSingleton<ITeamInEventData, TeamInEventData>();
            builder.Services.AddSingleton<IReportData, ReportData>();
            builder.Services.AddSingleton<IVoteOnWaitingData, VoteOnWaitingData>();
        }
    }
}
