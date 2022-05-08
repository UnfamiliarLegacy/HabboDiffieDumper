namespace DiffieDumper.Net.Packets;

public enum PacketS2C
{
    Unknown,
    
    // com.sulake.habbo.communication.messages.incoming.advertisement
    InterstitialMessageEvent,
    RoomAdErrorEvent,
        
    // com.sulake.habbo.communication.messages.incoming.availability
    AvailabilityStatusMessageEvent,
    AvailabilityTimeMessageEvent,
    InfoHotelClosedMessageEvent,
    InfoHotelClosingMessageEvent,
    LoginFailedHotelClosedMessageEvent,
    MaintenanceStatusMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.avatar
    ChangeUserNameResultMessageEvent,
    CheckUserNameResultMessageEvent,
    FigureUpdateEvent,
    WardrobeMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.callforhelp
    CfhSanctionMessageEvent,
    CfhTopicsInitMessageEvent,
    SanctionStatusEvent,
        
    // com.sulake.habbo.communication.messages.incoming.camera
    CameraPublishStatusMessageEvent,
    CameraPurchaseOKMessageEvent,
    CameraStorageUrlMessageEvent,
    CompetitionStatusMessageEvent,
    InitCameraMessageEvent,
    ThumbnailStatusMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.campaign
    CampaignCalendarDataMessageEvent,
    CampaignCalendarDoorOpenedMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.catalog
    BonusRareInfoMessageEvent,
    BuildersClubFurniCountMessageEvent,
    BuildersClubSubscriptionStatusMessageEvent,
    BundleDiscountRulesetMessageEvent,
    CatalogIndexMessageEvent,
    CatalogPageExpirationEvent,
    CatalogPageMessageEvent,
    CatalogPageWithEarliestExpiryMessageEvent,
    CatalogPublishedMessageEvent,
    ClubGiftInfoEvent,
    ClubGiftSelectedEvent,
    DirectSMSClubBuyAvailableMessageEvent,
    GiftReceiverNotFoundEvent,
    GiftWrappingConfigurationEvent,
    HabboClubExtendOfferMessageEvent,
    HabboClubOffersMessageEvent,
    IsOfferGiftableMessageEvent,
    LimitedEditionSoldOutEvent,
    LimitedOfferAppearingNextMessageEvent,
    NotEnoughBalanceMessageEvent,
    ProductOfferEvent,
    PurchaseErrorMessageEvent,
    PurchaseNotAllowedMessageEvent,
    PurchaseOKMessageEvent,
    RoomAdPurchaseInfoEvent,
    SeasonalCalendarDailyOfferMessageEvent,
    SellablePetPalettesMessageEvent,
    SnowWarGameTokensMessageEvent,
    TargetedOfferEvent,
    TargetedOfferNotFoundEvent,
    VoucherRedeemErrorMessageEvent,
    VoucherRedeemOkMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.competition
    CompetitionEntrySubmitResultMessageEvent,
    CompetitionVotingInfoMessageEvent,
    CurrentTimingCodeMessageEvent,
    IsUserPartOfCompetitionMessageEvent,
    NoOwnedRoomsAlertMessageEvent,
    SecondsUntilMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.crafting
    CraftableProductsMessageEvent,
    CraftingRecipeMessageEvent,
    CraftingRecipesAvailableMessageEvent,
    CraftingResultMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.error
    ErrorReportEvent,
        
    // com.sulake.habbo.communication.messages.incoming.friendfurni
    FriendFurniCancelLockMessageEvent,
    FriendFurniOtherLockConfirmedMessageEvent,
    FriendFurniStartConfirmationMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.friendlist
    AcceptFriendResultEvent,
    FindFriendsProcessResultEvent,
    FollowFriendFailedEvent,
    FriendListFragmentMessageEvent,
    FriendListUpdateEvent,
    FriendNotificationEvent,
    FriendRequestsEvent,
    HabboSearchResultEvent,
    InstantMessageErrorEvent,
    MessengerErrorEvent,
    MessengerInitEvent,
    MiniMailNewMessageEvent,
    MiniMailUnreadCountEvent,
    NewConsoleMessageEvent,
    NewFriendRequestEvent,
    RoomInviteErrorEvent,
    RoomInviteEvent,
        
    // com.sulake.habbo.communication.messages.incoming.game.directory
    Game2AccountGameStatusMessageEvent,
    Game2GameCancelledMessageEvent,
    Game2GameCreatedMessageEvent,
    Game2GameDirectoryStatusMessageEvent,
    Game2GameLongDataMessageEvent,
    Game2GameNotFoundMessageEvent,
    Game2GameStartedMessageEvent,
    Game2InArenaQueueMessageEvent,
    Game2JoiningGameFailedMessageEvent,
    Game2StartCounterMessageEvent,
    Game2StartingGameFailedMessageEvent,
    Game2StopCounterMessageEvent,
    Game2UserBlockedMessageEvent,
    Game2UserJoinedGameMessageEvent,
    Game2UserLeftGameMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.game.lobby
    AchievementResolutionCompletedMessageEvent,
    AchievementResolutionProgressMessageEvent,
    AchievementResolutionsMessageEvent,
    UserGameAchievementsMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.game.score
    Game2FriendsLeaderboardEvent,
    Game2TotalGroupLeaderboardEvent,
    Game2TotalLeaderboardEvent,
    Game2WeeklyFriendsLeaderboardEvent,
    Game2WeeklyGroupLeaderboardEvent,
    Game2WeeklySmallLeaderboardEvent,
    Game2WeeklyLeaderboardEvent,
    WeeklyCompetitiveFriendsLeaderboardEvent,
    WeeklyCompetitiveLeaderboardEvent,
    WeeklyGameRewardEvent,
    WeeklyGameRewardWinnersEvent,
        
    // com.sulake.habbo.communication.messages.incoming.game.snowwar.arena
    Game2ArenaEnteredMessageEvent,
    Game2EnterArenaFailedMessageEvent,
    Game2EnterArenaMessageEvent,
    Game2GameChatFromPlayerMessageEvent,
    Game2GameEndingMessageEvent,
    Game2GameRejoinMessageEvent,
    Game2PlayerExitedGameArenaMessageEvent,
    Game2PlayerRematchesMessageEvent,
    Game2StageEndingMessageEvent,
    Game2StageLoadMessageEvent,
    Game2StageRunningMessageEvent,
    Game2StageStartingMessageEvent,
    Game2StageStillLoadingMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.game.snowwar.ingame
    Game2FullGameStatusMessageEvent,
    Game2GameStatusMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.gamecenter (GUESS)
    BaseJumpJoinQueue,
    BaseJumpLeaveQueue,
    BaseJumpLoadGame,
    BaseJumpLoadGameURL,
    BaseJumpUnloadGame,
    GameAchievements,
    GameAchievementsList,
    GameCenterAccountInfo,
    GameCenterFeaturedPlayers,
    GameCenterGameList,
    GameFriendNotification,
        
    // com.sulake.habbo.communication.messages.incoming.gifts
    PhoneCollectionStateMessageEvent,
    TryPhoneNumberResultMessageEvent,
    TryVerificationCodeResultMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.groupforums
    ForumDataMessageEvent,
    ForumsListMessageEvent,
    ForumThreadsMessageEvent,
    PostMessageMessageEvent,
    PostThreadMessageEvent,
    ThreadMessagesMessageEvent,
    UnreadForumsCountMessageEvent,
    UpdateMessageMessageEvent,
    UpdateThreadMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.handshake
    AuthenticationOKMessageEvent,
    CompleteDiffieHandshakeEvent,
    DisconnectReasonEvent,
    GenericErrorEvent,
    IdentityAccountsEvent,
    InitDiffieHandshakeEvent,
    IsFirstLoginOfDayEvent,
    NoobnessLevelMessageEvent,
    PingMessageEvent,
    UniqueMachineIDEvent,
    UserObjectEvent,
    UserRightsMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.help
    CallForHelpDisabledNotifyMessageEvent,
    CallForHelpPendingCallsDeletedMessageEvent,
    CallForHelpPendingCallsMessageEvent,
    CallForHelpReplyMessageEvent,
    CallForHelpResultMessageEvent,
    ChatReviewSessionDetachedMessageEvent,
    ChatReviewSessionOfferedToGuideMessageEvent,
    ChatReviewSessionResultsMessageEvent,
    ChatReviewSessionStartedMessageEvent,
    ChatReviewSessionVotingStatusMessageEvent,
    FaqCategoriesMessageEvent,
    FaqCategoryMessageEvent,
    FaqClientFaqsMessageEvent,
    FaqSearchResultsMessageEvent,
    FaqTextMessageEvent,
    GuideOnDutyStatusMessageEvent,
    GuideReportingStatusMessageEvent,
    GuideSessionAttachedMessageEvent,
    GuideSessionDetachedMessageEvent,
    GuideSessionEndedMessageEvent,
    GuideSessionErrorMessageEvent,
    GuideSessionInvitedToGuideRoomMessageEvent,
    GuideSessionMessageMessageEvent,
    GuideSessionPartnerIsTypingMessageEvent,
    GuideSessionRequesterRoomMessageEvent,
    GuideSessionStartedMessageEvent,
    GuideTicketCreationResultMessageEvent,
    GuideTicketResolutionMessageEvent,
    HotelMergeNameChangeEvent,
    IssueCloseNotificationMessageEvent,
    QuizDataMessageEvent,
    QuizResultsMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.hotlooks
    HotLooksMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.inventory.achievements
    AchievementEvent,
    AchievementsEvent,
    AchievementsScoreEvent,

    // com.sulake.habbo.communication.messages.incoming.inventory.avatareffect
    AvatarEffectActivatedMessageEvent,
    AvatarEffectAddedMessageEvent,
    AvatarEffectExpiredMessageEvent,
    AvatarEffectSelectedMessageEvent,
    AvatarEffectsMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.inventory.badges
    BadgePointLimitsEvent,
    BadgeReceivedEvent,
    BadgesEvent,
    IsBadgeRequestFulfilledEvent,
        
    // com.sulake.habbo.communication.messages.incoming.inventory.bots
    BotAddedToInventoryEvent,
    BotInventoryEvent,
    BotReceivedMessageEvent,
    BotRemovedFromInventoryEvent,
        
    // com.sulake.habbo.communication.messages.incoming.inventory.clothing
    FigureSetIdAddedEvent,
    FigureSetIdRemovedEvent,
    FigureSetIdsEvent,

    // com.sulake.habbo.communication.messages.incoming.inventory.furni
    FurniListAddOrUpdateEvent,
    FurniListEvent,
    FurniListInvalidateEvent,
    FurniListRemoveEvent,
    PostItPlacedEvent,

    // com.sulake.habbo.communication.messages.incoming.inventory.trading
    TradeOpenFailedEvent,
    TradingAcceptEvent,
    TradingCloseEvent,
    TradingCompletedEvent,
    TradingConfirmationEvent,
    TradingItemListEvent,
    TradingNoSuchItemEvent,
    TradingNotOpenEvent,
    TradingOpenEvent,
    TradingOtherNotAllowedEvent,
    TradingYouAreNotAllowedEvent,

    // com.sulake.habbo.communication.messages.incoming.inventory.pets
    ConfirmBreedingRequestEvent,
    ConfirmBreedingResultEvent,
    GoToBreedingNestFailureEvent,
    NestBreedingSuccessEvent,
    PetAddedToInventoryEvent,
    PetBreedingEvent,
    PetInventoryEvent,
    PetReceivedMessageEvent,
    PetRemovedFromInventoryEvent,
        
    // com.sulake.habbo.communication.messages.incoming.inventory.purse
    CreditBalanceEvent,

    // com.sulake.habbo.communication.messages.incoming.landingview
    PromoArticlesMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.landingview.votes
    CommunityVoteReceivedEvent,

    // com.sulake.habbo.communication.messages.incoming.marketplace
    MarketPlaceOffersEvent,
    MarketPlaceOwnOffersEvent,
    MarketplaceBuyOfferResultEvent,
    MarketplaceCanMakeOfferResult,
    MarketplaceCancelOfferResultEvent,
    MarketplaceConfigurationEvent,
    MarketplaceItemStatsEvent,
    MarketplaceMakeOfferResult,

    // com.sulake.habbo.communication.messages.incoming.moderation
    CfhChatlogEvent,
    IssueDeletedMessageEvent,
    IssueInfoMessageEvent,
    IssuePickFailedMessageEvent,
    ModeratorActionResultMessageEvent,
    ModeratorCautionEvent,
    ModeratorInitMessageEvent,
    ModeratorMessageEvent,
    ModeratorRoomInfoEvent,
    ModeratorToolPreferencesEvent,
    ModeratorUserInfoEvent,
    RoomChatlogEvent,
    RoomVisitsEvent,
    UserBannedMessageEvent,
    UserChatlogEvent,
        
    // com.sulake.habbo.communication.messages.incoming.mysterybox
    CancelMysteryBoxWaitMessageEvent,
    GotMysteryBoxPrizeMessageEvent,
    MysteryBoxKeysMessageEvent,
    ShowMysteryBoxWaitMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.navigator
    CanCreateRoomEvent,
    CanCreateRoomEventEvent,
    CategoriesWithVisitorCountEvent,
    CompetitionRoomsDataMessageEvent,
    ConvertedRoomIdEvent,
    DoorbellMessageEvent,
    FavouriteChangedEvent,
    FavouritesEvent,
    FlatAccessDeniedMessageEvent,
    FlatCreatedEvent,
    GetGuestRoomResultEvent,
    GuestRoomSearchResultEvent,
    NavigatorSettingsEvent,
    OfficialRoomsEvent,
    PopularRoomTagsResultEvent,
    RoomEventCancelEvent,
    RoomEventEvent,
    RoomInfoUpdatedEvent,
    RoomRatingEvent,
    RoomThumbnailUpdateResultEvent,
    UserEventCatsEvent,
    UserFlatCatsEvent,

    // com.sulake.habbo.communication.messages.incoming.newnavigator
    NavigatorCollapsedCategoriesMessageEvent,
    NavigatorLiftedRoomsEvent,
    NavigatorMetaDataEvent,
    NavigatorSavedSearchesEvent,
    NavigatorSearchResultBlocksEvent,
    NewNavigatorPreferencesEvent,
        
    // com.sulake.habbo.communication.messages.incoming.nft
    UserNftWardrobeMessageEvent,
    UserNftWardrobeSelectionMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.notifications
    ActivityPointsMessageEvent,
    ClubGiftNotificationEvent,
    ElementPointerMessageEvent,
    HabboAchievementNotificationMessageEvent,
    HabboActivityPointNotificationMessageEvent,
    HabboBroadcastMessageEvent,
    InfoFeedEnableMessageEvent,
    MOTDNotificationEvent,
    NotificationDialogMessageEvent,
    OfferRewardDeliveredMessageEvent,
    PetLevelNotificationEvent,
    RestoreClientMessageEvent,
    UnseenItemsEvent,

    // com.sulake.habbo.communication.messages.incoming.nux
    NewUserExperienceGiftOfferEvent,
    NewUserExperienceNotCompleteEvent,
        
    // com.sulake.habbo.communication.messages.incoming.perk
    CitizenshipVipOfferPromoEnabledEvent,
    PerkAllowancesMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.poll
    PollContentsEvent,
    PollErrorEvent,
    PollOfferEvent,
    QuestionAnsweredEvent,
    QuestionEvent,
    QuestionFinishedEvent,
        
    // com.sulake.habbo.communication.messages.incoming.preferences
    AccountPreferencesEvent,

    // com.sulake.habbo.communication.messages.incoming.quest
    CommunityGoalEarnedPrizesMessageEvent,
    CommunityGoalHallOfFameMessageEvent,
    CommunityGoalProgressMessageEvent,
    ConcurrentUsersGoalProgressMessageEvent,
    EpicPopupMessageEvent,
    QuestCancelledMessageEvent,
    QuestCompletedMessageEvent,
    QuestDailyMessageEvent,
    QuestMessageEvent,
    QuestsMessageEvent,
    SeasonalQuestsMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.recycler
    RecyclerStatusMessageEvent,
    RecyclerFinishedMessageEvent,
    RecyclerPrizesMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.room.action
    AvatarEffectMessageEvent,
    CarryObjectMessageEvent,
    DanceMessageEvent,
    ExpressionMessageEvent,
    SleepMessageEvent,
    UseObjectMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.room.camera
    CameraSnapshotMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.room.chat
    ChatMessageEvent,
    FloodControlMessageEvent,
    RemainingMutePeriodEvent,
    RoomChatSettingsMessageEvent,
    RoomFilterSettingsMessageEvent,
    ShoutMessageEvent,
    UserTypingMessageEvent,
    WhisperMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.room.bots
    BotCommandConfigurationEvent,
    BotErrorEvent,
    BotForceOpenContextMenuEvent,
    BotSkillListUpdateEvent,

    // com.sulake.habbo.communication.messages.incoming.room.engine
    FavoriteMembershipUpdateMessageEvent,
    FloorHeightMapMessageEvent,
    FurnitureAliasesMessageEvent,
    HeightMapMessageEvent,
    HeightMapUpdateMessageEvent,
    ItemAddMessageEvent,
    ItemDataUpdateMessageEvent,
    ItemRemoveMessageEvent,
    ItemsMessageEvent,
    ItemUpdateMessageEvent,
    ObjectAddMessageEvent,
    ObjectDataUpdateMessageEvent,
    ObjectRemoveMessageEvent,
    ObjectsDataUpdateMessageEvent,
    ObjectsMessageEvent,
    ObjectUpdateMessageEvent,
    RoomEntryInfoMessageEvent,
    RoomPropertyMessageEvent,
    RoomVisualizationSettingsEvent,
    SlideObjectBundleMessageEvent,
    SpecialRoomEffectMessageEvent,
    UserChangeMessageEvent,
    UserRemoveMessageEvent,
    UsersMessageEvent,
    UserUpdateMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.room.furniture
    CustomStackingHeightUpdateMessageEvent,
    CustomUserNotificationMessageEvent,
    DiceValueMessageEvent,
    FurniRentOrBuyoutOfferMessageEvent,
    GuildFurniContextMenuInfoMessageEvent,
    OneWayDoorStatusMessageEvent,
    OpenPetPackageRequestedMessageEvent,
    OpenPetPackageResultMessageEvent,
    PresentOpenedMessageEvent,
    RentableSpaceRentFailedMessageEvent,
    RentableSpaceRentOkMessageEvent,
    RentableSpaceStatusMessageEvent,
    RequestSpamWallPostItMessageEvent,
    RoomDimmerPresetsMessageEvent,
    RoomMessageNotificationMessageEvent,
    YoutubeControlVideoMessageEvent,
    YoutubeDisplayPlaylistsMessageEvent,
    YoutubeDisplayVideoMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.room.layout
    RoomEntryTileMessageEvent,
    RoomOccupiedTilesMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.room.permissions
    YouAreControllerMessageEvent,
    YouAreNotControllerMessageEvent,
    YouAreOwnerMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.room.pets
    PetBreedingResultEvent,
    PetCommandsMessageEvent,
    PetExperienceEvent,
    PetFigureUpdateEvent,
    PetInfoMessageEvent,
    PetLevelUpdateEvent,
    PetPlacingErrorEvent,
    PetRespectFailedEvent,
    PetStatusUpdateEvent,
        
    // com.sulake.habbo.communication.messages.incoming.room.session
    CantConnectMessageEvent,
    CloseConnectionMessageEvent,
    FlatAccessibleMessageEvent,
    GamePlayerValueMessageEvent,
    OpenConnectionMessageEvent,
    RoomForwardMessageEvent,
    RoomQueueStatusMessageEvent,
    RoomReadyMessageEvent,
    YouArePlayingGameMessageEvent,
    YouAreSpectatorMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.roomsettings
    BannedUsersFromRoomEvent,
    FlatControllerAddedEvent,
    FlatControllerRemovedEvent,
    FlatControllersEvent,
    MuteAllInRoomEvent,
    NoSuchFlatEvent,
    RoomSettingsDataEvent,
    RoomSettingsErrorEvent,
    RoomSettingsSavedEvent,
    RoomSettingsSaveErrorEvent,
    ShowEnforceRoomCategoryDialogEvent,
    UserUnbannedFromRoomEvent,

    // com.sulake.habbo.communication.messages.incoming.sound
    JukeboxPlayListFullMessageEvent,
    JukeboxSongDisksMessageEvent,
    NowPlayingMessageEvent,
    OfficialSongIdMessageEvent,
    PlayListMessageEvent,
    PlayListSongAddedMessageEvent,
    TraxSongInfoMessageEvent,
    UserSongDisksInventoryMessageEvent,
        
    // com.sulake.habbo.communication.messages.incoming.talent
    TalentLevelUpMessageEvent,
    TalentTrackLevelMessageEvent,
    TalentTrackMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.tracking
    LatencyPingResponseMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.userclassification
    UserClassificationMessageEvent,

    // com.sulake.habbo.communication.messages.incoming.userdefinedroomevents
    OpenEvent,
    WiredFurniActionEvent,
    WiredFurniConditionEvent,
    WiredFurniTriggerEvent,
    WiredRewardResultMessageEvent,
    WiredSaveSuccessEvent,
    WiredValidationErrorEvent,

    // com.sulake.habbo.communication.messages.incoming.users
    AccountSafetyLockQuestionsMessageEvent,
    AccountSafetyLockStatusChangeMessageEvent,
    ApproveNameMessageEvent,
    ChangeEmailResultEvent,
    EmailStatusResultEvent,
    ExtendedProfileChangedMessageEvent,
    ExtendedProfileMessageEvent,
    GroupDetailsChangedMessageEvent,
    GroupMembershipRequestedMessageEvent,
    GuildCreatedMessageEvent,
    GuildCreationInfoMessageEvent,
    GuildEditFailedMessageEvent,
    GuildEditInfoMessageEvent,
    GuildEditorDataMessageEvent,
    GuildMemberFurniCountInHQMessageEvent,
    GuildMemberMgmtFailedMessageEvent,
    GuildMembersMessageEvent,
    GuildMembershipRejectedMessageEvent,
    GuildMembershipUpdatedMessageEvent,
    GuildMembershipsMessageEvent,
    HabboGroupBadgesMessageEvent,
    HabboGroupDeactivatedMessageEvent,
    HabboGroupDetailsMessageEvent,
    HabboGroupJoinFailedMessageEvent,
    HabboUserBadgesMessageEvent,
    HandItemReceivedMessageEvent,
    IgnoreResultMessageEvent,
    IgnoredUsersMessageEvent,
    InClientLinkMessageEvent,
    PetRespectNotificationEvent,
    PetSupplementedNotificationEvent,
    RelationshipStatusInfoEvent,
    RespectNotificationMessageEvent,
    RoomUserTagsMessageEvent,
    ScrSendKickbackInfoMessageEvent,
    ScrSendUserInfoEvent,
    UserNameChangedMessageEvent,
        
    // com.sulake.habbo.communication.messages.parser.vault
    CreditVaultStatusMessageEvent,
    IncomeRewardClaimResponseMessageEvent,
    IncomeRewardStatusMessageEvent
}