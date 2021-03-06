﻿using System;
using Common.Lib.Mapping;

namespace ANDP.Provisioning.API.Rest.Models.ApMax.MappingProfiles
{
    public class VoiceMailBoxType : CommonMappingProfile
    {
        protected override void Configure()
        {
            CreateMap<API.Rest.Models.ApMax.VoiceMailBoxType, Common.VoicemailV3.VoiceMailBoxType>()
                .ForMember(dest => dest.ExtensionData, opt => opt.Ignore())
                .ForMember(dest => dest.ActiveGreetingField, opt => opt.Ignore())
                .ForMember(dest => dest.AdminEntryPointField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowBroadcastMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowDailyScheduleField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowEmailDeletionField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowForwardingMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowFutureDeliveryField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowHolidayScheduleField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowInitialActionsField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowOutdialField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowOutdialListEditField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowPagerNotificationField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowRecordingField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowSendingMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowSpecificCallerField, opt => opt.Ignore())
                .ForMember(dest => dest.AutoForwardAddressField, opt => opt.Ignore())
                .ForMember(dest => dest.AutoForwardMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AutoForwardTypeField, opt => opt.Ignore())
                .ForMember(dest => dest.CallScreeningDelayField, opt => opt.Ignore())
                .ForMember(dest => dest.CallScreeningField, opt => opt.Ignore())
                .ForMember(dest => dest.CallingPartyField, opt => opt.Ignore())
                .ForMember(dest => dest.ChargeNumberField, opt => opt.Ignore())
                .ForMember(dest => dest.ChildListField, opt => opt.Ignore())
                .ForMember(dest => dest.DailyNotificationStatusField, opt => opt.Ignore())
                .ForMember(dest => dest.DailyNotificationTimeField, opt => opt.Ignore())
                .ForMember(dest => dest.DefaultInitialActionField, opt => opt.Ignore())
                .ForMember(dest => dest.DeleteShortKnownField, opt => opt.Ignore())
                .ForMember(dest => dest.DeleteShortUnknownField, opt => opt.Ignore())
                .ForMember(dest => dest.DescriptionField, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.DirectoryField, opt => opt.Ignore())
                .ForMember(dest => dest.DistributionListField, opt => opt.Ignore())
                .ForMember(dest => dest.EmailOnlyField, opt => opt.Ignore())
                .ForMember(dest => dest.EmailcodecTypeField, opt => opt.Ignore())
                .ForMember(dest => dest.ForceLanguageChoiceField, opt => opt.Ignore())
                .ForMember(dest => dest.ForcePasswordChangeField, opt => opt.Ignore())
                .ForMember(dest => dest.ForwardingListField, opt => opt.Ignore())
                .ForMember(dest => dest.GreetingFilenameField, opt => opt.Ignore())
                .ForMember(dest => dest.GreetingInterruptField, opt => opt.Ignore())
                .ForMember(dest => dest.GreetingListField, opt => opt.Ignore())
                .ForMember(dest => dest.HolidayListField, opt => opt.Ignore())
                .ForMember(dest => dest.IdField, opt => opt.Ignore())
                .ForMember(dest => dest.InitialActionListField, opt => opt.Ignore())
                .ForMember(dest => dest.InterPageDelayField, opt => opt.Ignore())
                .ForMember(dest => dest.LanguageField, opt => opt.Ignore())
                .ForMember(dest => dest.LastAccessField, opt => opt.Ignore())
                .ForMember(dest => dest.LoggingLevelField, opt => opt.Ignore())
                .ForMember(dest => dest.LoginField, opt => opt.Ignore())
                .ForMember(dest => dest.MailboxTypeField, opt => opt.MapFrom(src => Enum.Parse(typeof(Common.VoicemailV3.MailboxType), src.MailBoxType.ToString(), true)))
                .ForMember(dest => dest.MaxDistributionListsField, opt => opt.Ignore())
                .ForMember(dest => dest.MaxMailboxTimeField, opt => opt.MapFrom(src => src.MaxMailBoxTime))
                .ForMember(dest => dest.MaxMessageLengthField, opt => opt.MapFrom(src => src.MaxMessageLength))
                .ForMember(dest => dest.MaxMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.MaxSubmailboxesField, opt => opt.Ignore())
                .ForMember(dest => dest.MessageCountField, opt => opt.MapFrom(src => src.MessageCount))
                .ForMember(dest => dest.MessageListField, opt => opt.Ignore())
                .ForMember(dest => dest.MessagePlaybackOrderField, opt => opt.Ignore())
                .ForMember(dest => dest.NameField, opt => opt.Ignore())
                .ForMember(dest => dest.NewMessageRetentionField, opt => opt.Ignore())
                .ForMember(dest => dest.NotificationListField, opt => opt.MapFrom(src => src.Notifications))
                .ForMember(dest => dest.OptionsPackageField, opt => opt.Ignore())
                .ForMember(dest => dest.PageSeqentialField, opt => opt.Ignore())
                .ForMember(dest => dest.PageUrgentOnlyField, opt => opt.Ignore())
                .ForMember(dest => dest.PagerAttemptsField, opt => opt.Ignore())
                .ForMember(dest => dest.PagerListField, opt => opt.Ignore())
                .ForMember(dest => dest.ParentListField, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordField, opt => opt.Ignore())
                .ForMember(dest => dest.PlayAfterPromptField, opt => opt.Ignore())
                .ForMember(dest => dest.PlayBusyGreetingField, opt => opt.Ignore())
                .ForMember(dest => dest.PrePageDelayField, opt => opt.Ignore())
                .ForMember(dest => dest.ReplyTypeField, opt => opt.Ignore())
                .ForMember(dest => dest.SavedMessageRetentionField, opt => opt.Ignore())
                .ForMember(dest => dest.ScheduleListField, opt => opt.Ignore())
                .ForMember(dest => dest.ScheduledDeletionDateField, opt => opt.Ignore())
                .ForMember(dest => dest.ShortMessageCriteriaField, opt => opt.Ignore())
                .ForMember(dest => dest.SpecificCallerListField, opt => opt.Ignore())
                .ForMember(dest => dest.SubscriberListField, opt => opt.Ignore())
                .ForMember(dest => dest.TimezoneField, opt => opt.Ignore())
                .ForMember(dest => dest.VideoMWIUpdateRateField, opt => opt.Ignore())
                ;

            CreateMap<API.Rest.Models.ApMax.VoiceMailBoxType, Common.VoicemailV4.VoiceMailBoxType>()
                .ForMember(dest => dest.ExtensionData, opt => opt.Ignore())
                .ForMember(dest => dest.ActiveGreetingField, opt => opt.Ignore())
                .ForMember(dest => dest.AdminEntryPointField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowBroadcastMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowDailyScheduleField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowEmailDeletionField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowForwardingMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowFutureDeliveryField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowHolidayScheduleField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowInitialActionsField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowOutdialField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowOutdialListEditField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowPagerNotificationField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowRecordingField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowSendingMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowSpecificCallerField, opt => opt.Ignore())
                .ForMember(dest => dest.AutoForwardAddressField, opt => opt.Ignore())
                .ForMember(dest => dest.AutoForwardMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AutoForwardTypeField, opt => opt.Ignore())
                .ForMember(dest => dest.CallScreeningDelayField, opt => opt.Ignore())
                .ForMember(dest => dest.CallScreeningField, opt => opt.Ignore())
                .ForMember(dest => dest.CallingPartyField, opt => opt.Ignore())
                .ForMember(dest => dest.ChargeNumberField, opt => opt.Ignore())
                .ForMember(dest => dest.ChildListField, opt => opt.Ignore())
                .ForMember(dest => dest.DailyNotificationStatusField, opt => opt.Ignore())
                .ForMember(dest => dest.DailyNotificationTimeField, opt => opt.Ignore())
                .ForMember(dest => dest.DefaultInitialActionField, opt => opt.Ignore())
                .ForMember(dest => dest.DeleteShortKnownField, opt => opt.Ignore())
                .ForMember(dest => dest.DeleteShortUnknownField, opt => opt.Ignore())
                .ForMember(dest => dest.DescriptionField, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.DirectoryField, opt => opt.Ignore())
                .ForMember(dest => dest.DistributionListField, opt => opt.Ignore())
                .ForMember(dest => dest.EmailOnlyField, opt => opt.Ignore())
                .ForMember(dest => dest.EmailcodecTypeField, opt => opt.Ignore())
                .ForMember(dest => dest.ForceLanguageChoiceField, opt => opt.Ignore())
                .ForMember(dest => dest.ForcePasswordChangeField, opt => opt.Ignore())
                .ForMember(dest => dest.ForwardingListField, opt => opt.Ignore())
                .ForMember(dest => dest.GreetingFilenameField, opt => opt.Ignore())
                .ForMember(dest => dest.GreetingInterruptField, opt => opt.Ignore())
                .ForMember(dest => dest.GreetingListField, opt => opt.Ignore())
                .ForMember(dest => dest.HolidayListField, opt => opt.Ignore())
                .ForMember(dest => dest.IdField, opt => opt.Ignore())
                .ForMember(dest => dest.InitialActionListField, opt => opt.Ignore())
                .ForMember(dest => dest.InterPageDelayField, opt => opt.Ignore())
                .ForMember(dest => dest.LanguageField, opt => opt.Ignore())
                .ForMember(dest => dest.LastAccessField, opt => opt.Ignore())
                .ForMember(dest => dest.LoggingLevelField, opt => opt.Ignore())
                .ForMember(dest => dest.LoginField, opt => opt.Ignore())
                .ForMember(dest => dest.MailboxTypeField, opt => opt.MapFrom(src => Enum.Parse(typeof(Common.VoicemailV3.MailboxType), src.MailBoxType.ToString(), true)))
                .ForMember(dest => dest.MaxDistributionListsField, opt => opt.Ignore())
                .ForMember(dest => dest.MaxMailboxTimeField, opt => opt.MapFrom(src => src.MaxMailBoxTime))
                .ForMember(dest => dest.MaxMessageLengthField, opt => opt.MapFrom(src => src.MaxMessageLength))
                .ForMember(dest => dest.MaxMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.MaxSubmailboxesField, opt => opt.Ignore())
                .ForMember(dest => dest.MessageCountField, opt => opt.MapFrom(src => src.MessageCount))
                .ForMember(dest => dest.MessageListField, opt => opt.Ignore())
                .ForMember(dest => dest.MessagePlaybackOrderField, opt => opt.Ignore())
                .ForMember(dest => dest.NameField, opt => opt.Ignore())
                .ForMember(dest => dest.NewMessageRetentionField, opt => opt.Ignore())
                .ForMember(dest => dest.NotificationListField, opt => opt.MapFrom(src => src.Notifications))
                .ForMember(dest => dest.OptionsPackageField, opt => opt.Ignore())
                .ForMember(dest => dest.PageSeqentialField, opt => opt.Ignore())
                .ForMember(dest => dest.PageUrgentOnlyField, opt => opt.Ignore())
                .ForMember(dest => dest.PagerAttemptsField, opt => opt.Ignore())
                .ForMember(dest => dest.PagerListField, opt => opt.Ignore())
                .ForMember(dest => dest.ParentListField, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordField, opt => opt.Ignore())
                .ForMember(dest => dest.PlayAfterPromptField, opt => opt.Ignore())
                .ForMember(dest => dest.PlayBusyGreetingField, opt => opt.Ignore())
                .ForMember(dest => dest.PrePageDelayField, opt => opt.Ignore())
                .ForMember(dest => dest.ReplyTypeField, opt => opt.Ignore())
                .ForMember(dest => dest.SavedMessageRetentionField, opt => opt.Ignore())
                .ForMember(dest => dest.ScheduleListField, opt => opt.Ignore())
                .ForMember(dest => dest.ScheduledDeletionDateField, opt => opt.Ignore())
                .ForMember(dest => dest.ShortMessageCriteriaField, opt => opt.Ignore())
                .ForMember(dest => dest.SpecificCallerListField, opt => opt.Ignore())
                .ForMember(dest => dest.SubscriberListField, opt => opt.Ignore())
                .ForMember(dest => dest.TimezoneField, opt => opt.Ignore())
                .ForMember(dest => dest.VideoMWIUpdateRateField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowTemporaryGreetingsField, opt => opt.Ignore())
                .ForMember(dest => dest.ContinuousPlaybackField, opt => opt.Ignore())
                .ForMember(dest => dest.PlayEndOfMessageOptionField, opt => opt.Ignore())
                ;

            CreateMap<API.Rest.Models.ApMax.VoiceMailBoxType, Common.VoicemailV5.VoiceMailBoxType>()
                .ForMember(dest => dest.ExtensionData, opt => opt.Ignore())
                .ForMember(dest => dest.ActiveGreetingField, opt => opt.Ignore())
                .ForMember(dest => dest.AdminEntryPointField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowBroadcastMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowDailyScheduleField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowEmailDeletionField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowForwardingMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowFutureDeliveryField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowHolidayScheduleField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowInitialActionsField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowOutdialField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowOutdialListEditField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowPagerNotificationField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowRecordingField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowSendingMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowSpecificCallerField, opt => opt.Ignore())
                .ForMember(dest => dest.AutoForwardAddressField, opt => opt.Ignore())
                .ForMember(dest => dest.AutoForwardMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.AutoForwardTypeField, opt => opt.Ignore())
                .ForMember(dest => dest.CallScreeningDelayField, opt => opt.Ignore())
                .ForMember(dest => dest.CallScreeningField, opt => opt.Ignore())
                .ForMember(dest => dest.CallingPartyField, opt => opt.Ignore())
                .ForMember(dest => dest.ChargeNumberField, opt => opt.Ignore())
                .ForMember(dest => dest.ChildListField, opt => opt.Ignore())
                .ForMember(dest => dest.DailyNotificationStatusField, opt => opt.Ignore())
                .ForMember(dest => dest.DailyNotificationTimeField, opt => opt.Ignore())
                .ForMember(dest => dest.DefaultInitialActionField, opt => opt.Ignore())
                .ForMember(dest => dest.DeleteShortKnownField, opt => opt.Ignore())
                .ForMember(dest => dest.DeleteShortUnknownField, opt => opt.Ignore())
                .ForMember(dest => dest.DescriptionField, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.DirectoryField, opt => opt.Ignore())
                .ForMember(dest => dest.DistributionListField, opt => opt.Ignore())
                .ForMember(dest => dest.EmailOnlyField, opt => opt.Ignore())
                .ForMember(dest => dest.EmailcodecTypeField, opt => opt.Ignore())
                .ForMember(dest => dest.ForceLanguageChoiceField, opt => opt.Ignore())
                .ForMember(dest => dest.ForcePasswordChangeField, opt => opt.Ignore())
                .ForMember(dest => dest.ForwardingListField, opt => opt.Ignore())
                .ForMember(dest => dest.GreetingFilenameField, opt => opt.Ignore())
                .ForMember(dest => dest.GreetingInterruptField, opt => opt.Ignore())
                .ForMember(dest => dest.GreetingListField, opt => opt.Ignore())
                .ForMember(dest => dest.HolidayListField, opt => opt.Ignore())
                .ForMember(dest => dest.IdField, opt => opt.Ignore())
                .ForMember(dest => dest.InitialActionListField, opt => opt.Ignore())
                .ForMember(dest => dest.InterPageDelayField, opt => opt.Ignore())
                .ForMember(dest => dest.LanguageField, opt => opt.Ignore())
                .ForMember(dest => dest.LastAccessField, opt => opt.Ignore())
                .ForMember(dest => dest.LoggingLevelField, opt => opt.Ignore())
                .ForMember(dest => dest.LoginField, opt => opt.Ignore())
                .ForMember(dest => dest.MailboxTypeField, opt => opt.MapFrom(src => Enum.Parse(typeof(Common.VoicemailV3.MailboxType), src.MailBoxType.ToString(), true)))
                .ForMember(dest => dest.MaxDistributionListsField, opt => opt.Ignore())
                .ForMember(dest => dest.MaxMailboxTimeField, opt => opt.MapFrom(src => src.MaxMailBoxTime))
                .ForMember(dest => dest.MaxMessageLengthField, opt => opt.MapFrom(src => src.MaxMessageLength))
                .ForMember(dest => dest.MaxMessagesField, opt => opt.Ignore())
                .ForMember(dest => dest.MaxSubmailboxesField, opt => opt.Ignore())
                .ForMember(dest => dest.MessageCountField, opt => opt.MapFrom(src => src.MessageCount))
                .ForMember(dest => dest.MessageListField, opt => opt.Ignore())
                .ForMember(dest => dest.MessagePlaybackOrderField, opt => opt.Ignore())
                .ForMember(dest => dest.NameField, opt => opt.Ignore())
                .ForMember(dest => dest.NewMessageRetentionField, opt => opt.Ignore())
                .ForMember(dest => dest.NotificationListField, opt => opt.MapFrom(src => src.Notifications))
                .ForMember(dest => dest.OptionsPackageField, opt => opt.Ignore())
                .ForMember(dest => dest.PageSeqentialField, opt => opt.Ignore())
                .ForMember(dest => dest.PageUrgentOnlyField, opt => opt.Ignore())
                .ForMember(dest => dest.PagerAttemptsField, opt => opt.Ignore())
                .ForMember(dest => dest.PagerListField, opt => opt.Ignore())
                .ForMember(dest => dest.ParentListField, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordField, opt => opt.Ignore())
                .ForMember(dest => dest.PlayAfterPromptField, opt => opt.Ignore())
                .ForMember(dest => dest.PlayBusyGreetingField, opt => opt.Ignore())
                .ForMember(dest => dest.PrePageDelayField, opt => opt.Ignore())
                .ForMember(dest => dest.ReplyTypeField, opt => opt.Ignore())
                .ForMember(dest => dest.SavedMessageRetentionField, opt => opt.Ignore())
                .ForMember(dest => dest.ScheduleListField, opt => opt.Ignore())
                .ForMember(dest => dest.ScheduledDeletionDateField, opt => opt.Ignore())
                .ForMember(dest => dest.ShortMessageCriteriaField, opt => opt.Ignore())
                .ForMember(dest => dest.SpecificCallerListField, opt => opt.Ignore())
                .ForMember(dest => dest.SubscriberListField, opt => opt.Ignore())
                .ForMember(dest => dest.TimezoneField, opt => opt.Ignore())
                .ForMember(dest => dest.VideoMWIUpdateRateField, opt => opt.Ignore())
                .ForMember(dest => dest.AllowTemporaryGreetingsField, opt => opt.Ignore())
                .ForMember(dest => dest.ContinuousPlaybackField, opt => opt.Ignore())
                .ForMember(dest => dest.PlayEndOfMessageOptionField, opt => opt.Ignore())
                .ForMember(dest => dest.AinTriggers, opt => opt.Ignore())
                .ForMember(dest => dest.AppleVisualVoicemail, opt => opt.Ignore())
                .ForMember(dest => dest.BillingServiceID, opt => opt.Ignore())
                .ForMember(dest => dest.Disabled, opt => opt.Ignore())
                .ForMember(dest => dest.EmailNotificationDisabledField, opt => opt.Ignore())
                .ForMember(dest => dest.MaxRegisteredRemoteDevicesField, opt => opt.Ignore())
                .ForMember(dest => dest.MinimumPasswordLengthField, opt => opt.Ignore())
                .ForMember(dest => dest.NewMessageSortOrderField, opt => opt.Ignore())
                .ForMember(dest => dest.SavedMessageSortOrderField, opt => opt.Ignore())
                .ForMember(dest => dest.SingleGreetingMenusField, opt => opt.Ignore())
                .ForMember(dest => dest.VoiceTranscriptionField, opt => opt.Ignore())
                ;

            CreateMap<Common.VoicemailV3.VoiceMailBoxType, API.Rest.Models.ApMax.VoiceMailBoxType>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.DescriptionField))
                .ForMember(dest => dest.MailBoxType, opt => opt.MapFrom(src => src.MailboxTypeField))
                .ForMember(dest => dest.MaxMailBoxTime, opt => opt.MapFrom(src => src.MaxMailboxTimeField))
                .ForMember(dest => dest.MaxMessageLength, opt => opt.MapFrom(src => src.MaxMessageLengthField))
                .ForMember(dest => dest.MessageCount, opt => opt.MapFrom(src => src.MessageCountField))
                .ForMember(dest => dest.Notifications, opt => opt.MapFrom(src => src.NotificationListField))
                ;

            CreateMap<Common.VoicemailV4.VoiceMailBoxType, API.Rest.Models.ApMax.VoiceMailBoxType>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.DescriptionField))
                .ForMember(dest => dest.MailBoxType, opt => opt.MapFrom(src => src.MailboxTypeField))
                .ForMember(dest => dest.MaxMailBoxTime, opt => opt.MapFrom(src => src.MaxMailboxTimeField))
                .ForMember(dest => dest.MaxMessageLength, opt => opt.MapFrom(src => src.MaxMessageLengthField))
                .ForMember(dest => dest.MessageCount, opt => opt.MapFrom(src => src.MessageCountField))
                .ForMember(dest => dest.Notifications, opt => opt.MapFrom(src => src.NotificationListField))
                ;

            CreateMap<Common.VoicemailV5.VoiceMailBoxType, API.Rest.Models.ApMax.VoiceMailBoxType>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.DescriptionField))
                .ForMember(dest => dest.MailBoxType, opt => opt.MapFrom(src => src.MailboxTypeField))
                .ForMember(dest => dest.MaxMailBoxTime, opt => opt.MapFrom(src => src.MaxMailboxTimeField))
                .ForMember(dest => dest.MaxMessageLength, opt => opt.MapFrom(src => src.MaxMessageLengthField))
                .ForMember(dest => dest.MessageCount, opt => opt.MapFrom(src => src.MessageCountField))
                .ForMember(dest => dest.Notifications, opt => opt.MapFrom(src => src.NotificationListField))
                ;
        }
    }
}