if not exists (select 1 from dbo.[tblTeam])
begin
	insert into dbo.[tblTeam] (ContactPhone, DateOfRegistration, IsInTop5, Lost,PasswordHash,Player1,Player2,Player3,Player4,TeamId,TeamName,Wins, PlaceThatTheTeamRepresents)
	values ('061525846', '2021-6-4', 0, NULL, 'adsa23-411', 'Mirko','Slavko','Jovan','Uros', 'dsadsa2321', 'Tim23', NULL, 'Surcin'),
	('064313245', '2021-6-4', 0, NULL, 'dasds-dsa2', 'Nemanja','Milos','Stefan','Dragan', 'dsadasd2133', 'Druzina', NULL, 'Dobanovci'),
	('063213134', '2021-6-7', 0, NULL, 'dsadsadg-21a', 'Steva','Marko','Jovan','Momcilo', 'gfdghfdg1321', 'Beraci Pamuka', NULL, 'Ugrinovci'),
	('062343243', '2021-6-10', 0, NULL, 'dghtefa-23s', 'Vuk','Vlada','Zarko','Milan', 'gfdgdawer23', 'Beda iz predgradja', NULL, 'Dobanovci'),
	('066564452', '2021-6-6', 0, NULL, 'dasgfdgsg-das', 'Mirko','Slavko','Jovan','Uros', 'dsadf2fd3221', 'KK Mega', NULL, 'Ugrinovci'),
	('0643255757', '2021-6-7', 0, NULL, 'ddssdddd23-33', 'Radovan','Steva','Vuk','Jovan', 'dsadkgkgkd336', 'Padavicari', NULL, 'Dobanovci'),
	('0654356666', '2021-6-12', 0, NULL, 'hjgddgrt-321', 'Stefan','Pedja','Danilo','Momcilo', 'gfdffff8321', 'Virtus', NULL, 'Ugrinovci'),
	('0611111111', '2021-6-11', 0, NULL, 'jkjkjkjgfq-aa', 'Darko','Predrag','Srdjan','Pavle', 'gfdgda442923', 'Tim33', NULL, 'Surcin'),
	('0654545455', '2021-6-1', 0, NULL, 'gfdgdghhhj44-3', 'Milorad','Slavko','Marko','Jovan', 'ddsaguiii3221', 'Sokic', NULL, 'Dobanovci')
end
GO
