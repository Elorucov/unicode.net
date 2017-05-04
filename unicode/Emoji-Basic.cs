﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NeoSmart.Unicode
{
    public static partial class Emoji
    {
        /// <summary>
        /// A (sorted) enumeration of all emoji without skin variations and no duplicate gendered vs gender-neutral emoji, ideal for displaying.
        /// Emoji without supported glyphs in Segoe UI Emoji are also omitted from this list.
        /// </summary>
        public static IEnumerable<SingleEmoji> Basic => new [] {
	        /* 😀 */ GrinningFace,
	        /* 😁 */ GrinningFaceWithSmilingEyes,
	        /* 😂 */ FaceWithTearsOfJoy,
	        /* 🤣 */ RollingOnTheFloorLaughing,
	        /* 😃 */ SmilingFaceWithOpenMouth,
	        /* 😄 */ SmilingFaceWithOpenMouthAndSmilingEyes,
	        /* 😅 */ SmilingFaceWithOpenMouthAndColdSweat,
	        /* 😆 */ SmilingFaceWithOpenMouthAndClosedEyes,
	        /* 😉 */ WinkingFace,
	        /* 😊 */ SmilingFaceWithSmilingEyes,
	        /* 😋 */ FaceSavouringDeliciousFood,
	        /* 😎 */ SmilingFaceWithSunglasses,
	        /* 😍 */ SmilingFaceWithHeartEyes,
	        /* 😘 */ FaceBlowingAKiss,
	        /* 😗 */ KissingFace,
	        /* 😙 */ KissingFaceWithSmilingEyes,
	        /* 😚 */ KissingFaceWithClosedEyes,
	        /* ☺️ */ SmilingFace,
	        /* 🙂 */ SlightlySmilingFace,
	        /* 🤗 */ HuggingFace,
	        /* 🤔 */ ThinkingFace,
	        /* 😐 */ NeutralFace,
	        /* 😑 */ ExpressionlessFace,
	        /* 😶 */ FaceWithoutMouth,
	        /* 🙄 */ FaceWithRollingEyes,
	        /* 😏 */ SmirkingFace,
	        /* 😣 */ PerseveringFace,
	        /* 😥 */ DisappointedButRelievedFace,
	        /* 😮 */ FaceWithOpenMouth,
	        /* 🤐 */ ZipperMouthFace,
	        /* 😯 */ HushedFace,
	        /* 😪 */ SleepyFace,
	        /* 😫 */ TiredFace,
	        /* 😴 */ SleepingFace,
	        /* 😌 */ RelievedFace,
	        /* 😛 */ FaceWithStuckOutTongue,
	        /* 😜 */ FaceWithStuckOutTongueAndWinkingEye,
	        /* 😝 */ FaceWithStuckOutTongueAndClosedEyes,
	        /* 🤤 */ DroolingFace,
	        /* 😒 */ UnamusedFace,
	        /* 😓 */ FaceWithColdSweat,
	        /* 😔 */ PensiveFace,
	        /* 😕 */ ConfusedFace,
	        /* 🙃 */ UpsideDownFace,
	        /* 🤑 */ MoneyMouthFace,
	        /* 😲 */ AstonishedFace,
	        /* ☹️ */ FrowningFace,
	        /* 🙁 */ SlightlyFrowningFace,
	        /* 😖 */ ConfoundedFace,
	        /* 😞 */ DisappointedFace,
	        /* 😟 */ WorriedFace,
	        /* 😤 */ FaceWithSteamFromNose,
	        /* 😢 */ CryingFace,
	        /* 😭 */ LoudlyCryingFace,
	        /* 😦 */ FrowningFaceWithOpenMouth,
	        /* 😧 */ AnguishedFace,
	        /* 😨 */ FearfulFace,
	        /* 😩 */ WearyFace,
	        /* 😬 */ GrimacingFace,
	        /* 😰 */ FaceWithOpenMouthAndColdSweat,
	        /* 😱 */ FaceScreamingInFear,
	        /* 😳 */ FlushedFace,
	        /* 😵 */ DizzyFace,
	        /* 😡 */ PoutingFace,
	        /* 😠 */ AngryFace,
	        /* 😷 */ FaceWithMedicalMask,
	        /* 🤒 */ FaceWithThermometer,
	        /* 🤕 */ FaceWithHeadBandage,
	        /* 🤢 */ NauseatedFace,
	        /* 🤧 */ SneezingFace,
	        /* 😇 */ SmilingFaceWithHalo,
	        /* 🤠 */ CowboyHatFace,
	        /* 🤡 */ ClownFace,
	        /* 🤥 */ LyingFace,
	        /* 🤓 */ NerdFace,
	        /* 😈 */ SmilingFaceWithHorns,
	        /* 👿 */ AngryFaceWithHorns,
	        /* 👹 */ Ogre,
	        /* 👺 */ Goblin,
	        /* 💀 */ Skull,
	        /* ☠️ */ SkullAndCrossbones,
	        /* 👻 */ Ghost,
	        /* 👽 */ Alien,
	        /* 👾 */ AlienMonster,
	        /* 🤖 */ RobotFace,
	        /* 💩 */ PileOfPoo,
	        /* 😺 */ SmilingCatFaceWithOpenMouth,
	        /* 😸 */ GrinningCatFaceWithSmilingEyes,
	        /* 😹 */ CatFaceWithTearsOfJoy,
	        /* 😻 */ SmilingCatFaceWithHeartEyes,
	        /* 😼 */ CatFaceWithWrySmile,
	        /* 😽 */ KissingCatFaceWithClosedEyes,
	        /* 🙀 */ WearyCatFace,
	        /* 😿 */ CryingCatFace,
	        /* 😾 */ PoutingCatFace,
	        /* 🙈 */ SeeNoEvilMonkey,
	        /* 🙉 */ HearNoEvilMonkey,
	        /* 🙊 */ SpeakNoEvilMonkey,
	        /* 👶 */ Baby,
	        /* 👦 */ Boy,
	        /* 👧 */ Girl,
	        /* 👴 */ OldMan,
	        /* 👵 */ OldWoman,
	        /* 👮 */ PoliceOfficer,
	        /* 🕵️ */ Detective,
	        /* 💂 */ Guard,
	        /* 👷 */ ConstructionWorker,
	        /* 🤴 */ Prince,
	        /* 👸 */ Princess,
	        /* 👳 */ PersonWearingTurban,
	        /* 👱 */ BlondHairedPerson,
	        /* 👱‍♂️ */ BlondHairedMan,
	        /* 👱‍♀️ */ BlondHairedWoman,
	        /* 👰 */ BrideWithVeil,
	        /* 🤰 */ PregnantWoman,
	        /* 👼 */ BabyAngel,
	        /* 🎅 */ SantaClaus,
	        /* 🤶 */ MrsClaus,
	        /* 🙍 */ PersonFrowning,
	        /* 🙎 */ PersonPouting,
	        /* 🙅 */ PersonGesturingNo,
	        /* 🙆 */ PersonGesturingOk,
	        /* 💁 */ PersonTippingHand,
	        /* 🙋 */ PersonRaisingHand,
	        /* 🙇 */ PersonBowing,
	        /* 🤦 */ PersonFacepalming,
	        /* 🤷 */ PersonShrugging,
	        /* 💆 */ PersonGettingMassage,
	        /* 💇 */ PersonGettingHaircut,
	        /* 🚶 */ PersonWalking,
	        /* 🏃 */ PersonRunning,
	        /* 👯 */ PeopleWithBunnyEarsPartying,
	        /* 🛀 */ PersonTakingBath,
	        /* 🛌 */ PersonInBed,
	        /* 🗣️ */ SpeakingHead,
	        /* 👤 */ BustInSilhouette,
	        /* 👥 */ BustsInSilhouette,
	        /* 🤺 */ PersonFencing,
	        /* 🏇 */ HorseRacing,
	        /* ⛷️ */ Skier,
	        /* 🏂 */ Snowboarder,
	        /* 🏌️ */ PersonGolfing,
	        /* 🏄 */ PersonSurfing,
	        /* 🚣 */ PersonRowingBoat,
	        /* 🏊 */ PersonSwimming,
	        /* ⛹️ */ PersonBouncingBall,
	        /* 🏋️ */ PersonLiftingWeights,
	        /* 🚴 */ PersonBiking,
	        /* 🚵 */ PersonMountainBiking,
	        /* 🏎️ */ RacingCar,
	        /* 🏍️ */ Motorcycle,
	        /* 🤸 */ PersonCartwheeling,
	        /* 🤼 */ PeopleWrestling,
	        /* 🤽 */ PersonPlayingWaterPolo,
	        /* 🤾 */ PersonPlayingHandball,
	        /* 🤹 */ PersonJuggling,
	        /* 💏 */ Kiss,
	        /* 💑 */ CoupleWithHeart,
	        /* 👪 */ Family,
	        /* 👨‍👩‍👦‍👦 */ FamilyManWomanBoyBoy,
	        /* 👨‍👩‍👧‍👧 */ FamilyManWomanGirlGirl,
	        /* 👨‍👨‍👦 */ FamilyManManBoy,
	        /* 👨‍👨‍👧 */ FamilyManManGirl,
	        /* 👨‍👨‍👧‍👦 */ FamilyManManGirlBoy,
	        /* 👨‍👨‍👦‍👦 */ FamilyManManBoyBoy,
	        /* 👨‍👨‍👧‍👧 */ FamilyManManGirlGirl,
	        /* 👩‍👩‍👦 */ FamilyWomanWomanBoy,
	        /* 👩‍👩‍👧 */ FamilyWomanWomanGirl,
	        /* 👩‍👩‍👧‍👦 */ FamilyWomanWomanGirlBoy,
	        /* 👩‍👩‍👦‍👦 */ FamilyWomanWomanBoyBoy,
	        /* 👩‍👩‍👧‍👧 */ FamilyWomanWomanGirlGirl,
	        /* 🤳 */ Selfie,
	        /* 💪 */ FlexedBiceps,
	        /* 👈 */ BackhandIndexPointingLeft,
	        /* 👉 */ BackhandIndexPointingRight,
	        /* ☝️ */ IndexPointingUp,
	        /* 👆 */ BackhandIndexPointingUp,
	        /* 🖕 */ MiddleFinger,
	        /* 👇 */ BackhandIndexPointingDown,
	        /* ✌️ */ VictoryHand,
	        /* 🤞 */ CrossedFingers,
	        /* 🖖 */ VulcanSalute,
	        /* 🤘 */ SignOfTheHorns,
	        /* 🤙 */ CallMeHand,
	        /* 🖐️ */ RaisedHandWithFingersSplayed,
	        /* ✋ */ RaisedHand,
	        /* 👌 */ OkHand,
	        /* 👍 */ ThumbsUp,
	        /* 👎 */ ThumbsDown,
	        /* ✊ */ RaisedFist,
	        /* 👊 */ OncomingFist,
	        /* 🤛 */ LeftFacingFist,
	        /* 🤜 */ RightFacingFist,
	        /* 🤚 */ RaisedBackOfHand,
	        /* 👋 */ WavingHand,
	        /* ✍️ */ WritingHand,
	        /* 👏 */ ClappingHands,
	        /* 👐 */ OpenHands,
	        /* 🙌 */ RaisingHands,
	        /* 🙏 */ FoldedHands,
	        /* 🤝 */ Handshake,
	        /* 💅 */ NailPolish,
	        /* 👂 */ Ear,
	        /* 👃 */ Nose,
	        /* 👣 */ Footprints,
	        /* 👀 */ Eyes,
	        /* 👁️ */ Eye,
	        /* 👁️‍🗨️ */ EyeInSpeechBubble,
	        /* 👅 */ Tongue,
	        /* 👄 */ Mouth,
	        /* 💋 */ KissMark,
	        /* 💘 */ HeartWithArrow,
	        /* ❤️ */ RedHeart,
	        /* 💓 */ BeatingHeart,
	        /* 💔 */ BrokenHeart,
	        /* 💕 */ TwoHearts,
	        /* 💖 */ SparklingHeart,
	        /* 💗 */ GrowingHeart,
	        /* 💙 */ BlueHeart,
	        /* 💚 */ GreenHeart,
	        /* 💛 */ YellowHeart,
	        /* 💜 */ PurpleHeart,
	        /* 🖤 */ BlackHeart,
	        /* 💝 */ HeartWithRibbon,
	        /* 💞 */ RevolvingHearts,
	        /* 💟 */ HeartDecoration,
	        /* ❣️ */ HeavyHeartExclamation,
	        /* 💌 */ LoveLetter,
	        /* 💤 */ Zzz,
	        /* 💢 */ AngerSymbol,
	        /* 💣 */ Bomb,
	        /* 💥 */ Collision,
	        /* 💦 */ SweatDroplets,
	        /* 💨 */ DashingAway,
	        /* 💫 */ Dizzy,
	        /* 💬 */ SpeechBalloon,
	        /* 🗨️ */ LeftSpeechBubble,
	        /* 🗯️ */ RightAngerBubble,
	        /* 💭 */ ThoughtBalloon,
	        /* 🕳️ */ Hole,
	        /* 👓 */ Glasses,
	        /* 🕶️ */ Sunglasses,
	        /* 👔 */ Necktie,
	        /* 👕 */ TShirt,
	        /* 👖 */ Jeans,
	        /* 👗 */ Dress,
	        /* 👘 */ Kimono,
	        /* 👙 */ Bikini,
	        /* 👛 */ Purse,
	        /* 👜 */ Handbag,
	        /* 👝 */ ClutchBag,
	        /* 🛍️ */ ShoppingBags,
	        /* 🎒 */ SchoolBackpack,
	        /* 👟 */ RunningShoe,
	        /* 👠 */ HighHeeledShoe,
	        /* 👑 */ Crown,
	        /* 🎩 */ TopHat,
	        /* 🎓 */ GraduationCap,
	        /* ⛑️ */ RescueWorkersHelmet,
	        /* 📿 */ PrayerBeads,
	        /* 💄 */ Lipstick,
	        /* 💍 */ Ring,
	        /* 💎 */ GemStone,
	        /* 🐵 */ MonkeyFace,
	        /* 🐒 */ Monkey,
	        /* 🦍 */ Gorilla,
	        /* 🐶 */ DogFace,
	        /* 🐕 */ Dog,
	        /* 🐩 */ Poodle,
	        /* 🐺 */ WolfFace,
	        /* 🦊 */ FoxFace,
	        /* 🐱 */ CatFace,
	        /* 🐈 */ Cat,
	        /* 🦁 */ LionFace,
	        /* 🐯 */ TigerFace,
	        /* 🐅 */ Tiger,
	        /* 🐆 */ Leopard,
	        /* 🐴 */ HorseFace,
	        /* 🐎 */ Horse,
	        /* 🦄 */ UnicornFace,
	        /* 🦌 */ Deer,
	        /* 🐮 */ CowFace,
	        /* 🐂 */ Ox,
	        /* 🐃 */ WaterBuffalo,
	        /* 🐄 */ Cow,
	        /* 🐷 */ PigFace,
	        /* 🐖 */ Pig,
	        /* 🐗 */ Boar,
	        /* 🐽 */ PigNose,
	        /* 🐏 */ Ram,
	        /* 🐑 */ Ewe,
	        /* 🐐 */ Goat,
	        /* 🐪 */ Camel,
	        /* 🐫 */ TwoHumpCamel,
	        /* 🐘 */ Elephant,
	        /* 🦏 */ Rhinoceros,
	        /* 🐭 */ MouseFace,
	        /* 🐁 */ Mouse,
	        /* 🐀 */ Rat,
	        /* 🐹 */ HamsterFace,
	        /* 🐰 */ RabbitFace,
	        /* 🐇 */ Rabbit,
	        /* 🐿️ */ Chipmunk,
	        /* 🦇 */ Bat,
	        /* 🐻 */ BearFace,
	        /* 🐨 */ Koala,
	        /* 🐼 */ PandaFace,
	        /* 🐾 */ PawPrints,
	        /* 🦃 */ Turkey,
	        /* 🐔 */ Chicken,
	        /* 🐓 */ Rooster,
	        /* 🐣 */ HatchingChick,
	        /* 🐤 */ BabyChick,
	        /* 🐥 */ FrontFacingBabyChick,
	        /* 🐦 */ Bird,
	        /* 🐧 */ Penguin,
	        /* 🕊️ */ Dove,
	        /* 🦅 */ Eagle,
	        /* 🦆 */ Duck,
	        /* 🦉 */ Owl,
	        /* 🐸 */ FrogFace,
	        /* 🐊 */ Crocodile,
	        /* 🐢 */ Turtle,
	        /* 🦎 */ Lizard,
	        /* 🐍 */ Snake,
	        /* 🐲 */ DragonFace,
	        /* 🐉 */ Dragon,
	        /* 🐳 */ SpoutingWhale,
	        /* 🐋 */ Whale,
	        /* 🐬 */ Dolphin,
	        /* 🐟 */ Fish,
	        /* 🐠 */ TropicalFish,
	        /* 🐡 */ Blowfish,
	        /* 🦈 */ Shark,
	        /* 🐙 */ Octopus,
	        /* 🐚 */ SpiralShell,
	        /* 🦀 */ Crab,
	        /* 🦐 */ Shrimp,
	        /* 🦑 */ Squid,
	        /* 🐌 */ Snail,
	        /* 🦋 */ Butterfly,
	        /* 🐛 */ Bug,
	        /* 🐜 */ Ant,
	        /* 🐝 */ Honeybee,
	        /* 🐞 */ LadyBeetle,
	        /* 🕷️ */ Spider,
	        /* 🕸️ */ SpiderWeb,
	        /* 🦂 */ Scorpion,
	        /* 💐 */ Bouquet,
	        /* 🌸 */ CherryBlossom,
	        /* 💮 */ WhiteFlower,
	        /* 🏵️ */ Rosette,
	        /* 🌹 */ Rose,
	        /* 🥀 */ WiltedFlower,
	        /* 🌺 */ Hibiscus,
	        /* 🌻 */ Sunflower,
	        /* 🌼 */ Blossom,
	        /* 🌷 */ Tulip,
	        /* 🌱 */ Seedling,
	        /* 🌲 */ EvergreenTree,
	        /* 🌳 */ DeciduousTree,
	        /* 🌴 */ PalmTree,
	        /* 🌵 */ Cactus,
	        /* 🌾 */ SheafOfRice,
	        /* 🌿 */ Herb,
	        /* ☘️ */ Shamrock,
	        /* 🍀 */ FourLeafClover,
	        /* 🍁 */ MapleLeaf,
	        /* 🍂 */ FallenLeaf,
	        /* 🍃 */ LeafFlutteringInWind,
	        /* 🍇 */ Grapes,
	        /* 🍈 */ Melon,
	        /* 🍉 */ Watermelon,
	        /* 🍊 */ Tangerine,
	        /* 🍋 */ Lemon,
	        /* 🍌 */ Banana,
	        /* 🍍 */ Pineapple,
	        /* 🍎 */ RedApple,
	        /* 🍏 */ GreenApple,
	        /* 🍐 */ Pear,
	        /* 🍑 */ Peach,
	        /* 🍒 */ Cherries,
	        /* 🍓 */ Strawberry,
	        /* 🥝 */ KiwiFruit,
	        /* 🍅 */ Tomato,
	        /* 🥑 */ Avocado,
	        /* 🍆 */ Eggplant,
	        /* 🥔 */ Potato,
	        /* 🥕 */ Carrot,
	        /* 🌽 */ EarOfCorn,
	        /* 🌶️ */ HotPepper,
	        /* 🥒 */ Cucumber,
	        /* 🍄 */ Mushroom,
	        /* 🥜 */ Peanuts,
	        /* 🌰 */ Chestnut,
	        /* 🍞 */ Bread,
	        /* 🥐 */ Croissant,
	        /* 🥖 */ BaguetteBread,
	        /* 🥞 */ Pancakes,
	        /* 🧀 */ CheeseWedge,
	        /* 🍖 */ MeatOnBone,
	        /* 🍗 */ PoultryLeg,
	        /* 🥓 */ Bacon,
	        /* 🍔 */ Hamburger,
	        /* 🍟 */ FrenchFries,
	        /* 🍕 */ Pizza,
	        /* 🌭 */ HotDog,
	        /* 🌮 */ Taco,
	        /* 🌯 */ Burrito,
	        /* 🥙 */ StuffedFlatbread,
	        /* 🥚 */ Egg,
	        /* 🍳 */ Cooking,
	        /* 🥘 */ ShallowPanOfFood,
	        /* 🍲 */ PotOfFood,
	        /* 🥗 */ GreenSalad,
	        /* 🍿 */ Popcorn,
	        /* 🍱 */ BentoBox,
	        /* 🍘 */ RiceCracker,
	        /* 🍙 */ RiceBall,
	        /* 🍚 */ CookedRice,
	        /* 🍛 */ CurryRice,
	        /* 🍜 */ SteamingBowl,
	        /* 🍝 */ Spaghetti,
	        /* 🍠 */ RoastedSweetPotato,
	        /* 🍢 */ Oden,
	        /* 🍣 */ Sushi,
	        /* 🍤 */ FriedShrimp,
	        /* 🍥 */ FishCakeWithSwirl,
	        /* 🍡 */ Dango,
	        /* 🍦 */ SoftIceCream,
	        /* 🍧 */ ShavedIce,
	        /* 🍨 */ IceCream,
	        /* 🍩 */ Doughnut,
	        /* 🍪 */ Cookie,
	        /* 🎂 */ BirthdayCake,
	        /* 🍰 */ Shortcake,
	        /* 🍫 */ ChocolateBar,
	        /* 🍬 */ Candy,
	        /* 🍭 */ Lollipop,
	        /* 🍮 */ Custard,
	        /* 🍯 */ HoneyPot,
	        /* 🍼 */ BabyBottle,
	        /* 🥛 */ GlassOfMilk,
	        /* ☕ */ HotBeverage,
	        /* 🍵 */ TeacupWithoutHandle,
	        /* 🍶 */ Sake,
	        /* 🍾 */ BottleWithPoppingCork,
	        /* 🍷 */ WineGlass,
	        /* 🍸 */ CocktailGlass,
	        /* 🍹 */ TropicalDrink,
	        /* 🍺 */ BeerMug,
	        /* 🍻 */ ClinkingBeerMugs,
	        /* 🥂 */ ClinkingGlasses,
	        /* 🥃 */ TumblerGlass,
	        /* 🍽️ */ ForkAndKnifeWithPlate,
	        /* 🍴 */ ForkAndKnife,
	        /* 🥄 */ Spoon,
	        /* 🔪 */ KitchenKnife,
	        /* 🏺 */ Amphora,
	        /* 🌍 */ GlobeShowingEuropeAfrica,
	        /* 🌎 */ GlobeShowingAmericas,
	        /* 🌏 */ GlobeShowingAsiaAustralia,
	        /* 🌐 */ GlobeWithMeridians,
	        /* 🗺️ */ WorldMap,
	        /* 🗾 */ MapOfJapan,
	        /* 🏔️ */ SnowCappedMountain,
	        /* ⛰️ */ Mountain,
	        /* 🌋 */ Volcano,
	        /* 🗻 */ MountFuji,
	        /* 🏕️ */ Camping,
	        /* 🏖️ */ BeachWithUmbrella,
	        /* 🏜️ */ Desert,
	        /* 🏝️ */ DesertIsland,
	        /* 🏞️ */ NationalPark,
	        /* 🏟️ */ Stadium,
	        /* 🏛️ */ ClassicalBuilding,
	        /* 🏗️ */ BuildingConstruction,
	        /* 🏘️ */ House,
	        /* 🏙️ */ Cityscape,
	        /* 🏚️ */ DerelictHouse,
	        /* 🏡 */ HouseWithGarden,
	        /* 🏢 */ OfficeBuilding,
	        /* 🏣 */ JapanesePostOffice,
	        /* 🏤 */ PostOffice,
	        /* 🏥 */ Hospital,
	        /* 🏦 */ Bank,
	        /* 🏨 */ Hotel,
	        /* 🏩 */ LoveHotel,
	        /* 🏪 */ ConvenienceStore,
	        /* 🏫 */ School,
	        /* 🏬 */ DepartmentStore,
	        /* 🏭 */ Factory,
	        /* 🏯 */ JapaneseCastle,
	        /* 🏰 */ Castle,
	        /* 💒 */ Wedding,
	        /* 🗼 */ TokyoTower,
	        /* 🗽 */ StatueOfLiberty,
	        /* ⛪ */ Church,
	        /* 🕌 */ Mosque,
	        /* 🕍 */ Synagogue,
	        /* ⛩️ */ ShintoShrine,
	        /* 🕋 */ Kaaba,
	        /* ⛲ */ Fountain,
	        /* ⛺ */ Tent,
	        /* 🌁 */ Foggy,
	        /* 🌃 */ NightWithStars,
	        /* 🌄 */ SunriseOverMountains,
	        /* 🌅 */ Sunrise,
	        /* 🌆 */ CityscapeAtDusk,
	        /* 🌇 */ Sunset,
	        /* 🌉 */ BridgeAtNight,
	        /* ♨️ */ HotSprings,
	        /* 🌌 */ MilkyWay,
	        /* 🎠 */ CarouselHorse,
	        /* 🎡 */ FerrisWheel,
	        /* 🎢 */ RollerCoaster,
	        /* 💈 */ BarberPole,
	        /* 🎪 */ CircusTent,
	        /* 🎭 */ PerformingArts,
	        /* 🖼️ */ FramedPicture,
	        /* 🎨 */ ArtistPalette,
	        /* 🎰 */ SlotMachine,
	        /* 🚂 */ Locomotive,
	        /* 🚃 */ RailwayCar,
	        /* 🚄 */ HighSpeedTrain,
	        /* 🚅 */ HighSpeedTrainWithBulletNose,
	        /* 🚆 */ Train,
	        /* 🚇 */ Metro,
	        /* 🚈 */ LightRail,
	        /* 🚉 */ Station,
	        /* 🚊 */ Tram,
	        /* 🚝 */ Monorail,
	        /* 🚞 */ MountainRailway,
	        /* 🚋 */ TramCar,
	        /* 🚌 */ Bus,
	        /* 🚍 */ OncomingBus,
	        /* 🚎 */ Trolleybus,
	        /* 🚐 */ Minibus,
	        /* 🚑 */ Ambulance,
	        /* 🚒 */ FireEngine,
	        /* 🚓 */ PoliceCar,
	        /* 🚔 */ OncomingPoliceCar,
	        /* 🚕 */ Taxi,
	        /* 🚖 */ OncomingTaxi,
	        /* 🚗 */ Automobile,
	        /* 🚘 */ OncomingAutomobile,
	        /* 🚙 */ SportUtilityVehicle,
	        /* 🚚 */ DeliveryTruck,
	        /* 🚛 */ ArticulatedLorry,
	        /* 🚜 */ Tractor,
	        /* 🚲 */ Bicycle,
	        /* 🛴 */ KickScooter,
	        /* 🛵 */ MotorScooter,
	        /* 🚏 */ BusStop,
	        /* 🛣️ */ Motorway,
	        /* 🛤️ */ RailwayTrack,
	        /* ⛽ */ FuelPump,
	        /* 🚨 */ PoliceCarLight,
	        /* 🚥 */ HorizontalTrafficLight,
	        /* 🚦 */ VerticalTrafficLight,
	        /* 🚧 */ Construction,
	        /* 🛑 */ StopSign,
	        /* ⚓ */ Anchor,
	        /* ⛵ */ Sailboat,
	        /* 🛶 */ Canoe,
	        /* 🚤 */ Speedboat,
	        /* 🛳️ */ PassengerShip,
	        /* ⛴️ */ Ferry,
	        /* 🛥️ */ MotorBoat,
	        /* 🚢 */ Ship,
	        /* ✈️ */ Airplane,
	        /* 🛩️ */ SmallAirplane,
	        /* 🛫 */ AirplaneDeparture,
	        /* 🛬 */ AirplaneArrival,
	        /* 💺 */ Seat,
	        /* 🚁 */ Helicopter,
	        /* 🚟 */ SuspensionRailway,
	        /* 🚠 */ MountainCableway,
	        /* 🚡 */ AerialTramway,
	        /* 🛰️ */ Satellite,
	        /* 🚀 */ Rocket,
	        /* 🛎️ */ BellhopBell,
	        /* 🚪 */ Door,
	        /* 🛏️ */ Bed,
	        /* 🛋️ */ CouchAndLamp,
	        /* 🚽 */ Toilet,
	        /* 🚿 */ Shower,
	        /* 🛁 */ Bathtub,
	        /* ⌛ */ Hourglass,
	        /* ⏳ */ HourglassWithFlowingSand,
	        /* ⌚ */ Watch,
	        /* ⏰ */ AlarmClock,
	        /* ⏱️ */ Stopwatch,
	        /* ⏲️ */ TimerClock,
	        /* 🕛 */ TwelveOclock,
	        /* 🕧 */ TwelveThirty,
	        /* 🕐 */ OneOclock,
	        /* 🕜 */ OneThirty,
	        /* 🕑 */ TwoOclock,
	        /* 🕝 */ TwoThirty,
	        /* 🕒 */ ThreeOclock,
	        /* 🕞 */ ThreeThirty,
	        /* 🕓 */ FourOclock,
	        /* 🕟 */ FourThirty,
	        /* 🕔 */ FiveOclock,
	        /* 🕠 */ FiveThirty,
	        /* 🕕 */ SixOclock,
	        /* 🕡 */ SixThirty,
	        /* 🕖 */ SevenOclock,
	        /* 🕢 */ SevenThirty,
	        /* 🕗 */ EightOclock,
	        /* 🕣 */ EightThirty,
	        /* 🕘 */ NineOclock,
	        /* 🕤 */ NineThirty,
	        /* 🕙 */ TenOclock,
	        /* 🕥 */ TenThirty,
	        /* 🕚 */ ElevenOclock,
	        /* 🕦 */ ElevenThirty,
	        /* 🌑 */ NewMoon,
	        /* 🌒 */ WaxingCrescentMoon,
	        /* 🌓 */ FirstQuarterMoon,
	        /* 🌔 */ WaxingGibbousMoon,
	        /* 🌕 */ FullMoon,
	        /* 🌖 */ WaningGibbousMoon,
	        /* 🌗 */ LastQuarterMoon,
	        /* 🌘 */ WaningCrescentMoon,
	        /* 🌙 */ CrescentMoon,
	        /* 🌚 */ NewMoonFace,
	        /* 🌛 */ FirstQuarterMoonWithFace,
	        /* 🌜 */ LastQuarterMoonWithFace,
	        /* 🌡️ */ Thermometer,
	        /* ☀️ */ Sun,
	        /* 🌝 */ FullMoonWithFace,
	        /* 🌞 */ SunWithFace,
	        /* ⭐ */ WhiteMediumStar,
	        /* 🌟 */ GlowingStar,
	        /* 🌠 */ ShootingStar,
	        /* ☁️ */ Cloud,
	        /* ⛅ */ SunBehindCloud,
	        /* ⛈️ */ CloudWithLightningAndRain,
	        /* 🌤️ */ SunBehindSmallCloud,
	        /* 🌥️ */ SunBehindLargeCloud,
	        /* 🌦️ */ SunBehindRainCloud,
	        /* 🌧️ */ CloudWithRain,
	        /* 🌨️ */ CloudWithSnow,
	        /* 🌩️ */ CloudWithLightning,
	        /* 🌪️ */ Tornado,
	        /* 🌫️ */ Fog,
	        /* 🌬️ */ WindFace,
	        /* 🌀 */ Cyclone,
	        /* 🌈 */ Rainbow,
	        /* 🌂 */ ClosedUmbrella,
	        /* ☂️ */ Umbrella,
	        /* ☔ */ UmbrellaWithRainDrops,
	        /* ⛱️ */ UmbrellaOnGround,
	        /* ⚡ */ HighVoltage,
	        /* ❄️ */ Snowflake,
	        /* ☃️ */ Snowman,
	        /* ⛄ */ SnowmanWithoutSnow,
	        /* ☄️ */ Comet,
	        /* 🔥 */ Fire,
	        /* 💧 */ Droplet,
	        /* 🌊 */ WaterWave,
	        /* 🎃 */ JackOLantern,
	        /* 🎄 */ ChristmasTree,
	        /* 🎆 */ Fireworks,
	        /* 🎇 */ Sparkler,
	        /* ✨ */ Sparkles,
	        /* 🎈 */ Balloon,
	        /* 🎉 */ PartyPopper,
	        /* 🎊 */ ConfettiBall,
	        /* 🎋 */ TanabataTree,
	        /* 🎍 */ PineDecoration,
	        /* 🎎 */ JapaneseDolls,
	        /* 🎏 */ CarpStreamer,
	        /* 🎐 */ WindChime,
	        /* 🎑 */ MoonViewingCeremony,
	        /* 🎀 */ Ribbon,
	        /* 🎁 */ WrappedGift,
	        /* 🎗️ */ ReminderRibbon,
	        /* 🎟️ */ AdmissionTickets,
	        /* 🎫 */ Ticket,
	        /* 🎖️ */ MilitaryMedal,
	        /* 🏆 */ Trophy,
	        /* 🏅 */ SportsMedal,
	        /* 🥇 */ FirstPlaceMedal,
	        /* 🥈 */ SecondPlaceMedal,
	        /* 🥉 */ ThirdPlaceMedal,
	        /* ⚽ */ SoccerBall,
	        /* ⚾ */ Baseball,
	        /* 🏀 */ Basketball,
	        /* 🏐 */ Volleyball,
	        /* 🏈 */ AmericanFootball,
	        /* 🏉 */ RugbyFootball,
	        /* 🎾 */ Tennis,
	        /* 🎱 */ Pool8Ball,
	        /* 🎳 */ Bowling,
	        /* 🏑 */ FieldHockey,
	        /* 🏒 */ IceHockey,
	        /* 🏓 */ PingPong,
	        /* 🏸 */ Badminton,
	        /* 🥊 */ BoxingGlove,
	        /* 🥋 */ MartialArtsUniform,
	        /* 🥅 */ GoalNet,
	        /* 🎯 */ DirectHit,
	        /* ⛳ */ FlagInHole,
	        /* ⛸️ */ IceSkate,
	        /* 🎣 */ FishingPole,
	        /* 🎽 */ RunningShirt,
	        /* 🎿 */ Skis,
	        /* 🎮 */ VideoGame,
	        /* 🕹️ */ Joystick,
	        /* 🎲 */ GameDie,
	        /* ♠️ */ SpadeSuit,
	        /* ♥️ */ HeartSuit,
	        /* ♦️ */ DiamondSuit,
	        /* ♣️ */ ClubSuit,
	        /* 🃏 */ Joker,
	        /* 🀄 */ MahjongRedDragon,
	        /* 🎴 */ FlowerPlayingCards,
	        /* 🔇 */ MutedSpeaker,
	        /* 🔈 */ SpeakerLowVolume,
	        /* 🔉 */ SpeakerMediumVolume,
	        /* 🔊 */ SpeakerHighVolume,
	        /* 📢 */ Loudspeaker,
	        /* 📣 */ Megaphone,
	        /* 📯 */ PostalHorn,
	        /* 🔔 */ Bell,
	        /* 🔕 */ BellWithSlash,
	        /* 🎼 */ MusicalScore,
	        /* 🎵 */ MusicalNote,
	        /* 🎶 */ MusicalNotes,
	        /* 🎙️ */ StudioMicrophone,
	        /* 🎚️ */ LevelSlider,
	        /* 🎛️ */ ControlKnobs,
	        /* 🎤 */ Microphone,
	        /* 🎧 */ Headphone,
	        /* 📻 */ Radio,
	        /* 🎷 */ Saxophone,
	        /* 🎸 */ Guitar,
	        /* 🎹 */ MusicalKeyboard,
	        /* 🎺 */ Trumpet,
	        /* 🎻 */ Violin,
	        /* 🥁 */ Drum,
	        /* 📱 */ MobilePhone,
	        /* 📲 */ MobilePhoneWithArrow,
	        /* ☎️ */ Telephone,
	        /* 📞 */ TelephoneReceiver,
	        /* 📟 */ Pager,
	        /* 📠 */ FaxMachine,
	        /* 🔋 */ Battery,
	        /* 🔌 */ ElectricPlug,
	        /* 💻 */ LaptopComputer,
	        /* 🖥️ */ DesktopComputer,
	        /* 🖨️ */ Printer,
	        /* ⌨️ */ Keyboard,
	        /* 🖱️ */ ComputerMouse,
	        /* 🖲️ */ Trackball,
	        /* 💽 */ ComputerDisk,
	        /* 💾 */ FloppyDisk,
	        /* 💿 */ OpticalDisk,
	        /* 📀 */ Dvd,
	        /* 🎥 */ MovieCamera,
	        /* 🎞️ */ FilmFrames,
	        /* 📽️ */ FilmProjector,
	        /* 🎬 */ ClapperBoard,
	        /* 📺 */ Television,
	        /* 📷 */ Camera,
	        /* 📸 */ CameraWithFlash,
	        /* 📹 */ VideoCamera,
	        /* 📼 */ Videocassette,
	        /* 🔍 */ LeftPointingMagnifyingGlass,
	        /* 🔎 */ RightPointingMagnifyingGlass,
	        /* 🔬 */ Microscope,
	        /* 🔭 */ Telescope,
	        /* 📡 */ SatelliteAntenna,
	        /* 🕯️ */ Candle,
	        /* 💡 */ LightBulb,
	        /* 🔦 */ Flashlight,
	        /* 🏮 */ RedPaperLantern,
	        /* 📔 */ NotebookWithDecorativeCover,
	        /* 📕 */ ClosedBook,
	        /* 📖 */ OpenBook,
	        /* 📗 */ GreenBook,
	        /* 📘 */ BlueBook,
	        /* 📙 */ OrangeBook,
	        /* 📚 */ Books,
	        /* 📓 */ Notebook,
	        /* 📒 */ Ledger,
	        /* 📃 */ PageWithCurl,
	        /* 📜 */ Scroll,
	        /* 📄 */ PageFacingUp,
	        /* 📰 */ Newspaper,
	        /* 🗞️ */ RolledUpNewspaper,
	        /* 📑 */ BookmarkTabs,
	        /* 🔖 */ Bookmark,
	        /* 🏷️ */ Label,
	        /* 💰 */ MoneyBag,
	        /* 💴 */ YenBanknote,
	        /* 💵 */ DollarBanknote,
	        /* 💶 */ EuroBanknote,
	        /* 💷 */ PoundBanknote,
	        /* 💸 */ MoneyWithWings,
	        /* 💳 */ CreditCard,
	        /* 💹 */ ChartIncreasingWithYen,
	        /* 💱 */ CurrencyExchange,
	        /* 💲 */ HeavyDollarSign,
	        /* ✉️ */ Envelope,
	        /* 📧 */ EMail,
	        /* 📨 */ IncomingEnvelope,
	        /* 📩 */ EnvelopeWithArrow,
	        /* 📤 */ OutboxTray,
	        /* 📥 */ InboxTray,
	        /* 📦 */ Package,
	        /* 📫 */ ClosedMailboxWithRaisedFlag,
	        /* 📪 */ ClosedMailboxWithLoweredFlag,
	        /* 📬 */ OpenMailboxWithRaisedFlag,
	        /* 📭 */ OpenMailboxWithLoweredFlag,
	        /* 📮 */ Postbox,
	        /* 🗳️ */ BallotBoxWithBallot,
	        /* ✏️ */ Pencil,
	        /* ✒️ */ BlackNib,
	        /* 🖋️ */ FountainPen,
	        /* 🖊️ */ Pen,
	        /* 🖌️ */ Paintbrush,
	        /* 🖍️ */ Crayon,
	        /* 📝 */ Memo,
	        /* 💼 */ Briefcase,
	        /* 📁 */ FileFolder,
	        /* 📂 */ OpenFileFolder,
	        /* 🗂️ */ CardIndexDividers,
	        /* 📅 */ Calendar,
	        /* 📆 */ TearOffCalendar,
	        /* 🗒️ */ SpiralNotepad,
	        /* 🗓️ */ SpiralCalendar,
	        /* 📇 */ CardIndex,
	        /* 📈 */ ChartIncreasing,
	        /* 📉 */ ChartDecreasing,
	        /* 📊 */ BarChart,
	        /* 📋 */ Clipboard,
	        /* 📌 */ Pushpin,
	        /* 📍 */ RoundPushpin,
	        /* 📎 */ Paperclip,
	        /* 🖇️ */ LinkedPaperclips,
	        /* 📏 */ StraightRuler,
	        /* 📐 */ TriangularRuler,
	        /* ✂️ */ Scissors,
	        /* 🗃️ */ CardFileBox,
	        /* 🗄️ */ FileCabinet,
	        /* 🗑️ */ Wastebasket,
	        /* 🔒 */ Locked,
	        /* 🔓 */ Unlocked,
	        /* 🔏 */ LockedWithPen,
	        /* 🔐 */ LockedWithKey,
	        /* 🔑 */ Key,
	        /* 🗝️ */ OldKey,
	        /* 🔨 */ Hammer,
	        /* ⛏️ */ Pick,
	        /* ⚒️ */ HammerAndPick,
	        /* 🛠️ */ HammerAndWrench,
	        /* 🗡️ */ Dagger,
	        /* ⚔️ */ CrossedSwords,
	        /* 🔫 */ Pistol,
	        /* 🏹 */ BowAndArrow,
	        /* 🛡️ */ Shield,
	        /* 🔧 */ Wrench,
	        /* 🔩 */ NutAndBolt,
	        /* ⚙️ */ Gear,
	        /* 🗜️ */ Clamp,
	        /* ⚗️ */ Alembic,
	        /* ⚖️ */ BalanceScale,
	        /* 🔗 */ Link,
	        /* ⛓️ */ Chains,
	        /* 💉 */ Syringe,
	        /* 💊 */ Pill,
	        /* 🚬 */ Cigarette,
	        /* ⚰️ */ Coffin,
	        /* ⚱️ */ FuneralUrn,
	        /* 🗿 */ Moai,
	        /* 🛢️ */ OilDrum,
	        /* 🔮 */ CrystalBall,
	        /* 🛒 */ ShoppingCart,
	        /* 🏧 */ AtmSign,
	        /* 🚮 */ LitterInBinSign,
	        /* 🚰 */ PotableWater,
	        /* ♿ */ WheelchairSymbol,
	        /* 🚻 */ Restroom,
	        /* 🚼 */ BabySymbol,
	        /* 🚾 */ WaterCloset,
	        /* 🛂 */ PassportControl,
	        /* 🛃 */ Customs,
	        /* 🛄 */ BaggageClaim,
	        /* 🛅 */ LeftLuggage,
	        /* ⚠️ */ Warning,
	        /* 🚸 */ ChildrenCrossing,
	        /* ⛔ */ NoEntry,
	        /* 🚫 */ Prohibited,
	        /* 🚳 */ NoBicycles,
	        /* 🚭 */ NoSmoking,
	        /* 🚯 */ NoLittering,
	        /* 🚱 */ NonPotableWater,
	        /* 🚷 */ NoPedestrians,
	        /* 📵 */ NoMobilePhones,
	        /* 🔞 */ NoOneUnderEighteen,
	        /* ☢️ */ Radioactive,
	        /* ☣️ */ Biohazard,
	        /* ⬆️ */ UpArrow,
	        /* ↗️ */ UpRightArrow,
	        /* ➡️ */ RightArrow,
	        /* ↘️ */ DownRightArrow,
	        /* ⬇️ */ DownArrow,
	        /* ↙️ */ DownLeftArrow,
	        /* ⬅️ */ LeftArrow,
	        /* ↖️ */ UpLeftArrow,
	        /* ↕️ */ UpDownArrow,
	        /* ↔️ */ LeftRightArrow,
	        /* ↩️ */ RightArrowCurvingLeft,
	        /* ↪️ */ LeftArrowCurvingRight,
	        /* ⤴️ */ RightArrowCurvingUp,
	        /* ⤵️ */ RightArrowCurvingDown,
	        /* 🔃 */ ClockwiseVerticalArrows,
	        /* 🔄 */ AnticlockwiseArrowsButton,
	        /* 🔙 */ BackArrow,
	        /* 🔚 */ EndArrow,
	        /* 🔛 */ OnArrow,
	        /* 🔜 */ SoonArrow,
	        /* 🔝 */ TopArrow,
	        /* 🛐 */ PlaceOfWorship,
	        /* ⚛️ */ AtomSymbol,
	        /* 🕉️ */ Om,
	        /* ✡️ */ StarOfDavid,
	        /* ☸️ */ WheelOfDharma,
	        /* ☯️ */ YinYang,
	        /* ✝️ */ LatinCross,
	        /* ☦️ */ OrthodoxCross,
	        /* ☪️ */ StarAndCrescent,
	        /* ☮️ */ PeaceSymbol,
	        /* 🕎 */ Menorah,
	        /* 🔯 */ DottedSixPointedStar,
	        /* ♈ */ Aries,
	        /* ♉ */ Taurus,
	        /* ♊ */ Gemini,
	        /* ♋ */ Cancer,
	        /* ♌ */ Leo,
	        /* ♍ */ Virgo,
	        /* ♎ */ Libra,
	        /* ♏ */ Scorpius,
	        /* ♐ */ Sagittarius,
	        /* ♑ */ Capricorn,
	        /* ♒ */ Aquarius,
	        /* ♓ */ Pisces,
	        /* ⛎ */ Ophiuchus,
	        /* 🔀 */ ShuffleTracksButton,
	        /* 🔁 */ RepeatButton,
	        /* 🔂 */ RepeatSingleButton,
	        /* ▶️ */ PlayButton,
	        /* ⏩ */ FastForwardButton,
	        /* ⏭️ */ NextTrackButton,
	        /* ⏯️ */ PlayOrPauseButton,
	        /* ◀️ */ ReverseButton,
	        /* ⏪ */ FastReverseButton,
	        /* ⏮️ */ LastTrackButton,
	        /* 🔼 */ UpButton,
	        /* ⏫ */ FastUpButton,
	        /* 🔽 */ DownButton,
	        /* ⏬ */ FastDownButton,
	        /* ⏸️ */ PauseButton,
	        /* ⏹️ */ StopButton,
	        /* ⏺️ */ RecordButton,
	        /* ⏏️ */ EjectButton,
	        /* 🎦 */ Cinema,
	        /* 🔅 */ DimButton,
	        /* 🔆 */ BrightButton,
	        /* 📶 */ AntennaBars,
	        /* 📳 */ VibrationMode,
	        /* 📴 */ MobilePhoneOff,
	        /* ♀️ */ FemaleSign,
	        /* ♂️ */ MaleSign,
	        /* ⚕️ */ MedicalSymbol,
	        /* ♻️ */ RecyclingSymbol,
	        /* ⚜️ */ FleurDeLis,
	        /* 🔱 */ TridentEmblem,
	        /* 📛 */ NameBadge,
	        /* 🔰 */ JapaneseSymbolForBeginner,
	        /* ⭕ */ HeavyLargeCircle,
	        /* ✅ */ WhiteHeavyCheckMark,
	        /* ☑️ */ BallotBoxWithCheck,
	        /* ✔️ */ HeavyCheckMark,
	        /* ✖️ */ HeavyMultiplicationX,
	        /* ❌ */ CrossMark,
	        /* ❎ */ CrossMarkButton,
	        /* ➕ */ HeavyPlusSign,
	        /* ➖ */ HeavyMinusSign,
	        /* ➗ */ HeavyDivisionSign,
	        /* ➰ */ CurlyLoop,
	        /* ➿ */ DoubleCurlyLoop,
	        /* 〽️ */ PartAlternationMark,
	        /* ✳️ */ EightSpokedAsterisk,
	        /* ✴️ */ EightPointedStar,
	        /* ❇️ */ Sparkle,
	        /* ‼️ */ DoubleExclamationMark,
	        /* ⁉️ */ ExclamationQuestionMark,
	        /* ❓ */ QuestionMark,
	        /* ❔ */ WhiteQuestionMark,
	        /* ❕ */ WhiteExclamationMark,
	        /* ❗ */ ExclamationMark,
	        /* 〰️ */ WavyDash,
	        /* ©️ */ Copyright,
	        /* ®️ */ Registered,
	        /* ™️ */ TradeMark,
	        /* 💯 */ HundredPoints,
	        /* 🔠 */ InputLatinUppercase,
	        /* 🔡 */ InputLatinLowercase,
	        /* 🔢 */ InputNumbers,
	        /* 🔣 */ InputSymbols,
	        /* 🔤 */ InputLatinLetters,
	        /* 🅰️ */ AButtonBloodType,
	        /* 🆎 */ AbButtonBloodType,
	        /* 🅱️ */ BButtonBloodType,
	        /* 🆑 */ ClButton,
	        /* 🆒 */ CoolButton,
	        /* 🆓 */ FreeButton,
	        /* ℹ️ */ Information,
	        /* 🆔 */ IdButton,
	        /* Ⓜ️ */ CircledM,
	        /* 🆕 */ NewButton,
	        /* 🆖 */ NgButton,
	        /* 🅾️ */ OButtonBloodType,
	        /* 🆗 */ OkButton,
	        /* 🅿️ */ PButton,
	        /* 🆘 */ SosButton,
	        /* 🆚 */ VsButton,
	        /* 🈁 */ JapaneseHereButton,
	        /* 🈂️ */ JapaneseServiceChargeButton,
	        /* 🈷️ */ JapaneseMonthlyAmountButton,
	        /* 🈶 */ JapaneseNotFreeOfChargeButton,
	        /* 🈯 */ JapaneseReservedButton,
	        /* 🉐 */ JapaneseBargainButton,
	        /* 🈹 */ JapaneseDiscountButton,
	        /* 🈚 */ JapaneseFreeOfChargeButton,
	        /* 🈲 */ JapaneseProhibitedButton,
	        /* 🉑 */ JapaneseAcceptableButton,
	        /* 🈸 */ JapaneseApplicationButton,
	        /* 🈴 */ JapanesePassingGradeButton,
	        /* 🈳 */ JapaneseVacancyButton,
	        /* ㊗️ */ JapaneseCongratulationsButton,
	        /* ㊙️ */ JapaneseSecretButton,
	        /* 🈺 */ JapaneseOpenForBusinessButton,
	        /* 🈵 */ JapaneseNoVacancyButton,
	        /* ▪️ */ BlackSmallSquare,
	        /* ▫️ */ WhiteSmallSquare,
	        /* ◻️ */ WhiteMediumSquare,
	        /* ◼️ */ BlackMediumSquare,
	        /* ◽ */ WhiteMediumSmallSquare,
	        /* ◾ */ BlackMediumSmallSquare,
	        /* ⬛ */ BlackLargeSquare,
	        /* ⬜ */ WhiteLargeSquare,
	        /* 🔶 */ LargeOrangeDiamond,
	        /* 🔷 */ LargeBlueDiamond,
	        /* 🔸 */ SmallOrangeDiamond,
	        /* 🔹 */ SmallBlueDiamond,
	        /* 🔺 */ RedTrianglePointedUp,
	        /* 🔻 */ RedTrianglePointedDown,
	        /* 💠 */ DiamondWithADot,
	        /* 🔘 */ RadioButton,
	        /* 🔲 */ BlackSquareButton,
	        /* 🔳 */ WhiteSquareButton,
	        /* ⚪ */ WhiteCircle,
	        /* ⚫ */ BlackCircle,
	        /* 🔴 */ RedCircle,
	        /* 🔵 */ BlueCircle,
	        /* 🏁 */ ChequeredFlag,
	        /* 🚩 */ TriangularFlag,
	        /* 🎌 */ CrossedFlags,
	        /* 🏴 */ BlackFlag,
	        /* 🏳️ */ WhiteFlag,
	        /* 🏳️‍🌈 */ RainbowFlag,
        };
    }
}
