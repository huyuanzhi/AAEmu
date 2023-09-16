﻿namespace AAEmu.Game.Models.Game.Skills.Effects;

public enum SpecialType
{
    Charge = 1,
    DisturbCasting = 5,
    LoseTarget = 8,
    Unk9 = 9,
    Interaction = 10,
    Blink = 11,
    KnockBack = 13,
    SpawnDoodad = 15,
    BuffSteal = 16,
    Track = 17,
    FakeDeath = 18,
    SpawnBomb = 19,
    PhysicalEnchantWeapon = 20,
    PhysicalEnchantArmor = 21,
    Resurrection = 22,
    CapturePet = 23,
    SpawnPet = 24,
    Return = 25,
    GainItem = 27,
    AddExp = 28,
    AddLaborPower = 29,
    SavePortal = 30,
    OpenPortal = 31,
    GainItemWithPosImprint = 32,
    SkillUse = 33, // TODO renamed due to a conflict with skill.cs
    Anim = 34,
    FxGroup = 35,
    FxGroupAnim = 36,
    Projectile = 37,
    ProjectileAnim = 38,
    ManaCost = 39,
    Cooldown = 40,
    GlobalCooldown = 41,
    OpacityControl = 42,
    ResetCooldown = 43,
    RedeemBuff = 44,
    GainItemWithEmblemImprint = 45,
    ExplodeBuff = 46,
    TeleportToUnit = 47,
    Combo = 48,
    ItemConversion = 49,
    DeclareDominion = 50,
    MateMakeGetUp = 51,
    StopManaRegen = 52,
    AttachTo = 53,
    AddBreath = 54,
    Detach = 55,
    HealPet = 56,
    RenewEquipment = 57,
    RemoveDoodad = 58,
    CancelStealth = 59,
    SpawnSlave = 60,
    CancelOngoingBuff = 61,
    HealSlave = 62,
    CombatText = 63,
    GetSiegeTicket = 64,
    TeleportToSiegeHq = 65,
    AutoAttack = 66,
    CombatDice = 67,
    ApplyReagents = 68,
    SextantPos = 69,
    NotifyQuest = 70,
    DeclareIndependence = 71,
    DestroyAndSpawnSlave = 72,
    MoveToGround = 73,
    Escape = 74,
    ReportBot = 75,
    ClearProjectile = 76,
    RetrieveProjectile = 77,
    AddFxToProjectile = 78,
    FishingLoot = 79,
    StopChanneling = 80,
    FinishChanneling = 81,
    SetVariable = 82,
    ReportBotExpired = 83,
    ReportBotArrested = 84,
    EngraveOnGuardTower = 85,
    ConsumeLaborPower = 86,
    GiveLivingPoint = 87,
    ApplyBotTrial = 88,
    ArrestBot = 89,
    EscapeMySlave = 90,
    AddCharacterSlot = 91,
    GradeEnchant = 92,
    PlayUserMusic = 93,
    PauseUserMusic = 94,
    RechargeItemBuff = 95,
    ExpToItem = 96,
    UserMusicSaveNotes = 97,
    Dyeing = 98,
    GiveBmMileage = 99,
    GiveHonorPoint = 100,
    EnterBeautyshop = 101,
    GiveCrimePoint = 102,
    CleanupLookConvert = 103,
    AggroCopy = 104,
    AggroReset = 105,
    ItemSocketing = 106,
    GenderTransfer = 107,
    Skinize = 108,
    NpcDespawn = 109,
    StartDominionNonPvpDuration = 110,
    ItemCapScaleReset = 111,
    ItemCapScale = 112,
    AddPStat = 113,
    GiveAppellation = 114,
    ExitArchemall = 115,
    WeaponDisplay = 116,
    AuctionPostAuthority = 117,
    // TODO 3+
    GiveCashPoint = 118,
    RevertItemLook = 119,
    RechargeItemSkill = 120,
    RepairAuthorityInBag = 121,
    RebuildHousing = 122,
    ItemEvolving = 123,
    RechargeItemRndAttrUnitModifier = 124,
    HudAuctionAuthority = 125,
    ItemRefurbishment = 126,
    ProtectionForExpedition = 127,
    ExpeditionSummon = 128,
    HudBattlefieldAuthority = 129,
    RemoveDoodadGroup = 130,
    AddExpeditionExp = 131,
    AddExpeditionContributionPoint = 132,
    GainGachaLootPackItem = 133,
    ChangeSkillActiveType = 134,
    ActivateSavedAbilitySet = 135,
    ItemEvolvingReRoll = 136,
    ExpandDecoLimit = 137,
    DominionTaxInKind = 138,
    ExpeditionLevelChange = 139,
    RemoveAllDoodad = 140,
    LearnSpecialAbility = 141,
    IncreaseFavoritePortalLimit = 142,
    ResidentServicePoint = 143,
    AddFamilyExp = 144,
    ChangeTarget = 145,
    LoseTargetingTheTarget = 146,
    PlayAttachmentAnim = 149,
    PlaySkillControllerAttachmentAnim = 150,
    ItemSmelting = 151
}
