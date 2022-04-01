CREATE TABLE [dbo].[tblReport] (
    [ReportId]       INT            IDENTITY (1, 1) NOT NULL,
    [ReportedTeamId] NVARCHAR (50)  NOT NULL,
    [SenderTeamId]   NVARCHAR (50)  NOT NULL,
    [ReportMessage]  NVARCHAR (250) NOT NULL,
    CONSTRAINT [PK_tblReport] PRIMARY KEY CLUSTERED ([ReportId] ASC),
    CONSTRAINT [FK_tblReport_tblTeam] FOREIGN KEY ([ReportedTeamId]) REFERENCES [dbo].[tblTeam] ([TeamId]) ON DELETE CASCADE
);

