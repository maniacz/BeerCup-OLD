USE [BeerCupData]
GO
DELETE FROM [dbo].[Battles]
GO
SET IDENTITY_INSERT [dbo].[Battles] ON 
GO
INSERT [dbo].[Battles] ([Id], [BattleStyle], [BattleStartTime], [BattleEndTime]) VALUES (1, N'Saison', CAST(N'2020-04-01T16:00:00.0000000' AS DateTime2), CAST(N'2020-04-01T20:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Battles] ([Id], [BattleStyle], [BattleStartTime], [BattleEndTime]) VALUES (2, N'Roggenbier', CAST(N'2020-05-01T16:00:00.0000000' AS DateTime2), CAST(N'2020-05-01T20:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Battles] ([Id], [BattleStyle], [BattleStartTime], [BattleEndTime]) VALUES (3, N'Black IPA', CAST(N'2020-06-01T16:00:00.0000000' AS DateTime2), CAST(N'2020-06-01T20:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Battles] OFF
GO
DELETE FROM [dbo].[Breweries]
GO
SET IDENTITY_INSERT [dbo].[Breweries] ON 
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (1, N'BroGar', N'Łukasz Kipka')
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (2, N'Venom ', N'Daniel Śledzikowski')
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (3, N'Hołda Chmielu', N'Artur i Iwona Lesiak')
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (4, N'Kozakov Brewery', N'Krzysztof Kozakow i Karolina Wach')
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (5, N'Citra', NULL)
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (6, N'Browar Terapeutyczny', NULL)
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (7, N'Blade Łyse Doktory', NULL)
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (8, N'Bastion', N'Łukasz Wróblewski')
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (9, N'Browar Nuta', NULL)
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (10, N'Browar Kazamat', NULL)
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (11, N'Browar Domowy HOPcy', NULL)
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (12, N'Garaż', N'Janusz Švach')
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (13, N'41103', NULL)
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (14, N'Wykipi czy wybuchnie', NULL)
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (15, N'Browar Kropla Chmielu', NULL)
GO
INSERT [dbo].[Breweries] ([Id], [BreweryName], [BreweryOwner]) VALUES (16, N'Mody Homw Brewery', N'Daniel Lempke')
GO
SET IDENTITY_INSERT [dbo].[Breweries] OFF
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (1, 4)
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (1, 6)
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (1, 7)
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (1, 8)
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (1, 10)
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (3, 1)
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (3, 2)
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (3, 3)
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (3, 5)
GO
INSERT [dbo].[BattleBreweries] ([BattleId], [BreweryId]) VALUES (3, 9)
GO
SET IDENTITY_INSERT [dbo].[BattlesVotes] ON 
GO
DELETE FROM [dbo].[BattlesVotes]
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (1, 8, 8, 8, CAST(N'2020-05-22T10:23:27.5633333' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (2, 3, 3, 3, CAST(N'2020-05-23T13:46:44.8041500' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (3, 3, 3, 4, CAST(N'2020-05-23T13:46:57.8142410' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (4, 0, 0, 0, CAST(N'2020-05-23T16:09:28.8900000' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (5, 0, 0, 0, CAST(N'2020-05-23T16:24:28.0100000' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (6, 0, 0, 0, CAST(N'2020-06-17T12:26:39.7866667' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (7, 0, 0, 0, CAST(N'2020-06-19T09:48:04.4100000' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (8, 0, 0, 0, CAST(N'2020-06-26T12:55:46.1533333' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (9, 0, 0, 0, CAST(N'2020-06-26T13:01:48.7066667' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (10, 0, 0, 0, CAST(N'2020-06-26T13:03:01.2266667' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (11, 0, 0, 0, CAST(N'2020-06-26T13:03:26.0700000' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (12, 0, 0, 0, CAST(N'2020-06-26T13:03:32.9833333' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (13, 0, 0, 0, CAST(N'2020-06-26T14:09:21.4233333' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (14, 0, 0, 0, CAST(N'2020-06-26T14:10:17.1600000' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (15, 0, 0, 0, CAST(N'2020-06-26T14:30:28.3866667' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (16, 0, 0, 0, CAST(N'2020-06-26T14:33:16.7233333' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (17, 0, 0, 0, CAST(N'2020-06-29T11:03:32.5266667' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (18, 3, 3, 1, CAST(N'2020-07-05T10:36:07.7976150' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (19, 3, 3, 1, CAST(N'2020-07-05T10:35:58.5823550' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (20, 3, 3, 2, CAST(N'2020-07-05T10:36:10.6360700' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (21, 3, 3, 1, CAST(N'2020-07-25T13:13:01.4829250' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (22, 3, 3, 5, CAST(N'2020-07-25T13:13:21.3015110' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (23, 3, 3, 1, CAST(N'2020-07-25T13:13:21.3829290' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (24, 3, 3, 5, CAST(N'2020-07-25T13:13:21.4420990' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (25, 3, 3, 1, CAST(N'2020-07-25T13:13:21.4731580' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (26, 3, 3, 5, CAST(N'2020-07-25T13:13:21.5027220' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (27, 3, 3, 1, CAST(N'2020-08-14T13:42:18.7082540' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (28, 3, 3, 1, CAST(N'2020-08-14T13:42:18.7082540' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (29, 3, 3, 1, CAST(N'2020-08-14T13:42:18.7082540' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (30, 3, 3, 10, CAST(N'2020-08-14T13:42:18.7082540' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (31, 3, 3, 1, CAST(N'2020-08-14T14:50:35.0781860' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (32, 3, 3, 3, CAST(N'2020-08-14T14:50:55.4287880' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (33, 3, 3, 1, CAST(N'2020-08-16T13:02:38.5413040' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (34, 3, 3, 2, CAST(N'2020-08-16T13:02:47.0940580' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (35, 3, 3, 1, CAST(N'2020-10-24T10:33:13.3342980' AS DateTime2))
GO
INSERT [dbo].[BattlesVotes] ([Id], [BattleId], [VoterId], [BeerNumber], [CTime]) VALUES (36, 3, 3, 3, CAST(N'2020-10-24T10:33:35.9694010' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[BattlesVotes] OFF
GO
DELETE FROM [dbo].[CurrentBattle]
GO
INSERT [dbo].[CurrentBattle] ([Lock], [BattleId]) VALUES (N'X', 3)
GO
DELETE FROM [dbo].[Users]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([Id], [UserName], [Password]) VALUES (1, N'Grzegorz Jarzyna', N'Ze Szczecina')
GO
INSERT [dbo].[Users] ([Id], [UserName], [Password]) VALUES (2, N'Ralf', N'Loren')
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
