
/*Snack 10 - Fai inserire un numero , che chiameremo N, all'utente.
 Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
Ogni volta che ne crei uno, stampalo a schermo.*/

Console.WriteLine("Inserisci un numero");
int N = int.Parse(Console.ReadLine());
Random rand = new Random();
int[] arrayUtente;

for (int i = 0; i < N; i++)
{
    arrayUtente = new int[10];

    for (int j = 0; j < 10; j++)
    {
        arrayUtente[j] = rand.Next(1, 101);
    }

    for(int j = 0; j < arrayUtente.Length; j++)
    {
        Console.Write(arrayUtente[j] + " ");
    }

    Console.WriteLine();
}



/*Snack 5 - Il software chiede all'utente di inserire un numero.
 * Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.*/

Console.WriteLine("Inserisci un numero");
int nUtente = int.Parse(Console.ReadLine());

if( nUtente%2 == 0 )
{
    Console.WriteLine("Il numero è: " + nUtente);
}else
{
    Console.WriteLine("il numero è: " + (nUtente + 1));
}


/*Snack 4 - Calcola la somma e la media dei numeri da 2 a 10.*/

int somma = 0;
double media = 0;

for(int i = 2; i <= 10; i++)
{
    somma += i;
}

media = somma / (10 - 2);
Console.WriteLine($"La somma dei numeri è: {somma}");
Console.WriteLine($"La media dei numeri è: {media}");


/*Snack 3 - Il software deve chiedere per 10 volte all’utente di inserire un numero.
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