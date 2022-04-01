CREATE TABLE [dbo].[tblTeam] (
    [TeamId]             NVARCHAR (50) NOT NULL,
    [TeamName]           NVARCHAR (50) NOT NULL,
    [PasswordHash]       NVARCHAR (50) NOT NULL,
    [ContactPhone]       INT           NOT NULL,
    [Player1]            NVARCHAR (50) NOT NULL,
    [Player2]            NVARCHAR (50) NOT NULL,
    [Player3]            NVARCHAR (50) NOT NULL,
    [Player4]            NVARCHAR (50) NOT NULL,
    [DateOfRegistration] DATE          NOT NULL,
    [Wins]               NVARCHAR (50) NULL,
    [Lost]               INT           NULL,
    [IsInTop5]           BIT           NULL,
    [PlaceThatTheTeamRepresents] NCHAR(50) NOT NULL, 
    CONSTRAINT [PK_tblTeam] PRIMARY KEY CLUSTERED ([TeamId] ASC)
);

