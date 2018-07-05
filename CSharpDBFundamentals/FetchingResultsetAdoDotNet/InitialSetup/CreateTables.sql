CREATE TABLE [Towns]
(
	[Id] INT PRIMARY KEY,
	[Name] VARCHAR(50),
	[Country] VARCHAR(50)
)

CREATE TABLE [Villains]
(
	[Id] INT PRIMARY KEY,
	[Name] VARCHAR(50),
	[EvilnessFactor] VARCHAR(10) CHECK([EvilnessFactor] IN ('good', 'bad', 'evil', 'super evil')),
)

CREATE TABLE [Minions]
(
	[Id] INT PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL,
	[Age] INT,
	[TownId] INT,
	CONSTRAINT fk_MinionsTowns FOREIGN KEY ([TownId])
	REFERENCES [Towns]([Id])
)

CREATE TABLE VillainMinions
(	
	[VillainId] INT,
	[MinionId] INT,
	CONSTRAINT PK_VillansMinions PRIMARY KEY ([VillanId],[MinionId])

)