CREATE TABLE [dbo].[tblEvent] (
    [EventId]                    INT           IDENTITY (1, 1) NOT NULL,
    [Place]                      NVARCHAR (50) NOT NULL,
    [NumberOfTeamsInEvent]       INT           NOT NULL,
    [DateStart]                  DATE          NOT NULL,
    [DateEnd]                    DATE          NOT NULL,
    [NumberOfMatchesUntilTheEnd] INT           NOT NULL,
    [NumberOfMatchesPlayed]      INT           NOT NULL,
    [IsEventFinished]            BIT           NULL,
    CONSTRAINT [PK_tblEvent] PRIMARY KEY CLUSTERED ([EventId] ASC)
);

