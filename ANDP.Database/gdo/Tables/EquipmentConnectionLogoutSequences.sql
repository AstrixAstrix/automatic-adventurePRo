﻿CREATE TABLE [gdo].[EquipmentConnectionLogoutSequences] (
    [Id]                            INT            IDENTITY (1, 1) NOT NULL,
    [EquipmentConnectionSettingsId] INT            NOT NULL,
    [SequenceNumber]                INT            NOT NULL,
    [Command]                       NVARCHAR (100) NULL,
    [ExpectedResponse]              NVARCHAR (100) NULL,
    [Timeout]                       INT            NOT NULL,
    [CreatedByUser]                 NVARCHAR (20)  NOT NULL,
    [ModifiedByUser]                NVARCHAR (20)  NOT NULL,
    [DateCreated]                   DATETIME2 (7)  NOT NULL,
    [DateModified]                  DATETIME2 (7)  NOT NULL,
    [Version]                       INT            NOT NULL,
    CONSTRAINT [PK_EquipmentConnectionLogoutSequences] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_gdo_EquipmentConnectionLogoutSequences_EquipmentConnectionSettings] FOREIGN KEY ([EquipmentConnectionSettingsId]) REFERENCES [gdo].[EquipmentConnectionSettings] ([Id]),
    CONSTRAINT [AK_gdo_EquipmentConnectionLogoutSequences_EquipmentConnectionSettingsId_SequenceNumber] UNIQUE NONCLUSTERED ([EquipmentConnectionSettingsId] ASC, [SequenceNumber] ASC)
);

