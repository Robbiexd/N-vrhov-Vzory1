# Navrhove vzory 1
ach ta nostalgie

1) Implementujte model, který bude obsahovat:
třída Osoba
atributy: věk, pohlaví, jméno (chráněné, pouze pro čtení)
vlastnosti: přístup k atributům pouze směrem ven
skrytý parametrický konstruktor se vstupními parametry věk, pohlaví, jméno
veřejnou statickou metodu getInstance vracející instanci od třídy Osoba se vstupními parametry věk, pohlaví, jméno
obsahem metody bude kód, který podle parametru vek bude:
pro vek < 0 vracet nulovou referenci
pro vek od 0 do 7 bude vracet instanci od třídy Predskolak 
pro vek od 8 do 19 bude vracet instanci od třídy Skolak
pro vek od 20 do 65 bude vracet instanci od třídy Pracujici
nad 65 bude vracet instanci od třídy Duchodce

třídy Predskolak, Skolak, Pracujici, Duchodce
 budou následníky třídy Osoba
všechny budou implemetovat veřejný parametrický konstruktor se vstupními parametry věk, pohlaví, jméno
všechny budou implementovat metodu ToString, která vypíše atributy a řetězec s názvem třídy

hlavní program (konzolová aplikace):
dotaz uživatele na věk, pohlaví a jméno
vytvoření instance objektu Osoba
zavolání metody toString na Osoba

Rozšíření:
2) do třídy Osoba přidejte veřejnou metodu starnuti s parametrem cislo (o kolik daná osoba má zestárnout)
medoda bude vracet novou instanci od Osoba s parametrem vek+cislo (pokud bude cislo záporné, můžeme i omládnout ;-)

v hlavním programu ověřte metodu pro stárnutí

navrhove Vzory 2

1) Upravte třídu Předškolák, aby bylo možné vytvořit pouze jednu instanci. Další požadavky na vytvoření nové instance budou vracet už vytvořenou. Pokud dostaneme instanci s jinými parametry, někdo nás předběhl. (Je třeba si ji někde uložit.)

2) Upravte třídu Školak, aby bylo možné vytvářet pouze omezený počet instancí. Počet instancí bude nějaká fixní hodnota.
Pokud danou instanci už nebudete používat, tak ji vraťte, aby ji bylo možné poskytnout někomu jinému.

3) Upravte třídu Pracující, aby bylo možné vytvářet pouze instance s unikátními (neopakujícími se) parametry. Pokud bude volána metoda pro vytvoření nové instance s kombinací parametrů, která už existuje, vrátí se reference na již vytvořenou instanci.

Pozn.: Pokud by bylo možné zjistit počet referencí na již vytvořenou instanci, některé problémy by se tím zjednodušily.
