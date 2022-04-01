CREATE PROCEDURE [dbo].[spChallenge_GetAll]
AS
begin 
   SELECT *
   from dbo.[tblChallenge];
end