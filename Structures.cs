using ProtoBuf;
using System;
using System.Collections.Generic;

namespace LoadKeplerthData
{
    [ProtoContract]
    public struct KeyBindingData
    {
        [ProtoMember(1)]
        public KeyCode CurPrimary;
        [ProtoMember(2)]
        public KeyCode CurSecondary;
    }

    public enum KeyCode
    {
        None = 0,
        Backspace = 8,
        Delete = 0x7F,
        Tab = 9,
        Clear = 12,
        Return = 13,
        Pause = 19,
        Escape = 27,
        Space = 0x20,
        Keypad0 = 0x100,
        Keypad1 = 257,
        Keypad2 = 258,
        Keypad3 = 259,
        Keypad4 = 260,
        Keypad5 = 261,
        Keypad6 = 262,
        Keypad7 = 263,
        Keypad8 = 264,
        Keypad9 = 265,
        KeypadPeriod = 266,
        KeypadDivide = 267,
        KeypadMultiply = 268,
        KeypadMinus = 269,
        KeypadPlus = 270,
        KeypadEnter = 271,
        KeypadEquals = 272,
        UpArrow = 273,
        DownArrow = 274,
        RightArrow = 275,
        LeftArrow = 276,
        Insert = 277,
        Home = 278,
        End = 279,
        PageUp = 280,
        PageDown = 281,
        F1 = 282,
        F2 = 283,
        F3 = 284,
        F4 = 285,
        F5 = 286,
        F6 = 287,
        F7 = 288,
        F8 = 289,
        F9 = 290,
        F10 = 291,
        F11 = 292,
        F12 = 293,
        F13 = 294,
        F14 = 295,
        F15 = 296,
        Alpha0 = 48,
        Alpha1 = 49,
        Alpha2 = 50,
        Alpha3 = 51,
        Alpha4 = 52,
        Alpha5 = 53,
        Alpha6 = 54,
        Alpha7 = 55,
        Alpha8 = 56,
        Alpha9 = 57,
        Exclaim = 33,
        DoubleQuote = 34,
        Hash = 35,
        Dollar = 36,
        Percent = 37,
        Ampersand = 38,
        Quote = 39,
        LeftParen = 40,
        RightParen = 41,
        Asterisk = 42,
        Plus = 43,
        Comma = 44,
        Minus = 45,
        Period = 46,
        Slash = 47,
        Colon = 58,
        Semicolon = 59,
        Less = 60,
        Equals = 61,
        Greater = 62,
        Question = 0x3F,
        At = 0x40,
        LeftBracket = 91,
        Backslash = 92,
        RightBracket = 93,
        Caret = 94,
        Underscore = 95,
        BackQuote = 96,
        A = 97,
        B = 98,
        C = 99,
        D = 100,
        E = 101,
        F = 102,
        G = 103,
        H = 104,
        I = 105,
        J = 106,
        K = 107,
        L = 108,
        M = 109,
        N = 110,
        O = 111,
        P = 112,
        Q = 113,
        R = 114,
        S = 115,
        T = 116,
        U = 117,
        V = 118,
        W = 119,
        X = 120,
        Y = 121,
        Z = 122,
        LeftCurlyBracket = 123,
        Pipe = 124,
        RightCurlyBracket = 125,
        Tilde = 126,
        Numlock = 300,
        CapsLock = 301,
        ScrollLock = 302,
        RightShift = 303,
        LeftShift = 304,
        RightControl = 305,
        LeftControl = 306,
        RightAlt = 307,
        LeftAlt = 308,
        LeftCommand = 310,
        LeftApple = 310,
        LeftWindows = 311,
        RightCommand = 309,
        RightApple = 309,
        RightWindows = 312,
        AltGr = 313,
        Help = 315,
        Print = 316,
        SysReq = 317,
        Break = 318,
        Menu = 319,
        Mouse0 = 323,
        Mouse1 = 324,
        Mouse2 = 325,
        Mouse3 = 326,
        Mouse4 = 327,
        Mouse5 = 328,
        Mouse6 = 329,
        JoystickButton0 = 330,
        JoystickButton1 = 331,
        JoystickButton2 = 332,
        JoystickButton3 = 333,
        JoystickButton4 = 334,
        JoystickButton5 = 335,
        JoystickButton6 = 336,
        JoystickButton7 = 337,
        JoystickButton8 = 338,
        JoystickButton9 = 339,
        JoystickButton10 = 340,
        JoystickButton11 = 341,
        JoystickButton12 = 342,
        JoystickButton13 = 343,
        JoystickButton14 = 344,
        JoystickButton15 = 345,
        JoystickButton16 = 346,
        JoystickButton17 = 347,
        JoystickButton18 = 348,
        JoystickButton19 = 349,
        Joystick1Button0 = 350,
        Joystick1Button1 = 351,
        Joystick1Button2 = 352,
        Joystick1Button3 = 353,
        Joystick1Button4 = 354,
        Joystick1Button5 = 355,
        Joystick1Button6 = 356,
        Joystick1Button7 = 357,
        Joystick1Button8 = 358,
        Joystick1Button9 = 359,
        Joystick1Button10 = 360,
        Joystick1Button11 = 361,
        Joystick1Button12 = 362,
        Joystick1Button13 = 363,
        Joystick1Button14 = 364,
        Joystick1Button15 = 365,
        Joystick1Button16 = 366,
        Joystick1Button17 = 367,
        Joystick1Button18 = 368,
        Joystick1Button19 = 369,
        Joystick2Button0 = 370,
        Joystick2Button1 = 371,
        Joystick2Button2 = 372,
        Joystick2Button3 = 373,
        Joystick2Button4 = 374,
        Joystick2Button5 = 375,
        Joystick2Button6 = 376,
        Joystick2Button7 = 377,
        Joystick2Button8 = 378,
        Joystick2Button9 = 379,
        Joystick2Button10 = 380,
        Joystick2Button11 = 381,
        Joystick2Button12 = 382,
        Joystick2Button13 = 383,
        Joystick2Button14 = 384,
        Joystick2Button15 = 385,
        Joystick2Button16 = 386,
        Joystick2Button17 = 387,
        Joystick2Button18 = 388,
        Joystick2Button19 = 389,
        Joystick3Button0 = 390,
        Joystick3Button1 = 391,
        Joystick3Button2 = 392,
        Joystick3Button3 = 393,
        Joystick3Button4 = 394,
        Joystick3Button5 = 395,
        Joystick3Button6 = 396,
        Joystick3Button7 = 397,
        Joystick3Button8 = 398,
        Joystick3Button9 = 399,
        Joystick3Button10 = 400,
        Joystick3Button11 = 401,
        Joystick3Button12 = 402,
        Joystick3Button13 = 403,
        Joystick3Button14 = 404,
        Joystick3Button15 = 405,
        Joystick3Button16 = 406,
        Joystick3Button17 = 407,
        Joystick3Button18 = 408,
        Joystick3Button19 = 409,
        Joystick4Button0 = 410,
        Joystick4Button1 = 411,
        Joystick4Button2 = 412,
        Joystick4Button3 = 413,
        Joystick4Button4 = 414,
        Joystick4Button5 = 415,
        Joystick4Button6 = 416,
        Joystick4Button7 = 417,
        Joystick4Button8 = 418,
        Joystick4Button9 = 419,
        Joystick4Button10 = 420,
        Joystick4Button11 = 421,
        Joystick4Button12 = 422,
        Joystick4Button13 = 423,
        Joystick4Button14 = 424,
        Joystick4Button15 = 425,
        Joystick4Button16 = 426,
        Joystick4Button17 = 427,
        Joystick4Button18 = 428,
        Joystick4Button19 = 429,
        Joystick5Button0 = 430,
        Joystick5Button1 = 431,
        Joystick5Button2 = 432,
        Joystick5Button3 = 433,
        Joystick5Button4 = 434,
        Joystick5Button5 = 435,
        Joystick5Button6 = 436,
        Joystick5Button7 = 437,
        Joystick5Button8 = 438,
        Joystick5Button9 = 439,
        Joystick5Button10 = 440,
        Joystick5Button11 = 441,
        Joystick5Button12 = 442,
        Joystick5Button13 = 443,
        Joystick5Button14 = 444,
        Joystick5Button15 = 445,
        Joystick5Button16 = 446,
        Joystick5Button17 = 447,
        Joystick5Button18 = 448,
        Joystick5Button19 = 449,
        Joystick6Button0 = 450,
        Joystick6Button1 = 451,
        Joystick6Button2 = 452,
        Joystick6Button3 = 453,
        Joystick6Button4 = 454,
        Joystick6Button5 = 455,
        Joystick6Button6 = 456,
        Joystick6Button7 = 457,
        Joystick6Button8 = 458,
        Joystick6Button9 = 459,
        Joystick6Button10 = 460,
        Joystick6Button11 = 461,
        Joystick6Button12 = 462,
        Joystick6Button13 = 463,
        Joystick6Button14 = 464,
        Joystick6Button15 = 465,
        Joystick6Button16 = 466,
        Joystick6Button17 = 467,
        Joystick6Button18 = 468,
        Joystick6Button19 = 469,
        Joystick7Button0 = 470,
        Joystick7Button1 = 471,
        Joystick7Button2 = 472,
        Joystick7Button3 = 473,
        Joystick7Button4 = 474,
        Joystick7Button5 = 475,
        Joystick7Button6 = 476,
        Joystick7Button7 = 477,
        Joystick7Button8 = 478,
        Joystick7Button9 = 479,
        Joystick7Button10 = 480,
        Joystick7Button11 = 481,
        Joystick7Button12 = 482,
        Joystick7Button13 = 483,
        Joystick7Button14 = 484,
        Joystick7Button15 = 485,
        Joystick7Button16 = 486,
        Joystick7Button17 = 487,
        Joystick7Button18 = 488,
        Joystick7Button19 = 489,
        Joystick8Button0 = 490,
        Joystick8Button1 = 491,
        Joystick8Button2 = 492,
        Joystick8Button3 = 493,
        Joystick8Button4 = 494,
        Joystick8Button5 = 495,
        Joystick8Button6 = 496,
        Joystick8Button7 = 497,
        Joystick8Button8 = 498,
        Joystick8Button9 = 499,
        Joystick8Button10 = 500,
        Joystick8Button11 = 501,
        Joystick8Button12 = 502,
        Joystick8Button13 = 503,
        Joystick8Button14 = 504,
        Joystick8Button15 = 505,
        Joystick8Button16 = 506,
        Joystick8Button17 = 507,
        Joystick8Button18 = 508,
        Joystick8Button19 = 509
    }

    [ProtoContract]
    public class VilliageData
    {
        [ProtoMember(1)]
        public float X;
        [ProtoMember(2)]
        public float Y;
        [ProtoMember(3)]
        public int FloorIndex;
    }

    [ProtoContract]
    public class WorldState
    {
        [ProtoMember(1)]
        public DateTime PlayTime;
        [ProtoMember(2)]
        public DateTime SaveTime;
        [ProtoMember(3)]
        public int Index;
        [ProtoMember(4)]
        public int BagCount;
        [ProtoMember(5)]
        public string Seed;
        [ProtoMember(6)]
        public long WorldTicks;
        [ProtoMember(7)]
        public long LogTimes;
        [ProtoMember(8)]
        public bool IsCreated;
        [ProtoMember(9)]
        public bool ShowDeadMark;
        [ProtoMember(10)]
        public bool ShowHomeMark;
        [ProtoMember(11)]
        public double InGameTime;
        [ProtoMember(12)]
        public int Version;
        [ProtoMember(13)]
        public bool IsDead;
        [ProtoMember(14)]
        public List<int> HelpInfoIds;
        [ProtoMember(15)]
        public List<int> ShowedHelpInfos;
        [ProtoMember(16)]
        public bool IsShowHelpInfo;
        [ProtoMember(17)]
        public Dictionary<int, List<VilliageData>> Villiages;
        [ProtoMember(18)]
        public int CreatureIndex;
        [ProtoMember(19)]
        public List<int> WorkbenchFoundryLockedIds;
        [ProtoMember(20)]
        public int money;
        [ProtoMember(21)]
        public int DeepestFloor;
        [ProtoMember(22)]
        public int SeedHashCode;
        [ProtoMember(23)]
        public int BossVIndex;
        [ProtoMember(24)]
        public bool hasCreatedPlayer;
        [ProtoMember(25)]
        public int difficultyLevel;
        [ProtoMember(26)]
        public string MapName;
        [ProtoMember(27)]
        public int DungeonIndex;
        [ProtoMember(28)]
        public bool StopIntruder;
        [ProtoMember(29)]
        public int BossChallengeLevel;
    }

    [ProtoContract]
    public class ItemsDatas
    {
        [ProtoMember(1)]
        public Dictionary<int, ItemDatas> bagsData;
        [ProtoMember(2)]
        public Dictionary<int, float> ItemCds;
    }

    public enum BagType
    {
        MercenaryEquipBag = -3, // 0xFFFFFFFD
        PetBag = -2, // 0xFFFFFFFE
        CoocooChest = -1, // 0xFFFFFFFF
        BigBag = 0,
        EquipBag = 1,
        ChestBegin = 2,
    }

    [ProtoContract]
    public class ItemDatas
    {
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public BagType type;
        [ProtoMember(3)]
        public float fuelLeftSecs;
        [ProtoMember(4)]
        public float craftBeingSecs;
        [ProtoMember(5)]
        public long closeTicks;
        [ProtoMember(6)]
        public Dictionary<int, ItemData> items;
        [ProtoMember(7)]
        public int craftFoodCellId;
        [ProtoMember(8)]
        public int craftFoodCount;
        [ProtoMember(9)]
        public bool IsSellItem;

        [ProtoMember(10)]
        public int Money { get; set; }
    }

    [ProtoContract]
    public class DungeonData
    {
        [ProtoMember(1)]
        public int Index;
        [ProtoMember(2)]
        public int EnterX;
        [ProtoMember(3)]
        public int EnterY;
        [ProtoMember(4)]
        public int EnterFloor;
        [ProtoMember(5)]
        public int DungeonFloor;
        [ProtoMember(6)]
        public int BornX;
        [ProtoMember(7)]
        public int BornY;
        [ProtoMember(8)]
        public int ExitX;
        [ProtoMember(9)]
        public int ExitY;
        [ProtoMember(10)]
        public int StructureX;
        [ProtoMember(11)]
        public int StructureY;
        [ProtoMember(12)]
        public int StructureId;
        [ProtoMember(13)]
        public int MapId;
        [ProtoMember(14)]
        public int Version;
    }

    [ProtoContract]
    [Serializable]
    public class WeaponAttack
    {
        [ProtoMember(1)]
        public int ToCreatual;
        [ProtoMember(2)]
        public int ToTree;
        [ProtoMember(3)]
        public int ToWall;
        [ProtoMember(4)]
        public int ToBuild;
        [ProtoMember(5)]
        public int KnockBack;
        [ProtoMember(6)]
        public int DestroyLevel;
        [ProtoMember(7)]
        public float Speed;
        [ProtoMember(8)]
        public float Range;
        [ProtoMember(9)]
        public int ExploedDamage;
        [ProtoMember(10)]
        public int ExploedType;
        [ProtoMember(11)]
        public int AttackType;
        [ProtoMember(12)]
        public float CriticalChance;
        [ProtoMember(13)]
        public float CriticalDamage;
        [ProtoMember(14)]
        public int ReboundDamage;
        [ProtoMember(15)]
        public int FireDamage;
        [ProtoMember(16)]
        public float BulletFlyProgress;
    }

    public enum ItemType
    {
        None = 0,
        Food = 1,
        Weapon = 2,
        Placement = 4,
        Equip = 5,
        Usable = 6,
        UseToCreature = 7,
        NoneProgressUsable = 8,
        Fishing = 9,
        SkillItem = 10, // 0x0000000A
        RandomItemBag = 11, // 0x0000000B
        Clue = 12, // 0x0000000C
        PetFood = 13, // 0x0000000D
    }

    [ProtoContract]
    public class CageData
    {
        [ProtoMember(1)]
        public int CreatureId { get; set; }

        [ProtoMember(2)]
        public int BodyId { get; set; }

        [ProtoMember(3)]
        public int HairId { get; set; }

        [ProtoMember(4)]
        public int WeaponId { get; set; }

        [ProtoMember(5)]
        public int ArmourId { get; set; }
    }

    [ProtoContract]
    public class DropItemData
    {
        [ProtoMember(1)]
        public float PosX { get; set; }

        [ProtoMember(2)]
        public float PosY { get; set; }

        [ProtoMember(3)]
        public int FloorIndex { get; set; }

        [ProtoMember(4)]
        public int TimeSecs { get; set; }

        [ProtoMember(5)]
        public int DropType { get; set; }
    }

    [ProtoContract]
    public class ItemData
    {
        [ProtoMember(1)]
        public int id;
        [ProtoMember(4)]
        public int maxDurability;
        [ProtoMember(5)]
        public int curDurability;
        [ProtoMember(6)]
        public int count;
        [ProtoMember(7)]
        public WeaponAttack attack;
        [ProtoMember(8)]
        public ItemType type;
        [ProtoMember(9)]
        public int subType;
        [ProtoMember(10)]
        public int affixId;
        [ProtoMember(11)]
        public int defence;
        [ProtoMember(12)]
        public int equipBuff;
        [ProtoMember(13)]
        public int[] specialEffect;
        [ProtoMember(14)]
        public CageData cageData;
        [ProtoMember(15)]
        public int shopId;
        [ProtoMember(16)]
        public DropItemData dropItemData;
        [ProtoMember(18)]
        public VilliageData VilliageData;
        [ProtoMember(19)]
        public List<int> platingIds;
        [ProtoMember(20)]
        public int repairTimes;
        [ProtoMember(21)]
        public int equipSetId;
        [ProtoMember(22)]
        public List<int> equipSetEffects;
        [ProtoMember(23)]
        public int equipSetLevel;
        [ProtoMember(24)]
        public int equipBuff2;
    }

    [ProtoContract]
    public class DefenceDungeon
    {
        [ProtoMember(1)]
        public int X;
        [ProtoMember(2)]
        public int Y;
        [ProtoMember(3)]
        public int Floor;
        [ProtoMember(4)]
        public int EnterFloor;
        [ProtoMember(5)]
        public int State;
    }

    [ProtoContract]
    public class NpcManagerData
    {
        [ProtoMember(1)]
        public NpcCreateData[] List;
        [ProtoMember(2)]
        public long NextCreateTick;
        [ProtoMember(3)]
        public int Index;
    }

    [ProtoContract]
    public class NpcCreateData
    {
        [ProtoMember(1)]
        public int Seed;
        [ProtoMember(2)]
        public bool Read;
        [ProtoMember(3)]
        public int TalkIndex;
        [ProtoMember(4)]
        public bool Enable;
        [ProtoMember(5)]
        public int CreatureId;
        [ProtoMember(6)]
        public NpcHelpData HelpData;
    }

    [ProtoContract]
    public class NpcHelpData
    {
        [ProtoMember(1)]
        public int Floor;
        [ProtoMember(2)]
        public int X;
        [ProtoMember(3)]
        public int Y;
        [ProtoMember(4)]
        public int PlacementId;
        [ProtoMember(5)]
        public bool IsSave;
        [ProtoMember(6)]
        public int StructureId;
    }

    [ProtoContract]
    public struct PortalData
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public bool IsStarred;
        [ProtoMember(3)]
        public string Name;
        [ProtoMember(4)]
        public float X;
        [ProtoMember(5)]
        public float Y;
        [ProtoMember(6)]
        public int FloorIndex;
        [ProtoMember(7)]
        public int Duogeons;
    }

    [ProtoContract]
    public class IntruderData
    {
        [ProtoMember(4)]
        public int HomeId;
        [ProtoMember(5)]
        public int MapId;
        [ProtoMember(6)]
        public int HomeIndexX;
        [ProtoMember(7)]
        public int HomeIndexY;
        [ProtoMember(8)]
        public long HomeCreateTick;
        [ProtoMember(9)]
        public long HomeActiveTick;
        [ProtoMember(10)]
        public long TaskAcceptTick;
        [ProtoMember(11)]
        public long TaskCompleteTick;
        [ProtoMember(12)]
        public bool StopAutoBuild;
        [ProtoMember(13)]
        public int WorkerCount;
        [ProtoMember(14)]
        public int IntruderCount;
        [ProtoMember(15)]
        public long LastIntruderTick;
        [ProtoMember(16)]
        public long HoldTick;
        [ProtoMember(17)]
        public long SubIntruderTick;
        [ProtoMember(18)]
        public long DestroyTick;
        [ProtoMember(19)]
        public long SkipEventTick;
        [ProtoMember(20)]
        public long LastFighterTick;
        [ProtoMember(21)]
        public long AllowCaptainTick;
        [ProtoMember(22)]
        public long CaptainTick;

        [ProtoMember(1)]
        public int HomeX { get; set; }

        [ProtoMember(2)]
        public int HomeY { get; set; }

        [ProtoMember(3)]
        public int HomeFloor { get; set; }
    }

    [ProtoContract]
    public class NpcPlacementData
    {
        [ProtoMember(1)]
        public int Floor;
        [ProtoMember(2)]
        public int X;
        [ProtoMember(3)]
        public int Y;
        [ProtoMember(4)]
        public int PlacementId;
        [ProtoMember(5)]
        public bool IsUsed;
        [ProtoMember(6)]
        public int StructureId;
        [ProtoMember(7)]
        public int AreaStartX;
        [ProtoMember(8)]
        public int AreaStartY;
    }

    [ProtoContract]
    public class MercenaryDNAItem
    {
        [ProtoMember(1)]
        public int Count;
        [ProtoMember(2)]
        public bool New;
    }

    [ProtoContract]
    public class MercenaryManagerData
    {
        [ProtoMember(1)]
        public Dictionary<int, MercenaryDNAItem> Items;
        [ProtoMember(2)]
        public long ResetPlayerTick;
        [ProtoMember(3)]
        public List<MercenaryCreateData> CreateDatas;
    }

    [ProtoContract]
    public class MercenaryCreateData
    {
        [ProtoMember(1)]
        public int Seed;
        [ProtoMember(2)]
        public List<MercenaryEquipDNA> DNAs;
        [ProtoMember(3)]
        public List<MercenarySlotRate> Rates;
        [ProtoMember(4)]
        public List<int> Bans;
        [ProtoMember(5)]
        public bool Enable;
        [ProtoMember(6)]
        public int CreatureId;
    }

    [ProtoContract]
    public class MercenaryEquipDNA
    {
        [ProtoMember(1)]
        public int DNAId;
        [ProtoMember(2)]
        public int SlotIndex;
        [ProtoMember(3)]
        public int Rate;
    }

    [ProtoContract]
    public class MercenarySlotRate
    {
        [ProtoMember(1)]
        public int SlotIndex;
        [ProtoMember(2)]
        public int Rate;
    }

    [ProtoContract(SkipConstructor = true)]
    [ProtoInclude(100, typeof(BuffFieldAtOnce))]
    [ProtoInclude(101, typeof(BuffFieldLastSec))]
    [ProtoInclude(102, typeof(BuffFieldOver))]
    [ProtoInclude(103, typeof(BuffFieldLastFrame))]
    [ProtoInclude(104, typeof(BuffFieldLast3Sec))]
    [ProtoInclude(105, typeof(BuffFieldLast5Sec))]
    [ProtoInclude(106, typeof(BuffFieldLast10Sec))]
    [ProtoInclude(107, typeof(BuffFieldPet))]
    public class Buff
    {
        [ProtoMember(1)]
        public float MaxTime;
        [ProtoMember(2)]
        public int Id;
        [ProtoMember(3)]
        public float LeftTime;
        [ProtoMember(4)]
        public float EffectTime;
        [ProtoMember(5)]
        public bool Visable;
        [ProtoMember(6)]
        public float FieldValue;
        [ProtoMember(7)]
        public bool IsFirstGet;
        [ProtoMember(8)]
        public bool CanClean;
        [ProtoMember(9)]
        public string FieldName;
        [ProtoMember(10)]
        public float LastTime;
        [ProtoMember(11)]
        public int BuffType;
        [ProtoMember(12)]
        public int BuffLevel;
        [ProtoMember(13)]
        public int Index;
        [ProtoMember(14)]
        public int TypeIndex;
        [ProtoMember(15)]
        public int OverlayTimes;
        [ProtoMember(16)]
        public float allValuePercent;
    }

    [ProtoContract(SkipConstructor = true)]
    public class BuffFieldAtOnce : Buff
    {
    }

    [ProtoContract(SkipConstructor = true)]
    public class BuffFieldLast10Sec : Buff
    {
    }

    [ProtoContract(SkipConstructor = true)]
    public class BuffFieldLastSec : Buff
    {
    }

    [ProtoContract(SkipConstructor = true)]
    public class BuffFieldOver : Buff
    {
    }

    [ProtoContract(SkipConstructor = true)]
    public class BuffFieldLastFrame : Buff
    {
    }

    [ProtoContract(SkipConstructor = true)]
    public class BuffFieldLast3Sec : Buff
    {
    }

    [ProtoContract(SkipConstructor = true)]
    public class BuffFieldLast5Sec : Buff
    {
    }

    [ProtoContract(SkipConstructor = true)]
    public class BuffFieldPet : Buff
    {
    }

    [ProtoContract]
    public class DNAManager
    {
        [ProtoMember(1)]
        public List<DNAFormulaData> DNAFormulas;
        [ProtoMember(2)]
        public List<uint> UnlockDNAs;
        [ProtoMember(3)]
        public ushort CurFormulaIndex;
        [ProtoMember(4)]
        public Dictionary<ushort, uint> QuickItemDict;
        [ProtoMember(5)]
        public Dictionary<int, int> DNAMaterialsDict;
        [ProtoMember(6)]
        public Dictionary<int, int> DNAMaterialRedPoints;
    }

    [ProtoContract]
    public class DNAFormulaData
    {
        [ProtoMember(1)]
        public string Name;
        [ProtoMember(2)]
        public Dictionary<ushort, uint> Formula;
        [ProtoMember(3)]
        public Dictionary<ushort, uint> DNASet;
    }

    [ProtoContract]
    public class CharacterState
    {
        [ProtoMember(1)]
        public string Name;
        [ProtoMember(2)]
        public int Force;
        [ProtoMember(3)]
        public int WeaponId;
        [ProtoMember(4)]
        public int ArmourId;
        [ProtoMember(5)]
        public int MaxHp;
        [ProtoMember(6)]
        public int Hp;
        [ProtoMember(7)]
        public int MaxHunger;
        [ProtoMember(8)]
        public int Hunger;
        [ProtoMember(9)]
        public int CreatureId;
        [ProtoMember(10)]
        public int CurFloor;
        [ProtoMember(11)]
        public float CurPosX;
        [ProtoMember(12)]
        public float CurPosY;
        [ProtoMember(13)]
        public int ReliveFloor;
        [ProtoMember(14)]
        public float RelivePosX;
        [ProtoMember(15)]
        public float RelivePosY;
        [ProtoMember(16)]
        public int DeadFloor;
        [ProtoMember(17)]
        public float DeadPosX;
        [ProtoMember(18)]
        public float DeadPosY;
        [ProtoMember(19)]
        public int[] PartIds;
        [ProtoMember(20)]
        public int Sex;
        [ProtoMember(21)]
        public int ReliveBedX;
        [ProtoMember(22)]
        public int ReliveBedY;
        [ProtoMember(23)]
        public int DifficultyLevel;
        [ProtoMember(24)]
        public List<DeadData> DeadDatas;
        [ProtoMember(25)]
        public int money;
        [ProtoMember(26)]
        public int MaxEnergy;
        [ProtoMember(27)]
        public int Energy;
        [ProtoMember(28)]
        public long Guid;
    }

    [ProtoContract]
    public class DeadData
    {
        [ProtoMember(1)]
        public float DeadPosX;
        [ProtoMember(2)]
        public float DeadPosY;
        [ProtoMember(3)]
        public long DeadWorldTick;
        [ProtoMember(4)]
        public int DeadFloor;
    }

    [ProtoContract]
    public class PlayerState
    {
        public bool IsLoadFromBackup;
        [ProtoMember(1)]
        public DateTime PlayTime;
        [ProtoMember(2)]
        public DateTime SaveTime;
        [ProtoMember(3)]
        public int Index;
        [ProtoMember(4)]
        public double InGameTime;
        [ProtoMember(5)]
        public int Version;
        [ProtoMember(6)]
        public bool IsDead;
        [ProtoMember(7)]
        public bool IsCreated;
        [ProtoMember(8)]
        public int money;
        [ProtoMember(9)]
        public long LogTimes;
        [ProtoMember(10)]
        public int BagCount;
        [ProtoMember(11)]
        public long PlayerTicks;
        [ProtoMember(12)]
        public bool IsFirstInSpace;
        [ProtoMember(13)]
        public int FeedPetItemId;
        [ProtoMember(14)]
        public int FeedHorseItemId;
        [ProtoMember(15)]
        public int FixEnvironmentRemainSecond;
        [ProtoMember(16)]
        public List<int> WorkbenchFoundryLockedIds;
        [ProtoMember(17)]
        public Dictionary<int, int> PlayerSkillDictionary;
        [ProtoMember(18)]
        public int EquipedRSkill;
        [ProtoMember(19)]
        public int EquipedFSkill;
        [ProtoMember(20)]
        public float AutoFeedPetHp;
        [ProtoMember(21)]
        public float AutoFeedHorseHp;
        [ProtoMember(22)]
        public bool AutoFeedPetEnable;
        [ProtoMember(23)]
        public bool AutoFeedHorseEnable;
        [ProtoMember(24)]
        public int FeedMercenaryItemId;
        [ProtoMember(25)]
        public bool AutoFeedMercenaryEnable;
        [ProtoMember(26)]
        public float AutoFeedMercenaryHp;
    }

    public enum KeyBindingType
    {
        None = -1, // 0xFFFFFFFF
        MoveUp = 0,
        MoveDown = 1,
        MoveLeft = 2,
        MoveRight = 3,
        Quickbar1 = 4,
        Quickbar2 = 5,
        Quickbar3 = 6,
        Quickbar4 = 7,
        Quickbar5 = 8,
        Quickbar6 = 9,
        Quickbar7 = 10, // 0x0000000A
        Quickbar8 = 11, // 0x0000000B
        Quickbar9 = 12, // 0x0000000C
        Quickbar0 = 13, // 0x0000000D
        Clockwise = 14, // 0x0000000E
        Anticlockwise = 15, // 0x0000000F
        Backpack = 16, // 0x00000010
        Handcraft = 17, // 0x00000011
        OpenDoor = 18, // 0x00000012
        Unpack = 19, // 0x00000013
        Trash = 20, // 0x00000014
        MiniMap = 21, // 0x00000015
        BoundaryControl = 22, // 0x00000016
        BoundaryMiniMap = 23, // 0x00000017
        MiniMapClose = 24, // 0x00000018
        MiniMapZoomIn = 25, // 0x00000019
        MiniMapZoomOut = 26, // 0x0000001A
        MiniMapSetWaypoint = 27, // 0x0000001B
        MiniMapAddMarker = 28, // 0x0000001C
        MiniMapCurrentLocation = 29, // 0x0000001D
        MiniMapSelectMarkerColorLeft = 30, // 0x0000001E
        MiniMapSelectMarkerColorRight = 31, // 0x0000001F
        MiniMapRename = 32, // 0x00000020
        MiniMapDeleteMarker = 33, // 0x00000021
        MiniMapConfirm = 34, // 0x00000022
        MiniMapUp = 35, // 0x00000023
        MiniMapDown = 36, // 0x00000024
        MiniMapLeft = 37, // 0x00000025
        MiniMapRight = 38, // 0x00000026
        Achievement = 39, // 0x00000027
        DNA = 40, // 0x00000028
        Chat = 41, // 0x00000029
        BoundaryPetControl = 42, // 0x0000002A
        PetControlPaasive = 43, // 0x0000002B
        PetControlInitiative = 44, // 0x0000002C
        PetControlFollow = 45, // 0x0000002D
        OpenSkill = 46, // 0x0000002E
        UseSkill1 = 47, // 0x0000002F
        UseSkill2 = 48, // 0x00000030
    }

    [ProtoContract]
    public class ActiveMods
    {
        [ProtoMember(1)]
        public List<ulong> Ids;
    }

    [ProtoContract]
    public struct WaypointData
    {
        [ProtoMember(1)]
        public bool IsActive { get; set; }

        [ProtoMember(2)]
        public float X { get; set; }

        [ProtoMember(3)]
        public float Y { get; set; }
    }

    [ProtoContract]
    public struct PointMarkData
    {
        [ProtoMember(1)]
        public int Color { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public int Floor { get; set; }

        [ProtoMember(4)]
        public float X { get; set; }

        [ProtoMember(5)]
        public float Y { get; set; }

        [ProtoMember(6)]
        public int Index { get; set; }
    }

    [ProtoContract]
    public struct MiniMapPetData
    {
        [ProtoMember(1)]
        public float DisableTicks { get; set; }

        [ProtoMember(2)]
        public float X { get; set; }

        [ProtoMember(3)]
        public float Y { get; set; }

        [ProtoMember(4)]
        public int Floor { get; set; }

        [ProtoMember(5)]
        public string Name { get; set; }

        [ProtoMember(6)]
        public int Id { get; set; }

        [ProtoMember(7)]
        public float BeDyingTime { get; set; }

        [ProtoMember(8)]
        public long WorldTick { get; set; }

        [ProtoMember(9)]
        public int MarkType { get; set; }
    }

    [ProtoContract]
    public struct MiniMapCreatureData
    {
        [ProtoMember(1)]
        public float X { get; set; }

        [ProtoMember(2)]
        public float Y { get; set; }

        [ProtoMember(3)]
        public int Floor { get; set; }

        [ProtoMember(4)]
        public int Id { get; set; }

        [ProtoMember(5)]
        public int CreatureId { get; set; }

        [ProtoMember(6)]
        public long WorldTicks { get; set; }
    }

    [ProtoContract]
    public class MapVilliageData
    {
        [ProtoMember(1)]
        public float X;
        [ProtoMember(2)]
        public float Y;
        [ProtoMember(3)]
        public int FloorIndex;
        [ProtoMember(4)]
        public int VilliageId;
        [ProtoMember(5)]
        public int State;
        [ProtoMember(6)]
        public int PickIndex;
    }

    [ProtoContract]
    public class NpcClueData
    {
        [ProtoMember(1)]
        public int Index;
        [ProtoMember(2)]
        public int Floor;
        [ProtoMember(3)]
        public int X;
        [ProtoMember(4)]
        public int Y;
        [ProtoMember(5)]
        public bool New;
    }

    [ProtoContract]
    public struct MiniMapPlacementData
    {
        [ProtoMember(1)]
        public int PlacementX { get; set; }

        [ProtoMember(2)]
        public int PlacementY { get; set; }

        [ProtoMember(3)]
        public int Floor { get; set; }

        [ProtoMember(4)]
        public int PlacementId { get; set; }
    }

    [ProtoContract]
    public struct MapPetData
    {
        [ProtoMember(1)]
        public float X { get; set; }

        [ProtoMember(2)]
        public float Y { get; set; }

        [ProtoMember(3)]
        public int Floor { get; set; }

        [ProtoMember(4)]
        public int Id { get; set; }
    }

    [ProtoContract]
    public class StructureArea
    {
        [ProtoMember(1)]
        public Dictionary<int, OneTileData> needSaveDate;
        [ProtoMember(2)]
        public bool isCreatedStructure;
        [ProtoMember(3)]
        public int Version;
        [ProtoMember(4)]
        public bool isCreatedWorldClue;
        [ProtoMember(5)]
        public int keyHashCode;
    }

    [ProtoContract]
    public class OneTileData
    {
        [ProtoMember(13)]
        public List<AnimalData> animals;
        [ProtoMember(16)]
        public int Version;

        [ProtoMember(1)]
        public int X { get; set; }

        [ProtoMember(2)]
        public int Y { get; set; }

        [ProtoMember(3)]
        public int Terrain { get; set; }

        [ProtoMember(4)]
        public int Floor { get; set; }

        [ProtoMember(5)]
        public int Placement { get; set; }

        [ProtoMember(6)]
        public int FurnitureDirector { get; set; }

        [ProtoMember(7)]
        public int IsPlayerChange { get; set; }

        [ProtoMember(8)]
        public int ChestId { get; set; }

        [ProtoMember(9)]
        public long DisableTime { get; set; }

        [ProtoMember(10)]
        public long GrowTime { get; set; }

        [ProtoMember(11)]
        public int Default1 { get; set; }

        [ProtoMember(12)]
        public int Default2 { get; set; }

        [ProtoMember(14)]
        public int IsPlacement { get; set; }

        [ProtoMember(15)]
        public int StructureId { get; set; }

        [ProtoMember(17)]
        public int HideSurvey { get; set; }

        [ProtoMember(18)]
        public bool HasMiniMapId { get; set; }

        [ProtoMember(19)]
        public int UsingChestConnId { get; set; }

        [ProtoMember(20)]
        public long FireEndWorldTick { get; set; }

    }

    [ProtoContract]
    public class SelfAnimalData
    {
        [ProtoMember(21)]
        public int PetType;
        [ProtoMember(23)]
        public int TauntType;

        [ProtoMember(1)]
        public int OnwerId { get; set; }

        [ProtoMember(3)]
        public int CurHp { get; set; }

        [ProtoMember(4)]
        public int MaxHunger { get; set; }

        [ProtoMember(5)]
        public int CurHunger { get; set; }

        [ProtoMember(6)]
        public int ActionType { get; set; }

        [ProtoMember(7)]
        public int Kidney { get; set; }

        [ProtoMember(8)]
        public int ChestId { get; set; }

        [ProtoMember(12)]
        public string Name { get; set; }

        [ProtoMember(13)]
        public float StandX { get; set; }

        [ProtoMember(14)]
        public float StandY { get; set; }

        [ProtoMember(15)]
        public float BeDyingTime { get; set; }

        [ProtoMember(16)]
        public float AddAtk { get; set; }

        [ProtoMember(17)]
        public float AddDefend { get; set; }

        [ProtoMember(18)]
        public float AddMoveSpeed { get; set; }

        [ProtoMember(19)]
        public int PetBaseDataId { get; set; }

        [ProtoMember(20)]
        public ushort SubActionType { get; set; }

        [ProtoMember(22, IsPacked = false)]
        public long FeedWorldTicks { get; set; }
    }

    [ProtoContract]
    public class AnimalData
    {
        [ProtoMember(18)]
        public int Version;
        [ProtoMember(19)]
        public int OnwerType;
        [ProtoMember(20)]
        public SelfAnimalData SelfAnimalData;
        [ProtoMember(21)]
        public int HorseId;
        [ProtoMember(22)]
        public int PetId;
        [ProtoMember(23)]
        public int DataFloor;
        [ProtoMember(24)]
        public int MissionIndex;
        [ProtoMember(25)]
        public int MissionListId;
        [ProtoMember(26)]
        public int MissionId;
        [ProtoMember(27)]
        public float LifeTime;
        [ProtoMember(28)]
        public int MissionCreatedDay;
        [ProtoMember(30)]
        public MercenaryData MercenaryData;
        [ProtoMember(31)]
        public byte[] PetBag;
        [ProtoMember(32)]
        public int MissionRewardItem;
        [ProtoMember(33)]
        public int MissionRewardItemCount;
        [ProtoMember(34)]
        public NpcData npcData;
        [ProtoMember(35)]
        public int StructureId;

        public bool HasCreate { get; set; }

        [ProtoMember(1)]
        public int BronTime { get; set; }

        [ProtoMember(2, IsPacked = false)]
        public int XTransPosX { get; set; }

        [ProtoMember(3, IsPacked = false)]
        public int XTransPosY { get; set; }

        [ProtoMember(4, IsPacked = false)]
        public int X { get; set; }

        [ProtoMember(5, IsPacked = false)]
        public int Y { get; set; }

        [ProtoMember(6)]
        public bool Default { get; set; }

        [ProtoMember(7)]
        public int CreatureId { get; set; }

        [ProtoMember(8)]
        public int BodyId { get; set; }

        [ProtoMember(9)]
        public int HairId { get; set; }

        [ProtoMember(10)]
        public int WeaponId { get; set; }

        [ProtoMember(11)]
        public int ArmourId { get; set; }

        [ProtoMember(12)]
        public float ProductSecs { get; set; }

        [ProtoMember(13)]
        public float GrowSecs { get; set; }

        [ProtoMember(14)]
        public float DisableTicks { get; set; }

        [ProtoMember(15)]
        public float TransPosX { get; set; }

        [ProtoMember(16)]
        public float TransPosY { get; set; }

        [ProtoMember(17)]
        public float Hunger { get; set; }

    }

    [ProtoContract]
    public class MercenaryData
    {
        [ProtoMember(1)]
        public long Guid { get; set; }

        [ProtoMember(2)]
        public long OwnerGuid { get; set; }

        [ProtoMember(3)]
        public byte[] items { get; set; }

        [ProtoMember(4)]
        public MercenaryCreateData CreateData { get; set; }
    }

    public enum NPCActionType
    {
        None,
        Toilet,
        WashBasin,
        Shower,
        Tub,
        Bed,
        BedsideTable,
        Chair,
        SpaPool,
        Jukebox,
        Arcade,
        ChessTable,
        PokerTable,
        SimpleStage,
        SimpleStageMegaphone,
        SimpleStageGuitar,
        SmallChestTable,
        LongTable,
        BigSellTable,
        Model,
        TypeCount,
    }

    public enum NPCIdleActionType
    {
        None,
        DoNothing,
        Coffee,
        Megaphone,
        Guitar,
        Book,
        Food,
        BuyItem,
        Dance,
        WatchTalkShow,
        Count,
    }

    [ProtoContract]
    public class NpcData
    {
        [ProtoMember(1)]
        public NPCActionType ActionType;
        [ProtoMember(2)]
        public long ActionEndTick;
        [ProtoMember(3)]
        public int ActionPlacementX;
        [ProtoMember(4)]
        public int ActionPlacementY;
        [ProtoMember(5)]
        public int Exp;
        [ProtoMember(6)]
        public int TipProgress;
        [ProtoMember(7)]
        public int Money;
        [ProtoMember(8)]
        public int MoneyCreatedDay;
        [ProtoMember(9)]
        public int MissionRewardItem;
        [ProtoMember(10)]
        public int MissionRewardItemCount;
        [ProtoMember(11)]
        public NPCIdleActionType IdleActionType;
        [ProtoMember(12)]
        public long IdleActionEndTick;
        [ProtoMember(13)]
        public int ItemId;
    }
}
