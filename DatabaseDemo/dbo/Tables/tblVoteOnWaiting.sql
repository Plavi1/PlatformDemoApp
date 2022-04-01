CREATE TABLE [dbo].[tblVoteOnWaiting] (
    [TeamId]               NVARCHAR (50) NOT NULL,
    [ChallengeId]          NVARCHAR (50) NOT NULL,
    [ExpiringDateForVotes] DATE          NOT NULL, 
    CONSTRAINT [PK_tblVoteOnWaiting] PRIMARY KEY ([TeamId]),
    CONSTRAINT [FK_tblVoteOnWaiting_ChallengeId] FOREIGN KEY ([ChallengeId]) REFERENCES [dbo].[tblChallenge] ([ChallengeId]) ON DELETE CASCADE,
    CONSTRAINT [FK_tblVoteOnWaiting_tblTeam] FOREIGN KEY ([TeamId]) REFERENCES [dbo].[tblTeam] ([TeamId]) ON DELETE CASCADE
);

