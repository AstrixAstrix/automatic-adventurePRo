﻿CREATE TABLE [test].[AuditRecords] (
    [Id]                          INT              IDENTITY (1, 1) NOT NULL,
    [RunNumber]                   UNIQUEIDENTIFIER NOT NULL,
    [RunDate]                     DATE             NOT NULL,
    [CompanyId]                   INT              NOT NULL,
    [EquipmentSetupId]            INT              NOT NULL,
    [BillingOrEquipmentIndicator] BIT              NOT NULL,
    [ExternalAccountId]           NVARCHAR (36)    NULL,
    [ExternalServiceId]           NVARCHAR (36)    NULL,
    [ExternalItemId]              NVARCHAR (36)    NULL,
    [ItemTypeId]                  INT              NOT NULL,
    [RecordKey]                   NVARCHAR (50)    NOT NULL,
    [RecordType]                  NVARCHAR (50)    NOT NULL,
    [RecordValue]                 NVARCHAR (200)   NOT NULL,
    [Ignore]                      BIT              NULL,
    [MatchId]                     UNIQUEIDENTIFIER NULL,
    [AddToEquiment]               BIT              NULL,
    [AddToBilling]                BIT              NULL,
    [ModifiedByUser]              NVARCHAR (20)    NOT NULL,
    [CreatedByUser]               NVARCHAR (20)    NOT NULL,
    [DateCreated]                 DATETIME2 (7)    NOT NULL,
    [DateModified]                DATETIME2 (7)    NOT NULL,
    [Version]                     INT              NOT NULL,
    CONSTRAINT [PK_AuditRecords] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_test_AuditRecords_Companies] FOREIGN KEY ([CompanyId]) REFERENCES [test].[Companies] ([Id]),
    CONSTRAINT [FK_test_AuditRecords_EquipmentSetup] FOREIGN KEY ([EquipmentSetupId]) REFERENCES [test].[EquipmentSetup] ([Id]),
    CONSTRAINT [FK_test_AuditRecords_ItemTypeEnum] FOREIGN KEY ([ItemTypeId]) REFERENCES [test].[ItemTypeEnum] ([Id])
);

