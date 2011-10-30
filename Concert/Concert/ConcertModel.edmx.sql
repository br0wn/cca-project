
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/29/2011 12:00:01
-- Generated from EDMX file: C:\Users\vrabac\Downloads\Dropbox\Projects\NMBP\Concert\Concert\ConcertModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Concert];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[test].[FK_AlbumTrack]', 'F') IS NOT NULL
    ALTER TABLE [test].[trackset] DROP CONSTRAINT [FK_AlbumTrack];
GO
IF OBJECT_ID(N'[test].[FK_BandAlbum]', 'F') IS NOT NULL
    ALTER TABLE [test].[albumset] DROP CONSTRAINT [FK_BandAlbum];
GO
IF OBJECT_ID(N'[test].[FK_CountryLocation]', 'F') IS NOT NULL
    ALTER TABLE [test].[locationset] DROP CONSTRAINT [FK_CountryLocation];
GO
IF OBJECT_ID(N'[test].[FK_LocationConcert]', 'F') IS NOT NULL
    ALTER TABLE [test].[concertset] DROP CONSTRAINT [FK_LocationConcert];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[test].[albumset]', 'U') IS NOT NULL
    DROP TABLE [test].[albumset];
GO
IF OBJECT_ID(N'[test].[artistset]', 'U') IS NOT NULL
    DROP TABLE [test].[artistset];
GO
IF OBJECT_ID(N'[test].[bandset]', 'U') IS NOT NULL
    DROP TABLE [test].[bandset];
GO
IF OBJECT_ID(N'[test].[concertset]', 'U') IS NOT NULL
    DROP TABLE [test].[concertset];
GO
IF OBJECT_ID(N'[test].[countryset]', 'U') IS NOT NULL
    DROP TABLE [test].[countryset];
GO
IF OBJECT_ID(N'[test].[locationset]', 'U') IS NOT NULL
    DROP TABLE [test].[locationset];
GO
IF OBJECT_ID(N'[test].[trackset]', 'U') IS NOT NULL
    DROP TABLE [test].[trackset];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Album'
CREATE TABLE [dbo].[Album] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Band_Id] int  NOT NULL
);
GO

-- Creating table 'Artist'
CREATE TABLE [dbo].[Artist] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL
);
GO

-- Creating table 'Band'
CREATE TABLE [dbo].[Band] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Concert'
CREATE TABLE [dbo].[Concert] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [TicketPrice] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Location_Id] int  NOT NULL
);
GO

-- Creating table 'Country'
CREATE TABLE [dbo].[Country] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Location'
CREATE TABLE [dbo].[Location] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [SeatCount] int  NOT NULL,
    [Country_Id] int  NOT NULL
);
GO

-- Creating table 'Track'
CREATE TABLE [dbo].[Track] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Length] int  NOT NULL,
    [Album_Id] int  NOT NULL
);
GO

-- Creating table 'Instrument'
CREATE TABLE [dbo].[Instrument] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InstrumentArtist'
CREATE TABLE [dbo].[InstrumentArtist] (
    [Instrument_Id] int  NOT NULL,
    [Artist_Id] int  NOT NULL
);
GO

-- Creating table 'ArtistBand'
CREATE TABLE [dbo].[ArtistBand] (
    [Artist_Id] int  NOT NULL,
    [Band_Id] int  NOT NULL
);
GO

-- Creating table 'ConcertBand'
CREATE TABLE [dbo].[ConcertBand] (
    [Concert_Id] int  NOT NULL,
    [Band_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Album'
ALTER TABLE [dbo].[Album]
ADD CONSTRAINT [PK_Album]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Artist'
ALTER TABLE [dbo].[Artist]
ADD CONSTRAINT [PK_Artist]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Band'
ALTER TABLE [dbo].[Band]
ADD CONSTRAINT [PK_Band]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Concert'
ALTER TABLE [dbo].[Concert]
ADD CONSTRAINT [PK_Concert]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Country'
ALTER TABLE [dbo].[Country]
ADD CONSTRAINT [PK_Country]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Location'
ALTER TABLE [dbo].[Location]
ADD CONSTRAINT [PK_Location]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Track'
ALTER TABLE [dbo].[Track]
ADD CONSTRAINT [PK_Track]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Instrument'
ALTER TABLE [dbo].[Instrument]
ADD CONSTRAINT [PK_Instrument]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Instrument_Id], [Artist_Id] in table 'InstrumentArtist'
ALTER TABLE [dbo].[InstrumentArtist]
ADD CONSTRAINT [PK_InstrumentArtist]
    PRIMARY KEY NONCLUSTERED ([Instrument_Id], [Artist_Id] ASC);
GO

-- Creating primary key on [Artist_Id], [Band_Id] in table 'ArtistBand'
ALTER TABLE [dbo].[ArtistBand]
ADD CONSTRAINT [PK_ArtistBand]
    PRIMARY KEY NONCLUSTERED ([Artist_Id], [Band_Id] ASC);
GO

-- Creating primary key on [Concert_Id], [Band_Id] in table 'ConcertBand'
ALTER TABLE [dbo].[ConcertBand]
ADD CONSTRAINT [PK_ConcertBand]
    PRIMARY KEY NONCLUSTERED ([Concert_Id], [Band_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Instrument_Id] in table 'InstrumentArtist'
ALTER TABLE [dbo].[InstrumentArtist]
ADD CONSTRAINT [FK_InstrumentArtist_Instrument]
    FOREIGN KEY ([Instrument_Id])
    REFERENCES [dbo].[Instrument]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Artist_Id] in table 'InstrumentArtist'
ALTER TABLE [dbo].[InstrumentArtist]
ADD CONSTRAINT [FK_InstrumentArtist_Artist]
    FOREIGN KEY ([Artist_Id])
    REFERENCES [dbo].[Artist]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_InstrumentArtist_Artist'
CREATE INDEX [IX_FK_InstrumentArtist_Artist]
ON [dbo].[InstrumentArtist]
    ([Artist_Id]);
GO

-- Creating foreign key on [Band_Id] in table 'Album'
ALTER TABLE [dbo].[Album]
ADD CONSTRAINT [FK_BandAlbum]
    FOREIGN KEY ([Band_Id])
    REFERENCES [dbo].[Band]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BandAlbum'
CREATE INDEX [IX_FK_BandAlbum]
ON [dbo].[Album]
    ([Band_Id]);
GO

-- Creating foreign key on [Album_Id] in table 'Track'
ALTER TABLE [dbo].[Track]
ADD CONSTRAINT [FK_AlbumTrack]
    FOREIGN KEY ([Album_Id])
    REFERENCES [dbo].[Album]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AlbumTrack'
CREATE INDEX [IX_FK_AlbumTrack]
ON [dbo].[Track]
    ([Album_Id]);
GO

-- Creating foreign key on [Artist_Id] in table 'ArtistBand'
ALTER TABLE [dbo].[ArtistBand]
ADD CONSTRAINT [FK_ArtistBand_Artist]
    FOREIGN KEY ([Artist_Id])
    REFERENCES [dbo].[Artist]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Band_Id] in table 'ArtistBand'
ALTER TABLE [dbo].[ArtistBand]
ADD CONSTRAINT [FK_ArtistBand_Band]
    FOREIGN KEY ([Band_Id])
    REFERENCES [dbo].[Band]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ArtistBand_Band'
CREATE INDEX [IX_FK_ArtistBand_Band]
ON [dbo].[ArtistBand]
    ([Band_Id]);
GO

-- Creating foreign key on [Country_Id] in table 'Location'
ALTER TABLE [dbo].[Location]
ADD CONSTRAINT [FK_CountryLocation]
    FOREIGN KEY ([Country_Id])
    REFERENCES [dbo].[Country]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryLocation'
CREATE INDEX [IX_FK_CountryLocation]
ON [dbo].[Location]
    ([Country_Id]);
GO

-- Creating foreign key on [Location_Id] in table 'Concert'
ALTER TABLE [dbo].[Concert]
ADD CONSTRAINT [FK_LocationConcert]
    FOREIGN KEY ([Location_Id])
    REFERENCES [dbo].[Location]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationConcert'
CREATE INDEX [IX_FK_LocationConcert]
ON [dbo].[Concert]
    ([Location_Id]);
GO

-- Creating foreign key on [Concert_Id] in table 'ConcertBand'
ALTER TABLE [dbo].[ConcertBand]
ADD CONSTRAINT [FK_ConcertBand_Concert]
    FOREIGN KEY ([Concert_Id])
    REFERENCES [dbo].[Concert]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Band_Id] in table 'ConcertBand'
ALTER TABLE [dbo].[ConcertBand]
ADD CONSTRAINT [FK_ConcertBand_Band]
    FOREIGN KEY ([Band_Id])
    REFERENCES [dbo].[Band]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConcertBand_Band'
CREATE INDEX [IX_FK_ConcertBand_Band]
ON [dbo].[ConcertBand]
    ([Band_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------