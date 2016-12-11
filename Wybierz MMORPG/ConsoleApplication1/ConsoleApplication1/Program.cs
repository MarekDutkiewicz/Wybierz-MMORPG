using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gry BnS = new Gry();
            BnS.nazwa = "Blade & Soul";
            BnS.opis = "Gra MMORPG osadzona w realiach azjatyckiego fantasy. Autorzy skoncentrowali się przede wszystkim na stworzeniu rozbudowanego systemu potyczek, opartego na dalekowschodnich sztukach walki. Starcia z wrogami dodatkowo uatrakcyjnia zaawansowany silnik fizyczny. Całość powstała w oparciu o technologię Unreal Engine 3.0.";
            BnS.StrInt = "www.bladeandsoul.com/";
            BnS.dwlp = "NCSoft";

            Gry BD = new Gry();
            BD.nazwa = "Black Desert";
            BD.opis = "gra MMORPG osadzona w mrocznym świecie fantasy i koncentruje się na dostarczeniu dużego wirtualnego świata, pozbawionego instancjonowania. Sercem tej produkcji jest mocno zręcznościowy system walki, pozwalający również na potyczki konne oraz przeprowadzanie oblężeń.";
            BD.StrInt = "www.blackdesertonline.com/";
            BD.dwlp = "Pearl Abyss";

            Gry Aion = new Gry();
            Aion.nazwa = "Aion";
            Aion.opis = "W produkcji przenosimy się do świata zamieszkałego przez dwie zwaśnione frakcje i rozdartego potężnym kataklizmem. Podczas zabawy rozwijamy postać, wykonujemy zadania i walczymy z potworami w pojedynkę lub w grupach graczy. Twórcy przygotowali też rozbudowany tryb PvP i parę ciekawych funkcji, jak np. możliwość latania.";
            Aion.StrInt = "pl.aion.gameforge.com/";
            Aion.dwlp = "NCSoft";

            Gry EVE = new Gry();
            EVE.nazwa = "EVE online";
            EVE.opis = "symulator statku kosmicznego w konwencji MMO, wzbogacony o szerokie możliwości ekonomiczne i wojenne. Olbrzymi świat oferuje nam nie tylko możliwość staczania bitew i rozwoju postaci, ale przede wszystkim rozwijanie własnego imperium za pomocą handlu czy produkcji nowych technologii. Autorzy regularnie wypuszczają kolejne aktualizacje, które czynią wszechświata EVE jeszcze większym i doskonalszym.";
            EVE.StrInt = "www.eveonline.com/";
            EVE.dwlp = "EVE Universe";

            Gry M2 = new Gry();
            M2.nazwa = "Metin2";
            M2.opis = "osadzony w orientalnych klimatach MMORPG łączący w sobie elementy gier fantasy oraz mistyczną naturę dalekiego wschodu. Akcja gra rozgrywa się w świecie gdzie pewnego dnia z nieba spadły tajemnicze kamienie Metin, które przekształciły spokojny niegdyś świat w niebezpieczne i groźne miejsce. Zwierzęta zamieniły się w krwiożercze bestie, zmarli powstali z grobów, a niegdyś sprzymierzone królestwa rozpoczęły między sobą bezlitosną i krwawą wojnę. Gracz wciela się w sprzymierzeńca Boga Smoków, a jego głównym zadaniem jest walka ze zgubnym wpływem kamieni Metin.";
            M2.StrInt = "pl.metin2.gameforge.com/‎";
            M2.dwlp = "GameForge";

            Gry Mrg = new Gry();
            Mrg.nazwa = "Margonem";
            Mrg.opis = "Przeglądarkowa Gra MMORPG z przyjemną dla oka grafiką 2D, ogromem umiejętności każdej klasy postaci i wielką krainą oddaną do użytku graczy. Gra naciska duży nacisk na system klanów i bractw, jest on bardzo rozbudowany.";
            Mrg.StrInt = "www.margonem.pl/";
            Mrg.dwlp = "Garmory";

            Gry DN = new Gry();
            DN.nazwa = "Dragon Nest";
            DN.opis = "Dragon Nest jest dynamiczną grą z gatunku MMORPG, stworzoną przez południowokoreańskie studio deweloperskie Eyedentity Games. Fabuła przenosi graczy do fantastycznej krainy Lagendia, gdzie kreują własnych bohaterów i ruszają na pomoc bogini Altei, zatrutej przez swą złą siostrę - Vestinel. Gra dystrybuowana jest na zasadzie free-to-play z opcją mikropłatności za niektóre przedmioty i udogodnienia.";
            DN.StrInt = "www.dragonnest.eu";
            DN.dwlp = "Eyedentity";

            Gry L2 = new Gry();
            L2.nazwa = "Lineage 2";
            L2.opis = "Jedna z bardziej znanych i cenionych gier MMO w historii tego gatunku. Produkcja rozgrywa się w świecie fantasy zamieszkałym przez ludzi, elfy, krasnoludy i inne istoty. Lineage II cechuje się olbrzymim światem, rozbudowanym rozwojem postaci, bitwami zakrojonymi na ogromną skalę oraz motywem przejmowania kontroli nad zamkami. W grudniu 2011 roku gra przeszła na model free to play.";
            L2.StrInt = "www.lineage2.com/";
            L2.dwlp = "NCSoft";

            Gry D3 = new Gry();
            D3.nazwa = "Diablo 3";
            D3.opis = "Trzecia część jednej z najbardziej znanych i cenionych serii gier akcji RPG. Produkcja rozgrywa się w świecie Sanktuarium, w którym toczy się odwieczna walka między aniołami i demonami. Gracz wciela się w jedną z kilku dostępnych postaci, aby podjąć walkę ze złem. Twórcy wprowadzili do gry mnóstwo nowych rozwiązań i pomysłów.";
            D3.StrInt = "eu.battle.net/D3/pl";
            D3.dwlp = "Blizzard";

            Gry NT = new Gry();
            NT.nazwa = "NosTale";
            NT.opis = "sieciowa gra typu MMORPG stworzona w kreskówkowej, anime grafice(niepełne 3D).W grze znajdują się cztery żywioły tj: ogień, woda, światło, ciemność i element neutralny. W grze występują klasy postaci: Podróżnik, Mag, Ninja oraz Wojownik.Na początku grę zaczynamy podróżnikiem aby poznać mechanikę gry.Dopiero po dociągnięciu 15 lvl postaci oraz 20 profesji dane nam będzie przemienić naszego podróżnika w maga, wojownika bądź ninje.Każda klasa posiada unikalny zestaw umiejętności wzmacniających i walczących.";
            NT.StrInt = "www.nostale.pl/";
            NT.dwlp = "GameForge";

            Gry TERA = new Gry();
            TERA.nazwa = "TERA Online";
            TERA.opis = "gra z gatunku MMORPG wyprodukowana przez koreańskie studio Bluehole. Fabuła koncentruje się wokół losów Federacji Valkyon, stanowiącej przymierze ras żyjących w fantastycznym świecie.Prowadzona przez gracza postać uczestniczy w zmaganiach z siłami starającymi się obalić pokój.Gra oferuje 6 ras i 8 archetypowych profesji, a także nietuzinkowy system walki";
            TERA.StrInt = "en.tera.gameforge.com/";
            TERA.dwlp = "BlueHole / w Polsce GameForge";

            Gry WoT = new Gry();
            WoT.nazwa = "World of Tanks";
            WoT.opis = "darmowa gra MMO koncentrująca się na bitwach pomiędzy czołgami. Gra oferuje nam szansę pokierowania jednym z ponad 150 czołgów pochodzących z różnych okresów historycznych, od czasów poprzedzających II wojnę światową, aż po Wojnę koreańską. Każdy z nich posiada unikalną i zgodną z rzeczywistością charakterystykę, którą można usprawniać poprzez rozbudowę i różnorodne ulepszenia.";
            WoT.StrInt = "worldoftanks.eu/";
            WoT.dwlp = "Wargaming";

            Gry WoW = new Gry();
            WoW.nazwa = "World of Warcraft";
            WoW.opis = "Gra z gatunku cRPG przeznaczona do rozgrywki w trybie massive multiplayer online. Akcja przenosi tysiące graczy z całego świata do fantastycznego świata Warcraft’a, gdzie mogą poznawać jego tajemnice i legendy, odkrywać nigdy wcześniej nie widziane tereny oraz uczestniczyć w wielkich przygodach i krwawych bitwach.";
            WoW.StrInt = "worldofwarcraft.com/";
            WoW.dwlp = "Blizzard";

            Gry eoo = new Gry();
            eoo.nazwa = "The elder scrolls online";
            eoo.opis = "produkcja należąca do gatunku MMO, w której duży nacisk położono na ogromny, zróżnicowany i w pełni otwarty świat. Gra pozwala inaczej spojrzeć na krainy wykreowane między innymi w takich bestsellerach jak The Elder Scrolls Skyrim.";
            eoo.StrInt = "www.elderscrollsonline.com/";
            eoo.dwlp = "ZeniMax Online";

            Gry Esw = new Gry();
            Esw.nazwa = "Elsword";
            Esw.opis = "gra MMO, łącząca elementy side-scrollowej platformówki, bijatyki z rodzaju beat'em up i cRPG. Tytuł wyprodukowany został przez firmę KOG Games. Gracze wcielają się w mieszkańców fantastycznego świata, który staje się celem inwazji potworów. Oprawa wizualna gry utrzymana jest w konwencji komiksu manga.";
            Esw.StrInt = "www.elsword.pl/";
            Esw.dwlp = "KOG Studios / w Polsce Gameforge";

            Gry pkmn = new Gry();
            pkmn.nazwa = "PokeMMO";
            pkmn.opis = "stworzona przez fanów internetowa wersja gry na Gameboy’a Pokemon Fire Red. Mamy tu do czynienia zarówno z klasyczną kampanią jak i z zabawą z innymi graczami. W grze kreujemy swoją postać, nazywamy ją oraz łapiemy tytułowe pokemony, które będziemy używać w walce. Wszystkie zalety z oryginału zostały przeniesione do świata MMO, a nawet znacznie ulepszone.";
            pkmn.StrInt = "pokemmo.eu/";
            pkmn.dwlp = "PokeDEV";

            Gry Tibia = new Gry();
            Tibia.nazwa = "Tibia";
            Tibia.opis = "Gra z gatunku MMORPG, utworzona przez czterech niemieckich studentów informatyki: Stephana Börzsönyi, Ulricha Schlotta, Stephana Voglera i Guido Lübke (był zwykłym graczem, który dołączył do zespołu). Obecnym właścicielem praw do tej gry jest firma CipSoft. Myślę że nie trzeba jej przedstawiać nikomu ;)";
            Tibia.StrInt = "www.tibia.com/news/";
            Tibia.dwlp = "Cipsoft";

            Gry ToS = new Gry();
            ToS.nazwa = "Tree of Savior";
            ToS.opis = "gra MMORPG z Korei Południowej, stworzona jako duchowy spadkobierca Ragnarok Online. Ukazanie akcji w rzucie izometrycznym oraz zręcznościowy model walki sprawiają, że tytuł pod wieloma względami przypomina przedstawiciela gatunku hack’n’slash. Warto też wspomnieć o rozbudowanym systemie rozwoju bohatera, zawierającym 80 różnych klas postaci.";
            ToS.StrInt = "treeofsavior.com/";
            ToS.dwlp = "IMC Games";

            Gry MS = new Gry();
            MS.nazwa = "Maple Strory";
            MS.opis = "gra komputerowa z gatunku MMORPG, z elementami gry platformowej 2D, wyprodukowana przez koreańską firmę Wizet. Gra utrzymywana jest w konwencji anime fantasy.";
            MS.StrInt = "maplestory.nexon.net/";
            MS.dwlp = "NEXON";

            Gry AE = new Gry();
            AE.nazwa = "Ashen Empires";
            AE.opis = "gra z rodzaju MMORPG, oferująca średniowieczny świat fantasy, która powstała na podwalinach innego produktu, Dransik. Jedną z mocnych stron Ashen Empires jest możliwość tworzenia przez gracza własnej historii. Nie ma złego czy ";
            AE.StrInt = "www.ashenempires.com/";
            AE.dwlp = "TKO Games";

            Gry vd = new Gry();
            vd.nazwa = "Vindictus";
            vd.opis = "osadzona w klimatach dark fantasy gra akcji z elementami RPG, wyprodukowana przez studio Nexon. Gracz kieruje poczynaniami bohatera, który próbuje rozwikłać zagadkę nękanego przez potwory świata i znaleźć drogę do mitycznej, rajskiej krainy - Erinn. Tytuł oferuje realistyczny model walki, bazujący na możliwościach silnika Source.";
            vd.StrInt = "vindictus.nexoneu.com/";
            vd.dwlp = "NEXON";

            bool i;
            i = true;
            string a, odp;
            int gra, j, index;

            Console.WriteLine("Witaj. Podaj swoje imię.");
            a = Console.ReadLine();
            Console.WriteLine("Witaj {0}.\nWlaśnie uruchomiłeś program który pomoże Ci znaleźć MMORPG dobrane pod Twój gust.", a);
            Console.WriteLine("Zobaczysz teraz kilka pytań.\nOdpowiedz na nie wpisując a,b lub c, zależnie od Twoich upodobań :).\n");

            do
            {
                Console.WriteLine("\nTwój komputer jest stary czy z wyższej półki?\n a) stary \n b) z wyższej półki \n c) Przeciętny.\n");
                odp = (Console.ReadLine());
                if (odp == "a")
                {
                    BnS.pkt = BnS.pkt + 0;
                    BD.pkt = BD.pkt + 0;
                    Aion.pkt = Aion.pkt + 0;
                    EVE.pkt = EVE.pkt + 0;
                    M2.pkt = M2.pkt + 8;
                    Mrg.pkt = Mrg.pkt + 10;
                    DN.pkt = DN.pkt + 7;
                    L2.pkt = L2.pkt + 2;
                    D3.pkt = D3.pkt + 1;
                    NT.pkt = NT.pkt + 8;
                    TERA.pkt = TERA.pkt + 1;
                    WoT.pkt = WoT.pkt + 1;
                    WoW.pkt = WoW.pkt + 4;
                    eoo.pkt = eoo.pkt + 3;
                    Esw.pkt = Esw.pkt + 7;
                    pkmn.pkt = pkmn.pkt + 10;
                    Tibia.pkt = Tibia.pkt + 10;
                    ToS.pkt = ToS.pkt + 4;
                    MS.pkt = MS.pkt + 3;
                    AE.pkt = AE.pkt + 5;
                    vd.pkt = vd.pkt + 1;
                    i = false;
                }
                else
                    if (odp == "b")
                {
                    BnS.pkt = BnS.pkt + 8;
                    BD.pkt = BD.pkt + 9;
                    Aion.pkt = Aion.pkt + 8;
                    EVE.pkt = EVE.pkt + 8;
                    M2.pkt = M2.pkt + 2;
                    Mrg.pkt = Mrg.pkt + 1;
                    DN.pkt = DN.pkt + 2;
                    L2.pkt = L2.pkt + 6;
                    D3.pkt = D3.pkt + 7;
                    NT.pkt = NT.pkt + 2;
                    TERA.pkt = TERA.pkt + 8;
                    WoT.pkt = WoT.pkt + 8;
                    WoW.pkt = WoW.pkt + 3;
                    eoo.pkt = eoo.pkt + 8;
                    Esw.pkt = Esw.pkt + 8;
                    pkmn.pkt = pkmn.pkt + 1;
                    Tibia.pkt = Tibia.pkt + 1;
                    ToS.pkt = ToS.pkt + 5;
                    MS.pkt = MS.pkt + 5;
                    AE.pkt = AE.pkt + 5;
                    vd.pkt = vd.pkt + 5;
                    i = false;

                }
                else
                    if (odp == "c")
                {

                    i = false;
                }
                else
                {
                    Console.WriteLine("\nnie ma takiej odpowiedzi! odpowiedz jeszcze raz.\n");
                }
            }
            while (i == true);
            i = true;
            do
            {
                Console.WriteLine("\nPreferujesz gry P2P/B2P(pay to play/buy to play) czy F2P(free to play)?\n a) P2P/B2P \n b) F2P \n");
                odp = (Console.ReadLine());
                if (odp == "a")
                {
                    BD.pkt = BD.pkt + 5;
                    D3.pkt = D3.pkt + 5;
                    WoW.pkt = WoW.pkt + 5;
                    eoo.pkt = eoo.pkt + 5;

                    i = false;
                }
                else
                    if (odp == "b")
                {
                    BnS.pkt = BnS.pkt + 5;
                    Aion.pkt = Aion.pkt + 5;
                    EVE.pkt = EVE.pkt + 5;
                    M2.pkt = M2.pkt + 5;
                    Mrg.pkt = Mrg.pkt + 5;
                    DN.pkt = DN.pkt + 5;
                    L2.pkt = L2.pkt + 5;
                    NT.pkt = NT.pkt + 5;
                    TERA.pkt = TERA.pkt + 5;
                    WoT.pkt = WoT.pkt + 5;
                    Esw.pkt = Esw.pkt + 5;
                    pkmn.pkt = pkmn.pkt + 5;
                    Tibia.pkt = Tibia.pkt + 5;
                    ToS.pkt = ToS.pkt + 5;
                    MS.pkt = MS.pkt + 5;
                    AE.pkt = AE.pkt + 5;
                    vd.pkt = vd.pkt + 5;
                    i = false;

                }
                else
                {
                    Console.WriteLine("\nnie ma takiej odpowiedzi! odpowiedz jeszcze raz.\n");
                }
            }
            while (i == true);
            i = true;
            do
            {
                Console.WriteLine("\nPreferujesz gry polskojęzyczne czy anglojęzyczne?\n a) polskojęzyczne \n b) anglojęzyczne \n c) bez znaczenia.\n");
                odp = (Console.ReadLine());
                if (odp == "a")
                {
                    BnS.pkt = BnS.pkt + 5;
                    BD.pkt = BD.pkt + 5;
                    Aion.pkt = Aion.pkt + 5;
                    EVE.pkt = EVE.pkt + 5;
                    M2.pkt = M2.pkt - 5;
                    Mrg.pkt = Mrg.pkt - 5;
                    DN.pkt = DN.pkt + 5;
                    L2.pkt = L2.pkt + 5;
                    D3.pkt = D3.pkt - 5;
                    NT.pkt = NT.pkt - 5;
                    TERA.pkt = TERA.pkt + 5;
                    WoT.pkt = WoT.pkt - 5;
                    WoW.pkt = WoW.pkt + 5;
                    eoo.pkt = eoo.pkt + 5;
                    Esw.pkt = Esw.pkt + 5;
                    pkmn.pkt = pkmn.pkt + 5;
                    Tibia.pkt = Tibia.pkt + 5;
                    ToS.pkt = ToS.pkt + 5;
                    MS.pkt = MS.pkt + 5;
                    AE.pkt = AE.pkt + 5;
                    vd.pkt = vd.pkt + 5;
                    i = false;
                }
                else
                    if (odp == "b")
                {
                    BnS.pkt = BnS.pkt - 5;
                    BD.pkt = BD.pkt - 5;
                    Aion.pkt = Aion.pkt - 5;
                    EVE.pkt = EVE.pkt - 5;
                    M2.pkt = M2.pkt + 5;
                    Mrg.pkt = Mrg.pkt + 5;
                    DN.pkt = DN.pkt - 5;
                    L2.pkt = L2.pkt - 5;
                    D3.pkt = D3.pkt + 5;
                    NT.pkt = NT.pkt + 5;
                    TERA.pkt = TERA.pkt - 5;
                    WoT.pkt = WoT.pkt + 5;
                    WoW.pkt = WoW.pkt - 5;
                    eoo.pkt = eoo.pkt - 5;
                    Esw.pkt = Esw.pkt - 5;
                    pkmn.pkt = pkmn.pkt - 5;
                    Tibia.pkt = Tibia.pkt - 5;
                    ToS.pkt = ToS.pkt - 5;
                    MS.pkt = MS.pkt - 5;
                    AE.pkt = AE.pkt - 5;
                    vd.pkt = vd.pkt - 5;
                    i = false;

                }
                else
                    if (odp == "c")
                {

                    i = false;
                }
                else
                {
                    Console.WriteLine("\nnie ma takiej odpowiedzi! odpowiedz jeszcze raz.\n");
                }
            }
            while (i == true);
            i = true;
            do
            {
                Console.WriteLine("\nWolisz gry w których grafika nawiązuje do świata fantasy czy skupia się na realizmie? \n a) grafika fantasy \n b) grafika realistyczna \n c) bez różnicy.\n");
                odp = (Console.ReadLine());
                if (odp == "a")
                {

                    BnS.pkt = BnS.pkt + 4;
                    BD.pkt = BD.pkt + 0;
                    Aion.pkt = Aion.pkt + 4;
                    EVE.pkt = EVE.pkt + 0;
                    M2.pkt = M2.pkt + 4;
                    Mrg.pkt = Mrg.pkt + 5;
                    DN.pkt = DN.pkt + 5;
                    L2.pkt = L2.pkt + 4;
                    D3.pkt = D3.pkt + 2;
                    NT.pkt = NT.pkt + 2;
                    TERA.pkt = TERA.pkt + 3;
                    WoT.pkt = WoT.pkt + 1;
                    WoW.pkt = WoW.pkt + 4;
                    eoo.pkt = eoo.pkt - 1;
                    Esw.pkt = Esw.pkt + 2;
                    pkmn.pkt = pkmn.pkt + 4;
                    Tibia.pkt = Tibia.pkt + 3;
                    ToS.pkt = ToS.pkt + 3;
                    MS.pkt = MS.pkt + 2;
                    AE.pkt = AE.pkt + 2;
                    vd.pkt = vd.pkt + 2;
                    i = false;
                }
                else
                    if (odp == "b")
                {
                    BnS.pkt = BnS.pkt + 1;
                    BD.pkt = BD.pkt + 5;
                    Aion.pkt = Aion.pkt + 1;
                    EVE.pkt = EVE.pkt + 5;
                    M2.pkt = M2.pkt + 1;
                    Mrg.pkt = Mrg.pkt + 0;
                    DN.pkt = DN.pkt + 1;
                    L2.pkt = L2.pkt + 3;
                    D3.pkt = D3.pkt + 3;
                    NT.pkt = NT.pkt + 3;
                    TERA.pkt = TERA.pkt + 2;
                    WoT.pkt = WoT.pkt + 4;
                    WoW.pkt = WoW.pkt + 3;
                    eoo.pkt = eoo.pkt + 2;
                    Esw.pkt = Esw.pkt + 2;
                    pkmn.pkt = pkmn.pkt + 4;
                    Tibia.pkt = Tibia.pkt + 1;
                    ToS.pkt = ToS.pkt + 3;
                    MS.pkt = MS.pkt + 2;
                    AE.pkt = AE.pkt + 2;
                    vd.pkt = vd.pkt + 2;
                    i = false;

                }
                else
                    if (odp == "c")
                {

                    i = false;
                }
                else
                {
                    Console.WriteLine("nie ma takiej odpowiedzi! odpowiedz jeszcze raz.\n");
                }
            }
            while (i == true);
            i = true;
            do
            {
                Console.WriteLine("\nWolisz dobrą i 'świeżą' grafikę czy jesteś fanem retro?\n a) wolę grafikę szczegółową \n b) wolę grafikę retro.\n");
                odp = (Console.ReadLine());
                if (odp == "a")
                {
                    BnS.pkt = BnS.pkt + 8;
                    BD.pkt = BD.pkt + 10;
                    Aion.pkt = Aion.pkt + 8;
                    EVE.pkt = EVE.pkt + 10;
                    M2.pkt = M2.pkt + 4;
                    Mrg.pkt = Mrg.pkt + 6;
                    DN.pkt = DN.pkt + 2;
                    L2.pkt = L2.pkt + 6;
                    D3.pkt = D3.pkt + 6;
                    NT.pkt = NT.pkt + 6;
                    TERA.pkt = TERA.pkt + 5;
                    WoT.pkt = WoT.pkt + 8;
                    WoW.pkt = WoW.pkt - 1;
                    eoo.pkt = eoo.pkt + 3;
                    Esw.pkt = Esw.pkt + 1;
                    pkmn.pkt = pkmn.pkt + 3;
                    Tibia.pkt = Tibia.pkt + 0;
                    ToS.pkt = ToS.pkt + 2;
                    MS.pkt = MS.pkt + 6;
                    AE.pkt = AE.pkt + 4;
                    vd.pkt = vd.pkt + 2;
                    i = false;

                }
                else
                if (odp == "b")
                {
                    BnS.pkt = BnS.pkt - 1;
                    BD.pkt = BD.pkt - 1;
                    Aion.pkt = Aion.pkt - 1;
                    EVE.pkt = EVE.pkt - 1;
                    M2.pkt = M2.pkt + 4;
                    Mrg.pkt = Mrg.pkt + 4;
                    DN.pkt = DN.pkt + 2;
                    L2.pkt = L2.pkt - 1;
                    D3.pkt = D3.pkt - 1;
                    NT.pkt = NT.pkt + 4;
                    TERA.pkt = TERA.pkt - 5;
                    WoT.pkt = WoT.pkt - 4;
                    WoW.pkt = WoW.pkt + 1;
                    eoo.pkt = eoo.pkt - 3;
                    Esw.pkt = Esw.pkt - 1;
                    pkmn.pkt = pkmn.pkt + 3;
                    Tibia.pkt = Tibia.pkt + 4;
                    ToS.pkt = ToS.pkt + 2;
                    MS.pkt = MS.pkt + 3;
                    AE.pkt = AE.pkt + 4;
                    vd.pkt = vd.pkt + 2;
                    i = false;
                }
                else
                {
                    Console.WriteLine("Nie ma takiej odpowiedzi! odpowiedz jeszcze raz.\n");
                }
            }
            while (i == true);
            i = true;
            do
            {
                Console.WriteLine("\nSzukasz gry nastawionej na pvp czy pve? \n a) pvp \n b) pve \n c) lubię pvp i pve.\n");
                odp = (Console.ReadLine());
                if (odp == "a")
                {
                    BnS.pkt = BnS.pkt + 4;
                    BD.pkt = BD.pkt + 5;
                    Aion.pkt = Aion.pkt + 4;
                    EVE.pkt = EVE.pkt + 5;
                    M2.pkt = M2.pkt - 5;
                    Mrg.pkt = Mrg.pkt + 5;
                    DN.pkt = DN.pkt + 4;
                    L2.pkt = L2.pkt + 4;
                    D3.pkt = D3.pkt + 2;
                    NT.pkt = NT.pkt + 3;
                    TERA.pkt = TERA.pkt - 1;
                    WoT.pkt = WoT.pkt + 8;
                    WoW.pkt = WoW.pkt + 6;
                    eoo.pkt = eoo.pkt - 6;
                    Esw.pkt = Esw.pkt - 3;
                    pkmn.pkt = pkmn.pkt + 6;
                    Tibia.pkt = Tibia.pkt + 8;
                    ToS.pkt = ToS.pkt + 4;
                    MS.pkt = MS.pkt + 6;
                    AE.pkt = AE.pkt + 6;
                    vd.pkt = vd.pkt + 7;
                    i = false;
                }
                else
                    if (odp == "b")
                {
                    BnS.pkt = BnS.pkt + 5;
                    BD.pkt = BD.pkt + 3;
                    Aion.pkt = Aion.pkt + 6;
                    EVE.pkt = EVE.pkt + 1;
                    M2.pkt = M2.pkt + 4;
                    Mrg.pkt = Mrg.pkt + 3;
                    DN.pkt = DN.pkt + 7;
                    L2.pkt = L2.pkt + 8;
                    D3.pkt = D3.pkt + 6;
                    NT.pkt = NT.pkt + 3;
                    TERA.pkt = TERA.pkt + 5;
                    WoT.pkt = WoT.pkt - 10;
                    WoW.pkt = WoW.pkt + 4;
                    eoo.pkt = eoo.pkt + 5;
                    Esw.pkt = Esw.pkt + 3;
                    pkmn.pkt = pkmn.pkt + 6;
                    Tibia.pkt = Tibia.pkt + 4;
                    ToS.pkt = ToS.pkt + 2;
                    MS.pkt = MS.pkt + 1;
                    AE.pkt = AE.pkt + 4;
                    vd.pkt = vd.pkt + 6;
                    i = false;

                }
                else
                    if (odp == "c")
                {
                    BnS.pkt = BnS.pkt + 5;
                    BD.pkt = BD.pkt + 9;
                    Aion.pkt = Aion.pkt + 6;
                    EVE.pkt = EVE.pkt + 2;
                    M2.pkt = M2.pkt + 1;
                    Mrg.pkt = Mrg.pkt + 6;
                    DN.pkt = DN.pkt + 3;
                    L2.pkt = L2.pkt + 4;
                    D3.pkt = D3.pkt + 2;
                    NT.pkt = NT.pkt + 1;
                    TERA.pkt = TERA.pkt + 3;
                    WoT.pkt = WoT.pkt + 1;
                    WoW.pkt = WoW.pkt + 3;
                    eoo.pkt = eoo.pkt - 4;
                    Esw.pkt = Esw.pkt - 3;
                    pkmn.pkt = pkmn.pkt + 7;
                    Tibia.pkt = Tibia.pkt + 7;
                    ToS.pkt = ToS.pkt + 3;
                    MS.pkt = MS.pkt + 4;
                    AE.pkt = AE.pkt + 4;
                    vd.pkt = vd.pkt + 4;
                    i = false;

                }
                else
                {
                    Console.WriteLine("nie ma takiej odpowiedzi! odpowiedz jeszcze raz.\n");
                }
            }
            while (i == true);
            i = true;
            do
            {
                Console.WriteLine("\nczy w grze bardziej sobie cenisz otwarty świat czy system zamkniętych dungeonow? \n a) otwarty świat \n b) zamknięte dungeony \n c) połączenie obydwu opcji.\n");
                odp = (Console.ReadLine());
                if (odp == "a")
                {
                    BnS.pkt = BnS.pkt - 6;
                    BD.pkt = BD.pkt + 10;
                    Aion.pkt = Aion.pkt + 6;
                    EVE.pkt = EVE.pkt + 10;
                    M2.pkt = M2.pkt + 8;
                    Mrg.pkt = Mrg.pkt + 5;
                    DN.pkt = DN.pkt - 8;
                    L2.pkt = L2.pkt - 8;
                    D3.pkt = D3.pkt - 8;
                    NT.pkt = NT.pkt + 3;
                    TERA.pkt = TERA.pkt + 6;
                    WoT.pkt = WoT.pkt - 2;
                    WoW.pkt = WoW.pkt + 8;
                    eoo.pkt = eoo.pkt + 8;
                    Esw.pkt = Esw.pkt + 6;
                    pkmn.pkt = pkmn.pkt + 9;
                    Tibia.pkt = Tibia.pkt + 10;
                    ToS.pkt = ToS.pkt + 5;
                    MS.pkt = MS.pkt - 6;
                    AE.pkt = AE.pkt + 2;
                    vd.pkt = vd.pkt - 2;
                    i = false;

                }
                else
                    if (odp == "b")
                {
                    BnS.pkt = BnS.pkt + 6;
                    BD.pkt = BD.pkt - 10;
                    Aion.pkt = Aion.pkt - 6;
                    EVE.pkt = EVE.pkt - 10;
                    M2.pkt = M2.pkt - 8;
                    Mrg.pkt = Mrg.pkt - 5;
                    DN.pkt = DN.pkt + 8;
                    L2.pkt = L2.pkt + 8;
                    D3.pkt = D3.pkt + 8;
                    NT.pkt = NT.pkt - 3;
                    TERA.pkt = TERA.pkt - 6;
                    WoT.pkt = WoT.pkt + 2;
                    WoW.pkt = WoW.pkt - 8;
                    eoo.pkt = eoo.pkt - 8;
                    Esw.pkt = Esw.pkt - 6;
                    pkmn.pkt = pkmn.pkt - 9;
                    Tibia.pkt = Tibia.pkt - 10;
                    ToS.pkt = ToS.pkt - 5;
                    MS.pkt = MS.pkt + 6;
                    AE.pkt = AE.pkt - 2;
                    vd.pkt = vd.pkt + 2;
                    i = false;
                }
                else
                    if (odp == "c")
                {
                    BnS.pkt = BnS.pkt + 3;
                    BD.pkt = BD.pkt + 3;
                    Aion.pkt = Aion.pkt + 3;
                    EVE.pkt = EVE.pkt + 1;
                    M2.pkt = M2.pkt + 1;
                    Mrg.pkt = Mrg.pkt + 3;
                    DN.pkt = DN.pkt - 3;
                    L2.pkt = L2.pkt - 3;
                    D3.pkt = D3.pkt + 2;
                    NT.pkt = NT.pkt - 1;
                    TERA.pkt = TERA.pkt + 4;
                    WoT.pkt = WoT.pkt + 1;
                    WoW.pkt = WoW.pkt + 7;
                    eoo.pkt = eoo.pkt + 3;
                    Esw.pkt = Esw.pkt + 2;
                    pkmn.pkt = pkmn.pkt + 5;
                    Tibia.pkt = Tibia.pkt + 2;
                    ToS.pkt = ToS.pkt + 5;
                    MS.pkt = MS.pkt - 1;
                    AE.pkt = AE.pkt + 1;
                    vd.pkt = vd.pkt - 1;
                    i = false;
                }
                else
                {
                    Console.WriteLine("nie ma takiej odpowiedzi! odpowiedz jeszcze raz.\n");
                }
            }
            while (i == true);
            i = true;
            do
            {
                Console.WriteLine("\njesteś typem gracza-samotnika czy wolisz expić w party? \n a) expię sam \n b) expię w party \n c) różnie.\n");
                odp = (Console.ReadLine());
                if (odp == "a")
                {
                    BnS.pkt = BnS.pkt - 3;
                    BD.pkt = BD.pkt + 5;
                    Aion.pkt = Aion.pkt + 2;
                    EVE.pkt = EVE.pkt - 2;
                    M2.pkt = M2.pkt + 6;
                    Mrg.pkt = Mrg.pkt + 5;
                    DN.pkt = DN.pkt + 3;
                    L2.pkt = L2.pkt - 2;
                    D3.pkt = D3.pkt + 4;
                    NT.pkt = NT.pkt + 4;
                    TERA.pkt = TERA.pkt - 1;
                    WoT.pkt = WoT.pkt - 2;
                    WoW.pkt = WoW.pkt + 3;
                    eoo.pkt = eoo.pkt + 5;
                    Esw.pkt = Esw.pkt + 3;
                    pkmn.pkt = pkmn.pkt + 1;
                    Tibia.pkt = Tibia.pkt + 7;
                    ToS.pkt = ToS.pkt + 2;
                    MS.pkt = MS.pkt + 3;
                    AE.pkt = AE.pkt - 1;
                    vd.pkt = vd.pkt + 4;
                    i = false;
                }
                else
                if (odp == "b")
                {
                    BnS.pkt = BnS.pkt + 5;
                    BD.pkt = BD.pkt + 5;
                    Aion.pkt = Aion.pkt + 3;
                    EVE.pkt = EVE.pkt + 10;
                    M2.pkt = M2.pkt - 3;
                    Mrg.pkt = Mrg.pkt - 5;
                    DN.pkt = DN.pkt - 3;
                    L2.pkt = L2.pkt - 2;
                    D3.pkt = D3.pkt - 2;
                    NT.pkt = NT.pkt + 3;
                    TERA.pkt = TERA.pkt + 6;
                    WoT.pkt = WoT.pkt - 2;
                    WoW.pkt = WoW.pkt + 8;
                    eoo.pkt = eoo.pkt + 8;
                    Esw.pkt = Esw.pkt + 6;
                    pkmn.pkt = pkmn.pkt + 3;
                    Tibia.pkt = Tibia.pkt - 3;
                    ToS.pkt = ToS.pkt - 5;
                    MS.pkt = MS.pkt + 6;
                    AE.pkt = AE.pkt - 2;
                    vd.pkt = vd.pkt + 2;
                    i = false;
                }
                else
                if (odp == "c")
                {
                    BnS.pkt = BnS.pkt + 3;
                    BD.pkt = BD.pkt + 7;
                    Aion.pkt = Aion.pkt + 3;
                    EVE.pkt = EVE.pkt + 1;
                    M2.pkt = M2.pkt + 2;
                    Mrg.pkt = Mrg.pkt + 4;
                    DN.pkt = DN.pkt + 3;
                    L2.pkt = L2.pkt + 1;
                    D3.pkt = D3.pkt + 6;
                    NT.pkt = NT.pkt - 1;
                    TERA.pkt = TERA.pkt + 2;
                    WoT.pkt = WoT.pkt - 2;
                    WoW.pkt = WoW.pkt - 1;
                    eoo.pkt = eoo.pkt - 1;
                    Esw.pkt = Esw.pkt + 2;
                    pkmn.pkt = pkmn.pkt + 1;
                    Tibia.pkt = Tibia.pkt + 5;
                    ToS.pkt = ToS.pkt + 5;
                    MS.pkt = MS.pkt - 2;
                    AE.pkt = AE.pkt + 2;
                    vd.pkt = vd.pkt + 6;
                    i = false;
                }
                else
                {
                    Console.WriteLine("nie ma takiej odpowiedzi! odpowiedz jeszcze raz.\n");
                }
            }
            while (i == true);
            i = true;
            do
            {
                Console.WriteLine("\nczy w grze w którą chcesz grać crafting powinien odgrywać ważną rolę? \n a) tak\n b) nie\n");
                odp = (Console.ReadLine());
                if (odp == "a")
                {
                    BnS.pkt = BnS.pkt + 5;
                    BD.pkt = BD.pkt + 5;
                    Aion.pkt = Aion.pkt + 5;
                    EVE.pkt = EVE.pkt + 4;
                    M2.pkt = M2.pkt - 5;
                    Mrg.pkt = Mrg.pkt - 5;
                    DN.pkt = DN.pkt + 5;
                    L2.pkt = L2.pkt + 5;
                    D3.pkt = D3.pkt + 3;
                    NT.pkt = NT.pkt - 6;
                    TERA.pkt = TERA.pkt + 2;
                    WoT.pkt = WoT.pkt - 8;
                    WoW.pkt = WoW.pkt - 8;
                    eoo.pkt = eoo.pkt - 9;
                    Esw.pkt = Esw.pkt + 8;
                    pkmn.pkt = pkmn.pkt + 6;
                    Tibia.pkt = Tibia.pkt + 7;
                    ToS.pkt = ToS.pkt + 9;
                    MS.pkt = MS.pkt - 4;
                    AE.pkt = AE.pkt + 6;
                    vd.pkt = vd.pkt + 7;
                    i = false;
                }
                else
                    if (odp == "b")
                {
                    BnS.pkt = BnS.pkt - 7;
                    BD.pkt = BD.pkt - 7;
                    Aion.pkt = Aion.pkt - 2;
                    EVE.pkt = EVE.pkt - 4;
                    M2.pkt = M2.pkt + 5;
                    Mrg.pkt = Mrg.pkt + 5;
                    DN.pkt = DN.pkt - 2;
                    L2.pkt = L2.pkt - 2;
                    D3.pkt = D3.pkt - 3;
                    NT.pkt = NT.pkt + 6;
                    TERA.pkt = TERA.pkt - 2;
                    WoT.pkt = WoT.pkt + 8;
                    WoW.pkt = WoW.pkt + 8;
                    eoo.pkt = eoo.pkt + 9;
                    Esw.pkt = Esw.pkt - 8;
                    pkmn.pkt = pkmn.pkt - 6;
                    Tibia.pkt = Tibia.pkt - 7;
                    ToS.pkt = ToS.pkt + 9;
                    MS.pkt = MS.pkt + 4;
                    AE.pkt = AE.pkt - 6;
                    vd.pkt = vd.pkt - 7;
                    i = false;
                }
                else
                {
                    Console.WriteLine("nie ma takiej odpowiedzi! odpowiedz jeszcze raz.\n");
                }
            }
            while (i == true);
            i = true;
            int[] T;
            T = new int[21];
            T[0] = BnS.pkt;
            T[1] = BD.pkt;
            T[2] = Aion.pkt;
            T[3] = EVE.pkt;
            T[4] = M2.pkt;
            T[5] = Mrg.pkt;
            T[6] = DN.pkt;
            T[7] = L2.pkt;
            T[8] = D3.pkt;
            T[9] = NT.pkt;
            T[10] = TERA.pkt;
            T[11] = WoT.pkt;
            T[12] = WoW.pkt;
            T[13] = eoo.pkt;
            T[14] = Esw.pkt;
            T[15] = pkmn.pkt;
            T[16] = Tibia.pkt;
            T[17] = ToS.pkt;
            T[18] = MS.pkt;
            T[19] = AE.pkt;
            T[20] = vd.pkt;

            string[] T2;
            T2 = new string[21];
            T2[0] = BnS.nazwa;
            T2[1] = BD.nazwa;
            T2[2] = Aion.nazwa;
            T2[3] = EVE.nazwa;
            T2[4] = M2.nazwa;
            T2[5] = Mrg.nazwa;
            T2[6] = DN.nazwa;
            T2[7] = L2.nazwa;
            T2[8] = D3.nazwa;
            T2[9] = NT.nazwa;
            T2[10] = TERA.nazwa;
            T2[11] = WoT.nazwa;
            T2[12] = WoW.nazwa;
            T2[13] = eoo.nazwa;
            T2[14] = Esw.nazwa;
            T2[15] = pkmn.nazwa;
            T2[16] = Tibia.nazwa;
            T2[17] = ToS.nazwa;
            T2[18] = MS.nazwa;
            T2[19] = AE.nazwa;
            T2[20] = vd.nazwa;

            string[] T3;
            T3 = new string[21];
            T3[0] = BnS.opis;
            T3[1] = BD.opis;
            T3[2] = Aion.opis;
            T3[3] = EVE.opis;
            T3[4] = M2.opis;
            T3[5] = Mrg.opis;
            T3[6] = DN.opis;
            T3[7] = L2.opis;
            T3[8] = D3.opis;
            T3[9] = NT.opis;
            T3[10] = TERA.opis;
            T3[11] = WoT.opis;
            T3[12] = WoW.opis;
            T3[13] = eoo.opis;
            T3[14] = Esw.opis;
            T3[15] = pkmn.opis;
            T3[16] = Tibia.opis;
            T3[17] = ToS.opis;
            T3[18] = MS.opis;
            T3[19] = AE.opis;
            T3[20] = vd.opis;

            string[] T4;
            T4 = new string[21];
            T4[0] = BnS.StrInt;
            T4[1] = BD.StrInt;
            T4[2] = Aion.StrInt;
            T4[3] = EVE.StrInt;
            T4[4] = M2.StrInt;
            T4[5] = Mrg.StrInt;
            T4[6] = DN.StrInt;
            T4[7] = L2.StrInt;
            T4[8] = D3.StrInt;
            T4[9] = NT.StrInt;
            T4[10] = TERA.StrInt;
            T4[11] = WoT.StrInt;
            T4[12] = WoW.StrInt;
            T4[13] = eoo.StrInt;
            T4[14] = Esw.StrInt;
            T4[15] = pkmn.StrInt;
            T4[16] = Tibia.StrInt;
            T4[17] = ToS.StrInt;
            T4[18] = MS.StrInt;
            T4[19] = AE.StrInt;
            T4[20] = vd.StrInt;

            gra = T[0];
            index = 0;
        }
    }
}
