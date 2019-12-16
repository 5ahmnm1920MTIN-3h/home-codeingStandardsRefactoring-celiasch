# home-codeingStandardsRefactoring-celiasch
## Refactoring Ausarbeitung
### Was ist Refactoring Definition in eigenen Worten?
Refactoring ist hier um einen Code/ein Programm zu verbessern, ohne etwas an seiner Funktion und/oder Verhaltensweise zu ändern. Der Code ist somit übersichtlicher, kürzer, einfacher zu verstehen und weniger fehleranfällig.

### Welche Vorteile/Nachteile birgt Refactoring?
Vorteile: Ein sauberer Code ist leichter lesbar. Somit fallen auch zukünftige Änderungen einfacher, wenn beispielsweise ein/eine anderer/andere ProgrammiererIn weiter an dem Code arbeitet. Durch Refactoring können andere EntwicklerInnen den Code besser lesen und verstehen. Außerdem ist cleaner Code oft kürzer, da er auf das mindeste reduziert ist, und somit kann die Performance des Prozesses gesteigert werden (schnellerer Ablauf und mit weniger Unterbrechungen)
Nachteile: Refactoring kann oft aufwendig sein und einiges an Arbeitszeit benanspruchen. Außerdem kann man durch falsches Refactoring den Code zerstören und den Lauf des Prozesses unterbrechen. 

### Was sind die Refactoring-Schritte?
Man definiert am Anfang einen Testcase. Diesen probiert man aus und sieht sich an wie der Prozess abläuft. Dann fängt man an einen Teil an seinem Code zu verbessern (Beispielsweise leere Code zeilen löschen oder Magic Values austauschen). Danach spielt man den gleichen Testcase durch und sieht sich an, ob der Prozess genau gleich abläuft wie vor dem Refactoring. Wenn das so ist, commited man die Änderung inklusiver klarer Commit Message (git commit -m"refactoring: ......) auf gitHub.  
### Prinzipien von guten Code?

### Was versteht man unter Code Smell?
Ein Code Smell sind Teile vom Code, welche man verbessern/löschen könnte da sie nicht ordentlich sind/eigentlich nicht gebraucht werden (Beispielsweise Magic Strings oder unnötige Debuge Logs). Bei Code Smells handelt es sich nicht um falschen Code. Cleaner Code sollte den gleichen Prozess erzielen, nur ordentlicher,reduzierter und in weniger Fehleranfälliger Form.
### Recherche von 10 Code Smells die Eure Projekt betreffen können, inkl. Beschreibung und Beispiel.
1. Unnötige Kommentare: Ich schreibe mir manchmal als Gedächtnisstütze Kommentare während dem Programmieren. Doch einige sind unnötig und besetzen nur unnötige Zeilen an Code. 

2. Zu lange Methoden: Eine Methode sollte sich nur einer Aufgabe widmen. Bevor ich eine weitere Funktion in eine Methode schreibe, sollte ich dafür lieber eine eigene Methode erstellen.

3. Unnötige Debug Logs: Oft erstelle ich im Verlauf eines Projektes einige Debug Logs in Methoden um auszuprobieren ob sie funktioniert bzw. um herauszufinden wo der Fehler in meinem Code liegt. Doch diese werden nach dem fertigen Programmierprozess nicht mehr gebraucht und werden von mir deshalb gelöscht. 

4. Magic Strings/Magic Values: Statt direkt in dem Code Zahlen bzw Buchstaben zu schreiben, ist es besser eine Variable daraus zu machen und den Wert am Anfang zu deklarieren und anschließend mit dem Variablennamen in der Methode zu arbeiten. 

5. Nichtssagende/Falsche Methoden/Variablennamen: Mir passiert es manchmal, dass ich einer Methode oder einer Variable einen Namen gib der mir als Erstes einfällt. Das korrigiere ich anschließend beim Refactoring und tausche den Namen durch einen aus, der das aussagt, was die Variable ist bzw was die Methode macht. 

6. Ungenutze Directives: Unity erstellt oft anfangs Directives, welche ich oft gar nicht benutze. Diese werden eh in Visual Studio ausgegraugt und somit als nicht genutzt gekennzeichnet. Beim Refactoring lösche ich diese Directives um unnötigen Code zu vermeiden. 

7. Falsche Klammernsetzung: Auch hier ein Flüchtligkeitsfehler der mir schnell beim programmieren passiert. Beim Refactoring setze ich die Klammern in die richtigen Zeilen um den Code ordentlicher und übersichtlicher zu machen. 

