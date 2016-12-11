﻿using System;
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
        }
    }
}
