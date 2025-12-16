Cosmic Drop
Genre

Physics-based arcade puzzelgame.

Beschrijving

De speler schiet energiebollen af vanuit een lanceerplatform. In de ruimte zweven kosmische kristallen en kleine meteorieten die geraakt kunnen worden. Door targets te raken verzamelt de speler punten en probeert hij het level te voltooien met zo min mogelijk schoten.

Gameplaykern

Bal:
Een kleine blauwe “energy orb” die licht geeft.

Targets / bumps:
Ruimte-kristallen, mini-meteorieten en pulserende energie-stenen.
Sommige geven meer punten, andere stuiteren de bal onverwacht af.

Score:
+10 punten voor een kristal
+25 punten voor een meteoriet
+50 punten voor een zeldzame pulserende steen

Doel:
Raak genoeg targets om het score-doel van de beurt te halen.

Stijl en sfeer

Donker ruimte-thema met paars/blauw neonlicht.
Rustige ambient-space muziek.
Glowing effecten, zwevende objecten en een mysterieus sfeertje.

Structuur van het level

Bovenaan: lanceerplek
Midden: veld met targets, kristallen en meteorieten
Onderaan: gravity catcher waar de bal naartoe valt

Levelschets

Hier is mijn levelschets van het startlevel:

 Level Sketch

(Afbeelding toegevoegd in de repository)

Reflectie – Week 1

Wat heb ik gemaakt:
 Een nieuw Unity-project opgezet
 Een concept uitgewerkt
 Een eerste levelschets gemaakt
 Mijn README geschreven en alles gepusht naar GitHub

Hoe heb ik dit aangepakt:
Ik ben begonnen met het conceptformat en daarna de schets gemaakt. Alles toegevoegd aan de README en naar Git gepusht.

Waar liep ik tegenaan:
Git had eerst problemen door branches, maar na opnieuw instellen is het gelukt.
Unity zelf werkte prima, maar ik moet nog wennen aan physics-instellingen.

Wat heb ik geleerd:
– Basis van Unity 2D physics
– Werken met Git (add, commit, push)
– Het maken van een goed concept en documentatie

 Checklist:

 Unity-project werkt
 README bevat concept, sketch en reflectie
 .gitignore toegevoegd
 commit & push van vandaag
 link ingeleverd in Simulise






 Week 2 – Forces & Collisions
  Wat werkt nu:

✔ Bal met Rigidbody2D
✔ AddForce om de bal af te schieten
✔ Targets met Collider2D
✔ Botsing detectie met OnCollisionEnter2D
✔ "Hit!" in de Console

🎥 Demo GIF
![alt text](<../OneDrive/Рабочий стол/M2-skill-opdracht/ball_shoot.gif>)

 Reflectie – Week 2

Deze week heb ik geleerd hoe AddForce werkt en waarom je dit gebruikt in plaats van een Transform verplaatsen.
Ik heb een bal gemaakt met Rigidbody2D en physics-material voor bounciness.
Ook heb ik targets toegevoegd en collisions getest met OnCollisionEnter2D.
Het kostte wat testen om de juiste kracht en richting te vinden, maar nu werkt het goed.



## 2.2 Aim, Shoot & Line Renderer

In this step I implemented an aiming and shooting system similar to Peggle.

- The cannon rotates towards the mouse using an Aim script.
- Holding the left mouse button builds up force.
- A Line Renderer visualizes the shot power.
- Releasing the mouse button shoots the ball using AddForce.
- The ball interacts with physics and collides with targets.

### Demo🎯 3.1 Peggle – Hits & Score
Beschrijving

In deze opdracht heb ik de basis van een Peggle-mechanic gebouwd.
De bal wordt afgevuurd vanuit een kanon en kan Peggles raken.
Elke Peggle houdt bij hoeveel hits hij kan hebben, geeft punten bij elke hit en verdwijnt wanneer het maximum aantal hits is bereikt.

Gameplay mechanic

De speler schiet een bal af vanuit het kanon.

Wanneer de bal een Peggle raakt:

gaat het aantal resterende hits omlaag

wordt de score verhoogd

Zodra een Peggle geen hits meer over heeft, verdwijnt hij uit het level.

Peggle instellingen

Elke Peggle heeft eigen instellingen die via de Inspector aangepast kunnen worden:

Hits to destroy – hoeveel keer de Peggle geraakt kan worden

Points per hit – hoeveel punten één hit oplevert

Hierdoor is het mogelijk om verschillende soorten Peggles te maken zonder extra scripts.

Score systeem

De score wordt centraal bijgehouden in de ScoreManager.
Elke Peggle roept bij een hit AddScore() aan op de ScoreManager.
Op deze manier blijft het puntensysteem overzichtelijk en uitbreidbaar.

Technische uitleg

De Peggle gebruikt een Collider2D zonder Rigidbody.

De bal heeft een Rigidbody2D, zodat collisions worden geregistreerd.

Bij een collision wordt OnCollisionEnter2D() gebruikt om:

hits af te tellen

punten toe te voegen

de Peggle te verwijderen wanneer deze “op” is

Resultaat (GIF)

![Запись 2025-12-14 185332](https://github.com/user-attachments/assets/056cc621-8072-4bff-b589-c7791c4de341)


de bal die een Peggle raakt

de score die oploopt

de Peggle die verdwijnt

Reflectie

Wat heb ik gemaakt:
Ik heb een Peggle-mechanic gemaakt die reageert op hits, punten geeft en verdwijnt na een ingesteld aantal hits.

Hoe heb ik dit aangepakt:
Ik heb één Peggle-script gemaakt waarin zowel hit-registratie als score-verwerking zit. De score wordt afgehandeld door een aparte ScoreManager.

Waar liep ik tegenaan:
Ik had in het begin meerdere scripts voor dezelfde logica, wat errors veroorzaakte. Door alles in één Peggle-script te zetten werkte de mechanic correct.

Wat heb ik geleerd:
Ik heb geleerd hoe collisions werken in Unity 2D, hoe objecten met elkaar communiceren via scripts en hoe een centrale ScoreManager gebruikt kan worden.

✔ Checklist

Peggles reageren op hits

Score loopt correct op

Peggles verdwijnen na het juiste aantal hits

GIF toegevoegd aan README
![Aim and Shoot](ball_shoot.gif)

### Code
- Aim.cs
- ShootBall.cs

