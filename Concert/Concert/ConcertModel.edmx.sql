
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/31/2011 15:23:29
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

IF OBJECT_ID(N'[dbo].[FK_AlbumTrack]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Track] DROP CONSTRAINT [FK_AlbumTrack];
GO
IF OBJECT_ID(N'[dbo].[FK_ArtistBand_Artist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArtistBand] DROP CONSTRAINT [FK_ArtistBand_Artist];
GO
IF OBJECT_ID(N'[dbo].[FK_ArtistBand_Band]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArtistBand] DROP CONSTRAINT [FK_ArtistBand_Band];
GO
IF OBJECT_ID(N'[dbo].[FK_BandAlbum]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Album] DROP CONSTRAINT [FK_BandAlbum];
GO
IF OBJECT_ID(N'[dbo].[FK_ConcertBand_Band]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConcertBand] DROP CONSTRAINT [FK_ConcertBand_Band];
GO
IF OBJECT_ID(N'[dbo].[FK_ConcertBand_Concert]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConcertBand] DROP CONSTRAINT [FK_ConcertBand_Concert];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Location] DROP CONSTRAINT [FK_CountryLocation];
GO
IF OBJECT_ID(N'[dbo].[FK_InstrumentArtist_Artist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InstrumentArtist] DROP CONSTRAINT [FK_InstrumentArtist_Artist];
GO
IF OBJECT_ID(N'[dbo].[FK_InstrumentArtist_Instrument]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InstrumentArtist] DROP CONSTRAINT [FK_InstrumentArtist_Instrument];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationConcert]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Concert] DROP CONSTRAINT [FK_LocationConcert];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Album]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Album];
GO
IF OBJECT_ID(N'[dbo].[Artist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Artist];
GO
IF OBJECT_ID(N'[dbo].[ArtistBand]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArtistBand];
GO
IF OBJECT_ID(N'[dbo].[Band]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Band];
GO
IF OBJECT_ID(N'[dbo].[Concert]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Concert];
GO
IF OBJECT_ID(N'[dbo].[ConcertBand]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConcertBand];
GO
IF OBJECT_ID(N'[dbo].[Country]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Country];
GO
IF OBJECT_ID(N'[dbo].[Instrument]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Instrument];
GO
IF OBJECT_ID(N'[dbo].[InstrumentArtist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InstrumentArtist];
GO
IF OBJECT_ID(N'[dbo].[Location]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Location];
GO
IF OBJECT_ID(N'[dbo].[Track]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Track];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Album'
CREATE TABLE [dbo].[Album] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Band_Id] int  NULL
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
    [Location_Id] int  NULL
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
    [PostalCode] int  NOT NULL,
    [Country_Id] int  NULL
);
GO

-- Creating table 'Track'
CREATE TABLE [dbo].[Track] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Length] int  NOT NULL,
    [Uploaded] bit  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Album_Id] int  NULL
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