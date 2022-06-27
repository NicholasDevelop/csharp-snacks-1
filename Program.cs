
//Snack4 - Calcola la somma e la media dei numeri da 2 a 10.

int somma = 0;
int media = 0;

for(int i = 2; i <= 10; i++)
{
    somma += i;
}

media = somma / 10-1;
Console.WriteLine($"La somma dei numeri è: {somma}");
Console.WriteLine($"La media dei numeri è: {media}");


/*Snack3 - - Il software deve chiedere per 10 volte all’utente di inserire un numero.
Il programma stampa la somma di tutti i numeri inseriti.
 */

int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero da sommare");
    int numeroUtente = int.Parse(Console.ReadLine());
    sum += numeroUtente;
}

Console.WriteLine("La somma dei numeri inseriti è: {0}", sum);