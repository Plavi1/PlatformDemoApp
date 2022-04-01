CREATE TABLE [dbo].[tblTeamInChallenge] (
    [ChallengeId]      NVARCHAR (50) NOT NULL,
    [ChallengerTeamId] NVARCHAR (50) NOT NULL,
    [ChallengedTeamId] NVARCHAR (50) NOT NULL,
    [EventId]          INT           NOT NULL,
    CONSTRAINT [PK_tblTeamInChallenge_1] PRIMARY KEY CLUSTERED ([ChallengeId] ASC),
    CONSTRAINT [FK_tblTeamInChallenge_ChallengedTeamId] FOREIGN KEY ([ChallengedTeamId]) REFERENCES [dbo].[tblTeam] ([TeamId]) ON UPDATE CASCADE,
    CONSTRAINT [FK_tblTeamInChallenge_ChallengerTeamId] FOREIGN KEY ([ChallengerTeamId]) REFERENCES [dbo].[tblTeam] ([TeamId]) ON DELETE CASCADE,
    CONSTRAINT [FK_tblTeamInChallenge_tblChallenge] FOREIGN KEY ([ChallengeId]) REFERENCES [dbo].[tblChallenge] ([ChallengeId]) ON DELETE CASCADE,
    CONSTRAINT [FK_tblTeamInChallenge_tblEvent] FOREIGN KEY ([EventId]) REFERENCES [dbo].[tblEvent] ([EventId]) ON DELETE CASCADE
);

