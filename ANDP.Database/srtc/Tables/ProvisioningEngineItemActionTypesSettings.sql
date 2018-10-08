﻿CREATE TABLE [srtc].[ProvisioningEngineItemActionTypesSettings] (
    [Id]                           INT           IDENTITY (1, 1) NOT NULL,
    [ProvisioningEngineSettingsId] INT           NOT NULL,
    [ActionTypeEnumId]             INT           NOT NULL,
    [ItemTypeEnumId]               INT           NOT NULL,
    [CreatedByUser]                NVARCHAR (20) NOT NULL,
    [ModifiedByUser]               NVARCHAR (20) NOT NULL,
    [DateCreated]                  DATETIME2 (7) NOT NULL,
    [DateModified]                 DATETIME2 (7) NOT NULL,
    [Version]                      INT           NOT NULL,
    CONSTRAINT [PK_ProvisioningEngineItemActionTypesSettings] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_srtc_ProvisioningEngineItemActionTypesSettings_ActionTypeEnum] FOREIGN KEY ([ActionTypeEnumId]) REFERENCES [srtc].[ActionTypeEnum] ([Id]),
    CONSTRAINT [FK_srtc_ProvisioningEngineItemActionTypesSettings_ItemTypeEnum] FOREIGN KEY ([ItemTypeEnumId]) REFERENCES [srtc].[ItemTypeEnum] ([Id]),
    CONSTRAINT [FK_srtc_ProvisioningEngineItemActionTypesSettings_ProvisioningEngineSettings] FOREIGN KEY ([ProvisioningEngineSettingsId]) REFERENCES [srtc].[ProvisioningEngineSettings] ([Id])
);

