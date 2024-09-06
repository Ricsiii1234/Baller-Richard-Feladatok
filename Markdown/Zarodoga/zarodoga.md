### ZÁRÓDOLGOZAT

### Témavezető : Szabó Dániel

### Kovács László Szoftverfejlesztő

### 2020 - 2021

### 13.F


### Weiss Manfréd Szakgimnázium, Szakközépiskola és Kollégium

# Dan forum


## Tartalom

- [1 Összefoglaló](#1-összefoglaló)
   - [1.1 Záródolgozat téma kiválasztása](#11-záródolgozat-téma-kiválasztása)
   - [1.2 Alkalmazás tervezése](#12-alkalmazás-tervezése)
   - [1.3 Programnyelv kiválasztása, előkészületek](#13-programnyelv-kiválasztása-előkészületek)
   - [1.4 Adatbázis](#14-adatbázis)
   - [1.5 Köszönetnyilvánítás](#15-köszönetnyilvánítás)
- [2 Felhasználói dokumentáció](#2-felhasználói-dokumentáció)
   - [2.1 Rendszer Követelmény](#21-rendszer-követelmény)
   - [2.2 Alkalmazás telepítése](#22-alkalmazás-telepítése)
   - [2.3 Alkalmazás használata](#23-alkalmazás-használata)
   - [2.4 Gyakran ismételt kérdések](#24-gyakran-ismételt-kérdések)
   - [2.5 A program készítőjének elérhetősége](#25-a-program-készítőjének-elérhetősége)
- [3 Fejlesztői dokumentáció](#3-fejlesztői-dokumentáció)
   - [3.1 Adatbázis](#31-adatbázis)
      - [3.1.1 Account tábla](#311-account-tábla)
      - [3.1.2 Hozzászólás tábla](#312-hozzászólás-tábla)
      - [3.1.3 Mentett topic tábla](#313-mentett-topic-tábla)
      - [3.1.4 Topic tábla](#314-topic-tábla)
   - [3.2 Forrás kód](#32-forrás-kód)
   - [3.3 Java – PHP kapcsolat](#33-java-–-php-kapcsolat)
   - [3.4 PHP kódok](#34-php-kódok)
   - [3.5 Főbb változók](#35-főbb-változók)
   - [3.6 Admin felület](#36-admin-felület)
   - [3.7 Fejlesztési lehetőségek](#37-fejlesztési-lehetőségek)
   - [3.8 Milyen nehézségekkel találkoztam?](#38-milyen-nehézségekkel-találkoztam)
   - [3.9 Tesztdokumentáció](#39-tesztdokumentáció)
- [4 Irodalomjegyzék](#4-irodalomjegyzék)



## 1 Összefoglaló

### 1.1 Záródolgozat téma kiválasztása

Első sorban biztos voltam benne, hogy egy olyan felületet szeretnék létrehozni, ahol az általam
létrehozott alkalmazásokról tudok kommunikálni a felhasználókkal. Azonban ki kellet találni,
hogy milyen platformon szeretném ezt létrehozni (Webes vagy rendes alkalmazás?). Elkezdtem
tervezni egy weboldal alapú forumot, ami számomra nem volt megfelelő, ezért eldöntöttem,
hogy egy telefonos alkalmazást fogok létrehozni.

### 1.2 Alkalmazás tervezése

Az alkalmazást választó döntésem után kezdetleges látvány terveket hoztam létre az
alkalmazáshoz, amelyeket (egy-két kivételével) meg is valósítottam.

Elsőnek úgy terveztem, hogy belépés után a felhasználót egy kezdő felület köszöntse, amely
két opciót tartalmaz: Belépés vagy Regisztráció.
Ezt végül elvetettem, ugyanis számomra jelentéktelenné vált.



![alt text](1.jpg)

A következő tervezési lépés nem más, mint a topic kiválasztó rész:

![alt text](2.jpg)

Végül a topichoz való hozzászólást terveztem meg

![alt text](3.jpg)


### 1.3 Programnyelv kiválasztása, előkészületek

Miután eldöntöttem, hogy alkalmazást szeretnék létrehozni, akkor kerültem szembe azzal a
problémával, hogy rengetek platform van egy alkalmazás létrehozására. Időbe telt, mire
átnéztem párat ezek közül, de végül az ’Android Studio’ nyerte el a tetszésemet, amelyben javát
használtam. Miután kiválasztottam az alapokat, akkor következett az előkészület kezdete,
hiszen eddig nem programoztam javában. Az első hetekben egy egyszerű számológépet
készítettem, amelyen nagyon sok mindent kitapasztaltam és később ez mind a hasznomra vált.

### 1.4 Adatbázis

Az adatbázis létrehozására, illetve annak szerkesztéséhez az XAMPP programot használtam,

## ami teljesen megfelelt mindenre, amire szükségem lehetett.

Természetesen az adatbázissal kapcsolatban is rendelkeztem egy tervvel.

![alt text](4.jpg)

### 1.5 Köszönetnyilvánítás

Annak ellenére, hogy ebben az évben igencsak keveset tartózkodtunk az iskolában, rengeteg
segítséget és támogatást kaptam Kovács László tanár úrtól, gyakorlati és elméleti szinten is.





## 2 Felhasználói dokumentáció

### 2.1 Rendszer Követelmény

- Android rendszer
- Internet kapcsolat
- Min 5 mb szabad tárhely
- Min 3.00 -inch kijelző

### 2.2 Alkalmazás telepítése

![alt text](5.jpg)



Miután kiválasztottuk, hogy melyik eszközre
szeretnénk telepíteni, utána indítsunk el bármilyen
böngészőt rajta. Huawei készülékeken egy kék
bolygó ikon jelzi ezt.


![alt text](6.jpg)

Megnyitás után a képernyő tetején található keresőbe
írjuk be ezt a címet : szdaniel.hu



Amennyiben jól írtuk be a címet, abban az esetben ez az
oldal lesz látható számunkra. Itt a ’Letöltés’ feliratú gombra
kattintva elindíthatjuk a letöltést.


![alt text](7.jpg)


Böngészőtől függően megkérdezi,
hogy biztosan le szeretnénk-e tölteni
ezt a fájlt. A ’download’ gombra
kattintva ezt engedélyezzük és le is
tölti nekünk.


![alt text](8.jpg)

![alt text](9.jpg)

Miután letöltöttük utána megkérdezi a rendszer, hogy
biztosan szeretnénk telepíteni? A ’allow’ (vagy magyar
nyelvű készülékek esetében ’engedélyezés’ ) feliratú gombra
kattintva engedélyezzük a telepítést.



Engedélyezés után nincs más dolgunk, mint telepíteni az
alkalmazást.

Kattintsunk a jobb alsó sarokban található ’Install’ (magyar
rendszer esetén ’telepítés’) gombra és a rendszer utána telepíti
nekünk a programot.

![alt text](10.jpg)
Amennyiben mindent jól csináltunk és a telepítés sikeres,
abban az esetben egy zöld pipával jelzi a program, hogy
minden rendben van.
Ez után kiléphetünk a telepítési felületről.

![alt text](11.jpg)



![alt text](12.jpg)

Az alkalmazást a többi ikon mellet fogjuk megtalálni.
Ezt később mozgathatjuk is, amennyiben a
felhasználónak igénye van rá.

### 2.3 Alkalmazás használata...............................................................................................................

![alt text](13.jpg)

Az alkalmazás megnyitását követően a belépési felület fog
fogadni minket. Első belépésnél ez számunkra nem lesz
megfelelő, hisz nincs regisztrált fiókunk a fórumra. A
’bejelentkezés’ gomb alatt található ’regisztráció’ feliratra
kattintva regisztrálhatunk, annak érdekében, hogy később be
tudjunk jelentkezni a fiókunkba.

Amennyiben rendelkezünk regisztrált fiókkal, abban az esetben
a regisztrációkor megadott emailt és jelszót beírva majd a
’bejelentkezés’ gombot megnyomva be tudunk jelentkezni.



Ha nem adjuk meg valamelyik információt, avagy hibásan adjuk meg, akkor a program ezt jelzi
nekünk.

![alt text](14.jpg)

Regisztrációkor 3 adatot kell megadnunk: Egy felhasználó
nevet ezt a ’Nick név’ felirat alá írjuk (alatta lévő vízszintes
vonalra kattintva írhatunk oda), egy email cím, amit az ’email
cím’ felirat alá írhatunk (ugyan úgy, mint a felhasználó nevet)
illetve egy jelszót, amit a ’Jelszó’ felirat alá írunk (ugyan úgy
mint a felhasználó névnél és emailnél).
Mind a három adat szükséges a regisztrációhoz! Amennyiben
valamelyiket nem adjuk meg, abban az esetben a program jelzi
nekünk.
Adatok kitöltése után a ’Regisztráció’ gombra kattintva
regisztrálhatunk is.
Amennyiben még is van regisztrált fiókunk, abban az esetben a
’Belépés’ feliratra kattintva visszatérhetünk a belépés menühöz.



Belépés vagy regisztráció után, a menüben találjuk
magunkat. Itt három opció közül választhatunk. Kiválasztás
után kattintsunk a kiválasztott opcióra.

- Kijelentkezés
- Topicok
- Profil

![alt text](15.jpg)

Kijelentkezés gomb tevékenysége, a nevéből árulkodóan,
kijelentkezteti a felhasználót.

Topic gomb kiválasztása esetén más felhasználók által
létrehozott topickokat olvashatunk, illetve akár létre is
hozhatunk egy saját topicot.

Profil fül kiválasztása esetén a saját profilunkat tekinthetjük
meg.



A topic fület kiválasztva ez a kép tárul elénk. Ha úgy
döntünk, hogy inkább visszamennénk, abban az esetben a ’vissza’
gomb segítségével megtehetjük ezt.
Ha új topicot szeretnénk létrehozni, akkor azt a’+’ gomb
megnyomásával elkezdhetjük.
A ’devlog’ gomb Dániel által létrehozott játékok státuszához
visz. A frissítések gomb az alkalmazások és játékokhoz készült
frissítéseket írja le részletesen.
Amennyiben a képernyő közepétől kezdődő listából látunk olyan
rövid leírást, ami felkelti a figyelmünk, abban az esetben
kattintsunk rá és a program annak a topicnak a hozzászólásaihoz
visz minket.

![alt text](16.jpg)

Új topic létrehozásánál ez az ablak tárul elénk. Itt is van opció
visszamenni a topic kiválasztó részhez.

Amennyiben létre szeretnénk hozni egy topicot, abban az esetben
két dologra lesz szükségünk:

- Egy topic névre.
- A probléma hosszas leírására.

Egy rövid, ám bár sok dolgot eláruló névre lesz szükség, ami
röviden összefoglalja a problémát. Érdemes kulcs szavakat
belerakni.

A probléma hosszas leírásánál ajánlott minél több dolgot leírni a
problémáról. (pl. mikor történt, mi történt pontosan) erre azért van
szükség, hogy utána sokkal könnyebben tudjanak segíteni a
felhasználók.

Amennyiben valamelyik részt nem töltjük ki, abban az esetben a
program hibát jelez.


Itt is megtalálható az eddig sokszor használt vissza gomb,
amellyel visszaléphetünk a topic kiválasztó menühöz.
A képernyő fenti részénél, középen található a topic neve.
Emellett pedig a topic elmentésére szolgáló gomb. Ha erre
rákattintunk, akkor a profil menüben a ’mentett topicok’
listában megtalálható lesz ez a topic.
Alattuk egy lista lesz található, ahol az eddigi hozzászólások
találhatóak. Ezek közül kiválaszthatunk egyet, amit követően a
program részletesen kiírja az információkat a hozzászólásról.
A képernyő alján található a hozzászólás írására szolgáló
vízszintes vonal, amire kattintva beleírhatunk.
Ha írtunk egy hasznosnak vélt hozzászólást, akkor a mellette
lévő ’Send’ gombbal elküldhetjük azt, hogy a többi felhasználó
is olvashassa azt. Amennyiben nem töltjük ki a hozzászólás
részt, abban az esetben a program nem küld el
semmit se.
Amennyiben kiválasztottunk egy hozzászólást, abban az
esetben ez a kép tárul elénk.
Itt megtalálható a hozzászólónak a neve,
illetve maga a hozzászólás.
Amennyiben vissza szeretnénk menni a többi hozzászóláshoz,
akkor a vissza gomb segítségével megtehetjük ezt.



Menüben található profil opció kiválasztása esetén ide kerülünk.
Itt is megtalálható a vissza gomb természetesen.
Ezen felül megtalálható a felhasználó által, regisztrációnál
megadott felhasználóneve és email címe.
Alul megtalálható két opció:

- Hozzászolt topics ami elvisz a általunk hozzászolt topicokhoz,
- Illetve a mentett topics, ami az általunk elmentett topicok
    listájához visz.

Amennyiben a hozzászolt topic opciót vagy a mentett topic
opciót választottuk, ez a kép tárul elénk.

Itt a program egy listába összeszedi az összes felhasználó által
mentett vagy hozzászolt topicot.

Ha a felhasználó meg akar tekinteni egy topicot innen, akkor
egyszerűen csak ki kell választania. Egy kattintással át viszi a
felhasználót ahhoz a topichoz.

Természetesen itt sem ragad meg a felhasználó, hiszen az
eddig megszokott vissza gomb itt is megtalálható.


### 2.4 Gyakran ismételt kérdések

### - Elérhető lesz különbféle webáruházakban?

*Igen amint a szükséges dokumentumokat kitöltöttem.

### - Mennyi különbféle felhasználót hozhatok létre?

*Bármennyit. Nincs megkötve viszont nem árt figyelem elött tartani, hogy 6 hónap inaktivitás
után töröljük a nemhasznált felhasználókat!

### - Abban az esetben, ha problémám van a programmal hol jelezhetem ezt?

*Amennyiben a fórumon ezt nem teheti meg abban az esetben a ’elérhetőség’ résznél
feltüntetett email címen lehet jelezni ezt

### 2.5 A program készítőjének elérhetősége

E-mail cím: danikaszab@gmail.com

Telefon szám: 06- 30 - 812 - 8489


## 3. Fejlesztői dokumentáció

### 3.1 Adatbázis

#### 3.1.1 Account tábla

Ebben a táblában található a felhasználó összes információja, amire szükségel lehet.


|oszlop neve:| aid®| anev |ajelszo| aemail| jogosultsag|
|-|-|-|-|-|-|
|Típusa:| int(10)| varchar(20)| varchar(20)| varchar(30)| int(1)|

Itt az ’aid’ kapta az elsődleges kulcsot, hisz ez alapján lehet a legkönnyebben beazonosítani egy
felhasználót. Ez az értek automatán növekszik, így külső behatás nem szükséges (új felhasználó
esetén növekszik eggyel).

Az ’anev’ itt a felhasználó a felhasználónevét adhatja meg, amely maximum 20 betűt vagy
számot tartalmazhat. Ez lesz az a név, amit az alkalmazásban hozzászóláskor és topic
létrehozáskor ki fog írni az alkalmazás.

Az ’ajelszo’ hasonló az ’anev’ oszlophoz, viszont ezt az értéket sehol nem mutatjuk meg, mivel
a felhasználó ezzel, illetve a ’aemail’-el tud belépni.

Az ’aemail’ oszlop szolgál a felhasználó email címének az elmentésére. Ezt a négy értéket a
felhasználó adja meg a regisztrációkor.

A ’jogosultsag’ tábla tartalmazza a felhasználónak a jogosultságát. Itt három érték szerepelhet:


0 - admin felhasználó. Ez azt jelenti hogy későbbiekben látni fogja a csak adminoknak
szolgáló gombot.
1 - Sima felhasználó. Ilyenkor csak az alap minden felhasználónak megengedett
funkciókat használhatja.
2 - Bannolt fiók. Ez az az eset, mikor a felhasználó megsértette valamelyik szabályt.
Ebben az esetben ezt a fiókot nem lehet tovább használni, ugyanis belépésnél nem
engedi tovább a felhasználót.

Összeségében ezt tartom a legfontosabb táblának, hiszen e-nélkül belépni se lehet az
alkalmazásba.

#### 3.1.2 Hozzaszolas tábla..............................................................................................................

Ebben a táblában a hozzászólásokról található információ.
|oszlop neve| hid® |aid| tid| htext|
|-|-|-|-|-|
|Típusa :| int(10)| int(10)| int(10)| varchar(6000)|

Itt a ’hid’ az elsődleges kulcs. Ebben az oszlopban tároljuk a hozzászólás id-t. Ez az értek
automatán növekszik, így külső behatás nem szükséges (új hozzászólás esetén növekszik
eggyel).

Az ’aid’ oszlopban a hozzászólást létrehozó felhasználónak az id-jét tároljuk. Ez azért fontos,
mert ha valaki megvizsgálja a hozzászólást, akkor a hozzászóló nevét kiírja, emellett
amennyiben a hozzászólás megsértett egy szabályt, abban az esetben bannolhassuk a
felhasználót.

A ’tid’ oszlopban a hozzászolt topicnak az id-jét tároljuk, így tudjuk összekötni a hozzászólást
a topic-al.

’htext’ itt a hozzászólást magát tároljuk el.

#### 3.1.3 Mentetttopic tábla

Ebben a táblában tárolom el a felhasználó által mentett topicokat.



|oszlop neve:| tid| aid| valid|
|-|-|-|-|
|Típusa| int(10)| int(10)| tinnyint(1)|

Itt a ’tid’ a elsődleges kulcs. Ebben az oszlopban tároljuk a topicnak az id-jét. Ez az értek
automatán növekszik, így külső behatás nem szükséges (új mentett topic esetén növekszik
eggyel).

’aid’ ez az oszlop a mentő felhasználónak az id-jét tárolja. Ezzel tudjuk összekapcsolni a
mentett topicot a felhasználóval.

’valid’ oszlop tárolja el hogy a felhasználó vissza vonta-e a mentést. Erre azért van szükség,
mert ha a felhasználó meg gondolja magát és nem akarja mentve hagyni, akkor egyszerűen csak
1 - re állítom(ez mutatja, hogy nem akarja látni), viszont ha utána mégis menteni akarja, akkor
nem hozom létre újra, hanem ezt az értéket 0-ra állítom.


0 - látni akarja
1 - nem akarja látni


#### 3.1.4 topic tábla

Ebben a táblában található a topichoz fűződő információk.


|oszlop neve| tid| anev| tvalid| ttartalom| tnev|
|-|-|-|-|-|-|
|Típusa :| int(3) |varchar(20) |tinyint(1)| text| varchar(40)|

Itt ’tid’ az elsődleges kulcs. Ez a topicnak az id-je hogy később könnyebben lehessen
megkeresni. Ez az értek automatán növekszik, így külső behatás nem szükséges (új topic esetén
növekszik eggyel).

’anev’ Itt tároljuk el a létrehozónak a nevét, hogy könnyebben tudjuk kiírni.

’tvalid’ Ez jelz,i hogy az adott topic látható-e. Amennyiben túl sok negatív hozzászólás van
vagy akár maga a topic értelmetlen, abban az esetben láthatatlanná lehet tenni.

Ennek két értéke lehet:

0 – Látható minden felhasználónak

1 – Nem látható senkinek.

’ttartalom’ A létrehozó által megadott tartalom helye (amit létrehozásnál megad pl. kérdések és
információk).

’tnev’ Ez pedig a létrehozó által megadott topic név. Ezt fogja mindenki először meglátni.


### 3.2 Forrás kód

Mivel magát az alkalmazást az ’Android studio’ programban csináltam, így a scripteket külön
tárolja el, tehát fontosnak gondoltam, hogy külön is mellékeljem a kód soraimat.

Ezt a ’forráskódok’ mappában lehet megtalálni.

Illetve az adatbázis kezelés és minden más internetet igénylő feladatot php-ban oldottam meg.

Ezt ’php kódok’ mappában lehet megtalálni.

A ’forráskódok’ mappában található egy ’gyakranhasznalt’ java class.

Ez 2 nagyon fontos változót tartalmaz.

Mivel külön fájlokban van a php-kód, illetve
ezek egy webszerveren találhatóak, ezért
elérési utat kell megadni, és hogy ne folyton ugyanazt kelljen megadni mindenhol, ennek
érdekében pedig létre hoztam ezt a két változót, hogy csak beilleszteni kelljen. Ha itt átírom,
akkor nem lesz olyan gond, hogy valahol máshol nem írtam át és kifagy az alkalmazás.

### 3.3 Java – php kapcsolat

Ahhoz, hogy sikerüljön adatot átrakni php-ba, 2 db tömbre van szükség. Az első tömbnek a
változó nevet kell tartalmaznia pl. ’email’ vagy ’felhasznalonev’, a másodiknak pedig magát a
változót kell tartalmaznia pl. ’galuska@galuska.com’ vagy ’gali’. Ez után a ’putData’
paranccsal el tudjuk indítani a php-t.

Ezek után amennyiben jó elérési utat adtunk meg és a tömbök is rendben vannak, akkor a php
le is futott. Meg kell néznünk, hogy a vissza térő adatok megfelelőek-e.

Ebben az esetben a jogát néztem meg egy felhasználónak. Először megnéztem, hogy sikerült-e
felrakni, utána pedig azt, hogy sikerült-e hiba nélkül befejezni a php-t. Amennyiben ezek


sikeresen teljesülnek, abban az esetben egy putData.getResult() el megszerezhetjük a php ban
echoval kiírt eredményeket.

Php oldalon az áthozott tömb változókat ’POST’ methoddal tudjuk használni.

### 3.4 PHP kódok

Mivel php programozási nyelvel már volt dolgom, így megpróbáltam a legátláthatóbban
megoldani a feladatokat. Minden php kódot három részre bontottam : ’Áthozott infó’,’adatbazis
info’ és ’lekerdezes’. Erre azért volt szükség, hogy sokkal jobban lehessen tudni melyik változót
hol hozom létre. Mikor teszteltem a php-kódókat, akkor egy új csoportot hoztam létre
’Próba’ként.


Az áthozott infó csoportban azokat a változókat tárolom, amiket a java programból hoztam át
’POST’ methodal. Ezek általában olyan infók, amiket később lekérdezésnél használok. pl.
email, felhasználónév, id.

Adatbázis infó csoportba tartozik minden, ami szükséges ahhoz, hogy elérjem az adatbázist.
Webszerverhez való csatlakozási név, jelszó, illetve a tábla neve. Ezt utána fel is használom,
hogy csatlakozzak az adatbázishoz. Mivel webszerveren van a adatbázis és maga a php fájl is,
így localhost névvel is pontosan tudja, hogy hova csatlakozzon.

Lekérdezés csoportban minden olyan van, ami maga a program. Itt dolgozik a php, mivel itt
kommunikálok az adatbázissal (pl. feltöltés, lekérdezés), illetve itt írom ki az adatokat, hogy
utána a java programban lekérdezzem.

### 3.5 Főbb változók

Nagyon fontos kiemelnem a ’profil’ class-t, hisz ebben nagyon sok fontos változót tároltam el
annak érdekében, hogy ne keljen újra és újra lekérdeznem őket a szervertől.

A ’mail’ változó a felhasználónak az email címét tárolja el. A ’nev’ logikusan a felhasználó
nevet menti el, emellett ’jogosultsag’ és az ’id’ a nevükből adódóan elmondják mit
tartalmaznak.

Felmerül a kérdés, hogy miért volt szükség elmenteni a felhasználó jogosultságát, ha már az
elején megnézzük, hogy bannolva van-e vagy nem? Ez egy teljesen jogos kérdés lenne, ha
nem lenne admin felület az alkalmazásban. Az alkalmazás tartalmaz egy admin felület részt,
amit csak az adminok érhetnek el, ezt viszont csak akkor tudom megvizsgálni, ha elmentem a
jogosultságát a felhasználónak.


Ebben a kódsorban vizsgálom meg, hogy admin-e a felhasználó. Amennyiben admin, abban
az esetben megjelenik az admin felülethez vezető gomb.

### 3.6 Admin felület

Ez az adminoknak ad egy felületet a topicok és az emberek viselkedésének szabályozására.
Amennyiben egy admin lép be az alkalmazásban, akkor így néz ki a menü:


Természetesen nem nagy varázslat egy gombot
láthatatlanná tenni egy átlag felhasználó szeme elött.
Azonban a fontossága annál inkább érdekesebb.


Azért találtam fontosnak, hogy az admin felülethez vezető
gomb egyhelyen legyen a topic
kiválasztó résszel, mert így egy admin is élvezheti azokat
a funkciókat, amiket egy áltag felhasználó és így nem kell
átjelentkeznie egy normál fiókba.


Az admin felületre kattintva ezt fogjuk látni.

Itt a nem admin jogosultsággal rendelkező
felhasználóknak a neve található.

Amennyiben rá kattint egy névre, annak az
embernek az információit találja majd meg.

Ha rá mentünk egy névre ez a kép tárul elénk:


Az eddigi információk mellet alul ki írja a felhasználó által írt hozzászólásokat a könnyebb
moderálás érdekében. Amennyiben nincs bannolva a felhasználó, abban az esetben ’Ban’
gomb jelenik meg, ellen esetben pedig az ’Unban’ feliratú gomb jelenik meg.
Bármelyik feliratú gomb jelenik meg, rá kattintva bannolhatjuk vagy UnBannolhatjuk a
felhasználót.

### 3.7 Fejlesztési lehetőségek

- Felhasználói adatok megváltoztatása.
- Felhasználó törlése
- Automatikus bejelentkezés
- Hozzászólás like-dislike lehetőség
- Egy adott személy ignorálása (egy felhasználó kiválaszt egy másikat, akinek a
    hozzászólásait nem szeretné látni és a továbbiakban azok a hozzászólások nem jelennek
    meg).
- Hozzászólás, illetve egy adott topic keresési lehetőségei.
- ’Admin felkeresése’ opció. Lehetővé teszi, hogy egy adminnak írjunk egy adott topic -
    al kapcsolatban. (Report funkció).

### 3.8 Milyen nehézségekel találkoztam?

Igazából rengeteggel. Elsősorban iskola mellet nehéz volt belekezdeni egy új programozási
nyelvbe, ez a kódsoraimon is látszik, hiszen sok helyen ott a megjegyzés mi mit csinál. A
belépési menü pedig ezért ilyen kesze kusza.

Miután kiismertem magam a lehetőségeimmel, utána jött egy újabb akadály, mégpedig az, hogy
nem tudtam adatbázishoz kapcsolni a programot. Természetesen erre rengeteg megoldás volt
az interneten, viszont mindegyik más és más volt, mivel a probléma nem mindenkinél ugyanaz.
Az elején nem is gondoltam arra, hogy majd php- val kötöm össze az alkalmazást. Viszont a
kutató munkám eredménye az lett, hogy ez a legkényelmesebb megoldás számomra.


### 3.9 Tesztdokumentáció


Amennyiben belépésnél a felhasználó nem ad meg vagy rosszul ad
meg bármilyen adatot abban az esetben a program jelzi.

Abban az esetben ha a felhasználó regisztrációnál nem ad meg bármilyen adatot abban az
esetben a program ezt jelzi:

![alt text](30.jpg)

Ha a felhasználó által beírt név / email cím foglalt abban az esetben a program ezt jelzi:

![alt text](31.jpg)

Abban az esetben ha használat közben az internet elmegy abban az esetben a program nem
reagál semmilyen input-ra!

Admin felület teszteléséhez szükséges belépési adatok:

Felhasználó név: elso

Jelszó : elso

## 4 Irodalomjegyzék

- Szin választás : https://www.w3schools.com/colors/colors_picker.asp
- PHP parancsok : https://www.php.net/manual/en/index.php
- Java segítség : https://www.w3schools.com/java/
- Java olvasmány : Alkalmazásfejlesztés Android Studio rendszerben


