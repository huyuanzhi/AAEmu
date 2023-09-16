﻿namespace AAEmu.Game.Models.Game.Mails;

public enum MailType : byte
{
    InvalidMailType = 0,
    Normal = 1,
    Express = 2,
    Registered = 3,
    Spam = 4,
    Admin = 5,
    Billing = 6,
    BalanceReceipt = 7,
    TaxrateChanged = 8,
    Charged = 9,
    Promotion = 10,
    MiaSend = 11,
    MiaRecv = 12,
    AucOffCancel = 13,
    AucOffSuccess = 14,
    AucOffFail = 15,
    AucBidWin = 16,
    AucBidFail = 17,
    SysExpress = 18,
    SysSellBackpack = 19,
    DemolishWithPenalty = 20,
    HousingSale = 21,
    UserBill = 22,
    NationTaxRate = 23,
    NationTaxReceipt = 24,
    NationRequestFriend = 25,
    KickedFromBeginnerExped = 26,
    MobilizationGiveItem = 27,
    HeroCandidateAlarm = 28,
    HeroElectionItem = 29,
    HousingRebuild = 30,
    Demolish = 31,
    SiegeWinGiveItem = 32,
    SiegeLoseGiveItem = 33,
    TaxInKindReceipt = 34,
    NationRelationFriend = 35,
    NationRelationFriendSuccess = 36,
    NationRelationFriendReject = 37,
    NationRelationFriendRejectItem = 38,
    NationRelationHostile = 39,
    NationRelationHostileSuccess = 40,
    NationRelationHostileReject = 41,
    SiegeAuctionStart = 42,
    ExpeditionImmigrationReject = 43,
    ResidentBalance = 44
}

public enum CommercialMailTypes
{
    Charged = MailType.Charged,
    MiaRecv = MailType.MiaRecv,
    MiaSend = MailType.MiaSend,
    Promotion = MailType.Promotion,
}

public enum MiaMailTypes
{
    MiaRecv = MailType.MiaRecv,
    MiaSend = MailType.MiaSend,
}
