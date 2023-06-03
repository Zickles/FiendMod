using Modding;
using System;

namespace FiendMod
{
    public class FiendMod : Mod
    {
        public override string GetVersion() => "1.0.0.0";

        public override void Initialize()
        {
            Log("Initializing");

            ModHooks.LanguageGetHook += LanguageGet;

            Log("Initialized");
        }

        public string LanguageGet(string key, string sheetTitle, string orig)
        {
            if (key == "COLOSSEUM" && sheetTitle == "Map Zones")
            {
                return "Colosseum of Fiends";
            }
            if (key == "COLOSSEUM" && sheetTitle == "Jiji")
            {
                return "Yes, I can see the regrets you've left behind. A dark stain surrounded by warriors and fiends.";
            }
            switch (key) 
            {
                case "ZOTE_TEXT":
                    return "Defeat Zote in the Colosseum of Fiends";                    
                case "COLOSSEUM_3_TEXT":
                    return "Complete the Trial of the Fiend";
                case "COLOSSEUM_3_TITLE":
                    return "Fiend";
                case "GODSEEKER_WATERWAYS_AWAKE_1":
                    return "Creeper. Did thee wake Us?<page>Revived, this kingdom. These Gods, tuned and bested, gleaming in mind. Bright. Sharp.<page>...And this? Our form swells? Large? Nay. Immense. Majestic. Hibernation, so long forced upon Us, yet the shell that results is strong... So strong!<page>Thine gaze is adoring. Ye must think Us Godly. Amusing, fiendish. But thou art faced with enormity and beauty, true...";
                case "PANTHEON_ENTER_0":
                    return "Wretch! Thou hast ordained thine own destruction!<br><page>Through sacred combat are We attuned to this Kingdom's greatest beings. By entering this gate thou hast challenged the very Gods of this Kingdom!<br><page>Dost thou consider thyself the equal of this pantheon, of its masters? Draw thy weapon then, fiend of fiends, and be damned for thy arrogance!";                    
                case "GODSEEKER_ENGINE_PRIME_DREAM":
                    return "O bound one, thy silence nearly deafens Us. Fiendishly we feared thee, yet only by thine providence shall We find the one We seek. The God sleeping within... ";                    
                case "ELDERBUG_FLOWER_DECLINE":
                    return "Oh. My mistake. Yes. Very fiendish of me. I don't know why I thought you'd go to so much effort for a simple old bug.<page>Appreciating others and being considerate... these aren't skills that everyone is born with.";                    
                case "GREY_PRINCE_5":
                    return "Jealous fiend! You stand no chance!";                    
                case "ZOTE_2":
                    return "Another fiend to be cut down by Life Ender...";                    
                case "XERO_DEFEAT":
                    return "Ah... I can see now. Those who turn against the King are doomed as soon as they raise their weapon.<page>Do not call me a traitor. Simply call me a fiend.<page>I know you will not flee. Wherever you go... I will be watching.";                    
                case "MARKOTH_REPEAT":
                    return "Raise your weapon then, fiend, and die like those who came before you.";
                case "DESC_COL_SHIELD":
                    return "Warrior fighting for glory in the Colosseum of Fiends. Warily approaches opponents with shell held high.";
                case "NOTE_MAWLEK_TURRET":
                    return "How did this fiendish creature lose its legs?! I suppose it's possible to lose anything, if you really try.";
                case "DESC_COL_FLYINGSENTRY":
                    return "Warrior fighting for glory in the Colosseum of Fiends. Flies just out of an opponent's reach then darts in for the kill.";
                case "NAME_COL_MINER":
                    return "Sturdy Fiend";
                case "NOTE_MAGEBLOB":
                    return "These fiends meddled with the soul of other creatures and lost their shape. Now they skulk through the shadows of their Sanctum like slugs, hoping their old brothers will build them new bodies.";
                case "DESC_COL_ROLLER":
                    return "Hardened baldur, bred for battle in the Colosseum of Fiends. Tougher and more aggressive than its wild ancestor.";
                case "NAME_COL_SHIELD":
                    return "Shielded Fiend";
                case "NAME_SNAPPER_TRAP":
                    return "Fiend Eater";
                case "DESC_LOBSTER_LANCER":
                    return "Veteran warrior of the Colosseum of Fiends. Fights by the side of creatures she has trained.";
                case "NOTE_MAGE_BALLOON":
                    return "I've heard whispers that the secret these fiends were searching for was immortality. To live forever... I've never heard of anything so obscene!";
                case "DESC_COL_MOSQUITO":
                    return "Hardened squit, bred for battle in the Colosseum of Fiends. Tougher and more aggressive than its wild ancestor.";
                case "NOTE_SNAPPER_TRAP":
                    return "You really would have to be a fiend to be tricked by a plant.";
                case "NAME_COL_FLYINGSENTRY":
                    return "Winged Fiend";
                case "NAME_COL_WORM":
                    return "Heavy Fiend";
                case "DESC_COL_WORM":
                    return "Warrior fighting for glory in the Colosseum of Fiends. Aggressively charges down foes.";
                case "DESC_COL_MINER":
                    return "Warrior fighting for glory in the Colosseum of Fiends. Uses crescent-shaped blades to cut down foes.";
                case "GLAD_DUNGEON":
                    return "...Are we all Fiends?..";
                case "CLIFF_TAB_02":
                    return "Higher beings, these words are for you alone.<br><br>These blasted plains stretch never-ending. There is no world beyond.<br>Those fiendish enough to traverse this void must pay the toll and relinquish the precious mind this kingdom grants.";
                case "COL_CORPSE_ACID_01":
                    return "...Fiends...";
                case "CLOTH_FUNG_DREAM":
                    return "Am I in over my head? Even these shroom creatures almost did me in and far nastier things await further down.<page>Curse me and my fiendish bravado! If I could shed my pride, I'd be asking this tiny warrior for help. ";
                case "LITTLE_FOOL_CHAMP":
                    return "A true fiend keeps on fighting, even when there is no more glory to be gained. Step over to a board and make your mark! Show us how fiendish you truly are!";
                case "LEGEATER_BROKEN":
                    return "Eeeauuggh! You broke it! I gave you that charm as a gift, and you broke it! Clumsy little fiend... Nasty.<page>Apologise, ask me nicely, and I'll fix it for you. Give me Geo and I'll fix it for you.";
                case "DUNG_DEFENDER_ISMA":
                    return "Ahh! That tear... You've been to her grove!<page>I swore I'd visit, but... my duties... my oath...<page>Oh, I'm sorry. Ignore me, I'm being fiendish. If I'm not careful I'll sink down into old memories and won't ever come back again.<page>She's a great judge of character, so if she gave you her blessing you must be something special indeed. I'm barely worthy to be in your presence!";
                case "LITTLE_FOOL_OFFER_3":
                    return "Make a contribution, and you can enter the Trial of the Fiend.";
                case "LITTLE_FOOL_DREAM":
                    return "Lord Fiend, give me another chance. I'll prove my strength to you!";
                case "LEGEATER_REFUSE":
                    return "You're a fiend, aren't you?";
                case "TRIAL_BOARD_GOLD":
                    return "Trial of the Fiend. Fight for Geo... and the glory of being a Fiend.<br>Place a mark and begin the Trial?";
                case "TRIAL_UNLOCK_GOLD":
                    return "Pay to open the Trial of the Fiend?";
                case "STAG_TRAM":
                    return "That pass you hold! Is it not for that ghastly machine, the tram? I hope you're not thinking of riding on that grotesque contraption.<page>The thought a mere machine could attempt what we stags do! Fiendish...Very fiendish.";
                case "LITTLE_FOOL_MAIN":
                    return "Fiend";
                case "COLOSSEUM_SUB":
                    return "Of Fiends";
                case "PRECEPT_2":
                    return "Precept Two: 'Never Let Them Laugh at You'.<page>Fiends laugh at everything, even at their superiors. But beware, laughter isn't harmless! Laughter spreads like a disease, and soon everyone is laughing at you.<page>You need to strike at the source of this perverse merriment quickly to stop it from spreading.";
                case "ZOTE_COLOSSEUM_MEET":
                    return "Hmm? What do you want, cur? Have you come to laugh at me as well?<page>Fiends! Did you never consider that being trapped in this cage was precisely what I intended?!<page>Yes, by all means, release me into your arena!<page>I am Zote the Mighty! And as soon as I draw my nail, 'Life Ender', your laughter will turn into terror!";
                case "ZOTE_DREAM_BUZZER":
                    return "Fiendish beast... you dulled your mandibles by gnawing on my indestructible body. No wonder you were defeated by this weakling!";
                case "ZOTE_COLOSSEUM_GREET":
                    return "I have been fighting my whole life. I've slain hundreds, nay thousands, of foes.<page>And these fiends think to face me in combat? Madness! It seems they've been gripped by a powerful desire to be destroyed.<page>Very well then. Zote the Mighty will grant them their desire...";
            }
            return orig;
        }
    }
}
