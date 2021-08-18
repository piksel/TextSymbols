namespace Piksel.TextSymbols
{
    public static class Fa6Extensions
    {
        public static TextSymbol TextSymbol(this Fa6 symbol) 
          => new TextSymbol(char.ConvertFromUtf32((int)symbol));
    }

    public partial record TextSymbol {
      public static implicit operator TextSymbol(Fa6 fa6) => fa6.TextSymbol();
    }

    public enum Fa6: int
    {
        Exclamation = 0x21,
        Ditto,
        Hashtag,
        DollarSign,
        Percent,
        Ampersand,
        Apostrophe,
        BracketRound,
        BracketRoundRight,
        Asterisk,
        Plus,
        Comma,
        Hyphen,
        Period,
        SlashForward,
        D0,
        D1,
        D2,
        D3,
        D4,
        D5,
        D6,
        D7,
        D8,
        D9,
        Colon,
        Semicolon,
        LessThan,
        Equals,
        GreaterThan,
        Question,
        At,
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z,
        BracketSquare,
        SlashBack,
        BracketSquareRight,
        // ??? = 5e
        // ??? = 5f
        AccentGrave = 0x60,
        // ??? = [61..7a]
        BracketCurly = 0x7b,
        Pipe,
        BracketCurlyRight,
        Tilde,
        // ??? = [7f..a1]
        CentSign = 0xa2,
        SterlingSign,
        // ??? = a4
        YenSign = 0xa5,
        // ??? = a6
        Section = 0xa7,
        // ??? = a8
        Copyright = 0xa9,
        // ??? = aa
        AnglesLeft = 0xab,
        Corner,
        // ??? = ad
        Registered = 0xae,
        // ??? = af
        // ??? = b0
        PlusMinus = 0xb1,
        // ??? = b2
        // ??? = b3
        // ??? = b4
        // ??? = b5
        Paragraph = 0xb6,
        // ??? = b7
        // ??? = b8
        // ??? = b9
        // ??? = ba
        AnglesRight = 0xbb,
        // ??? = [bc..d6]
        Xmark = 0xd7,
        EmptySet,
        // ??? = [d9..f6]
        Divide = 0xf7,
        // ??? = [f8..2012]
        Minus = 0x2013,
        Dash,
        HorizontalRule,
        // ??? = 2016
        // ??? = 2017
        // ??? = 2018
        // ??? = 2019
        // ??? = 201a
        // ??? = 201b
        QuoteLeft = 0x201c,
        QuoteRight,
        // ??? = [201e..2038]
        AngleLeft = 0x2039,
        AngleRight,
        // ??? = [203b..20a3]
        LiraSign = 0x20a4,
        // ??? = 20a5
        // ??? = 20a6
        // ??? = 20a7
        RupeeSign = 0x20a8,
        WonSign,
        ShekelSign,
        // ??? = 20ab
        EuroSign = 0x20ac,
        // ??? = 20ad
        // ??? = 20ae
        // ??? = 20af
        // ??? = 20b0
        // ??? = 20b1
        // ??? = 20b2
        // ??? = 20b3
        HryvniaSign = 0x20b4,
        // ??? = 20b5
        // ??? = 20b6
        // ??? = 20b7
        TengeSign = 0x20b8,
        // ??? = 20b9
        // ??? = 20ba
        // ??? = 20bb
        // ??? = 20bc
        RubleSign = 0x20bd,
        // ??? = [20be..2121]
        Trademark = 0x2122,
        // ??? = [2123..2138]
        SquareInfo = 0x2139,
        // ??? = [213a..218f]
        ArrowLeft = 0x2190,
        ArrowUp,
        ArrowRight,
        ArrowDown,
        LeftRight,
        UpDown,
        // ??? = 2196
        SquareUpRight = 0x2197,
        // ??? = [2198..21a3]
        ArrowLeftFromLine = 0x21a4,
        ArrowUpFromLine,
        ArrowRightFromLine,
        ArrowDownFromLine,
        // ??? = [21a8..21b9]
        ArrowRotateLeft = 0x21ba,
        ArrowRotateRight,
        // ??? = 21bc
        // ??? = 21bd
        // ??? = 21be
        // ??? = 21bf
        // ??? = 21c0
        // ??? = 21c1
        // ??? = 21c2
        // ??? = 21c3
        ArrowRightArrowLeft = 0x21c4,
        // ??? = [21c5..21e3]
        ArrowLeftToLine = 0x21e4,
        ArrowRightToLine,
        // ??? = [21e6..2210]
        Sigma = 0x2211,
        // ??? = 2212
        // ??? = 2213
        // ??? = 2214
        // ??? = 2215
        // ??? = 2216
        // ??? = 2217
        // ??? = 2218
        // ??? = 2219
        SquareRoot = 0x221a,
        // ??? = 221b
        // ??? = 221c
        // ??? = 221d
        Infinity = 0x221e,
        // ??? = [221f..223e]
        WaveSine = 0x223f,
        // ??? = [2240..22c1]
        Intersection = 0x22c2,
        Union,
        // ??? = [22c4..2302]
        AngleUp = 0x2303,
        AngleDown,
        // ??? = [2305..2319]
        Watch = 0x231a,
        HourglassEnd,
        // ??? = [231c..2327]
        Keyboard = 0x2328,
        ChevronLeft,
        ChevronRight,
        DeleteLeft,
        // ??? = [232c..2398]
        Print = 0x2399,
        // ??? = [239a..23ce]
        Eject = 0x23cf,
        // ??? = [23d0..23e8]
        Forward = 0x23e9,
        Backward,
        // ??? = 23eb
        // ??? = 23ec
        ForwardFast = 0x23ed,
        BackwardFast,
        // ??? = 23ef
        AlarmClock = 0x23f0,
        Stopwatch,
        // ??? = 23f2
        Hourglass = 0x23f3,
        // ??? = 23f4
        // ??? = 23f5
        // ??? = 23f6
        // ??? = 23f7
        Pause = 0x23f8,
        Stop,
        // ??? = 23fa
        PowerOff = 0x23fb,
        // ??? = 23fc
        // ??? = 23fd
        Moon = 0x23fe,
        // ??? = [23ff..24bc]
        CircleH = 0x24bd,
        // ??? = [24be..259f]
        Square = 0x25a0,
        // ??? = [25a1..25ab]
        Rectangle = 0x25ac,
        // ??? = 25ad
        // ??? = 25ae
        // ??? = 25af
        // ??? = 25b0
        // ??? = 25b1
        Triangle = 0x25b2,
        // ??? = 25b3
        // ??? = 25b4
        // ??? = 25b5
        Play = 0x25b6,
        // ??? = [25b7..25ce]
        Circle = 0x25cf,
        CircleHalfStroke,
        // ??? = [25d1..25ff]
        Sun = 0x2600,
        Cloud,
        // ??? = 2602
        Snowman = 0x2603,
        Meteor,
        // ??? = [2605..260d]
        PhoneRotary = 0x260e,
        // ??? = 260f
        // ??? = 2610
        SquareCheck = 0x2611,
        // ??? = 2612
        // ??? = 2613
        // ??? = 2614
        MugHot = 0x2615,
        // ??? = 2616
        // ??? = 2617
        // ??? = 2618
        // ??? = 2619
        // ??? = 261a
        // ??? = 261b
        // ??? = 261c
        HandPointUp = 0x261d,
        // ??? = 261e
        // ??? = 261f
        SkullCrossbones = 0x2620,
        // ??? = 2621
        CircleRadiation = 0x2622,
        Biohazard,
        // ??? = 2624
        Ankh = 0x2625,
        // ??? = 2626
        // ??? = 2627
        // ??? = 2628
        // ??? = 2629
        StarAndCrescent = 0x262a,
        // ??? = 262b
        Khanda = 0x262c,
        // ??? = 262d
        Peace = 0x262e,
        YinYang,
        // ??? = 2630
        // ??? = 2631
        // ??? = 2632
        // ??? = 2633
        // ??? = 2634
        // ??? = 2635
        // ??? = 2636
        // ??? = 2637
        Dharmachakra = 0x2638,
        FaceFrown,
        // ??? = 263a
        // ??? = 263b
        // ??? = 263c
        // ??? = 263d
        // ??? = 263e
        Mercury = 0x263f,
        Venus,
        // ??? = 2641
        Mars = 0x2642,
        // ??? = [2643..2659]
        ChessKing = 0x265a,
        ChessQueen,
        ChessRook,
        ChessBishop,
        ChessKnight,
        ChessPawn,
        Spade,
        // ??? = 2661
        // ??? = 2662
        Club = 0x2663,
        // ??? = 2664
        Heart = 0x2665,
        Diamond,
        // ??? = [2667..2671]
        Recycle = 0x2672,
        // ??? = [2673..267f]
        DiceOne = 0x2680,
        DiceTwo,
        DiceThree,
        DiceFour,
        DiceFive,
        DiceSix,
        // ??? = [2686..2692]
        Anchor = 0x2693,
        Swords,
        // ??? = 2695
        ScaleBalanced = 0x2696,
        // ??? = 2697
        FlowerDaffodil = 0x2698,
        Gear,
        // ??? = 269a
        Atom = 0x269b,
        // ??? = 269c
        // ??? = 269d
        // ??? = 269e
        // ??? = 269f
        TriangleExclamation = 0x26a0,
        Bolt,
        VenusDouble,
        MarsDouble,
        VenusMars,
        MarsAndVenus,
        MarsStroke,
        Transgender,
        MarsStrokeUp,
        MarsStrokeRight,
        // ??? = 26aa
        // ??? = 26ab
        // ??? = 26ac
        // ??? = 26ad
        // ??? = 26ae
        // ??? = 26af
        Coffin = 0x26b0,
        // ??? = 26b1
        Neuter = 0x26b2,
        // ??? = [26b3..26bc]
        Futbol = 0x26bd,
        Baseball,
        // ??? = 26bf
        // ??? = 26c0
        // ??? = 26c1
        // ??? = 26c2
        // ??? = 26c3
        // ??? = 26c4
        CloudSun = 0x26c5,
        CloudRain,
        // ??? = [26c7..26de]
        Truck = 0x26df,
        // ??? = 26e0
        // ??? = 26e1
        // ??? = 26e2
        // ??? = 26e3
        // ??? = 26e4
        // ??? = 26e5
        // ??? = 26e6
        // ??? = 26e7
        ShieldCross = 0x26e8,
        ToriiGate,
        Church,
        // ??? = 26eb
        // ??? = 26ec
        // ??? = 26ed
        // ??? = 26ee
        // ??? = 26ef
        Mountains = 0x26f0,
        // ??? = 26f1
        // ??? = 26f2
        // ??? = 26f3
        // ??? = 26f4
        // ??? = 26f5
        // ??? = 26f6
        PersonSkiing = 0x26f7,
        IceSkate,
        // ??? = 26f9
        Campground = 0x26fa,
        // ??? = 26fb
        // ??? = 26fc
        GasPump = 0x26fd,
        // ??? = 26fe
        // ??? = 26ff
        Scissors = 0x2700,
        // ??? = 2701
        // ??? = 2702
        // ??? = 2703
        // ??? = 2704
        // ??? = 2705
        // ??? = 2706
        // ??? = 2707
        PlaneEngines = 0x2708,
        Envelope,
        HandFist,
        Hand,
        HandPeace,
        // ??? = 270d
        // ??? = 270e
        Pencil = 0x270f,
        // ??? = 2710
        PenNib = 0x2711,
        PenFancy,
        Check,
        // ??? = [2714..271c]
        Cross = 0x271d,
        // ??? = 271e
        // ??? = 271f
        // ??? = 2720
        StarOfDavid = 0x2721,
        // ??? = 2722
        // ??? = 2723
        // ??? = 2724
        // ??? = 2725
        // ??? = 2726
        // ??? = 2727
        Sparkles = 0x2728,
        // ??? = [2729..273e]
        Flower = 0x273f,
        // ??? = 2740
        // ??? = 2741
        // ??? = 2742
        // ??? = 2743
        Snowflake = 0x2744,
        // ??? = [2745..274d]
        SquareXmark = 0x274e,
        // ??? = [274f..27a0]
        SquareRight = 0x27a1,
        // ??? = [27a2..2933]
        TurnUp = 0x2934,
        TurnDown,
        // ??? = [2936..2b04]
        SquareLeft = 0x2b05,
        SquareUp,
        SquareDown,
        // ??? = [2b08..2b1a]
        SquareFull = 0x2b1b,
        // ??? = 2b1c
        // ??? = 2b1d
        // ??? = 2b1e
        // ??? = 2b1f
        // ??? = 2b20
        // ??? = 2b21
        // ??? = 2b22
        Hexagon = 0x2b23,
        // ??? = [2b24..2b4f]
        Star = 0x2b50,
        // ??? = [2b51..2b94]
        Right = 0x2b95,
        // ??? = [2b96..dfff]
        CaravanSimple = 0xe000,
        CatSpace,
        CoffeePot,
        Comet,
        FanTable,
        Faucet,
        // ??? = e006
        FirefoxBrowser = 0xe007,
        Galaxy,
        Garage,
        GarageCar,
        GarageOpen,
        Heat,
        HouseChimneyWindow,
        HouseDay,
        HousePersonLeave,
        HouseNight,
        HousePersonReturn,
        HouseSignal,
        Ideal,
        LampDesk,
        LampFloor,
        LightCeiling,
        LightSwitch,
        LightSwitchOff,
        LightSwitchOn,
        Microblog,
        Microwave,
        Outlet,
        Oven,
        PiedPiperSquare,
        PlanetMoon,
        // ??? = e020
        PoliceBox = 0xe021,
        PersonToPortal,
        PersonFromPortal,
        Radar,
        Raygun,
        Refrigerator,
        // ??? = e027
        Sensor = 0xe028,
        SensorTriangleExclamation,
        SensorFire,
        SensorOn,
        SensorCloud,
        Siren,
        SirenOn,
        SolarSystem,
        CircleSort,
        CircleSortDown,
        CircleSortUp,
        SpaceStationMoon,
        SpaceStationMoonConstruction,
        Sprinkler,
        // ??? = e036
        Starfighter = 0xe037,
        StarfighterTwinIonEngine,
        Starship,
        StarshipFreighter,
        SwordLaser,
        SwordLaserAlt,
        SwordsLaser,
        // ??? = e03e
        TemperatureArrowDown = 0xe03f,
        TemperatureArrowUp,
        Trailer,
        Transporter,
        Transporter1,
        Transporter2,
        Transporter3,
        TransporterEmpty,
        // ??? = e047
        UfoBeam = 0xe048,
        Unity,
        UserAlien,
        UserRobot,
        UserVisor,
        Vacuum,
        VacuumRobot,
        // ??? = e04f
        WindowFrameOpen = 0xe050,
        CoffinCross,
        Dailymotion,
        FolderArrowDown,
        FolderArrowUp,
        InstagramSquare,
        Mixer,
        Shopify,
        UserUnlock,
        Bacteria,
        Bacterium,
        BoxTissue,
        HandHoldingMedical,
        HandSparkles,
        HandsBubbles,
        HandshakeSimpleSlash,
        HandshakeSlash,
        HeadSideCough,
        HeadSideCoughSlash,
        HeadSideMask,
        HeadSideVirus,
        HouseChimneyUser,
        HouseLaptop,
        LungsVirus,
        PeopleArrowsLeftRight,
        PlaneSlash,
        PumpMedical,
        PumpSoap,
        ShieldVirus,
        Sink,
        // ??? = e06e
        Stopwatch20 = 0xe06f,
        ShopSlash,
        StoreSlash,
        ToiletPaperSlash,
        UsersSlash,
        Virus,
        VirusSlash,
        Viruses,
        Deezer,
        EdgeLegacy,
        GooglePay,
        Rust,
        Tiktok,
        Unsplash,
        Cloudflare,
        Guilded,
        Hive,
        Innosoft,
        Instalod,
        OctopusDeploy,
        Perbyte,
        Uncharted,
        Vest,
        VestPatches,
        WatchmanMonitoring,
        Wodu,
        Airplay,
        Alt,
        // ??? = e08b
        Angle = 0xe08c,
        Angle90,
        // ??? = e08e
        AppleCore = 0xe08f,
        ArrowDownFromDottedLine,
        ArrowDownLeft,
        ArrowDownLeftAndArrowUpRightToCenter,
        ArrowDownRight,
        ArrowDownToBracket,
        ArrowDownToDottedLine,
        ArrowDownToSquare,
        ArrowTrendDown,
        ArrowTrendUp,
        ArrowUpArrowDown,
        ArrowUpFromBracket,
        ArrowUpFromDottedLine,
        ArrowUpFromSquare,
        ArrowUpLeft,
        ArrowUpLeftFromCircle,
        ArrowUpRight,
        ArrowUpRightAndArrowDownLeftFromCenter,
        ArrowUpToDottedLine,
        ArrowsCross,
        ArrowsFromDottedLine,
        ArrowsFromLine,
        ArrowsMinimize,
        ArrowsToDottedLine,
        ArrowsToLine,
        AudioDescriptionSlash,
        AustralSign,
        Avocado,
        AwardSimple,
        BahtSign,
        BarsFilter,
        BarsSort,
        BasketShoppingSimple,
        BatteryExclamation,
        BatteryLow,
        Bee,
        BeerMug,
        BitcoinSign,
        BlockQuote,
        BoltAuto,
        BoltLightning,
        BoltSlash,
        BookArrowRight,
        BookArrowUp,
        BookBookmark,
        BookCircleArrowRight,
        BookCircleArrowUp,
        BookCopy,
        BookFont,
        BookOpenCover,
        BookSection,
        BookmarkSlash,
        BowlingBallPin,
        BoxCircleCheck,
        BracketsRound,
        BrainCircuit,
        BrakeWarning,
        BriefcaseBlank,
        Brightness,
        BrightnessLow,
        Browsers,
        Buildings,
        BurgerFries,
        BurgerGlass,
        CableCar,
        CalendarArrowDown,
        CalendarArrowUp,
        CalendarClock,
        CalendarHeart,
        CalendarImage,
        CalendarLines,
        CalendarRange,
        Calendars,
        CameraRotate,
        CameraSlash,
        CameraViewfinder,
        CartMinus,
        CartShoppingFast,
        CartXmark,
        Castle,
        CediSign,
        // ??? = e0e0
        ChartBullet = 0xe0e1,
        ChartCandlestick,
        ChartColumn,
        ChartGantt,
        ChartLineUp,
        ChartPyramid,
        ChartRadar,
        ChartScatter3d,
        ChartScatterBubble,
        ChartTreeMap,
        ChartWaterfall,
        Cherries,
        Circle0,
        Circle1,
        Circle2,
        Circle3,
        Circle4,
        Circle5,
        Circle6,
        Circle7,
        Circle8,
        Circle9,
        CircleA,
        CircleAmpersand,
        CircleArrowDownLeft,
        CircleArrowDownRight,
        CircleArrowUpLeft,
        CircleArrowUpRight,
        CircleB,
        CircleBolt,
        CircleBookOpen,
        CircleBookmark,
        CircleC,
        CircleCalendar,
        CircleCamera,
        CircleD,
        CircleDashed,
        CircleDivide,
        CircleDownLeft,
        CircleDownRight,
        CircleE,
        CircleEllipsis,
        CircleEllipsisVertical,
        CircleEnvelope,
        CircleExclamationCheck,
        CircleF,
        CircleG,
        CircleHalf,
        CircleI,
        CircleJ,
        CircleK,
        CircleL,
        CircleM,
        CircleMicrophone,
        CircleMicrophoneLines,
        CircleN,
        CircleO,
        CircleP,
        CirclePhone,
        CirclePhoneFlip,
        CirclePhoneHangup,
        CircleQ,
        CircleQuarter,
        CircleR,
        CircleS,
        CircleSmall,
        CircleStar,
        CircleT,
        CircleThreeQuarters,
        CircleTrash,
        CircleU,
        CircleUpLeft,
        CircleUpRight,
        CircleV,
        CircleVideo,
        CircleW,
        CircleWaveformLines,
        CircleX,
        CircleY,
        CircleZ,
        Clapperboard,
        ClapperboardPlay,
        ClipboardMedical,
        ClockDesk,
        ClosedCaptioningSlash,
        ClothesHanger,
        CloudSlash,
        CloudWord,
        Clover,
        CodeCompare,
        CodeFork,
        CodePullRequest,
        CodeSimple,
        CoffeeBean,
        CoffeeBeans,
        ColonSign,
        // ??? = e141
        Command = 0xe142,
        CommentArrowDown,
        CommentArrowUp,
        CommentArrowUpRight,
        CommentCaptions,
        CommentCode,
        CommentImage,
        CommentMiddle,
        CommentMiddleTop,
        CommentQuestion,
        CommentQuote,
        CommentText,
        CommentsQuestion,
        CommentsQuestionCheck,
        ConveyorBeltEmpty,
        CrateEmpty,
        CruzeiroSign,
        // ??? = e153
        DeleteRight = 0xe154,
        DesktopArrowDown,
        DiagramLeanCanvas,
        DiagramNested,
        DiagramSankey,
        // ??? = e159
        DiagramVenn = 0xe15a,
        Dial,
        DialHigh,
        DialLow,
        DialMax,
        DialMed,
        DialMedLow,
        DialMin,
        DialOff,
        Display,
        DisplayArrowDown,
        DisplayCode,
        DisplayMedical,
        // ??? = e167
        Dolphin = 0xe168,
        DongSign,
        DownLeft,
        DownRight,
        Eggplant,
        Elevator,
        Engine,
        EnvelopeDot,
        Envelopes,
        Escalator,
        EyeDropperFull,
        EyeDropperHalf,
        FerrisWheel,
        FileBinary,
        FileHeart,
        FilePlusMinus,
        Files,
        FilmSlash,
        Films,
        FilterCircleXmark,
        FilterList,
        FilterSlash,
        Filters,
        FireHydrant,
        FloppyDiskCircleArrowRight,
        FloppyDiskCircleXmark,
        FloppyDiskPen,
        FloppyDisks,
        FlorinSign,
        FolderBlank,
        FolderBookmark,
        FolderGear,
        FolderGrid,
        FolderHeart,
        FolderImage,
        FolderMagnifyingGlass,
        FolderMedical,
        FolderMusic,
        FolderUser,
        FrancSign,
        Gif,
        GlassEmpty,
        GlassHalf,
        Grate,
        GrateDroplet,
        Grid,
        Grid2,
        Grid2Plus,
        Grid4,
        Grid5,
        GuaraniSign,
        Gun,
        GunSlash,
        GunSquirt,
        HandBackPointDown,
        HandBackPointLeft,
        HandBackPointRibbon,
        HandBackPointRight,
        HandBackPointUp,
        HandFingersCrossed,
        HandHoldingSkull,
        HandLove,
        HandPointRibbon,
        HandWave,
        HandsClapping,
        HandHorns,
        HeadSideHeart,
        HeartHalf,
        HeartHalfStroke,
        HexagonDivide,
        HighDefinition,
        HighlighterLine,
        HouseUser,
        HouseBuilding,
        HouseChimneyHeart,
        HouseTree,
        HouseTurret,
        ImageLandscape,
        ImagePolaroidUser,
        ImageSlash,
        ImageUser,
        ImagesUser,
        InboxFull,
        Inboxes,
        IndianRupeeSign,
        InputNumeric,
        InputPipe,
        InputText,
        KeyboardBrightness,
        KeyboardBrightnessLow,
        KeyboardDown,
        KeyboardLeft,
        KipSign,
        LampStreet,
        LaptopArrowDown,
        LaptopSlash,
        LariSign,
        LassoSparkles,
        LightbulbExclamationOn,
        LinkHorizontal,
        LinkHorizontalSlash,
        LinkSimple,
        LinkSimpleSlash,
        ListDropdown,
        ListRadio,
        ListTimeline,
        ListTree,
        LitecoinSign,
        Loader,
        ManatSign,
        Manhole,
        MaskFace,
        Memo,
        MemoCircleCheck,
        MemoPad,
        MessageArrowDown,
        MessageArrowUp,
        MessageArrowUpRight,
        MessageCaptions,
        MessageCode,
        MessageImage,
        MessageMiddle,
        MessageMiddleTop,
        MessageQuestion,
        MessageQuote,
        MessageSms,
        MessageText,
        MessagesQuestion,
        Meter,
        MeterBolt,
        MeterDroplet,
        MeterFire,
        MicrochipAi,
        MillSign,
        MobileNotch,
        MobileSignal,
        MobileSignalOut,
        MoneyBillSimple,
        MoneyBillSimpleWave,
        MoneyBills,
        MoneyBillsSimple,
        MugTeaSaucer,
        NairaSign,
        Nfc,
        NfcLock,
        NfcMagnifyingGlass,
        NfcPen,
        NfcSignal,
        NfcSlash,
        NfcTrash,
        Notdef,
        Note,
        NoteMedical,
        Notebook,
        Notes,
        OctagonDivide,
        OctagonExclamation,
        OilCanDrip,
        PaintbrushPencil,
        // ??? = e207
        PalletBox = 0xe208,
        Panorama,
        PaperPlaneTop,
        Peach,
        Pear,
        Pedestal,
        PenCircle,
        PenClipSlash,
        PenFancySlash,
        PenField,
        PenLine,
        PenSlash,
        PenSwirl,
        PencilSlash,
        People,
        PeopleDress,
        PeopleDressSimple,
        PeoplePants,
        PeoplePantsSimple,
        PeopleSimple,
        PersonDressSimple,
        PersonPinball,
        PersonSeat,
        PersonSeatReclined,
        PersonSimple,
        PesetaSign,
        PesoSign,
        PhoneArrowDownLeft,
        PhoneArrowUpRight,
        PhoneHangup,
        PhoneMissed,
        PhoneXmark,
        PhotoFilmMusic,
        Pinball,
        // ??? = e22a
        PlaneProp = 0xe22b,
        PlaneTail,
        PlaneUp,
        PlaneUpSlash,
        PlayPause,
        // ??? = e230
        PuzzlePieceSimple = 0xe231,
        // ??? = e232
        // ??? = e233
        Quotes = 0xe234,
        RectanglePro,
        RectangleTerminal,
        RectangleVerticalHistory,
        Reel,
        ReplyClock,
        RestroomSimple,
        Rhombus,
        RotateExclamation,
        RupiahSign,
        Screencast,
        Scribble,
        SdCards,
        Seal,
        SealExclamation,
        SealQuestion,
        SeatAirline,
        // ??? = e245
        ShelvesEmpty = 0xe246,
        ShieldExclamation,
        ShieldKeyhole,
        ShieldMinus,
        ShieldPlus,
        ShieldSlash,
        ShieldXmark,
        ShowerDown,
        Sidebar,
        SidebarFlip,
        SignalStreamSlash,
        SimCards,
        Slider,
        SlidersSimple,
        Split,
        Square0,
        Square1,
        Square2,
        Square3,
        Square4,
        Square5,
        Square6,
        Square7,
        Square8,
        Square9,
        SquareA,
        SquareAmpersand,
        SquareArrowDownLeft,
        SquareArrowDownRight,
        SquareArrowUpLeft,
        SquareB,
        SquareBolt,
        SquareC,
        SquareCode,
        SquareD,
        SquareDashed,
        SquareDivide,
        SquareDownLeft,
        SquareDownRight,
        SquareE,
        SquareEllipsis,
        SquareEllipsisVertical,
        SquareF,
        SquareG,
        SquareI,
        SquareJ,
        SquareK,
        SquareL,
        SquareM,
        SquareN,
        SquareO,
        SquareP,
        SquarePhoneHangup,
        SquareQ,
        SquareR,
        SquareS,
        SquareSmall,
        SquareStar,
        SquareT,
        SquareU,
        SquareUpLeft,
        SquareUser,
        SquareV,
        SquareW,
        SquareX,
        SquareY,
        SquareZ,
        Stairs,
        StandardDefinition,
        StarSharp,
        StarSharpHalf,
        StarSharpHalfStroke,
        StarfighterTwinIonEngineAdvanced,
        SunBright,
        TableLayout,
        TablePivot,
        TableRows,
        TableTree,
        Tally1,
        Tally2,
        Tally3,
        Tally4,
        TaxiBus,
        TemperatureList,
        TicketAirline,
        TicketsAirline,
        Timeline,
        TimelineArrow,
        Timer,
        ToiletPaperBlankUnder,
        ToiletPaperUnder,
        ToiletPaperUnderSlash,
        TowerControl,
        TrainSubwayTunnel,
        TransformerBolt,
        Transporter4,
        Transporter5,
        Transporter6,
        Transporter7,
        TrashCanCheck,
        TrashCanClock,
        TrashCanList,
        TrashCanPlus,
        TrashCanSlash,
        TrashCanXmark,
        TrashCheck,
        TrashClock,
        TrashList,
        TrashPlus,
        TrashSlash,
        TrashXmark,
        TruckContainerEmpty,
        TruckFlatbed,
        TruckFront,
        TruckTow,
        TtyAnswer,
        TugrikSign,
        TurkishLiraSign,
        UmbrellaSimple,
        UpLeft,
        UpRight,
        UserBountyHunter,
        UserPilot,
        UserPilotTie,
        UserShakespeare,
        UtilityPole,
        UtilityPoleDouble,
        Vault,
        VectorCircle,
        VectorPolygon,
        VideoArrowDownLeft,
        VideoArrowUpRight,
        WandMagicSparkles,
        WatchApple,
        WatchSmart,
        WheatAwn,
        WheelchairMove,
        WifiExclamation,
        Wirsindhanderk,
        WrenchSimple,
        RobotAstromech,
        // ??? = [e2d3..e2db]
        D360Degrees = 0xe2dc,
        // ??? = e2dd
        // ??? = e2de
        Aperture = 0xe2df,
        // ??? = e2e0
        ArrowTurnDownLeft = 0xe2e1,
        // ??? = e2e2
        Balloon = 0xe2e3,
        Balloons,
        Banana,
        BangladeshiTakaSign,
        BenchTree,
        Blueberries,
        BowlChopsticks,
        BowlChopsticksNoodles,
        BowlRice,
        // ??? = e2ec
        // ??? = e2ed
        // ??? = e2ee
        // ??? = e2ef
        // ??? = e2f0
        // ??? = e2f1
        BriefcaseArrowRight = 0xe2f2,
        // ??? = e2f3
        Citrus = 0xe2f4,
        CitrusSlice,
        Coconut,
        // ??? = e2f7
        // ??? = e2f8
        // ??? = e2f9
        DisplaySlash = 0xe2fa,
        // ??? = e2fb
        // ??? = e2fc
        // ??? = e2fd
        FaceExplode = 0xe2fe,
        FaceViewfinder,
        Family,
        FamilyDress,
        FamilyPants,
        Fence,
        FishBones,
        // ??? = e305
        Grapes = 0xe306,
        GridHorizontal,
        // ??? = e308
        // ??? = e309
        // ??? = e30a
        // ??? = e30b
        KiwiFruit = 0xe30c,
        // ??? = e30d
        // ??? = e30e
        Mango = 0xe30f,
        Melon,
        MelonSlice,
        MoneyFromBracket,
        MoneySimpleFromBracket,
        // ??? = e314
        // ??? = e315
        Olive = 0xe316,
        OliveBranch,
        Option,
        // ??? = e319
        PartyBell = 0xe31a,
        PartyHorn,
        Peapod,
        // ??? = e31d
        PersonPregnant = 0xe31e,
        Pineapple,
        // ??? = e320
        // ??? = e321
        RectangleCode = 0xe322,
        RectanglesMixed,
        RollerCoaster,
        // ??? = e325
        // ??? = e326
        // ??? = e327
        // ??? = e328
        SquareQuote = 0xe329,
        SquareTerminal,
        Strawberry,
        // ??? = e32c
        TablePicnic = 0xe32d,
        ThoughtBubble,
        Tick,
        Tomato,
        TurnDownLeft,
        // ??? = e332
        UserPolice = 0xe333,
        UserPoliceTie,
        // ??? = e335
        // ??? = e336
        WatermelonSlice = 0xe337,
        WheatAwnSlash,
        WheatSlash,
        Badminton,
        Binary,
        BinaryCircleCheck,
        BinaryLock,
        BinarySlash,
        BootHeeled,
        Bots,
        CarBolt,
        CarCircleBolt,
        CarMirrors,
        CarSideBolt,
        ClockEight,
        ClockEightThirty,
        ClockEleven,
        ClockElevenThirty,
        ClockFive,
        ClockFiveThirty,
        ClockFourThirty,
        ClockNine,
        ClockNineThirty,
        ClockOne,
        ClockOneThirty,
        ClockSeven,
        ClockSevenThirty,
        ClockSix,
        ClockSixThirty,
        ClockTen,
        ClockTenThirty,
        ClockThree,
        ClockThreeThirty,
        ClockTwelve,
        ClockTwelveThirty,
        ClockTwo,
        ClockTwoThirty,
        CloudCheck,
        CloudMinus,
        CloudPlus,
        CloudXmark,
        Cmplid,
        Columns3,
        CrystalBall,
        CupStraw,
        CupStrawSwoosh,
        DistributeSpacingHorizontal,
        DistributeSpacingVertical,
        Eyes,
        FaceAngryHorns,
        FaceAnguished,
        FaceAnxiousSweat,
        FaceAstonished,
        FaceConfounded,
        FaceConfused,
        FaceCowboyHat,
        FaceDisappointed,
        FaceDisguise,
        FaceDowncastSweat,
        FaceDrooling,
        FaceExpressionless,
        FaceEyesXmarks,
        FaceFearful,
        FaceFrownSlight,
        FaceGlasses,
        FaceHandOverMouth,
        FaceHandYawn,
        FaceHeadBandage,
        FaceHushed,
        FaceIcicles,
        FaceKissClosedEyes,
        FaceLying,
        FaceMask,
        FaceMonocle,
        FaceNauseated,
        FaceNoseSteam,
        FaceParty,
        FacePensive,
        FacePersevering,
        FacePleading,
        FacePouting,
        FaceRaisedEyebrow,
        FaceRelieved,
        FaceSadSweat,
        FaceScream,
        FaceShush,
        FaceSleeping,
        FaceSleepy,
        FaceSmileHalo,
        FaceSmileHearts,
        FaceSmileHorns,
        FaceSmileRelaxed,
        FaceSmileTear,
        FaceSmileTongue,
        FaceSmileUpsideDown,
        FaceSmilingHands,
        FaceSmirking,
        FaceSunglasses,
        FaceSwear,
        FaceThermometer,
        FaceThinking,
        FaceTissue,
        FaceTongueMoney,
        FaceTongueSweat,
        FaceUnamused,
        FaceVomit,
        FaceWeary,
        FaceWoozy,
        FaceWorried,
        FaceZany,
        FaceZipper,
        FileLock,
        FileSlash,
        FishingRod,
        FlyingDisc,
        GalleryThumbnails,
        GoalNet,
        GolfFlagHole,
        GridDividers,
        HockeyStickPuck,
        HouseChimney,
        HouseChimneyBlank,
        HouseCrack,
        HouseMedical,
        HouseWindow,
        KeySkeletonLeftRight,
        LacrosseStick,
        LacrosseStickBall,
        MaskSnorkel,
        MessageBot,
        Moped,
        NestingDolls,
        ObjectsAlignBottom,
        ObjectsAlignCenterHorizontal,
        ObjectsAlignCenterVertical,
        ObjectsAlignLeft,
        ObjectsAlignRight,
        ObjectsAlignTop,
        ObjectsColumn,
        PaperclipVertical,
        Pinata,
        PipeSmoking,
        Pool8Ball,
        RugbyBall,
        ShirtLongSleeve,
        ShirtRunning,
        ShirtTankTop,
        SignatureLock,
        SignatureSlash,
        SkiBoot,
        SkiBootSki,
        SlotMachine,
        TeddyBear,
        TruckBolt,
        UniformMartialArts,
        UserChef,
        UserHairBuns,
        // ??? = [e3d4..efff]
        MartiniGlassEmpty = 0xf000,
        // ??? = f001
        // ??? = f002
        // ??? = f003
        // ??? = f004
        // ??? = f005
        // ??? = f006
        // ??? = f007
        // ??? = f008
        TableCellsLarge = 0xf009,
        TableCells,
        TableList,
        // ??? = f00c
        // ??? = f00d
        MagnifyingGlassPlus = 0xf00e,
        // ??? = f00f
        MagnifyingGlassMinus = 0xf010,
        // ??? = f011
        // ??? = f012
        // ??? = f013
        // ??? = f014
        // ??? = f015
        // ??? = f016
        // ??? = f017
        // ??? = f018
        Download = 0xf019,
        // ??? = f01a
        // ??? = f01b
        Inbox = 0xf01c,
        // ??? = f01d
        // ??? = f01e
        // ??? = f01f
        // ??? = f020
        // ??? = f021
        RectangleList = 0xf022,
        // ??? = f023
        // ??? = f024
        // ??? = f025
        VolumeOff = 0xf026,
        // ??? = f027
        // ??? = f028
        Qrcode = 0xf029,
        Barcode,
        // ??? = f02b
        Tags = 0xf02c,
        // ??? = f02d
        // ??? = f02e
        // ??? = f02f
        Camera = 0xf030,
        Font,
        Bold,
        Italic,
        TextHeight,
        TextWidth,
        AlignLeft,
        AlignCenter,
        AlignRight,
        AlignJustify,
        List,
        Outdent,
        Indent,
        Video,
        Image,
        // ??? = f03f
        // ??? = f040
        Location = 0xf041,
        // ??? = f042
        // ??? = f043
        PenToSquare = 0xf044,
        // ??? = f045
        // ??? = f046
        ArrowsUpDownLeftRight = 0xf047,
        BackwardStep,
        // ??? = f049
        // ??? = f04a
        // ??? = f04b
        // ??? = f04c
        // ??? = f04d
        // ??? = f04e
        // ??? = f04f
        // ??? = f050
        ForwardStep = 0xf051,
        // ??? = f052
        // ??? = f053
        // ??? = f054
        CirclePlus = 0xf055,
        CircleMinus,
        CircleXmark,
        CircleCheck,
        CircleQuestion,
        CircleInfo,
        Crosshairs,
        // ??? = f05c
        // ??? = f05d
        // ??? = f05e
        // ??? = f05f
        // ??? = f060
        // ??? = f061
        // ??? = f062
        // ??? = f063
        Share = 0xf064,
        Expand,
        Compress,
        // ??? = f067
        // ??? = f068
        // ??? = f069
        CircleExclamation = 0xf06a,
        // ??? = f06b
        Leaf = 0xf06c,
        // ??? = f06d
        // ??? = f06e
        // ??? = f06f
        EyeSlash = 0xf070,
        // ??? = f071
        Plane = 0xf072,
        CalendarDays,
        // ??? = f074
        // ??? = f075
        // ??? = f076
        ChevronUp = 0xf077,
        ChevronDown,
        Retweet,
        // ??? = f07a
        // ??? = f07b
        // ??? = f07c
        ArrowsUpDown = 0xf07d,
        ArrowsLeftRight,
        // ??? = f07f
        ChartBar = 0xf080,
        TwitterSquare,
        FacebookSquare,
        // ??? = f083
        // ??? = f084
        Gears = 0xf085,
        // ??? = f086
        // ??? = f087
        // ??? = f088
        StarHalf = 0xf089,
        // ??? = f08a
        ArrowRightFromBracket = 0xf08b,
        Linkedin,
        // ??? = f08d
        ArrowUpRightFromSquare = 0xf08e,
        // ??? = f08f
        ArrowRightToBracket = 0xf090,
        // ??? = f091
        GithubSquare = 0xf092,
        Upload,
        // ??? = f094
        // ??? = f095
        // ??? = f096
        // ??? = f097
        SquarePhone = 0xf098,
        Twitter,
        Facebook,
        Github,
        // ??? = f09c
        // ??? = f09d
        Rss = 0xf09e,
        // ??? = f09f
        // ??? = f0a0
        // ??? = f0a1
        // ??? = f0a2
        Certificate = 0xf0a3,
        HandPointRight,
        HandPointLeft,
        // ??? = f0a6
        HandPointDown = 0xf0a7,
        CircleArrowLeft,
        CircleArrowRight,
        CircleArrowUp,
        CircleArrowDown,
        // ??? = f0ac
        // ??? = f0ad
        ListCheck = 0xf0ae,
        // ??? = f0af
        Filter = 0xf0b0,
        // ??? = f0b1
        UpDownLeftRight = 0xf0b2,
        // ??? = [f0b3..f0bf]
        Users = 0xf0c0,
        // ??? = f0c1
        // ??? = f0c2
        Flask = 0xf0c3,
        // ??? = f0c4
        Copy = 0xf0c5,
        // ??? = f0c6
        // ??? = f0c7
        // ??? = f0c8
        Bars = 0xf0c9,
        ListUl,
        ListOl,
        Strikethrough,
        Underline,
        Table,
        // ??? = f0cf
        WandMagic = 0xf0d0,
        // ??? = f0d1
        Pinterest = 0xf0d2,
        PinterestSquare,
        GooglePlusSquare,
        GooglePlusG,
        MoneyBill,
        CaretDown,
        CaretUp,
        CaretLeft,
        CaretRight,
        TableColumns,
        Sort,
        SortDown,
        SortUp,
        // ??? = f0df
        // ??? = f0e0
        LinkedinIn = 0xf0e1,
        // ??? = f0e2
        Gavel = 0xf0e3,
        // ??? = f0e4
        // ??? = f0e5
        // ??? = f0e6
        // ??? = f0e7
        Sitemap = 0xf0e8,
        Umbrella,
        Paste,
        // ??? = f0eb
        // ??? = f0ec
        CloudArrowDown = 0xf0ed,
        CloudArrowUp,
        // ??? = f0ef
        UserDoctor = 0xf0f0,
        // ??? = f0f1
        // ??? = f0f2
        // ??? = f0f3
        MugSaucer = 0xf0f4,
        // ??? = f0f5
        // ??? = f0f6
        // ??? = f0f7
        // ??? = f0f8
        // ??? = f0f9
        SuitcaseMedical = 0xf0fa,
        JetFighter,
        BeerMugEmpty,
        SquareH,
        SquarePlus,
        // ??? = f0ff
        // ??? = f100
        // ??? = f101
        AnglesUp = 0xf102,
        AnglesDown,
        // ??? = f104
        // ??? = f105
        // ??? = f106
        // ??? = f107
        // ??? = f108
        // ??? = f109
        TabletButton = 0xf10a,
        MobileButton,
        // ??? = f10c
        // ??? = f10d
        // ??? = f10e
        // ??? = f10f
        Spinner = 0xf110,
        // ??? = f111
        // ??? = f112
        GithubAlt = 0xf113,
        // ??? = f114
        // ??? = f115
        // ??? = f116
        // ??? = f117
        // ??? = f118
        // ??? = f119
        // ??? = f11a
        Gamepad = 0xf11b,
        // ??? = f11c
        // ??? = f11d
        // ??? = f11e
        // ??? = f11f
        Terminal = 0xf120,
        Code,
        ReplyAll,
        // ??? = f123
        LocationArrow = 0xf124,
        Crop,
        CodeBranch,
        LinkSlash,
        // ??? = f128
        Info = 0xf129,
        // ??? = f12a
        Superscript = 0xf12b,
        Subscript,
        Eraser,
        // ??? = f12e
        // ??? = f12f
        Microphone = 0xf130,
        MicrophoneSlash,
        // ??? = f132
        // ??? = f133
        // ??? = f134
        Rocket = 0xf135,
        Maxcdn,
        CircleChevronLeft,
        CircleChevronRight,
        CircleChevronUp,
        CircleChevronDown,
        Html5,
        Css3,
        // ??? = f13d
        UnlockKeyhole = 0xf13e,
        // ??? = f13f
        Bullseye = 0xf140,
        Ellipsis,
        EllipsisVertical,
        SquareRss,
        CirclePlay,
        // ??? = f145
        SquareMinus = 0xf146,
        // ??? = f147
        ArrowTurnUp = 0xf148,
        ArrowTurnDown,
        // ??? = f14a
        SquarePen = 0xf14b,
        SquareArrowUpRight,
        ShareFromSquare,
        // ??? = f14e
        // ??? = f14f
        SquareCaretDown = 0xf150,
        SquareCaretUp,
        SquareCaretRight,
        // ??? = f153
        // ??? = f154
        // ??? = f155
        // ??? = f156
        // ??? = f157
        // ??? = f158
        // ??? = f159
        Btc = 0xf15a,
        // ??? = f15b
        // ??? = f15c
        ArrowDownAZ = 0xf15d,
        ArrowUpAZ,
        // ??? = f15f
        ArrowDownWideShort = 0xf160,
        ArrowUpWideShort,
        ArrowDown19,
        ArrowUp19,
        // ??? = f164
        // ??? = f165
        // ??? = f166
        Youtube = 0xf167,
        Xing,
        XingSquare,
        // ??? = f16a
        Dropbox = 0xf16b,
        StackOverflow,
        Instagram,
        Flickr,
        // ??? = f16f
        Adn = 0xf170,
        Bitbucket,
        // ??? = f172
        Tumblr = 0xf173,
        TumblrSquare,
        ArrowDownLong,
        ArrowUpLong,
        ArrowLeftLong,
        ArrowRightLong,
        Apple,
        Windows,
        Android,
        Linux,
        Dribbble,
        Skype,
        // ??? = f17f
        Foursquare = 0xf180,
        Trello,
        PersonDress,
        // ??? = f183
        Gratipay = 0xf184,
        // ??? = f185
        // ??? = f186
        BoxArchive = 0xf187,
        Bug,
        Vk,
        Weibo,
        Renren,
        Pagelines,
        StackExchange,
        // ??? = f18e
        // ??? = f18f
        // ??? = f190
        SquareCaretLeft = 0xf191,
        // ??? = f192
        Wheelchair = 0xf193,
        VimeoSquare,
        // ??? = f195
        // ??? = f196
        ShuttleSpace = 0xf197,
        Slack,
        SquareEnvelope,
        Wordpress,
        Openid,
        Bank,
        // ??? = f19d
        Yahoo = 0xf19e,
        // ??? = f19f
        Google = 0xf1a0,
        Reddit,
        RedditSquare,
        StumbleuponCircle,
        Stumbleupon,
        Delicious,
        Digg,
        PiedPiperPp,
        PiedPiperAlt,
        Drupal,
        Joomla,
        Language,
        // ??? = f1ac
        // ??? = f1ad
        Child = 0xf1ae,
        // ??? = f1af
        Paw = 0xf1b0,
        // ??? = f1b1
        Cube = 0xf1b2,
        Cubes,
        Behance,
        BehanceSquare,
        Steam,
        SteamSquare,
        // ??? = f1b8
        // ??? = f1b9
        // ??? = f1ba
        // ??? = f1bb
        Spotify = 0xf1bc,
        Deviantart,
        Soundcloud,
        // ??? = f1bf
        Database = 0xf1c0,
        FilePdf,
        FileWord,
        FileExcel,
        FilePowerpoint,
        // ??? = f1c5
        FileZipper = 0xf1c6,
        FileAudio,
        FileVideo,
        FileCode,
        Vine,
        Codepen,
        Jsfiddle,
        LifeRing,
        CircleNotch,
        // ??? = f1cf
        Rebel = 0xf1d0,
        Empire,
        GitSquare,
        Git,
        HackerNews,
        TencentWeibo,
        Qq,
        Weixin,
        PaperPlane,
        // ??? = f1d9
        ClockRotateLeft = 0xf1da,
        // ??? = f1db
        Heading = 0xf1dc,
        // ??? = f1dd
        Sliders = 0xf1de,
        // ??? = f1df
        ShareNodes = 0xf1e0,
        SquareShareNodes,
        // ??? = f1e2
        // ??? = f1e3
        Tty = 0xf1e4,
        Binoculars,
        // ??? = f1e6
        Slideshare = 0xf1e7,
        Twitch,
        Yelp,
        // ??? = f1ea
        Wifi = 0xf1eb,
        // ??? = f1ec
        Paypal = 0xf1ed,
        GoogleWallet,
        // ??? = f1ef
        CcVisa = 0xf1f0,
        CcMastercard,
        CcDiscover,
        CcAmex,
        CcPaypal,
        CcStripe,
        // ??? = f1f6
        // ??? = f1f7
        Trash = 0xf1f8,
        // ??? = f1f9
        // ??? = f1fa
        EyeDropper = 0xf1fb,
        // ??? = f1fc
        // ??? = f1fd
        ChartArea = 0xf1fe,
        // ??? = f1ff
        ChartPie = 0xf200,
        ChartLine,
        Lastfm,
        LastfmSquare,
        ToggleOff,
        ToggleOn,
        // ??? = f206
        // ??? = f207
        Ioxhost = 0xf208,
        Angellist,
        ClosedCaptioning,
        // ??? = f20b
        // ??? = f20c
        Buysellads = 0xf20d,
        Connectdevelop,
        // ??? = f20f
        Dashcube = 0xf210,
        Forumbee,
        Leanpub,
        Sellsy,
        Shirtsinbulk,
        Simplybuilt,
        Skyatlas,
        CartPlus,
        CartArrowDown,
        // ??? = f219
        // ??? = f21a
        // ??? = f21b
        // ??? = f21c
        StreetView = 0xf21d,
        HeartPulse,
        // ??? = [f21f..f22c]
        Genderless = 0xf22d,
        // ??? = f22e
        // ??? = f22f
        // ??? = f230
        PinterestP = 0xf231,
        Whatsapp,
        Server,
        UserPlus,
        UserXmark,
        // ??? = f236
        Viacoin = 0xf237,
        // ??? = f238
        TrainSubway = 0xf239,
        Medium,
        YCombinator,
        OptinMonster,
        Opencart,
        Expeditedssl,
        // ??? = f23f
        // ??? = f240
        BatteryThreeQuarters = 0xf241,
        BatteryHalf,
        BatteryQuarter,
        BatteryEmpty,
        ArrowPointer,
        ICursor,
        ObjectGroup,
        ObjectUngroup,
        NoteSticky,
        // ??? = f24a
        CcJcb = 0xf24b,
        CcDinersClub,
        Clone,
        // ??? = f24e
        // ??? = f24f
        // ??? = f250
        HourglassStart = 0xf251,
        HourglassEmpty,
        // ??? = f253
        // ??? = f254
        HandBackFist = 0xf255,
        // ??? = f256
        HandScissors = 0xf257,
        HandLizard,
        // ??? = f259
        HandPointer = 0xf25a,
        // ??? = f25b
        // ??? = f25c
        // ??? = f25d
        CreativeCommons = 0xf25e,
        // ??? = f25f
        Gg = 0xf260,
        GgCircle,
        Tripadvisor,
        Odnoklassniki,
        OdnoklassnikiSquare,
        GetPocket,
        WikipediaW,
        Safari,
        Chrome,
        Firefox,
        Opera,
        InternetExplorer,
        Tv,
        Contao,
        D500px,
        // ??? = f26f
        Amazon = 0xf270,
        CalendarPlus,
        CalendarMinus,
        CalendarXmark,
        CalendarCheck,
        Industry,
        // ??? = f276
        SignsPost = 0xf277,
        // ??? = f278
        // ??? = f279
        Message = 0xf27a,
        // ??? = f27b
        Houzz = 0xf27c,
        VimeoV,
        BlackTie,
        // ??? = f27f
        Fonticons = 0xf280,
        RedditAlien,
        Edge,
        // ??? = f283
        Codiepie = 0xf284,
        Modx,
        FortAwesome,
        Usb,
        ProductHunt,
        Mixcloud,
        Scribd,
        CirclePause,
        // ??? = f28c
        CircleStop = 0xf28d,
        // ??? = f28e
        // ??? = f28f
        BagShopping = 0xf290,
        BasketShopping,
        // ??? = f292
        Bluetooth = 0xf293,
        BluetoothB,
        // ??? = f295
        Gitlab = 0xf296,
        Wpbeginner,
        Wpforms,
        Envira,
        UniversalAccess,
        // ??? = f29b
        // ??? = f29c
        PersonWalkingWithCane = 0xf29d,
        AudioDescription,
        // ??? = f29f
        PhoneVolume = 0xf2a0,
        Braille,
        EarListen,
        HandsAslInterpreting,
        EarDeaf,
        Glide,
        GlideG,
        Hands,
        EyeLowVision,
        Viadeo,
        ViadeoSquare,
        Snapchat,
        // ??? = f2ac
        SnapchatSquare = 0xf2ad,
        PiedPiper,
        // ??? = f2af
        FirstOrder = 0xf2b0,
        Yoast,
        Themeisle,
        GooglePlus,
        FontAwesome,
        Handshake,
        EnvelopeOpen,
        // ??? = f2b7
        Linode = 0xf2b8,
        AddressBook,
        // ??? = f2ba
        AddressCard = 0xf2bb,
        // ??? = f2bc
        CircleUser = 0xf2bd,
        // ??? = f2be
        // ??? = f2bf
        // ??? = f2c0
        IdBadge = 0xf2c1,
        IdCard,
        // ??? = f2c3
        Quora = 0xf2c4,
        FreeCodeCamp,
        Telegram,
        TemperatureFull,
        TemperatureThreeQuarters,
        // ??? = f2c9
        TemperatureQuarter = 0xf2ca,
        TemperatureEmpty,
        // ??? = f2cc
        // ??? = f2cd
        Podcast = 0xf2ce,
        // ??? = f2cf
        // ??? = f2d0
        // ??? = f2d1
        WindowRestore = 0xf2d2,
        // ??? = f2d3
        // ??? = f2d4
        Bandcamp = 0xf2d5,
        Grav,
        Etsy,
        Imdb,
        Ravelry,
        Sellcast,
        Microchip,
        // ??? = f2dc
        Superpowers = 0xf2dd,
        Wpexplorer,
        // ??? = f2df
        Meetup = 0xf2e0,
        // ??? = f2e1
        // ??? = f2e2
        Fork = 0xf2e3,
        Knife,
        // ??? = f2e5
        ForkKnife = 0xf2e6,
        // ??? = f2e7
        CircleDollar = 0xf2e8,
        SquareDollar,
        RotateLeft,
        TrophyStar,
        // ??? = f2ec
        TrashCan = 0xf2ed,
        HexagonXmark,
        // ??? = f2ef
        OctagonXmark = 0xf2f0,
        // ??? = f2f1
        // ??? = f2f2
        StarExclamation = 0xf2f3,
        // ??? = f2f4
        RightFromBracket = 0xf2f5,
        RightToBracket,
        ShieldCheck,
        Scrubber,
        RotateRight,
        // ??? = f2fa
        RectangleVertical = 0xf2fb,
        RectangleWide,
        SquareQuestion,
        // ??? = f2fe
        // ??? = f2ff
        HexagonPlus = 0xf300,
        OctagonPlus,
        Images,
        // ??? = f303
        // ??? = f304
        PenClip = 0xf305,
        // ??? = f306
        HexagonMinus = 0xf307,
        OctagonMinus,
        DownLong,
        LeftLong,
        RightLong,
        UpLong,
        LockKeyhole,
        // ??? = f30e
        // ??? = f30f
        // ??? = f310
        // ??? = f311
        // ??? = f312
        H1 = 0xf313,
        H2,
        H3,
        FileCheck,
        FileXmark,
        FileMinus,
        FilePlus,
        FileExclamation,
        // ??? = f31b
        // ??? = f31c
        ArrowsMaximize = 0xf31d,
        Maximize,
        // ??? = f31f
        ExpandWide = 0xf320,
        SquareExclamation,
        ChevronsDown,
        ChevronsLeft,
        ChevronsRight,
        ChevronsUp,
        CompressWide,
        // ??? = f327
        // ??? = f328
        SquareChevronDown = 0xf329,
        SquareChevronLeft,
        SquareChevronRight,
        SquareChevronUp,
        CircleCaretDown,
        CircleCaretLeft,
        // ??? = f32f
        CircleCaretRight = 0xf330,
        CircleCaretUp,
        // ??? = f332
        CalendarPen = 0xf333,
        CalendarExclamation,
        Badge,
        BadgeCheck,
        // ??? = f337
        // ??? = f338
        SquareArrowDown = 0xf339,
        SquareArrowLeft,
        SquareArrowRight,
        SquareArrowUp,
        ArrowDownToLine,
        // ??? = f33e
        // ??? = f33f
        // ??? = f340
        ArrowUpToLine = 0xf341,
        // ??? = f342
        // ??? = f343
        // ??? = f344
        // ??? = f345
        UpFromLine = 0xf346,
        RightFromLine,
        LeftFromLine,
        DownFromLine,
        DownToLine,
        LeftToLine,
        RightToLine,
        UpToLine,
        // ??? = f34e
        // ??? = f34f
        // ??? = f350
        // ??? = f351
        // ??? = f352
        // ??? = f353
        Down = 0xf354,
        Left,
        // ??? = f356
        Up = 0xf357,
        CircleDown,
        CircleLeft,
        CircleRight,
        CircleUp,
        SquareFontAwesomeStroke,
        UpRightFromSquare,
        // ??? = f35e
        // ??? = f35f
        // ??? = f360
        ArrowsRetweet = 0xf361,
        RightLeft,
        // ??? = f363
        ArrowsRepeat = 0xf364,
        // ??? = f365
        ArrowsRepeat1 = 0xf366,
        ShareAll,
        AccessibleIcon,
        Accusoft,
        Adversal,
        Affiliatetheme,
        Algolia,
        Amilia,
        Angrycreative,
        AppStore,
        AppStoreIos,
        Apper,
        Asymmetrik,
        Audible,
        Avianex,
        Aws,
        BatteryBolt,
        BatterySlash,
        Bimobject,
        Bitcoin,
        Bity,
        Blackberry,
        Blogger,
        BloggerB,
        // ??? = f37e
        Buromobelexperte = 0xf37f,
        Centercode,
        // ??? = f381
        // ??? = f382
        Cloudscale = 0xf383,
        Cloudsmith,
        Cloudversify,
        CodeCommit,
        CodeMerge,
        Cpanel,
        CreditCardBlank,
        CreditCardFront,
        Css3Alt,
        Cuttlefish,
        DAndD,
        Deploydog,
        Deskpro,
        // ??? = f390
        DigitalOcean = 0xf391,
        Discord,
        Discourse,
        Dochub,
        Docker,
        Draft2digital,
        DribbbleSquare,
        // ??? = f398
        Dyalog = 0xf399,
        Earlybirds,
        EllipsisStroke,
        EllipsisStrokeVertical,
        Erlang,
        FacebookF,
        FacebookMessenger,
        FilmSimple,
        Firstdraft,
        FonticonsFi,
        FortAwesomeAlt,
        Freebsd,
        // ??? = f3a5
        Gitkraken = 0xf3a6,
        Gofore,
        Goodreads,
        GoodreadsG,
        GoogleDrive,
        GooglePlay,
        Gripfire,
        Grunt,
        Gulp,
        HackerNewsSquare,
        HireAHelper,
        Hotjar,
        Hubspot,
        // ??? = f3b3
        Itunes = 0xf3b4,
        ItunesNote,
        Jenkins,
        Joget,
        Js,
        JsSquare,
        Keycdn,
        Kickstarter,
        KickstarterK,
        Laravel,
        // ??? = f3be
        // ??? = f3bf
        Line = 0xf3c0,
        LockOpen,
        LockKeyholeOpen,
        Lyft,
        Magento,
        LocationDot,
        Medapps,
        // ??? = f3c7
        Medrt = 0xf3c8,
        // ??? = f3c9
        Microsoft = 0xf3ca,
        Mix,
        Mizuni,
        MobileScreenButton,
        // ??? = f3ce
        MobileScreen = 0xf3cf,
        Monero,
        MoneyBill1,
        Napster,
        NodeJs,
        Npm,
        Ns8,
        Nutritionix,
        Page4,
        Palfed,
        Patreon,
        Periscope,
        Phabricator,
        PhoenixFramework,
        PhoneSlash,
        // ??? = f3de
        Playstation = 0xf3df,
        ImagePortrait,
        Pushed,
        Python,
        RedRiver,
        Wpressr,
        Reply,
        Replyd,
        Resolving,
        Rocketchat,
        Rockrms,
        Schlix,
        Searchengin,
        Servicestack,
        ShieldBlank,
        Sistrix,
        // ??? = f3ef
        SquareSliders = 0xf3f0,
        SlidersUp,
        SquareSlidersVertical,
        Speakap,
        SpinnerThird,
        Staylinked,
        SteamSymbol,
        StickerMule,
        Studiovinari,
        Supple,
        TabletScreenButton,
        Tablet,
        TabletScreen,
        // ??? = f3fd
        // ??? = f3fe
        TicketSimple = 0xf3ff,
        // ??? = f400
        // ??? = f401
        Uber = 0xf402,
        Uikit,
        Uniregistry,
        Untappd,
        UserLarge,
        Ussunnah,
        Vaadin,
        Viber,
        Vimeo,
        Vnv,
        WhatsappSquare,
        Whmcs,
        Window,
        WindowFlip,
        RectangleXmark,
        WordpressSimple,
        Xbox,
        Yandex,
        YandexInternational,
        ApplePay,
        CcApplePay,
        Fly,
        // ??? = f418
        Node = 0xf419,
        Osi,
        React,
        Autoprefixer,
        Less,
        Sass,
        Vuejs,
        Angular,
        Aviato,
        DownLeftAndUpRightToCenter,
        Ember,
        UpRightAndDownLeftFromCenter,
        SquareFontAwesome,
        Gitter,
        Hooli,
        Strava,
        Stripe,
        StripeS,
        Typo3,
        AmazonPay,
        CcAmazonPay,
        Ethereum,
        Korvue,
        Elementor,
        YoutubeSquare,
        BaseballBatBall,
        // ??? = f433
        // ??? = f434
        BasketballHoop = 0xf435,
        BowlingBall,
        BowlingPins,
        // ??? = f438
        Chess = 0xf439,
        // ??? = f43a
        ChessBishopPiece = 0xf43b,
        ChessBoard,
        ChessClock,
        ChessClockFlip,
        // ??? = f43f
        ChessKingPiece = 0xf440,
        // ??? = f441
        ChessKnightPiece = 0xf442,
        // ??? = f443
        ChessPawnPiece = 0xf444,
        // ??? = f445
        ChessQueenPiece = 0xf446,
        // ??? = f447
        ChessRookPiece = 0xf448,
        // ??? = f449
        // ??? = f44a
        Dumbbell = 0xf44b,
        // ??? = f44c
        Flipboard = 0xf44d,
        // ??? = f44e
        FootballHelmet = 0xf44f,
        GolfBallTee,
        GolfClub,
        Hips,
        HockeyPuck,
        HockeySticks,
        LuchadorMask,
        // ??? = f456
        Php = 0xf457,
        Quidditch,
        Quinscape,
        Racquet,
        Shuttlecock,
        // ??? = f45c
        // ??? = f45d
        // ??? = f45e
        // ??? = f45f
        Whistle = 0xf460,
        HandDots,
        // ??? = f462
        RectangleBarcode = 0xf463,
        BarcodeRead,
        BarcodeScan,
        // ??? = f466
        BoxCheck = 0xf467,
        BoxesStacked,
        BriefcaseMedical,
        FireFlameSimple,
        Capsules,
        ClipboardCheck,
        ClipboardList,
        ConveyorBelt,
        ConveyorBeltBoxes,
        PersonDotsFromLine,
        // ??? = f471
        Dolly = 0xf472,
        DollyEmpty,
        CartFlatbed,
        CartFlatbedBoxes,
        CartFlatbedEmpty,
        FileMedical,
        FileWaveform,
        KitMedical,
        Forklift,
        HandHoldingBox,
        HandsHoldingDiamond,
        HospitalWide,
        // ??? = f47e
        IdCardClip = 0xf47f,
        Shelves,
        NotesMedical,
        Pallet,
        PalletBoxes,
        Pills,
        PrescriptionBottle,
        PrescriptionBottleMedical,
        BedPulse,
        ScannerGun,
        ScannerKeyboard,
        ScannerTouchscreen,
        TruckFast,
        TruckClock,
        // ??? = f48d
        // ??? = f48e
        TabletRugged = 0xf48f,
        Tablets,
        Thermometer,
        // ??? = f492
        Vials = 0xf493,
        Warehouse,
        WarehouseFull,
        WeightScale,
        XRay,
        Blanket,
        BookHeart,
        BoxTaped,
        SquareFragile,
        BoxOpenFull,
        BoxHeart,
        BoxOpen,
        SquareThisWayUp,
        BoxDollar,
        // ??? = f4a1
        MessageCheck = 0xf4a2,
        MessageDots,
        MessagePen,
        MessageExclamation,
        MessageLines,
        MessageMinus,
        MessagePlus,
        MessageSlash,
        MessageSmile,
        MessageXmark,
        CommentCheck,
        // ??? = f4ad
        CommentPen = 0xf4ae,
        CommentExclamation,
        CommentLines,
        CommentMinus,
        CommentPlus,
        CommentSlash,
        CommentSmile,
        CommentXmark,
        Messages,
        ContainerStorage,
        Couch,
        CircleDollarToSlot,
        // ??? = f4ba
        WineGlassCrack = 0xf4bb,
        HandHeart,
        HandHolding,
        HandHoldingHeart,
        HandHoldingSeedling,
        HandHoldingDollar,
        HandHoldingDroplet,
        HandsHolding,
        HandsHoldingHeart,
        HandshakeAngle,
        HandsHoldingDollar,
        // ??? = f4c6
        CircleHeart = 0xf4c7,
        // ??? = f4c8
        HouseHeart = 0xf4c9,
        Lamp,
        LeafHeart,
        Loveseat,
        ParachuteBox,
        PeopleCarryBox,
        PersonCarryBox,
        PersonDolly,
        PersonDollyEmpty,
        PhonePlus,
        PiggyBank,
        RampLoading,
        Readme,
        // ??? = f4d6
        Route = 0xf4d7,
        // ??? = f4d8
        SignHanging = 0xf4d9,
        // ??? = f4da
        Tape = 0xf4db,
        TruckContainer,
        TruckRampCouch,
        TruckRampBox,
        TruckMoving,
        TruckRamp,
        VideoPlus,
        VideoSlash,
        // ??? = f4e3
        Java = 0xf4e4,
        PiedPiperHat,
        // ??? = f4e6
        CreativeCommonsBy = 0xf4e7,
        CreativeCommonsNc,
        CreativeCommonsNcEu,
        CreativeCommonsNcJp,
        CreativeCommonsNd,
        CreativeCommonsPd,
        CreativeCommonsPdAlt,
        CreativeCommonsRemix,
        CreativeCommonsSa,
        CreativeCommonsSampling,
        CreativeCommonsSamplingPlus,
        CreativeCommonsShare,
        CreativeCommonsZero,
        Ebay,
        Keybase,
        Mastodon,
        RProject,
        Researchgate,
        Teamspeak,
        UserLargeSlash,
        UserAstronaut,
        UserCheck,
        UserClock,
        UserGear,
        UserPen,
        // ??? = f500
        UserGraduate = 0xf501,
        UserLock,
        UserMinus,
        // ??? = f504
        UserShield = 0xf505,
        UserSlash,
        UserTag,
        UserTie,
        UsersGear,
        FirstOrderAlt,
        Fulcrum,
        GalacticRepublic,
        GalacticSenate,
        JediOrder,
        Mandalorian,
        OldRepublic,
        PhoenixSquadron,
        Sith,
        TradeFederation,
        WolfPackBattalion,
        ScaleUnbalanced,
        ScaleUnbalancedFlip,
        Blender,
        // ??? = f518
        TowerBroadcast = 0xf519,
        // ??? = f51a
        Chalkboard = 0xf51b,
        ChalkboardUser,
        // ??? = f51d
        Coins = 0xf51e,
        // ??? = f51f
        Crow = 0xf520,
        // ??? = [f521..f52a]
        DoorOpen = 0xf52b,
        // ??? = f52c
        // ??? = f52d
        Frog = 0xf52e,
        // ??? = f52f
        Glasses = 0xf530,
        // ??? = f531
        GreaterThanEqual = 0xf532,
        // ??? = f533
        // ??? = f534
        KiwiBird = 0xf535,
        // ??? = f536
        LessThanEqual = 0xf537,
        Memory,
        MicrophoneLinesSlash,
        MoneyBillWave,
        MoneyBill1Wave,
        MoneyCheck,
        MoneyCheckDollar,
        NotEqual,
        // ??? = f53f
        // ??? = f540
        // ??? = f541
        DiagramProject = 0xf542,
        // ??? = f543
        // ??? = f544
        // ??? = f545
        RulerCombined = 0xf546,
        RulerHorizontal,
        RulerVertical,
        // ??? = f549
        // ??? = f54a
        ShoePrints = 0xf54b,
        // ??? = f54c
        // ??? = f54d
        Store = 0xf54e,
        Shop,
        BarsStaggered,
        Stroopwafel,
        // ??? = f552
        // ??? = f553
        // ??? = f554
        Wallet = 0xf555,
        // ??? = f556
        Archway = 0xf557,
        BookAtlas,
        Award,
        // ??? = f55a
        BezierCurve = 0xf55b,
        Bong,
        Brush,
        BusSimple,
        Cannabis,
        CheckDouble,
        MartiniGlassCitrus,
        // ??? = f562
        // ??? = f563
        CookieBite = 0xf564,
        CropSimple,
        TachographDigital,
        FaceDizzy,
        CompassDrafting,
        // ??? = f569
        DrumSteelpan = 0xf56a,
        FeatherPointed,
        FileContract,
        FileArrowDown,
        FileExport,
        FileImport,
        FileInvoice,
        FileInvoiceDollar,
        FilePrescription,
        FileSignature,
        FileArrowUp,
        Fill,
        FillDrip,
        Fingerprint,
        // ??? = [f578..f58b]
        FaceGrinWink = 0xf58c,
        Grip,
        GripVertical,
        HeadphonesSimple,
        Headset,
        Highlighter,
        Hornbill,
        HotTubPerson,
        // ??? = f594
        Joint = 0xf595,
        // ??? = f596
        // ??? = f597
        // ??? = f598
        FaceLaugh = 0xf599,
        // ??? = f59a
        FaceLaughSquint = 0xf59b,
        FaceLaughWink,
        CartFlatbedSuitcase,
        Mailchimp,
        MapLocation,
        MapLocationDot,
        Marker,
        // ??? = f5a2
        Megaport = 0xf5a3,
        // ??? = f5a4
        // ??? = f5a5
        Monument = 0xf5a6,
        MortarPestle,
        Nimblr,
        PaintBrushFine,
        PaintRoller,
        Passport,
        // ??? = f5ac
        // ??? = f5ad
        PenRuler = 0xf5ae,
        // ??? = f5af
        // ??? = f5b0
        Prescription = 0xf5b1,
        Rev,
        // ??? = f5b3
        // ??? = f5b4
        Shopware = 0xf5b5,
        // ??? = f5b6
        Signature = 0xf5b7,
        // ??? = f5b8
        FaceSmilePlus = 0xf5b9,
        SolarPanel,
        Spa,
        Splotch,
        SprayCan,
        Squarespace,
        Stamp,
        StarHalfStroke,
        SuitcaseRolling,
        // ??? = f5c2
        Swatchbook = 0xf5c3,
        // ??? = f5c4
        WaterLadder = 0xf5c5,
        Themeco,
        DropletSlash,
        // ??? = f5c8
        // ??? = f5c9
        // ??? = f5ca
        VectorSquare = 0xf5cb,
        Weebly,
        WeightHanging,
        WineGlassEmpty,
        Wix,
        SprayCanSparkles,
        // ??? = f5d1
        // ??? = f5d2
        AtomSimple = 0xf5d3,
        // ??? = f5d4
        BellSchool = 0xf5d5,
        BellSchoolSlash,
        // ??? = f5d7
        BoneBreak = 0xf5d8,
        // ??? = f5d9
        BookOpenReader = 0xf5da,
        // ??? = f5db
        // ??? = f5dc
        BusSchool = 0xf5dd,
        CarRear,
        CarBattery,
        CarBump,
        CarCrash,
        CarGarage,
        CarWrench,
        // ??? = f5e4
        CarTilt = 0xf5e5,
        CarWash,
        ChargingStation,
        ClipboardPrescription,
        CompassSlash,
        Diploma,
        DiamondTurnRight,
        DoNotEnter,
        DrawCircle,
        DrawPolygon,
        DrawSquare,
        // ??? = f5f0
        Ello = 0xf5f1,
        EngineWarning,
        FileCertificate,
        GasPumpSlash,
        // ??? = f5f5
        GlobeStand = 0xf5f6,
        Hackerrank,
        WavePulse,
        Inhaler,
        Kaggle,
        Kidneys,
        LaptopCode,
        LayerGroup,
        LayerMinus,
        LayerPlus,
        // ??? = f600
        LocationCrosshairs = 0xf601,
        CircleLocationArrow,
        LocationCrosshairsSlash,
        // ??? = f604
        LocationDotSlash = 0xf605,
        LocationCheck,
        LocationPen,
        LocationExclamation,
        LocationMinus,
        LocationPlus,
        LocationQuestion,
        LocationSlash,
        LocationSmile,
        LocationXmark,
        Markdown,
        // ??? = f610
        MonitorWaveform = 0xf611,
        Neos,
        OilCan,
        OilTemperature,
        CircleParking,
        BanParking,
        SquareParkingSlash,
        PenPaintbrush,
        Poop,
        RouteHighway,
        RouteInterstate,
        // ??? = f61c
        Scalpel = 0xf61d,
        ScalpelLineDashed,
        Shapes,
        Skeleton,
        StarOfLife,
        SteeringWheel,
        Stomach,
        GaugeMed,
        Gauge,
        GaugeMax,
        GaugeLow,
        GaugeMin,
        GaugeSimpleMed,
        GaugeSimple,
        GaugeSimpleMax,
        GaugeSimpleLow,
        GaugeSimpleMin,
        Teeth,
        TeethOpen,
        // ??? = f630
        Tire = 0xf631,
        TireFlat,
        TirePressureWarning,
        TireRugged,
        // ??? = f635
        TrafficCone = 0xf636,
        // ??? = f637
        TrafficLightGo = 0xf638,
        TrafficLightSlow,
        TrafficLightStop,
        TruckMonster,
        // ??? = f63c
        ScreenUsers = 0xf63d,
        WatchFitness,
        Zhihu,
        // ??? = f640
        RectangleAd = 0xf641,
        Alipay,
        ChartMixed,
        // ??? = f644
        BadgeDollar = 0xf645,
        BadgePercent,
        BookBible,
        // ??? = f648
        BullseyePointer = 0xf649,
        BriefcaseClock,
        // ??? = f64b
        CalculatorSimple = 0xf64c,
        // ??? = f64d
        ChartPieSimple = 0xf64e,
        // ??? = f64f
        MessageDollar = 0xf650,
        CommentDollar,
        MessagesDollar,
        CommentsDollar,
        // ??? = f654
        // ??? = f655
        // ??? = f656
        EnvelopeOpenDollar = 0xf657,
        EnvelopeOpenText,
        FileChartColumn,
        FileChartPie,
        FileSpreadsheet,
        FileUser,
        FolderMinus,
        FolderPlus,
        FolderXmark,
        Folders,
        Function,
        FilterCircleDollar,
        GiftCard,
        Gopuram,
        Hamsa,
        Bahai,
        Integral,
        // ??? = f668
        Jedi = 0xf669,
        BookJournalWhills,
        // ??? = f66b
        Keynote = 0xf66c,
        // ??? = f66d
        Lambda = 0xf66e,
        // ??? = f66f
        LightbulbDollar = 0xf670,
        LightbulbExclamation,
        LightbulbOn,
        LightbulbSlash,
        EnvelopesBulk,
        // ??? = f675
        Menorah = 0xf676,
        BrainArrowCurvedRight,
        // ??? = f678
        // ??? = f679
        Omega = 0xf67a,
        SpaghettiMonsterFlying,
        // ??? = f67c
        PhoneOffice = 0xf67d,
        Pi,
        PlaceOfWorship,
        Podium,
        SquarePollVertical,
        SquarePollHorizontal,
        // ??? = f683
        HandsPraying = 0xf684,
        PresentationScreen,
        PrintSlash,
        BookQuran,
        MagnifyingGlassDollar,
        MagnifyingGlassLocation,
        Shredder,
        // ??? = f68b
        SignalWeak = 0xf68c,
        SignalFair,
        SignalGood,
        SignalStrong,
        SignalBars,
        SignalBarsWeak,
        SignalBarsFair,
        SignalBarsGood,
        SignalBarsSlash,
        SignalSlash,
        // ??? = f696
        // ??? = f697
        SquareRootVariable = 0xf698,
        // ??? = f699
        // ??? = f69a
        // ??? = f69b
        Tally = 0xf69c,
        TheRedYeti,
        Theta,
        // ??? = f69f
        ScrollTorah = 0xf6a0,
        // ??? = f6a1
        // ??? = f6a2
        ChartUser = 0xf6a3,
        UserCrown,
        UserGroupCrown,
        ValueAbsolute,
        Vihara,
        // ??? = f6a8
        VolumeXmark = 0xf6a9,
        WifiWeak,
        WifiFair,
        WifiSlash,
        // ??? = f6ad
        Acorn = 0xf6ae,
        AcquisitionsIncorporated,
        Alicorn,
        CrateApple,
        // ??? = f6b2
        AxeBattle = 0xf6b3,
        // ??? = f6b4
        Bat = 0xf6b5,
        BlenderPhone,
        BookSkull,
        BookSparkles,
        // ??? = f6b9
        Campfire = 0xf6ba,
        // ??? = f6bb
        // ??? = f6bc
        CandyCorn = 0xf6bd,
        // ??? = f6be
        Cauldron = 0xf6bf,
        // ??? = f6c0
        ChairOffice = 0xf6c1,
        ClawMarks,
        CloudMoon,
        // ??? = f6c4
        CupTogo = 0xf6c5,
        // ??? = f6c6
        // ??? = f6c7
        // ??? = f6c8
        CriticalRole = 0xf6c9,
        DAndDBeyond,
        Dagger,
        Dev,
        DiceD10,
        DiceD12,
        DiceD20,
        DiceD4,
        DiceD6,
        DiceD8,
        // ??? = f6d3
        // ??? = f6d4
        // ??? = f6d5
        // ??? = f6d6
        DrumstickBite = 0xf6d7,
        // ??? = f6d8
        Dungeon = 0xf6d9,
        // ??? = f6da
        EyeEvil = 0xf6db,
        FantasyFlightGames,
        FileCsv,
        // ??? = f6de
        FireFlame = 0xf6df,
        FlaskRoundPoison,
        FlaskRoundPotion,
        // ??? = f6e2
        // ??? = f6e3
        HammerWar = 0xf6e4,
        HandHoldingMagic,
        // ??? = f6e6
        HatWitch = 0xf6e7,
        HatWizard,
        HeadSide,
        HeadSideGoggles,
        HelmetBattle,
        PersonHiking,
        // ??? = f6ed
        HockeyMask = 0xf6ee,
        HoodCloak,
        // ??? = f6f0
        HouseChimneyCrack = 0xf6f1,
        // ??? = f6f2
        // ??? = f6f3
        // ??? = f6f4
        // ??? = f6f5
        // ??? = f6f6
        LeafOak = 0xf6f7,
        Mace,
        Mandolin,
        Mask,
        // ??? = f6fb
        // ??? = f6fc
        // ??? = f6fd
        Narwhal = 0xf6fe,
        NetworkWired,
        // ??? = f700
        PawSimple = 0xf701,
        PawClaws,
        Pegasus,
        PennyArcade,
        // ??? = f705
        // ??? = f706
        Pumpkin = 0xf707,
        // ??? = f708
        RabbitRunning = 0xf709,
        // ??? = f70a
        Ring = 0xf70b,
        // ??? = f70c
        Scarecrow = 0xf70d,
        // ??? = f70e
        ScrollOld = 0xf70f,
        Scythe,
        // ??? = f711
        // ??? = f712
        Shovel = 0xf713,
        // ??? = f714
        Slash = 0xf715,
        // ??? = f716
        // ??? = f717
        SpiderBlackWidow = 0xf718,
        // ??? = f719
        Squirrel = 0xf71a,
        Staff,
        // ??? = f71c
        // ??? = f71d
        // ??? = f71e
        ToiletPaperBlank = 0xf71f,
        Tombstone,
        // ??? = f721
        // ??? = f722
        TreasureChest = 0xf723,
        Trees,
        Turkey,
        // ??? = f726
        // ??? = f727
        UserInjured = 0xf728,
        VrCardboard,
        Wand,
        WandSparkles,
        // ??? = f72c
        Wheat = 0xf72d,
        Wind,
        WineBottle,
        WizardsOfTheCoast,
        ThinkPeaks,
        Ballot,
        BallotCheck,
        BoothCurtain,
        // ??? = f735
        CalendarStar = 0xf736,
        ClipboardListCheck,
        CloudDrizzle,
        CloudHail,
        CloudHailMixed,
        CloudMeatball,
        CloudMoonRain,
        // ??? = f73d
        CloudRainbow = 0xf73e,
        CloudShowers,
        CloudShowersHeavy,
        CloudSleet,
        // ??? = f742
        // ??? = f743
        Clouds = 0xf744,
        CloudsMoon,
        CloudsSun,
        Democrat,
        DropletDegree,
        Eclipse,
        MoonOverSun,
        FireSmoke,
        FlagSwallowtail,
        FlagUsa,
        // ??? = f74e
        HouseFlood = 0xf74f,
        DropletPercent,
        Hurricane,
        LandmarkDome,
        // ??? = f753
        MoonCloud = 0xf754,
        MoonStars,
        PersonBooth,
        PersonSign,
        PodiumStar,
        PollPeople,
        PooBolt,
        // ??? = f75b
        Raindrops = 0xf75c,
        Reacteurope,
        Republican,
        Smog,
        Smoke,
        SnowBlowing,
        Stars,
        // ??? = f763
        SunDust = 0xf764,
        SunHaze,
        // ??? = f766
        // ??? = f767
        TemperatureSnow = 0xf768,
        TemperatureHigh,
        TemperatureSun,
        TemperatureLow,
        // ??? = f76c
        CloudBoltMoon = 0xf76d,
        CloudBoltSun,
        // ??? = f76f
        // ??? = f770
        XmarkToSlot = 0xf771,
        CheckToSlot,
        Water,
        WaterArrowDown,
        WaterArrowUp,
        WindWarning,
        Windsock,
        // ??? = f778
        Angel = 0xf779,
        Artstation,
        Atlassian,
        Baby,
        BabyCarriage,
        BallPile,
        Bells,
        // ??? = f780
        Blog = 0xf781,
        // ??? = f782
        CalendarDay = 0xf783,
        CalendarWeek,
        CanadianMapleLeaf,
        CandyCane,
        // ??? = f787
        CashRegister = 0xf788,
        Centos,
        ChartNetwork,
        Chimney,
        Minimize,
        Confluence,
        // ??? = f78e
        DeerRudolph = 0xf78f,
        Dhl,
        Diaspora,
        Dreidel,
        Dumpster,
        DumpsterFire,
        EarMuffs,
        Ethernet,
        Fedex,
        Fedora,
        Figma,
        Fireplace,
        SnowmanHead,
        Gifts,
        GingerbreadMan,
        ChampagneGlass,
        // ??? = f79f
        // ??? = f7a0
        WhiskeyGlassIce = 0xf7a1,
        EarthEuropa,
        GlobeSnow,
        GripLines,
        GripLinesVertical,
        Guitar,
        HatSanta,
        HatWinter,
        // ??? = f7a9
        HollyBerry = 0xf7aa,
        HorseHead,
        // ??? = f7ac
        Icicles = 0xf7ad,
        Igloo,
        Intercom,
        Invision,
        Jira,
        LightsHoliday,
        Mendeley,
        Mistletoe,
        Mitten,
        // ??? = f7b6
        MugMarshmallows = 0xf7b7,
        Ornament,
        Radiation,
        // ??? = f7ba
        RaspberryPi = 0xf7bb,
        Redhat,
        Restroom,
        Rv,
        // ??? = f7bf
        // ??? = f7c0
        // ??? = f7c1
        SdCard = 0xf7c2,
        ShovelSnow,
        SimCard,
        PersonSkating,
        Sketch,
        PersonSkiJumping,
        PersonSkiLift,
        // ??? = f7c9
        PersonSkiingNordic = 0xf7ca,
        PersonSledding,
        Sleigh,
        CommentSms,
        // ??? = f7ce
        Snowflakes = 0xf7cf,
        // ??? = f7d0
        PersonSnowmobiling = 0xf7d1,
        Snowplow,
        Sourcetree,
        StarChristmas,
        Stocking,
        Suse,
        // ??? = f7d7
        // ??? = f7d8
        ScrewdriverWrench = 0xf7d9,
        // ??? = f7da
        // ??? = f7db
        TreeDecorated = 0xf7dc,
        TreeLarge,
        TruckPlow,
        Ubuntu,
        Ups,
        Usps,
        Wreath,
        Yarn,
        FireFlameCurved,
        // ??? = f7e5
        BookMedical = 0xf7e6,
        BookUser,
        BooksMedical,
        BracketsSquare,
        BracketsCurly,
        // ??? = f7eb
        BreadSlice = 0xf7ec,
        // ??? = f7ed
        ChartScatter = 0xf7ee,
        Cheese,
        // ??? = f7f0
        // ??? = f7f1
        HouseChimneyMedical = 0xf7f2,
        ClipboardUser,
        MessageMedical,
        CommentMedical,
        // ??? = f7f6
        Crutch = 0xf7f7,
        Crutches,
        BanBug,
        Disease,
        // ??? = f7fb
        EggFried = 0xf7fc,
        FilesMedical,
        FishCooked,
        // ??? = f7ff
        // ??? = f800
        // ??? = f801
        FolderTree = 0xf802,
        // ??? = f803
        // ??? = f804
        Burger = 0xf805,
        // ??? = f806
        HelmetSafety = 0xf807,
        HeadSideBrain,
        HeadSideMedical,
        HouseBlank,
        // ??? = f80b
        // ??? = f80c
        HospitalUser = 0xf80d,
        Hospitals,
        // ??? = f80f
        // ??? = f810
        // ??? = f811
        LaptopMedical = 0xf812,
        // ??? = f813
        // ??? = f814
        // ??? = f815
        // ??? = f816
        // ??? = f817
        PizzaSlice = 0xf818,
        // ??? = f819
        PrintMagnifyingGlass = 0xf81a,
        RingsWedding,
        Sack,
        // ??? = f81d
        // ??? = f81e
        // ??? = f81f
        Sausage = 0xf820,
        ShishKebab,
        Sickle,
        BowlHot,
        // ??? = f824
        Stretcher = 0xf825,
        // ??? = f826
        BookTanakh = 0xf827,
        BarsProgress,
        TrashArrowUp,
        TrashCanArrowUp,
        // ??? = f82b
        // ??? = f82c
        UserHeadset = 0xf82d,
        UserDoctorMessage,
        UserNurse,
        UsersMedical,
        Walker,
        CameraWeb,
        CameraWebSlash,
        Airbnb,
        BattleNet,
        Bootstrap,
        Buffer,
        Chromecast,
        Evernote,
        ItchIo,
        Salesforce,
        SpeakerDeck,
        Symfony,
        WaveSquare,
        Waze,
        Yammer,
        GitAlt,
        Stackpath,
        AlarmExclamation,
        AlarmPlus,
        AlarmSnooze,
        AlignSlash,
        // ??? = f847
        BellExclamation = 0xf848,
        BellPlus,
        // ??? = f84a
        // ??? = f84b
        BorderAll = 0xf84c,
        BorderBottom,
        BorderInner,
        BorderLeft,
        BorderNone,
        BorderOuter,
        BorderRight,
        BorderTopLeft,
        BorderBottomRight,
        BorderTop,
        BringForward,
        BringFront,
        BurgerSoda,
        CarBuilding,
        CarBus,
        Cars,
        // ??? = f85c
        TrianglePersonDigging = 0xf85d,
        PersonDigging,
        Drone,
        DroneFront,
        Dryer,
        DryerHeat,
        Fan,
        Farm,
        FileMagnifyingGlass,
        FontCase,
        GameBoard,
        GameBoardSimple,
        GlassCitrus,
        H4,
        HatChef,
        // ??? = f86c
        Icons = 0xf86d,
        // ??? = f86e
        Kerning = 0xf86f,
        LineColumns,
        LineHeight,
        MoneyCheckPen,
        MoneyCheckDollarPen,
        Mug,
        MugTea,
        Overline,
        FileDashedLine,
        ParagraphLeft,
        // ??? = f879
        LaptopMobile = 0xf87a,
        SquarePhoneFlip,
        PhotoFilm,
        TextSlash,
        SendBack,
        SendBackward,
        // ??? = f880
        ArrowDownZA = 0xf881,
        ArrowUpZA,
        ArrowDownArrowUp,
        ArrowDownShortWide,
        ArrowUpShortWide,
        ArrowDown91,
        ArrowUp91,
        ArrowDownTriangleSquare,
        ArrowDownSquareTriangle,
        ArrowUpTriangleSquare,
        ArrowUpSquareTriangle,
        ArrowDownBigSmall,
        ArrowDownSmallBig,
        ArrowUpBigSmall,
        ArrowUpSmallBig,
        // ??? = f890
        SpellCheck = 0xf891,
        // ??? = f892
        Text = 0xf893,
        TextSize,
        TrashUndo,
        TrashCanUndo,
        Voicemail,
        WashingMachine,
        // ??? = f899
        WaveTriangle = 0xf89a,
        WindTurbine,
        BorderCenterH,
        BorderCenterV,
        CottonBureau,
        // ??? = f89f
        AlbumCollection = 0xf8a0,
        AmpGuitar,
        BadgeSheriff,
        // ??? = f8a3
        CassetteBetamax = 0xf8a4,
        // ??? = f8a5
        BuyNLarge = 0xf8a6,
        // ??? = f8a7
        // ??? = f8a8
        // ??? = f8a9
        CameraPolaroid = 0xf8aa,
        // ??? = f8ab
        CameraCctv = 0xf8ac,
        Clarinet,
        CloudMusic,
        MessageMusic,
        CommentMusic,
        ComputerClassic,
        ComputerSpeaker,
        Cowbell,
        CowbellCirclePlus,
        DiscDrive,
        FileMusic,
        FilmCanister,
        // ??? = f8b8
        Flute = 0xf8b9,
        FluxCapacitor,
        GameConsoleHandheld,
        // ??? = f8bc
        Gramophone = 0xf8bd,
        // ??? = f8be
        Guitars = 0xf8bf,
        HatCowboy,
        HatCowboySide,
        HeadSideHeadphones,
        HorseSaddle,
        ImagePolaroid,
        // ??? = f8c5
        Jug = 0xf8c6,
        Kazoo,
        Lasso,
        ListMusic,
        Mdb,
        // ??? = f8cb
        // ??? = f8cc
        ComputerMouseScrollwheel = 0xf8cd,
        Mp3Player,
        MusicNote,
        MusicNoteSlash,
        MusicSlash,
        Orcid,
        // ??? = f8d3
        Piano = 0xf8d4,
        // ??? = f8d5
        Projector = 0xf8d6,
        // ??? = f8d7
        RadioTuner = 0xf8d8,
        RecordVinyl,
        Router,
        SaxophoneFire,
        // ??? = f8dc
        SignalStream = 0xf8dd,
        SkullCow,
        Speaker,
        Speakers,
        Swift,
        TriangleInstrument,
        // ??? = f8e3
        Turntable = 0xf8e4,
        // ??? = f8e5
        TvMusic = 0xf8e6,
        Typewriter,
        Umbraco,
        UsbDrive,
        UserCowboy,
        UserMusic,
        // ??? = f8ec
        // ??? = f8ed
        WagonCovered = 0xf8ee,
        WalkieTalkie,
        WatchCalculator,
        Waveform,
        WaveformLines,
        Scanner,
        AirConditioner,
        // ??? = f8f5
        // ??? = f8f6
        BedFront = 0xf8f7,
        BedBunk,
        // ??? = f8f9
        // ??? = f8fa
        Blinds = 0xf8fb,
        BlindsOpen,
        BlindsRaised,
        CameraSecurity,
        Caravan,
        // ??? = [f900..1f17e]
        SquareParking = 0x1f17f,
        // ??? = [1f180..1f304]
        Sunrise = 0x1f305,
        // ??? = 1f306
        Sunset = 0x1f307,
        Rainbow,
        // ??? = 1f309
        // ??? = 1f30a
        Volcano = 0x1f30b,
        // ??? = 1f30c
        EarthAfrica = 0x1f30d,
        EarthAmericas,
        EarthAsia,
        Globe,
        // ??? = [1f311..1f31f]
        StarShooting = 0x1f320,
        TemperatureHalf,
        // ??? = 1f322
        // ??? = 1f323
        SunCloud = 0x1f324,
        // ??? = 1f325
        CloudSunRain = 0x1f326,
        // ??? = 1f327
        CloudSnow = 0x1f328,
        CloudBolt,
        Tornado,
        CloudFog,
        // ??? = 1f32c
        Hotdog = 0x1f32d,
        Taco,
        Burrito,
        // ??? = 1f330
        Seedling = 0x1f331,
        Tree,
        TreeDeciduous,
        TreePalm,
        Cactus,
        PepperHot,
        FlowerTulip,
        // ??? = 1f338
        // ??? = 1f339
        // ??? = 1f33a
        // ??? = 1f33b
        // ??? = 1f33c
        Corn = 0x1f33d,
        // ??? = 1f33e
        // ??? = 1f33f
        // ??? = 1f340
        LeafMaple = 0x1f341,
        // ??? = [1f342..1f34a]
        Lemon = 0x1f34b,
        // ??? = 1f34c
        // ??? = 1f34d
        AppleWhole = 0x1f34e,
        // ??? = 1f34f
        // ??? = 1f350
        // ??? = 1f351
        // ??? = 1f352
        // ??? = 1f353
        BurgerCheese = 0x1f354,
        Pizza,
        Meat,
        Drumstick,
        // ??? = 1f358
        // ??? = 1f359
        // ??? = 1f35a
        // ??? = 1f35b
        // ??? = 1f35c
        // ??? = 1f35d
        BreadLoaf = 0x1f35e,
        FrenchFries,
        // ??? = 1f360
        // ??? = 1f361
        // ??? = 1f362
        // ??? = 1f363
        // ??? = 1f364
        // ??? = 1f365
        // ??? = 1f366
        // ??? = 1f367
        IceCream = 0x1f368,
        // ??? = 1f369
        Cookie = 0x1f36a,
        // ??? = [1f36b..1f373]
        Utensils = 0x1f374,
        // ??? = 1f375
        // ??? = 1f376
        WineGlass = 0x1f377,
        MartiniGlass,
        // ??? = 1f379
        // ??? = 1f37a
        // ??? = 1f37b
        // ??? = 1f37c
        // ??? = 1f37d
        // ??? = 1f37e
        Popcorn = 0x1f37f,
        // ??? = 1f380
        Gift = 0x1f381,
        CakeCandles,
        JackOLantern,
        TreeChristmas,
        // ??? = [1f385..1f391]
        Backpack = 0x1f392,
        GraduationCap,
        // ??? = 1f394
        // ??? = 1f395
        // ??? = 1f396
        Ribbon = 0x1f397,
        // ??? = 1f398
        MicrophoneLines = 0x1f399,
        // ??? = 1f39a
        // ??? = 1f39b
        // ??? = 1f39c
        // ??? = 1f39d
        Film = 0x1f39e,
        Ticket,
        // ??? = 1f3a0
        // ??? = 1f3a1
        // ??? = 1f3a2
        // ??? = 1f3a3
        MicrophoneStand = 0x1f3a4,
        CameraMovie,
        // ??? = 1f3a6
        Headphones = 0x1f3a7,
        Palette,
        // ??? = 1f3a9
        // ??? = 1f3aa
        // ??? = 1f3ab
        // ??? = 1f3ac
        MasksTheater = 0x1f3ad,
        GamepadModern,
        BullseyeArrow,
        // ??? = 1f3b0
        // ??? = 1f3b1
        Dice = 0x1f3b2,
        // ??? = 1f3b3
        // ??? = 1f3b4
        Music = 0x1f3b5,
        // ??? = 1f3b6
        Saxophone = 0x1f3b7,
        GuitarElectric,
        PianoKeyboard,
        Trumpet,
        Violin,
        // ??? = 1f3bc
        // ??? = 1f3bd
        TennisBall = 0x1f3be,
        // ??? = 1f3bf
        Basketball = 0x1f3c0,
        FlagCheckered,
        PersonSnowboarding,
        PersonRunning,
        // ??? = 1f3c4
        Medal = 0x1f3c5,
        Trophy,
        // ??? = 1f3c7
        Football = 0x1f3c8,
        // ??? = 1f3c9
        PersonSwimming = 0x1f3ca,
        // ??? = 1f3cb
        // ??? = 1f3cc
        Motorcycle = 0x1f3cd,
        // ??? = 1f3ce
        CricketBatBall = 0x1f3cf,
        Volleyball,
        FieldHockeyStickBall,
        // ??? = 1f3d2
        TableTennisPaddleBall = 0x1f3d3,
        Mountain,
        // ??? = 1f3d5
        UmbrellaBeach = 0x1f3d6,
        // ??? = 1f3d7
        // ??? = 1f3d8
        City = 0x1f3d9,
        // ??? = 1f3da
        Landmark = 0x1f3db,
        // ??? = 1f3dc
        IslandTropical = 0x1f3dd,
        // ??? = 1f3de
        // ??? = 1f3df
        House = 0x1f3e0,
        // ??? = 1f3e1
        Building = 0x1f3e2,
        // ??? = 1f3e3
        // ??? = 1f3e4
        Hospital = 0x1f3e5,
        // ??? = 1f3e6
        // ??? = 1f3e7
        Hotel = 0x1f3e8,
        // ??? = 1f3e9
        // ??? = 1f3ea
        School = 0x1f3eb,
        // ??? = 1f3ec
        IndustryWindows = 0x1f3ed,
        // ??? = 1f3ee
        // ??? = 1f3ef
        // ??? = 1f3f0
        // ??? = 1f3f1
        // ??? = 1f3f2
        // ??? = 1f3f3
        Flag = 0x1f3f4,
        // ??? = 1f3f5
        // ??? = 1f3f6
        Tag = 0x1f3f7,
        // ??? = 1f3f8
        BowArrow = 0x1f3f9,
        // ??? = [1f3fa..1f403]
        Cow = 0x1f404,
        // ??? = 1f405
        // ??? = 1f406
        Rabbit = 0x1f407,
        Cat,
        Dragon,
        // ??? = 1f40a
        Whale = 0x1f40b,
        // ??? = 1f40c
        Snake = 0x1f40d,
        Horse,
        Ram,
        // ??? = 1f410
        Sheep = 0x1f411,
        Monkey,
        // ??? = 1f413
        // ??? = 1f414
        Dog = 0x1f415,
        Pig,
        // ??? = 1f417
        Elephant = 0x1f418,
        // ??? = 1f419
        // ??? = 1f41a
        // ??? = 1f41b
        // ??? = 1f41c
        // ??? = 1f41d
        // ??? = 1f41e
        Fish = 0x1f41f,
        // ??? = 1f420
        // ??? = 1f421
        Turtle = 0x1f422,
        // ??? = [1f423..1f440]
        Eye = 0x1f441,
        Ear,
        // ??? = 1f443
        Lips = 0x1f444,
        // ??? = 1f445
        // ??? = 1f446
        // ??? = 1f447
        // ??? = 1f448
        // ??? = 1f449
        // ??? = 1f44a
        // ??? = 1f44b
        // ??? = 1f44c
        ThumbsUp = 0x1f44d,
        ThumbsDown,
        // ??? = 1f44f
        // ??? = 1f450
        Crown = 0x1f451,
        // ??? = 1f452
        GlassesRound = 0x1f453,
        // ??? = 1f454
        Shirt = 0x1f455,
        // ??? = [1f456..1f463]
        User = 0x1f464,
        UserGroup,
        // ??? = [1f466..1f476]
        UserHelmetSafety = 0x1f477,
        // ??? = 1f478
        // ??? = 1f479
        // ??? = 1f47a
        Ghost = 0x1f47b,
        // ??? = 1f47c
        Alien = 0x1f47d,
        Alien8bit,
        // ??? = 1f47f
        Skull = 0x1f480,
        // ??? = 1f481
        // ??? = 1f482
        // ??? = 1f483
        // ??? = 1f484
        // ??? = 1f485
        // ??? = 1f486
        // ??? = 1f487
        // ??? = 1f488
        Syringe = 0x1f489,
        // ??? = 1f48a
        // ??? = 1f48b
        // ??? = 1f48c
        // ??? = 1f48d
        Gem = 0x1f48e,
        // ??? = 1f48f
        // ??? = 1f490
        // ??? = 1f491
        // ??? = 1f492
        // ??? = 1f493
        HeartCrack = 0x1f494,
        // ??? = [1f495..1f49e]
        SquareHeart = 0x1f49f,
        // ??? = 1f4a0
        Lightbulb = 0x1f4a1,
        // ??? = 1f4a2
        Bomb = 0x1f4a3,
        Snooze,
        // ??? = 1f4a5
        // ??? = 1f4a6
        Droplet = 0x1f4a7,
        // ??? = 1f4a8
        Poo = 0x1f4a9,
        // ??? = 1f4aa
        // ??? = 1f4ab
        CommentDots = 0x1f4ac,
        // ??? = 1f4ad
        // ??? = 1f4ae
        // ??? = 1f4af
        SackDollar = 0x1f4b0,
        // ??? = 1f4b1
        // ??? = 1f4b2
        CreditCard = 0x1f4b3,
        // ??? = 1f4b4
        // ??? = 1f4b5
        // ??? = 1f4b6
        // ??? = 1f4b7
        // ??? = 1f4b8
        // ??? = 1f4b9
        // ??? = 1f4ba
        Laptop = 0x1f4bb,
        Briefcase,
        Album,
        FloppyDisk,
        CompactDisc,
        // ??? = 1f4c0
        Folder = 0x1f4c1,
        FolderOpen,
        // ??? = 1f4c3
        File = 0x1f4c4,
        Calendar,
        // ??? = 1f4c6
        // ??? = 1f4c7
        // ??? = 1f4c8
        ChartLineDown = 0x1f4c9,
        // ??? = 1f4ca
        Clipboard = 0x1f4cb,
        Thumbtack,
        MapPin,
        Paperclip,
        Ruler,
        RulerTriangle,
        // ??? = 1f4d1
        // ??? = 1f4d2
        // ??? = 1f4d3
        Book = 0x1f4d4,
        BookBlank,
        BookOpen,
        // ??? = 1f4d7
        // ??? = 1f4d8
        // ??? = 1f4d9
        Books = 0x1f4da,
        // ??? = 1f4db
        Scroll = 0x1f4dc,
        FilePen,
        Phone,
        Pager,
        Fax,
        SatelliteDish,
        Bullhorn,
        Megaphone,
        InboxOut,
        InboxIn,
        Box,
        // ??? = 1f4e7
        // ??? = 1f4e8
        // ??? = 1f4e9
        Mailbox = 0x1f4ea,
        // ??? = 1f4eb
        // ??? = 1f4ec
        // ??? = 1f4ed
        // ??? = 1f4ee
        // ??? = 1f4ef
        Newspaper = 0x1f4f0,
        Mobile,
        // ??? = 1f4f2
        // ??? = 1f4f3
        // ??? = 1f4f4
        // ??? = 1f4f5
        Signal = 0x1f4f6,
        CameraRetro,
        // ??? = 1f4f8
        Camcorder = 0x1f4f9,
        TvRetro,
        Radio,
        CassetteVhs,
        // ??? = 1f4fd
        Boombox = 0x1f4fe,
        // ??? = 1f4ff
        Shuffle = 0x1f500,
        Repeat,
        Repeat1,
        // ??? = 1f503
        Rotate = 0x1f504,
        // ??? = 1f505
        // ??? = 1f506
        VolumeSlash = 0x1f507,
        VolumeLow,
        Volume,
        VolumeHigh,
        BatteryFull,
        Plug,
        MagnifyingGlass,
        // ??? = 1f50e
        // ??? = 1f50f
        // ??? = 1f510
        Key = 0x1f511,
        Lock,
        Unlock,
        Bell,
        BellSlash,
        Bookmark,
        Link,
        CircleDot,
        // ??? = [1f519..1f522]
        Symbols = 0x1f523,
        // ??? = 1f524
        Fire = 0x1f525,
        Flashlight,
        Wrench,
        Hammer,
        // ??? = 1f529
        KnifeKitchen = 0x1f52a,
        // ??? = 1f52b
        Microscope = 0x1f52c,
        Telescope,
        // ??? = [1f52e..1f548]
        Om = 0x1f549,
        Dove,
        Kaaba,
        Mosque,
        Synagogue,
        Hanukiah,
        // ??? = 1f54f
        // ??? = 1f550
        // ??? = 1f551
        // ??? = 1f552
        Clock = 0x1f553,
        // ??? = [1f554..1f56c]
        BellOn = 0x1f56d,
        // ??? = 1f56e
        CandleHolder = 0x1f56f,
        // ??? = 1f570
        // ??? = 1f571
        // ??? = 1f572
        // ??? = 1f573
        // ??? = 1f574
        UserSecret = 0x1f575,
        Sunglasses,
        Spider,
        SpiderWeb,
        Joystick,
        // ??? = 1f57a
        // ??? = 1f57b
        // ??? = 1f57c
        PhoneFlip = 0x1f57d,
        // ??? = [1f57e..1f589]
        Pen = 0x1f58a,
        // ??? = 1f58b
        PaintBrush = 0x1f58c,
        // ??? = 1f58d
        // ??? = 1f58e
        // ??? = 1f58f
        // ??? = 1f590
        // ??? = 1f591
        // ??? = 1f592
        // ??? = 1f593
        // ??? = 1f594
        HandMiddleFinger = 0x1f595,
        HandSpock,
        // ??? = [1f597..1f5a4]
        Desktop = 0x1f5a5,
        // ??? = 1f5a6
        // ??? = 1f5a7
        // ??? = 1f5a8
        Calculator = 0x1f5a9,
        // ??? = 1f5aa
        // ??? = 1f5ab
        // ??? = 1f5ac
        CassetteTape = 0x1f5ad,
        // ??? = 1f5ae
        // ??? = 1f5af
        // ??? = 1f5b0
        ComputerMouse = 0x1f5b1,
        // ??? = 1f5b2
        // ??? = 1f5b3
        HardDrive = 0x1f5b4,
        // ??? = 1f5b5
        // ??? = 1f5b6
        // ??? = 1f5b7
        // ??? = 1f5b8
        FileLines = 0x1f5b9,
        // ??? = 1f5ba
        FileImage = 0x1f5bb,
        // ??? = 1f5bc
        // ??? = 1f5bd
        // ??? = 1f5be
        // ??? = 1f5bf
        // ??? = 1f5c0
        // ??? = 1f5c1
        // ??? = 1f5c2
        // ??? = 1f5c3
        CabinetFiling = 0x1f5c4,
        // ??? = [1f5c5..1f5d3]
        Browser = 0x1f5d4,
        WindowMinimize,
        WindowMaximize,
        // ??? = 1f5d7
        ArrowsRotate = 0x1f5d8,
        // ??? = 1f5d9
        // ??? = 1f5da
        // ??? = 1f5db
        // ??? = 1f5dc
        KeySkeleton = 0x1f5dd,
        // ??? = 1f5de
        // ??? = 1f5df
        // ??? = 1f5e0
        Sword = 0x1f5e1,
        // ??? = 1f5e2
        // ??? = 1f5e3
        // ??? = 1f5e4
        // ??? = 1f5e5
        // ??? = 1f5e6
        // ??? = 1f5e7
        // ??? = 1f5e8
        Comment = 0x1f5e9,
        Comments,
        // ??? = 1f5eb
        // ??? = 1f5ec
        // ??? = 1f5ed
        // ??? = 1f5ee
        // ??? = 1f5ef
        // ??? = 1f5f0
        // ??? = 1f5f1
        // ??? = 1f5f2
        BoxBallot = 0x1f5f3,
        // ??? = 1f5f4
        // ??? = 1f5f5
        // ??? = 1f5f6
        // ??? = 1f5f7
        // ??? = 1f5f8
        // ??? = 1f5f9
        Map = 0x1f5fa,
        // ??? = 1f5fb
        // ??? = 1f5fc
        // ??? = 1f5fd
        // ??? = 1f5fe
        // ??? = 1f5ff
        FaceGrin = 0x1f600,
        FaceLaughBeam,
        FaceGrinTears,
        FaceGrinWide,
        FaceGrinBeam,
        FaceGrinBeamSweat,
        FaceGrinSquint,
        // ??? = 1f607
        // ??? = 1f608
        FaceSmileWink = 0x1f609,
        FaceSmileBeam,
        // ??? = 1f60b
        // ??? = 1f60c
        FaceGrinHearts = 0x1f60d,
        // ??? = 1f60e
        // ??? = 1f60f
        FaceMeh = 0x1f610,
        // ??? = 1f611
        // ??? = 1f612
        // ??? = 1f613
        // ??? = 1f614
        // ??? = 1f615
        // ??? = 1f616
        FaceKiss = 0x1f617,
        FaceKissWinkHeart,
        FaceKissBeam,
        // ??? = 1f61a
        FaceGrinTongue = 0x1f61b,
        FaceGrinTongueWink,
        FaceGrinTongueSquint,
        // ??? = 1f61e
        // ??? = 1f61f
        FaceAngry = 0x1f620,
        // ??? = 1f621
        FaceSadTear = 0x1f622,
        // ??? = 1f623
        // ??? = 1f624
        // ??? = 1f625
        FaceFrownOpen = 0x1f626,
        // ??? = 1f627
        // ??? = 1f628
        // ??? = 1f629
        // ??? = 1f62a
        FaceTired = 0x1f62b,
        FaceGrimace,
        FaceSadCry,
        FaceSurprise,
        // ??? = 1f62f
        // ??? = 1f630
        // ??? = 1f631
        // ??? = 1f632
        FaceFlushed = 0x1f633,
        // ??? = 1f634
        // ??? = 1f635
        FaceMehBlank = 0x1f636,
        // ??? = [1f637..1f641]
        FaceSmile = 0x1f642,
        // ??? = 1f643
        FaceRollingEyes = 0x1f644,
        // ??? = [1f645..1f67f]
        RocketLaunch = 0x1f680,
        Helicopter,
        // ??? = 1f682
        // ??? = 1f683
        // ??? = 1f684
        // ??? = 1f685
        Train = 0x1f686,
        // ??? = 1f687
        // ??? = 1f688
        // ??? = 1f689
        TrainTram = 0x1f68a,
        // ??? = 1f68b
        // ??? = 1f68c
        Bus = 0x1f68d,
        // ??? = 1f68e
        // ??? = 1f68f
        VanShuttle = 0x1f690,
        TruckMedical,
        // ??? = 1f692
        // ??? = 1f693
        // ??? = 1f694
        // ??? = 1f695
        Taxi = 0x1f696,
        CarSide,
        Car,
        // ??? = 1f699
        // ??? = 1f69a
        // ??? = 1f69b
        Tractor = 0x1f69c,
        // ??? = 1f69d
        // ??? = 1f69e
        // ??? = 1f69f
        // ??? = 1f6a0
        // ??? = 1f6a1
        Ship = 0x1f6a2,
        // ??? = 1f6a3
        // ??? = 1f6a4
        // ??? = 1f6a5
        TrafficLight = 0x1f6a6,
        // ??? = 1f6a7
        // ??? = 1f6a8
        FlagPennant = 0x1f6a9,
        DoorClosed,
        Ban,
        Smoking,
        BanSmoking,
        // ??? = 1f6ae
        // ??? = 1f6af
        FaucetDrip = 0x1f6b0,
        // ??? = 1f6b1
        Bicycle = 0x1f6b2,
        // ??? = 1f6b3
        PersonBiking = 0x1f6b4,
        PersonBikingMountain,
        PersonWalking,
        // ??? = 1f6b7
        // ??? = 1f6b8
        // ??? = 1f6b9
        // ??? = 1f6ba
        // ??? = 1f6bb
        // ??? = 1f6bc
        Toilet = 0x1f6bd,
        // ??? = 1f6be
        Shower = 0x1f6bf,
        // ??? = 1f6c0
        Bath = 0x1f6c1,
        // ??? = [1f6c2..1f6cb]
        Bed = 0x1f6cc,
        BagsShopping,
        BellConcierge,
        BedEmpty,
        PersonPraying,
        Octagon,
        CartShopping,
        // ??? = [1f6d3..1f6e0]
        Shield = 0x1f6e1,
        // ??? = 1f6e2
        Road = 0x1f6e3,
        // ??? = 1f6e4
        // ??? = 1f6e5
        // ??? = 1f6e6
        // ??? = 1f6e7
        // ??? = 1f6e8
        // ??? = 1f6e9
        // ??? = 1f6ea
        PlaneDeparture = 0x1f6eb,
        PlaneArrival,
        // ??? = 1f6ed
        // ??? = 1f6ee
        // ??? = 1f6ef
        Satellite = 0x1f6f0,
        // ??? = 1f6f1
        // ??? = 1f6f2
        // ??? = 1f6f3
        // ??? = 1f6f4
        // ??? = 1f6f5
        // ??? = 1f6f6
        // ??? = 1f6f7
        Ufo = 0x1f6f8,
        // ??? = 1f6f9
        // ??? = 1f6fa
        TruckPickup = 0x1f6fb,
        // ??? = [1f6fc..1f915]
        Robot = 0x1f916,
        // ??? = 1f917
        // ??? = 1f918
        // ??? = 1f919
        // ??? = 1f91a
        // ??? = 1f91b
        // ??? = 1f91c
        HandshakeSimple = 0x1f91d,
        // ??? = 1f91e
        // ??? = 1f91f
        // ??? = 1f920
        // ??? = 1f921
        // ??? = 1f922
        FaceGrinSquintTears = 0x1f923,
        // ??? = 1f924
        // ??? = 1f925
        // ??? = 1f926
        // ??? = 1f927
        // ??? = 1f928
        FaceGrinStars = 0x1f929,
        // ??? = [1f92a..1f940]
        Drum = 0x1f941,
        ChampagneGlasses,
        WhiskeyGlass,
        Spoon,
        // ??? = 1f945
        // ??? = 1f946
        // ??? = 1f947
        // ??? = 1f948
        // ??? = 1f949
        BoxingGlove = 0x1f94a,
        // ??? = 1f94b
        CurlingStone = 0x1f94c,
        // ??? = 1f94d
        // ??? = 1f94e
        // ??? = 1f94f
        Croissant = 0x1f950,
        // ??? = 1f951
        // ??? = 1f952
        Bacon = 0x1f953,
        // ??? = 1f954
        Carrot = 0x1f955,
        // ??? = 1f956
        Salad = 0x1f957,
        // ??? = 1f958
        // ??? = 1f959
        Egg = 0x1f95a,
        Glass,
        // ??? = [1f95c..1f966]
        Pie = 0x1f967,
        // ??? = 1f968
        Steak = 0x1f969,
        Sandwich,
        // ??? = [1f96b..1f976]
        UserNinja = 0x1f977,
        // ??? = 1f978
        // ??? = 1f979
        // ??? = 1f97a
        // ??? = 1f97b
        // ??? = 1f97c
        // ??? = 1f97d
        Boot = 0x1f97e,
        // ??? = 1f97f
        // ??? = 1f980
        // ??? = 1f981
        // ??? = 1f982
        // ??? = 1f983
        Unicorn = 0x1f984,
        // ??? = 1f985
        Duck = 0x1f986,
        // ??? = 1f987
        // ??? = 1f988
        // ??? = 1f989
        // ??? = 1f98a
        // ??? = 1f98b
        Deer = 0x1f98c,
        // ??? = [1f98d..1f99a]
        Hippo = 0x1f99b,
        // ??? = 1f99c
        // ??? = 1f99d
        // ??? = 1f99e
        // ??? = 1f99f
        // ??? = 1f9a0
        BadgerHoney = 0x1f9a1,
        // ??? = 1f9a2
        // ??? = 1f9a3
        // ??? = 1f9a4
        // ??? = 1f9a5
        Otter = 0x1f9a6,
        // ??? = 1f9a7
        // ??? = 1f9a8
        // ??? = 1f9a9
        // ??? = 1f9aa
        // ??? = 1f9ab
        // ??? = 1f9ac
        // ??? = 1f9ad
        DogLeashed = 0x1f9ae,
        // ??? = 1f9af
        // ??? = 1f9b0
        // ??? = 1f9b1
        // ??? = 1f9b2
        // ??? = 1f9b3
        Bone = 0x1f9b4,
        // ??? = 1f9b5
        // ??? = 1f9b6
        Tooth = 0x1f9b7,
        // ??? = 1f9b8
        // ??? = 1f9b9
        // ??? = 1f9ba
        // ??? = 1f9bb
        // ??? = 1f9bc
        // ??? = 1f9bd
        // ??? = 1f9be
        // ??? = 1f9bf
        CheeseSwiss = 0x1f9c0,
        // ??? = [1f9c1..1f9cc]
        Person = 0x1f9cd,
        // ??? = [1f9ce..1f9df]
        Brain = 0x1f9e0,
        // ??? = 1f9e1
        // ??? = 1f9e2
        Scarf = 0x1f9e3,
        // ??? = 1f9e4
        // ??? = 1f9e5
        Socks = 0x1f9e6,
        // ??? = 1f9e7
        // ??? = 1f9e8
        PuzzlePiece = 0x1f9e9,
        Vial,
        // ??? = 1f9eb
        Dna = 0x1f9ec,
        Compass,
        Abacus,
        FireExtinguisher,
        Toolbox,
        // ??? = 1f9f1
        Magnet = 0x1f9f2,
        Suitcase,
        // ??? = 1f9f4
        // ??? = 1f9f5
        // ??? = 1f9f6
        // ??? = 1f9f7
        // ??? = 1f9f8
        Broom = 0x1f9f9,
        // ??? = 1f9fa
        ToiletPaper = 0x1f9fb,
        Soap,
        // ??? = 1f9fd
        Receipt = 0x1f9fe,
        // ??? = [1f9ff..1fa78]
        Bandage = 0x1fa79,
        Stethoscope,
        // ??? = 1fa7b
        // ??? = 1fa7c
        // ??? = 1fa7d
        // ??? = 1fa7e
        // ??? = 1fa7f
        // ??? = 1fa80
        Kite = 0x1fa81,
        // ??? = [1fa82..1fa8f]
        PlanetRinged = 0x1fa90,
        Chair,
        // ??? = 1fa92
        Axe = 0x1fa93,
        // ??? = 1fa94
        Banjo = 0x1fa95,
        // ??? = 1fa96
        // ??? = 1fa97
        // ??? = 1fa98
        Coin = 0x1fa99,
        // ??? = 1fa9a
        Screwdriver = 0x1fa9b,
        // ??? = 1fa9c
        // ??? = 1fa9d
        // ??? = 1fa9e
        WindowFrame = 0x1fa9f,
        // ??? = 1faa0
        // ??? = 1faa1
        // ??? = 1faa2
        // ??? = 1faa3
        // ??? = 1faa4
        Toothbrush = 0x1faa5,
        TombstoneBlank,
        // ??? = [1faa7..1fab5]
        Feather = 0x1fab6,
        // ??? = [1fab7..1fac0]
        Lungs = 0x1fac1,
    }
}
