1. Cijferlijst-analyse (met CSV-inlezen)

Leerdoelen: bestand inlezen (File.ReadAllLines), string→int parsing, array vullen, methoden met array-parameter.

Opgave: de leerling krijgt een cijfers.csv (bv. Jan,14 / An,16 / Bo,9 per lijn — naam + cijfer). Ze lezen het bestand in, splitsen elke lijn op de komma, en bouwen een int[] met de cijfers (en evt. een parallelle string[] met namen).

Methoden om te schrijven:

double Gemiddelde(int[] cijfers)
int Hoogste(int[] cijfers) / int Laagste(int[] cijfers)
int AantalGeslaagd(int[] cijfers, int grens)

Output: nette samenvatting in console (gemiddelde, hoogste + wie, aantal geslaagd/gebuisd).

Autograding-idee (Classroom 50): run command met een vaste cijfers.csv als fixture in de repo → exit code + output-match (regex) op de berekende waarden.
