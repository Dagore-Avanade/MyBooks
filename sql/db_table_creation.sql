use Library;

GO

CREATE TABLE [Genres]
(
	[GenreId]			INT IDENTITY(1,1) PRIMARY KEY,
	[Name]				NVARCHAR(50)
);

GO

CREATE TABLE [Authors]
(
	[AuthorId]			INT IDENTITY(1,1) PRIMARY KEY,
	[FirstName]			NVARCHAR(50) NOT NULL,
	[LastName]			NVARCHAR(50) NOT NULL,
	[Country]			NVARCHAR(100) NOT NULL,
	[DateOfBirth]		DATE NOT NULL,
	[DateOfDeath]		DATE
);

GO

CREATE TABLE [Books]
(
	[BookId]			INT IDENTITY(1, 1) PRIMARY KEY,
	[Title]				NVARCHAR(100) NOT NULL,
	[PublicationDate]	DATE NOT NULL,
	[NumberOfPages]		INT NOT NULL,
	[Description]		NVARCHAR(300) DEFAULT '',
	[AuthorId]			INT FOREIGN KEY REFERENCES Authors(AuthorId),
	[GenreId]			INT FOREIGN KEY REFERENCES Genres(GenreId)
);
