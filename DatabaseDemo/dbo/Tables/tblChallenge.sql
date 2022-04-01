CREATE TABLE [dbo].[tblChallenge] (
    [ChallengeId]                  NVARCHAR (50) NOT NULL,
    [Time]                         TIME (7)      NOT NULL,
    [Date]                         DATE          NOT NULL,
    [LocationOfTheBasketballCourt] NVARCHAR (50) NOT NULL,
    [PlaceOfTeams]                 NVARCHAR (50) NOT NULL,
    [NumberOfTimeOrDateChanged]    INT           NULL,
    [IsChallengeComfirmed]         BIT           NULL,
    [IsChallengeFinished]          BIT           NULL,
    [VotesChallenger]              INT           NULL,
    [VotesChallenged]              INT           NULL,
    CONSTRAINT [PK_tblChallenge] PRIMARY KEY CLUSTERED ([ChallengeId] ASC)
);

