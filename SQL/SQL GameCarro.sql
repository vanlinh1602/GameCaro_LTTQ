create database GameCaro
go
use GameCaro
go

create table Player
(
   name nvarchar(20),
   PRIMARY KEY (name)
)
go

create table HistoryGacha
(
	name nvarchar(20),
	Date smalldatetime,
	items nvarchar(20),
	FOREIGN KEY (name) REFERENCES Player(name)
)
go

create table History
(
	Date smalldatetime,
	player1 nvarchar(20),
	point1 int,
	point2 int,
	player2 nvarchar(20),
	PRIMARY KEY (Date, player1, player2),
	FOREIGN KEY (player1) REFERENCES Player(name),
	FOREIGN KEY (player2) REFERENCES Player(name)
)
go