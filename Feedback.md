
## Feedback C# OO Programming


#### Algemeen 

#### Kennismaking Visual Studio 2019


- [x] *Aanmaken solution binnen GIT-repository*
- [ ] *Eenvoudige consoletoepassing (met invoer gebruiker)*
- [x] *Eenvoudige WinForm toepassing*
- [x] *Een klasse toevoegen*

#### Gebruik GIT


- [x] *Je gebruikt 'atomaire' commits*
- [x] *Je gebruikt zinvolle commit messages*

* Je commit-messages zouden nog iets concreter en specifieker kunnen zijn.

#### Debugging

--> Nog niet beoordeeld (kan enkel interactief gebeuren)

- [ ] *Code stap voor stap uitvoeren*
- [ ] *Breakpoints*
- [ ] *De waarde van variabelen bekijken tijdens de uitvoering van je programma*

#### Programmeerstijl

- [ ] *Huisregels voor programmeerstijl volgen*

* Je volgt niet altijd de regels voor naamgeving:
  * Gebruik geen underscores in namen (pas de automatisch gegenereerde namen met underscores aan).

* Gebruik type inference ('var') volgens de conventie uit de stijlregels.
* Je gebruikt 'Random' niet op een correcte manier. Gebruik per kalsse één instantie die je dan in je methodes telkens opnieuw gebruikt.
* Vermijd overbodige blanco lijnen (bv. twee achter elkaar of een blanco lijn tussen twee accolades).

* Tip: hou rekening met de messages en warnings uit de 'Error List'.

#### Exceptions

- [ ] *try..catch*
- [x] *try..catch..finally*
- [x] *Je werpt bruikbare exceptions op wanneer je een foutsituatie detecteert die niet lokaal op een beter manier kan afgehandeld worden.*

* Een exceptie opvangen om ze dan onmiddellijk weer op te gooien heeft niet zoveel zin.

#### Enumerations

- [x] *Declaratie en gebruik van enum-type*

* Zet een enum-declaratie niet in hetzelfde bestand als een klasse-declaratie (maar wel in een afzonderlijk bestand).


#### Properties

- [x] *Full property (with private backing field)*
- [x] *Extra code in getter of setter (bv. validatie)*
- [x] *Auto-implemented property*
- [ ] *Access-modifiers voor Getters en Setters*

* Vervang 'full' properties door 'auto' properties als je geen bijkomende code hebt in de 'set' of 'get' block.


#### Interpolated strings

- [x] *Interpolated strings*

#### Generic collections

- [x] *List<T>*
- [x] *Dictionary<T,T>*
- [ ] *Overzicht andere generic collections*


#### Interfaces

- [x] *Interface declaratie*
- [x] *Interface implementatie*
- [x] *Interface gebruiken als type*

#### Architectuur van een toepassing - Meerlagenmodel

- [ ] *Klasseblibliotheken*
- [x] *Meerlagenmodel - 3lagenmodel*
- [x] *'Loose coupling' - dependency injection*
- [ ] *Interface gebruiken als scheiding tussen architectuurlagen*

* Je hebt nog geen datalaag?

#### Bestanden en 'streams'

- [x] *Statische klassen uit 'System.IO'*
- [x] *Streams*
- [ ] *Serialisatie*

#### 'Value' en 'Reference' types, cloning van objecten

--> Nog niet beoordeeld

- [ ] *'value' en 'reference' types, 'deep' versus 'shallow' copy, object cloning*

#### Klassen - klassehiërarchie

- [x] *Klasse declaratie*
- [x] *constructor overloading*
- [ ] *Klasse-hiërarchie - subklasse - base-constructor*
- [x] *Klasse-hiërarchie - virtual methods - override*
- [x] *Abstracte klasse + implementatie*

* Je klassehiërarchie is niet echt zinvol: er is maar één subklasse van een abstracte klasse.


#### Structs

--> Nog niet beoordeeld

- [ ] *Structs*

##### Extension methods

- [x] *Extension method schrijven*
- [x] *Functioneel gebruik van extension methods*

#### Delegates

- [x] *(Predefined) Delegates*

#### Lambda expressions

- [x] *Lambda expressions*

* Je gebruikt enkel zeer eenvoudige lambda-expressions, overgenomen uit voorbeeldcode.

#### Language Integrated Query (Linq)

- [ ] *Linq standard query operator syntax*
- [x] *Linq method syntax*
- [x] *Basismethodes voor Linq*

* BJe gebruikt Linq heel beperkt: Order, ToList, Take


#### Events

- [x] *Event 'Publisher'*
- [x] *Event 'Consumer'*

#### Concurrent programmatie: Tasks

--> Nog niet beoordeeld

- [x] *Tasks*
- [ ] *Cross-thread' interactie vanuit een Task met de userinterface*
- [ ] *Exceptions in Tasks*
- [ ] *Parallel loops*
 

#### Concurrent programming: Task synchronisation

--> Nog niet beoordeeld

- [ ] *Lock*
- [ ] *Concurrent/ thread safe collections*

#### Asynchronous programming: async .. await

- [x] *async .. await*

* Het is geen good practice om een async methode op te roepen zonder dat je een 'await' doet van het resultaat.

* De 'async' methode `ReadFile` is zelf niet echt asynchroon. Vervang daarin beter `sr.ReadLine')` door `await sr.ReadLineAsync();


#### (Recursie)

- [x] *Recursie - concept*
- [ ] *Backtracking*

* Theoretisch zou het kunnen dat je recursieve methode 'GenerateFood' nooit stapt (als er elke keer random punten berekend worden die net op je slang liggen).

#### (Indexers & Iteratoren)
 
--> Nog niet beoordeeld

- [ ] *Indexers*
- [ ] *Enumeratoren*

#### (Statische klassen, methoden, velden)

- [x] *Zinvol gebruik statische klassen, methoden, velden*

#### Code Reviews

- [x] *Code reviews*

* Code review is OK maar soms wat slordig geschreven.