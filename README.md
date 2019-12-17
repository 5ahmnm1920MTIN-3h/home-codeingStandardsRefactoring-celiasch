## Refactoring Ausarbeitung
### Was ist Refactoring Definition in eigenen Worten?
Refactoring ist hier um einen Code/ein Programm zu verbessern, ohne etwas an seiner Funktion und/oder Verhaltensweise zu ändern. Der Code ist somit übersichtlicher, kürzer, einfacher zu verstehen und weniger fehleranfällig.

### Welche Vorteile/Nachteile birgt Refactoring?
1. Vorteile: Ein sauberer Code ist leichter lesbar. Somit fallen auch zukünftige Änderungen einfacher, wenn beispielsweise ein/eine anderer/andere ProgrammiererIn weiter an dem Code arbeitet. Durch Refactoring können andere EntwicklerInnen den Code besser lesen und verstehen. Außerdem ist cleaner Code oft kürzer, da er auf das mindeste reduziert ist, und somit kann die Performance des Prozesses gesteigert werden (schnellerer Ablauf und mit weniger Unterbrechungen)
2. Nachteile: Refactoring kann oft aufwendig sein und einiges an Arbeitszeit benanspruchen. Außerdem kann man durch falsches Refactoring den Code zerstören und den Lauf des Prozesses unterbrechen. 

### Was sind die Refactoring-Schritte?
Man definiert am Anfang einen Testcase. Diesen probiert man aus und sieht sich an wie der Prozess abläuft. Dann fängt man an einen Teil an seinem Code zu verbessern (Beispielsweise leere Code zeilen löschen oder Magic Values austauschen). Danach spielt man den gleichen Testcase durch und sieht sich an, ob der Prozess genau gleich abläuft wie vor dem Refactoring. Wenn das so ist, commited man die Änderung inklusiver klarer Commit Message (git commit -m"refactoring: ......) auf gitHub.  
### Prinzipien von guten Code?
1. KISS (Keep it simple Stupid): Der Code sollte sehr einfach gehalten werden und nicht verkompliziert werden. Es sollte stets die einfachste Lösung gewählt werden.

2. YAGNI (You aint gonna need it): Oft denkt man sich einige Funktionen aus welche man unbedingt noch in seinen Prozess einbauen will. Man sollte sich stets bewusst sein welche Funktionen man wirklich braucht. So stellt man sicher, dass man Zeit spart und das Projekt als ein Ganzes wirklich vorrangeht. 

3. DRY(Dont repeat yourself): Vorallem durch Copy and Paste kann es passieren, dass unnötige Codestellen wiederholt werden. Das sollte vermieden werden um Wiederholungen auszuschließen und Speicher zu sparen. 

4. SoC (Seperation of Concerns): Eine Codeeinheit sollte EINE klare Aufgabe haben. Die verschiedenen Belangen sollten klar getrennt sein, in eigenenen Codeeinheiten. 

5. POLA (Principle of least Astonishment): Der User/die Userin sollte nie überrascht sein durch den Prozess/den Code. 

6. Information Hidding & Encapsulation: Das Prinzip beschreibt das Verbergen der inneren Struktur eines Objektes, damit auf dieses nur über seine öffentlichen Methoden und Attribute zugegriffen werden kann.
### Was versteht man unter Code Smell?
Ein Code Smell sind Teile vom Code, welche man verbessern/löschen könnte da sie nicht ordentlich sind/eigentlich nicht gebraucht werden (Beispielsweise Magic Strings oder unnötige Debuge Logs). Bei Code Smells handelt es sich nicht um falschen Code. Cleaner Code sollte den gleichen Prozess erzielen, nur ordentlicher,reduzierter und in weniger Fehleranfälliger Form.
### Recherche von 10 Code Smells die Eure Projekt betreffen können, inkl. Beschreibung und Beispiel.
1. Unnötige Kommentare: Ich schreibe mir manchmal als Gedächtnisstütze Kommentare während dem Programmieren. Doch einige sind unnötig und besetzen nur unnötige Zeilen an Code. 

2. Zu lange Methoden: Eine Methode sollte sich nur einer Aufgabe widmen. Bevor ich eine weitere Funktion in eine Methode schreibe, sollte ich dafür lieber eine eigene Methode erstellen.

3. Unnötige Debug Logs: Oft erstelle ich im Verlauf eines Projektes einige Debug Logs in Methoden um auszuprobieren ob sie funktioniert bzw. um herauszufinden wo der Fehler in meinem Code liegt. Doch diese werden nach dem fertigen Programmierprozess nicht mehr gebraucht und werden von mir deshalb gelöscht. 

4. Magic Strings/Magic Values: Statt direkt in dem Code Zahlen bzw Buchstaben zu schreiben, ist es besser eine Variable daraus zu machen und den Wert am Anfang zu deklarieren und anschließend mit dem Variablennamen in der Methode zu arbeiten. 

5. Nichtssagende Variablennamen: Mir passiert es manchmal, dass ich einer Methode oder einer Variable einen Namen gib der mir als Erstes einfällt. Das korrigiere ich anschließend beim Refactoring und tausche den Namen durch einen aus, der das aussagt, was die Variable ist bzw was die Methode macht. 

6. Ungenutze Directives: Unity erstellt oft anfangs Directives, welche ich oft gar nicht benutze. Diese werden eh in Visual Studio ausgegraugt und somit als nicht genutzt gekennzeichnet. Beim Refactoring lösche ich diese Directives um unnötigen Code zu vermeiden. 

7. Falsche Klammernsetzung: Auch hier ein Flüchtligkeitsfehler der mir schnell beim programmieren passiert. Beim Refactoring setze ich die Klammern in die richtigen Zeilen um den Code ordentlicher und übersichtlicher zu machen. 

8. Leerzeilen im Code: Leerzeilen passieren auch schnell beim programmieren und sollten im Nachhinein gelöscht werden um unnötige Zeilen einzusparen.

9. Methoden-und Variablennamen Formatieren: Die Namen sollten in der richtigen Formatierung sein (Camelcase). Oft passiert es, dass man sie klein schreibt. 

10. Unbenutzer Code: Wenn man Codestellen übernimmt kann es leicht passieren, dass man auch unnötigen Code mitnimmt, der nicht genutzt wird. Dieser verbraucht nur unnötigen Speicher. 

# Santa Run

### Project description: 
This is a simple 2D side-scroll game. The Santa runs from left to right and has to avoid some obstacles by jumping over them.
The game ends when the Santa hits an obstacle.  The goal is to avoid as many obstacles as possible.

### Development platform: 
Windows 10, Unity version 2019.1.14f1, Visual Studio Community 2017, Scripting Runtime Version: .NET 4.0

### Target platform: 
WebGl and Standalone, RefRes: 1920 * 1080

### Visuals: 
<div>
<img src = "./Screenshots/sketch-SantaRun.JPG" width = "500">
</div>

[![SANTA RUN](https://i9.ytimg.com/vi/2C74XxBkFfI/mq1.jpg?sqp=CNWnze8F&rs=AOn4CLBrmO-tJ3gQ2BNeMxvrmQcsIhhcgQ)](https://www.youtube.com/embed/2C74XxBkFfI "Santa RUN")

https://www.youtube.com/embed/2C74XxBkFfI

### Necessary setup/execution steps: 
For playing the game go to: 
* WebGL: https://hs-teaching.github.io/WegGL-SantaRun/
* Standalone (.exe): Clone project and publish as Standalone

For development: Clone this project. 

### Third party material: 
* This game is based on the game Santa Run developed by Raja Biswas in the Udemy-course Unity 2018 Game Developmen by Example 
[Unity 2018 Game Development by Example](https://www.udemy.com/course/unity-2d-game-development-by-example/).
* Sprites are used from https://www.gameart2d.com/santa-claus-free-sprites.html


### Project state: 
Program is working correctly, no errors, refactoring is needed.
Refactoring needed: 
* del not used namespaces
* del unused variables
* del needless debugs
* del needless comments
* del unused methods
* rename variables (coding standards)
* rename methods (coding standards)
* fix poor conditional clauses
* fix poor formating
* replace magic string
* replace magic number

### Limitations: 
Only one level is implemented. 

### Lessons Learned: 
* Create 2D Scenes
* Use Quads for moving Backgrounds (Textures instead of Sprites)
* Use Particle System for snowing effect.
* Use Scene Management for switching between Scenes
* Create and control Animations (Animation, Animator and Scripts)
* Use the singelton pattern
* Spawn objects
* Use UI elements and manipulate UI elements with scrips


Copyright by smeerws