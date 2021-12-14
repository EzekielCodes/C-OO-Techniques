
## Feedback C# OO Programming


#### Kennismaking Visual Studio 2019


- [x] *Aanmaken solution binnen GIT-repository*
- [ ] *Eenvoudige consoletoepassing (met invoer gebruiker)*
- [x] *Eenvoudige WinForm toepassing*
- [x] *Een klasse toevoegen*

* Je bent gestart met ene console-toepassing die je dan 'omgebouwd' hebt naar een WinForms toepassing?

#### Gebruik GIT


- [ ] *Je gebruikt 'atomaire' commits*
- [ ] *Je gebruikt zinvolle commit messages*

* Je Commits zijn niet voldoende frekwent. Probeer na het schrijven of grondig aanpassen van een methode, klasse of na het oplossen van een bug onmiddellijk een commit te doen.
* Je commits zijn niet (altijd) atomair: je hebt commits waarin je meerdere losstaande wijzigingen hebt gedaan.


#### Debugging

--> Nog niet beoordeeld (kan enkel interactief gebeuren)

- [ ] *Code stap voor stap uitvoeren*
- [ ] *Breakpoints*
- [ ] *De waarde van variabelen bekijken tijdens de uitvoering van je programma*

#### Programmeerstijl

--> Nog niet beoordeeld

- [ ] *Huisregels voor programmeerstijl volgen*

* Je volgt niet altijd de regels voor naamgeving:
  * Voor de naam van je project wordt PascalCasing gebruikt.
  * Voor namen van publieke properties wordt PascalCasing gebruikt.
  * Start de namen van private velden met een underscore (gevolgd door de naam in camelCasing).
  * Gebruik geen underscores in namen (pas de automatisch gegenereerde namen met underscores aan).
  * Declareer slechts één variabele per lijn ('clean code').
  * Kies zinvolle namen voor je grafische componenten (Form1)

* Zet een enum-declaratie niet in hetzelfde bestand als een klasse-declaratie.
* Hanteer de gevraagde volgorde voor de verschillende onderdelen van je klasse (properties na de velden en voor de constructor).
* Gebruik type inference ('var') volgens de conventie uit de stijlregels.
* Je gebruikt 'Random' niet op een correcte manier. Gebruik per kalsse één instantie die je dan in je methodes telkens opnieuw gebruikt.
* Vermijd overbodige blanco lijnen (bv. twee achter elkaar of een blanco lijn tussen twee accolades).

* Tip: hou rekening met de messages en warnings uit de 'Error List'.

#### Exceptions

- [ ] *try..catch*
- [ ] *try..catch..finally*
- [x] *Je werpt bruikbare exceptions op wanneer je een foutsituatie detecteert die niet lokaal op een beter manier kan afgehandeld worden.*

#### Enumerations

- [x] *Declaratie en gebruik van enum-type*

* Zet een enum-declaratie niet in hetzelfde bestand als een klasse-declaratie (maar wel in een afzonderlijk bestand).


#### Properties

- [x] *Full property (with private backing field)*
- [ ] *Extra code in getter of setter (bv. validatie)*
- [x] *Auto-implemented property*
- [ ] *Access-modifiers voor Getters en Setters*

* Vervang 'full' properties door 'auto' properties als je geen bijkomende code hebt in de 'set' of 'get' block.


#### Interpolated strings

--> Nog niet beoordeeld

- [ ] *Interpolated strings*

#### Generic collections

- [x] *List<T>*
- [ ] *Dictionary<T,T>*
- [ ] *Overzicht andere generic collections*


#### Interfaces

- [x] *Interface declaratie*
- [x] *Interface implementatie*
- [ ] *Interface gebruiken als type*

#### Architectuur van een toepassing - Meerlagenmodel

- [ ] *Klasseblibliotheken*
- [x] *Meerlagenmodel - 3lagenmodel*
- [x] *'Loose coupling' - dependency injection*
- [ ] *Interface gebruiken als scheiding tussen architectuurlagen*

* Je hebt nog geen datalaag?

#### Bestanden en 'streams'

--> Nog niet beoordeeld

- [ ] *Statische klassen uit 'System.IO'*
- [ ] *Streams*
- [ ] *Serialisatie*

#### 'Value' en 'Reference' types, cloning van objecten

--> Nog niet beoordeeld

- [ ] *'value' en 'reference' types, 'deep' versus 'shallow' copy, object cloning*

#### Klassen - klassehiërarchie

--> Nog niet beoordeeld

- [ ] *Klasse declaratie*
- [ ] *constructor overloading*
- [ ] *Klasse-hiërarchie - subklasse - base-constructor*
- [ ] *Klasse-hiërarchie - virtual methods - override*
- [ ] *Abstracte klasse + implementatie*

#### Structs

--> Nog niet beoordeeld

- [ ] *Structs*

##### Extension methods

--> Nog niet beoordeeld

- [ ] *Extension method schrijven*
- [ ] *Functioneel gebruik van extension methods*

#### Delegates

--> Nog niet beoordeeld

- [ ] *(Predefined) Delegates*

#### Lambda expressions

--> Nog niet beoordeeld

- [ ] *Lambda expressions*

#### Language Integrated Query (Linq)

--> Nog niet beoordeeld

- [ ] *Linq standard query operator syntax*
- [ ] *Linq method syntax*
- [ ] *Basismethodes voor Linq*

#### Events

- [ ] *Event 'Publisher'*
- [x] *Event 'Consumer'*

* Je reageert op externe events maar nog niet op eigen events die vanuit je eigen code gestart worden.


#### Concurrent programmatie: Tasks

--> Nog niet beoordeeld

- [ ] *Tasks*
- [ ] *Cross-thread' interactie vanuit een Task met de userinterface*
- [ ] *Exceptions in Tasks*
- [ ] *Parallel loops*
 
#### Concurrent programming: Task synchronisation

--> Nog niet beoordeeld

- [ ] *Lock*
- [ ] *Concurrent/ thread safe collections*

#### Asynchronous programming: async .. await

--> Nog niet beoordeeld

- [ ] *async .. await*

#### (Recursie)

--> Nog niet beoordeeld

- [ ] *Recursie - concept*
- [ ] *Backtracking*

#### (Indexers & Iteratoren)
 
--> Nog niet beoordeeld

- [ ] *Indexers*
- [ ] *Enumeratoren*

#### (Statische klassen, methoden, velden)

--> Nog niet beoordeeld

- [ ] *Zinvol gebruik statische klassen, methoden, velden*

#### Code Reviews

- [x] *Code reviews*

* Code review is OK maar soms wat slordig geschreven.