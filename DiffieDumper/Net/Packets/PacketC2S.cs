namespace DiffieDumper.Net.Packets;

public enum PacketC2S
{
    Unknown,
    
    // com.sulake.habbo.communication.messages.outgoing.advertisement
    GetInterstitialMessageComposer,
    InterstitialShownMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.avatar
    ChangeUserNameMessageComposer,
    CheckUserNameMessageComposer,
    GetWardrobeMessageComposer,
    SaveWardrobeOutfitMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.camera
    RequestCameraConfigurationMessageComposer,
    PhotoCompetitionMessageComposer,
    PublishPhotoMessageComposer,
    PurchasePhotoMessageComposer,
    RenderRoomMessageComposer,
    RenderRoomThumbnailMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.campaign
    OpenCampaignCalendarDoorAsStaffComposer,
    OpenCampaignCalendarDoorComposer,

    // com.sulake.habbo.communication.messages.outgoing.catalog
    BuildersClubPlaceRoomItemMessageComposer,
    BuildersClubPlaceWallItemMessageComposer,
    BuildersClubQueryFurniCountMessageComposer,
    GetBonusRareInfoMessageComposer,
    GetBundleDiscountRulesetComposer,
    GetCatalogIndexComposer,
    GetCatalogPageComposer,
    GetCatalogPageExpirationComposer,
    GetCatalogPageWithEarliestExpiryComposer,
    GetClubGiftMessageComposer,
    GetClubOffersMessageComposer,
    GetDirectClubBuyAvailableComposer,
    GetGiftWrappingConfigurationComposer,
    GetHabboBasicMembershipExtendOfferComposer,
    GetHabboClubExtendOfferMessageComposer,
    GetIsOfferGiftableComposer,
    GetLimitedOfferAppearingNextComposer,
    GetNextTargetedOfferComposer,
    GetProductOfferComposer,
    GetRoomAdPurchaseInfoComposer,
    GetSeasonalCalendarDailyComposer,
    GetSellablePetPalettesComposer,
    GetSnowWarGameTokensOfferComposer,
    GetTargetedOfferComposer,
    MarkCatalogNewAdditionsPageOpenedComposer,
    PurchaseBasicMembershipExtensionComposer,
    PurchaseFromCatalogAsGiftComposer,
    PurchaseFromCatalogComposer,
    PurchaseRoomAdMessageComposer,
    PurchaseSnowWarGameTokensOfferComposer,
    PurchaseTargetedOfferComposer,
    PurchaseVipMembershipExtensionComposer,
    RedeemVoucherMessageComposer,
    RoomAdPurchaseInitiatedComposer,
    SelectClubGiftComposer,
    SetTargetedOfferStateComposer,
    ShopTargetedOfferViewedComposer,

    // com.sulake.habbo.communication.messages.outgoing.competition
    ForwardToACompetitionRoomMessageComposer,
    ForwardToASubmittableRoomMessageComposer,
    ForwardToRandomCompetitionRoomMessageComposer,
    GetCurrentTimingCodeMessageComposer,
    GetIsUserPartOfCompetitionMessageComposer,
    GetSecondsUntilMessageComposer,
    RoomCompetitionInitMessageComposer,
    SubmitRoomToCompetitionMessageComposer,
    VoteForRoomMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.crafting
    CraftComposer,
    CraftSecretComposer,
    GetCraftableProductsComposer,
    GetCraftingRecipeComposer,
    GetCraftingRecipesAvailableComposer,

    // com.sulake.habbo.communication.messages.outgoing.feedback
    UserFeedbackMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.friendfurni
    FriendFurniConfirmLockMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.friendlist
    AcceptFriendMessageComposer,
    DeclineFriendMessageComposer,
    FindNewFriendsMessageComposer,
    FollowFriendMessageComposer,
    FriendListUpdateMessageComposer,
    GetFriendRequestsMessageComposer,
    HabboSearchMessageComposer,
    MessengerInitMessageComposer,
    RemoveFriendMessageComposer,
    RequestFriendMessageComposer,
    SendMsgMessageComposer,
    SendRoomInviteMessageComposer,
    SetRelationshipStatusMessageComposer,
    VisitUserMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.game.arena
    Game2ExitGameMessageComposer,
    Game2GameChatMessageComposer,
    Game2LoadStageReadyMessageComposer,
    Game2PlayAgainMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.game.directory
    Game2CheckGameDirectoryStatusMessageComposer,
    Game2GetAccountGameStatusMessageComposer,
    Game2LeaveGameMessageComposer,
    Game2QuickJoinGameMessageComposer,
    Game2StartSnowWarMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.game.ingame
    Game2MakeSnowballMessageComposer,
    Game2RequestFullStatusUpdateMessageComposer,
    Game2SetUserMoveTargetMessageComposer,
    Game2ThrowSnowballAtHumanMessageComposer,
    Game2ThrowSnowballAtPositionMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.game.lobby
    GetResolutionAchievementsMessageComposer,
    GetUserGameAchievementsMessageComposer,
    ResetResolutionAchievementMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.game.score
    Game2GetFriendsLeaderboardComposer,
    Game2GetTotalGroupLeaderboardComposer,
    Game2GetTotalLeaderboardComposer,
    Game2GetWeeklyFriendsLeaderboardComposer,
    Game2GetWeeklyGroupLeaderboardComposer,
    Game2GetWeeklyLeaderboardComposer,
    GetFriendsWeeklyCompetitiveLeaderboardComposer,
    GetWeeklyCompetitiveLeaderboardComposer,
    GetWeeklyGameRewardComposer,
    GetWeeklyGameRewardWinnersComposer,

    // com.sulake.habbo.communication.messages.outgoing.gifts
    GetGiftMessageComposer,
    ResetPhoneNumberStateMessageComposer,
    SetPhoneNumberVerificationStatusMessageComposer,
    TryPhoneNumberMessageComposer,
    VerifyCodeMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.groupforums
    GetForumsListMessageComposer,
    GetForumStatsMessageComposer,
    GetMessagesMessageComposer,
    GetThreadMessageComposer,
    GetThreadsMessageComposer,
    GetUnreadForumsCountMessageComposer,
    ModerateMessageMessageComposer,
    ModerateThreadMessageComposer,
    PostMessageMessageComposer,
    UpdateForumReadMarkerMessageComposer,
    UpdateForumSettingsMessageComposer,
    UpdateThreadMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.handshake
    ClientHelloMessageComposer,
    ClientResumedMessageEvent,
    ClientSuspendedMessageEvent,
    CompleteDiffieHandshakeMessageComposer,
    DisconnectMessageComposer,
    InfoRetrieveMessageComposer,
    InitDiffieHandshakeMessageComposer,
    PongMessageComposer,
    SSOTicketMessageComposer,
    TryLoginMessageComposer,
    UniqueIDMessageComposer,
    VersionCheckMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.help
    CallForHelpFromForumMessageMessageComposer,
    CallForHelpFromForumThreadMessageComposer,
    CallForHelpFromIMMessageComposer,
    CallForHelpFromPhotoMessageComposer,
    CallForHelpFromSelfieMessageComposer,
    CallForHelpMessageComposer,
    ChatReviewGuideDecidesOnOfferMessageComposer,
    ChatReviewGuideDetachedMessageComposer,
    ChatReviewGuideVoteMessageComposer,
    ChatReviewSessionCreateMessageComposer,
    DeletePendingCallsForHelpMessageComposer,
    GetCfhStatusMessageComposer,
    GetClientFaqsMessageComposer,
    GetFaqCategoriesMessageComposer,
    GetFaqCategoryMessageComposer,
    GetFaqTextMessageComposer,
    GetGuideReportingStatusMessageComposer,
    GetPendingCallsForHelpMessageComposer,
    GetQuizQuestionsComposer,
    GuideSessionCreateMessageComposer,
    GuideSessionFeedbackMessageComposer,
    GuideSessionGetRequesterRoomMessageComposer,
    GuideSessionGuideDecidesMessageComposer,
    GuideSessionInviteRequesterMessageComposer,
    GuideSessionIsTypingMessageComposer,
    GuideSessionMessageMessageComposer,
    GuideSessionOnDutyUpdateMessageComposer,
    GuideSessionReportMessageComposer,
    GuideSessionRequesterCancelsMessageComposer,
    GuideSessionResolvedMessageComposer,
    PostQuizAnswersComposer,
    SearchFaqsMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.hotlooks
    GetHotLooksMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.inventory.achievements
    GetAchievementsComposer,
        
    // com.sulake.habbo.communication.messages.outgoing.inventory.avatareffect
    AvatarEffectActivatedComposer,
    AvatarEffectSelectedComposer,

    // com.sulake.habbo.communication.messages.outgoing.inventory.badges
    GetBadgePointLimitsComposer,
    GetBadgesComposer,
    GetIsBadgeRequestFulfilledComposer,
    RequestABadgeComposer,
    SetActivatedBadgesComposer,
        
    // com.sulake.habbo.communication.messages.outgoing.inventory.bots
    GetBotInventoryComposer,

    // com.sulake.habbo.communication.messages.outgoing.inventory.furni
    RequestFurniInventoryComposer,
    RequestFurniInventoryWhenNotInRoomComposer,
    RequestRoomPropertySet,

    // com.sulake.habbo.communication.messages.outgoing.inventory.pets
    CancelPetBreedingComposer,
    ConfirmPetBreedingComposer,
    GetPetInventoryComposer,

    // com.sulake.habbo.communication.messages.outgoing.inventory.purse
    GetCreditsInfoComposer,
        
    // com.sulake.habbo.communication.messages.outgoing.inventory.trading
    AcceptTradingComposer,
    AddItemsToTradeComposer,
    AddItemToTradeComposer,
    CloseTradingComposer,
    ConfirmAcceptTradingComposer,
    ConfirmDeclineTradingComposer,
    OpenTradingComposer,
    RemoveItemFromTradeComposer,
    UnacceptTradingComposer,

    // com.sulake.habbo.communication.messages.outgoing.landingview
    GetPromoArticlesMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.landingview.votes
    CommunityGoalVoteMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.marketplace
    BuyMarketplaceOfferMessageComposer,
    BuyMarketplaceTokensMessageComposer,
    CancelMarketplaceOfferMessageComposer,
    GetMarketplaceCanMakeOfferMessageComposer,
    GetMarketplaceConfigurationMessageComposer,
    GetMarketplaceItemStatsComposer,
    GetMarketplaceOffersMessageComposer,
    GetMarketplaceOwnOffersMessageComposer,
    MakeOfferMessageComposer,
    RedeemMarketplaceOfferCreditsMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.moderator
    CloseIssueDefaultActionMessageComposer,
    CloseIssuesMessageComposer,
    DefaultSanctionMessageComposer,
    GetCfhChatlogMessageComposer,
    GetModeratorRoomInfoMessageComposer,
    GetModeratorUserInfoMessageComposer,
    GetRoomChatlogMessageComposer,
    GetRoomVisitsMessageComposer,
    GetUserChatlogMessageComposer,
    ModAlertMessageComposer,
    ModBanMessageComposer,
    ModerateRoomMessageComposer,
    ModeratorActionMessageComposer,
    ModKickMessageComposer,
    ModMessageMessageComposer,
    ModMuteMessageComposer,
    ModToolPreferencesComposer,
    ModToolSanctionComposer,
    ModTradingLockMessageComposer,
    PickIssuesMessageComposer,
    ReleaseIssuesMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.mysterybox
    MysteryBoxWaitingCanceledMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.navigator
    AddFavouriteRoomMessageComposer,
    CancelEventMessageComposer,
    CanCreateRoomMessageComposer,
    CompetitionRoomsSearchMessageComposer,
    ConvertGlobalRoomIdMessageComposer,
    CreateFlatMessageComposer,
    DeleteFavouriteRoomMessageComposer,
    EditEventMessageComposer,
    ForwardToARandomPromotedRoomMessageComposer,
    ForwardToSomeRoomMessageComposer,
    GetCategoriesWithUserCountMessageComposer,
    GetGuestRoomMessageComposer,
    GetOfficialRoomsMessageComposer,
    GetPopularRoomTagsMessageComposer,
    GetUserEventCatsMessageComposer,
    GetUserFlatCatsMessageComposer,
    GuildBaseSearchMessageComposer,
    MyFavouriteRoomsSearchMessageComposer,
    MyFrequentRoomHistorySearchMessageComposer,
    MyFriendsRoomsSearchMessageComposer,
    MyGuildBasesSearchMessageComposer,
    MyRecommendedRoomsMessageComposer,
    MyRoomHistorySearchMessageComposer,
    MyRoomRightsSearchMessageComposer,
    MyRoomsSearchMessageComposer,
    PopularRoomsSearchMessageComposer,
    RateFlatMessageComposer,
    RemoveOwnRoomRightsRoomMessageComposer,
    RoomAdEventTabAdClickedComposer,
    RoomAdEventTabViewedComposer,
    RoomAdSearchMessageComposer,
    RoomsWhereMyFriendsAreSearchMessageComposer,
    RoomsWithHighestScoreSearchMessageComposer,
    RoomTextSearchMessageComposer,
    SetRoomSessionTagsMessageComposer,
    ToggleStaffPickMessageComposer,
    UpdateHomeRoomMessageComposer,
    UpdateRoomThumbnailMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.newnavigator
    NavigatorAddCollapsedCategoryMessageComposer,
    NavigatorAddSavedSearchComposer,
    NavigatorDeleteSavedSearchComposer,
    NavigatorRemoveCollapsedCategoryMessageComposer,
    NavigatorSetSearchCodeViewModeMessageComposer,
    NewNavigatorInitComposer,
    NewNavigatorSearchComposer,
        
    // com.sulake.habbo.communication.messages.outgoing.nft
    GetSelectedNftWardrobeOutfitMessageComposer,
    GetUserNftWardrobeMessageComposer,
    SaveUserNftWardrobeMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.notifications
    ResetUnseenItemIdsComposer,
    ResetUnseenItemsComposer,

    // com.sulake.habbo.communication.messages.outgoing.nux
    NewUserExperienceGetGiftsMessageComposer,
    NewUserExperienceScriptProceedComposer,

    // com.sulake.habbo.communication.messages.outgoing.poll
    PollAnswerComposer,
    PollRejectComposer,
    PollStartComposer,

    // com.sulake.habbo.communication.messages.outgoing.preferences
    SetChatPreferencesMessageComposer,
    SetChatStylePreferenceComposer,
    SetIgnoreRoomInvitesMessageComposer,
    SetNewNavigatorWindowPreferencesMessageComposer,
    SetRoomCameraPreferencesMessageComposer,
    SetSoundSettingsComposer,
    SetUIFlagsMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.quest
    AcceptQuestMessageComposer,
    ActivateQuestMessageComposer,
    CancelQuestMessageComposer,
    FriendRequestQuestCompleteMessageComposer,
    GetCommunityGoalEarnedPrizesMessageComposer,
    GetCommunityGoalHallOfFameMessageComposer,
    GetCommunityGoalProgressMessageComposer,
    GetConcurrentUsersGoalProgressMessageComposer,
    GetConcurrentUsersRewardMessageComposer,
    GetDailyQuestMessageComposer,
    GetQuestsMessageComposer,
    GetSeasonalQuestsOnlyMessageComposer,
    OpenQuestTrackerMessageComposer,
    RedeemCommunityGoalPrizeMessageComposer,
    RejectQuestMessageComposer,
    StartCampaignMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.recycler
    GetRecyclerStatusMessageComposer,
    GetRecyclerPrizesMessageComposer,
    RecycleItemsMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.register
    UpdateFigureDataMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.room.action
    AmbassadorAlertMessageComposer,
    AssignRightsMessageComposer,
    BanUserWithDurationMessageComposer,
    KickUserMessageComposer,
    LetUserInMessageComposer,
    MuteAllInRoomComposer,
    MuteUserMessageComposer,
    RemoveAllRightsMessageComposer,
    RemoveRightsMessageComposer,
    UnbanUserFromRoomMessageComposer,
    UnmuteUserMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.room.avatar
    AvatarExpressionMessageComposer,
    ChangeMottoMessageComposer,
    ChangePostureMessageComposer,
    CustomizeAvatarWithFurniMessageComposer,
    DanceMessageComposer,
    DropCarryItemMessageComposer,
    LookToMessageComposer,
    PassCarryItemMessageComposer,
    PassCarryItemToPetMessageComposer,
    SignMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.room.bots
    CommandBotComposer,
    GetBotCommandConfigurationDataComposer,

    // com.sulake.habbo.communication.messages.outgoing.room.chat
    StartTypingMessageComposer,
    CancelTypingMessageComposer,
    ChatMessageComposer,
    ShoutMessageComposer,
    WhisperMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.room.engine
    CompostPlantMessageComposer,
    GetFurnitureAliasesMessageComposer,
    GetHeightMapMessageComposer,
    GetItemDataMessageComposer,
    GetPetCommandsMessageComposer,
    GiveSupplementToPetMessageComposer,
    HarvestPetMessageComposer,
    MountPetMessageComposer,
    MoveAvatarMessageComposer,
    MoveObjectMessageComposer,
    MovePetMessageComposer,
    MoveWallItemMessageComposer,
    PetMessageComposer,
    PickupObjectMessageComposer,
    PlaceBotMessageComposer,
    PlaceObjectMessageComposer,
    PlacePetMessageComposer,
    RemoveBotFromFlatMessageComposer,
    RemoveItemMessageComposer,
    RemovePetFromFlatMessageComposer,
    RemoveSaddleFromPetMessageComposer,
    SetClothingChangeDataMessageComposer,
    SetItemDataMessageComposer,
    SetObjectDataMessageComposer,
    TogglePetBreedingPermissionMessageComposer,
    TogglePetRidingPermissionMessageComposer,
    UseFurnitureMessageComposer,
    UseWallItemMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.room.furniture
    AddSpamWallPostItMessageComposer,
    ControlYoutubeDisplayPlaybackMessageComposer,
    CreditFurniRedeemMessageComposer,
    DiceOffMessageComposer,
    EnterOneWayDoorMessageComposer,
    ExtendRentOrBuyoutFurniMessageComposer,
    ExtendRentOrBuyoutStripItemMessageComposer,
    GetGuildFurniContextMenuInfoMessageComposer,
    GetRentOrBuyoutOfferMessageComposer,
    GetYoutubeDisplayStatusMessageComposer,
    OpenMysteryTrophyMessageComposer,
    OpenPetPackageMessageComposer,
    PlacePostItMessageComposer,
    PresentOpenMessageComposer,
    RentableSpaceCancelRentMessageComposer,
    RentableSpaceRentMessageComposer,
    RentableSpaceStatusMessageComposer,
    RoomDimmerChangeStateMessageComposer,
    RoomDimmerGetPresetsMessageComposer,
    RoomDimmerSavePresetMessageComposer,
    SetCustomStackingHeightComposer,
    SetMannequinFigureComposer,
    SetMannequinNameComposer,
    SetRandomStateMessageComposer,
    SetRoomBackgroundColorDataComposer,
    SetYoutubeDisplayPlaylistMessageComposer,
    SpinWheelOfFortuneMessageComposer,
    ThrowDiceMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.room.layout
    GetOccupiedTilesMessageComposer,
    GetRoomEntryTileMessageComposer,
    UpdateFloorPropertiesMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.room.pets
    BreedPetsMessageComposer,
    CustomizePetWithFurniComposer,
    GetPetInfoMessageComposer,
    PetSelectedMessageComposer,
    RespectPetMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.room.session
    ChangeQueueMessageComposer,
    OpenFlatConnectionMessageComposer,
    QuitMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.roomdirectory
    RoomNetworkOpenConnectionMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.roomsettings
    DeleteRoomMessageComposer,
    GetBannedUsersFromRoomMessageComposer,
    GetCustomRoomFilterMessageComposer,
    GetFlatControllersMessageComposer,
    GetRoomSettingsMessageComposer,
    SaveRoomSettingsMessageComposer,
    UpdateRoomCategoryAndTradeSettingsComposer,
    UpdateRoomFilterMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.sound
    AddJukeboxDiskComposer,
    GetJukeboxPlayListMessageComposer,
    GetNowPlayingMessageComposer,
    GetOfficialSongIdMessageComposer,
    GetSongInfoMessageComposer,
    GetSoundMachinePlayListMessageComposer,
    GetSoundSettingsComposer,
    GetUserSongDisksMessageComposer,
    RemoveJukeboxDiskComposer,

    // com.sulake.habbo.communication.messages.outgoing.talent
    GetTalentTrackLevelMessageComposer,
    GetTalentTrackMessageComposer,
    GuideAdvertisementReadMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.tracking
    EventLogMessageComposer,
    LagWarningReportMessageComposer,
    LatencyPingReportMessageComposer,
    LatencyPingRequestMessageComposer,
    PerformanceLogMessageComposer,
    PerformanceTabletLogMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.userclassification
    PeerUsersClassificationMessageComposer,
    RoomUsersClassificationMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.userdefinedroomevents
    ApplySnapshotMessageComposer,
    OpenMessageComposer,
    UpdateActionMessageComposer,
    UpdateConditionMessageComposer,
    UpdateTriggerMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.users
    AccountSafetyLockGetQuestionsMessageComposer,
    AccountSafetyLockUnlockMessageComposer,
    AddAdminRightsToMemberMessageComposer,
    ApproveAllMembershipRequestsMessageComposer,
    ApproveMembershipRequestMessageComposer,
    ApproveNameMessageComposer,
    ChangeEmailComposer,
    CreateGuildMessageComposer,
    DeactivateGuildMessageComposer,
    DeselectFavouriteHabboGroupMessageComposer,
    GetEmailStatusComposer,
    GetExtendedProfileByNameMessageComposer,
    GetExtendedProfileMessageComposer,
    GetGuildCreationInfoMessageComposer,
    GetGuildEditInfoMessageComposer,
    GetGuildEditorDataMessageComposer,
    GetGuildMembersMessageComposer,
    GetGuildMembershipsMessageComposer,
    GetHabboGroupBadgesMessageComposer,
    GetHabboGroupDetailsMessageComposer,
    GetIgnoredUsersMessageComposer,
    GetMOTDMessageComposer,
    GetMemberGuildItemCountMessageComposer,
    GetRelationshipStatusInfoMessageComposer,
    GetSelectedBadgesMessageComposer,
    GiveStarGemToUserMessageComposer,
    IgnoreUserIdMessageComposer,
    IgnoreUserMessageComposer,
    JoinHabboGroupMessageComposer,
    KickMemberMessageComposer,
    RejectMembershipRequestMessageComposer,
    RemoveAdminRightsFromMemberMessageComposer,
    RespectUserMessageComposer,
    ScrGetKickbackInfoMessageComposer,
    ScrGetUserInfoMessageComposer,
    SelectFavouriteHabboGroupMessageComposer,
    UnblockGroupMemberMessageComposer,
    UnignoreUserMessageComposer,
    UpdateGuildBadgeMessageComposer,
    UpdateGuildColorsMessageComposer,
    UpdateGuildIdentityMessageComposer,
    UpdateGuildSettingsMessageComposer,

    // com.sulake.habbo.communication.messages.outgoing.vault
    CreditVaultStatusMessageComposer,
    IncomeRewardClaimMessageComposer,
    IncomeRewardStatusMessageComposer,
    WithdrawCreditVaultMessageComposer,
}