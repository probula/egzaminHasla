

List<string> maleLitery =
[
    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
    "x", "y", "z"
];
List<string> duzeLitery =
[
    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W",
    "X", "Y", "Z"
];
List<string> znakiDiakrytyczne = ["ą", "ć", "ę", "ł", "ń", "ó", "ś", "ż", "ź", "Ą", "Ć", "Ę", "Ł", "Ń", "Ó", "Ś", "Ż", "Ź"];
List<string> cyfry = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"];
List<string> znakiSpecjalne = ["!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+"];



//nazwa funkcji: generujLosoweHaslo
//opis funkcji: generuje losowe haslo skladajace sie z 3 duzych liter, 3 malych liter, 2 znakoiw diaktrycznych, 2 cyfr, 2 znakow specjalnych. wyszstkie znaki sa wybierane lsoow i ustawiane w losowej kolejnosci
//parametry: brak
//zwracany typ i opis: funkcja zwraca wartosc typu string ktora jest losowo wygeneowanym haslem
//autor: <numer zdającego>


string generujLosoweHaslo(){
    var random = new Random();
    List<string> finalneHaslo = [];
    

    for (int i = 0; i < 3; i++)
    {
        finalneHaslo?.Add(maleLitery[random.Next(duzeLitery.Count-1)]);
        finalneHaslo?.Add(duzeLitery[random.Next(duzeLitery.Count - 1)]);
    }

    for (int i = 0; i < 2; i++)
    {
        finalneHaslo?.Add(znakiDiakrytyczne[random.Next(znakiDiakrytyczne.Count - 1)]);
        finalneHaslo?.Add(cyfry[random.Next(cyfry.Count - 1)]);
        finalneHaslo?.Add(znakiSpecjalne[random.Next(znakiSpecjalne.Count - 1)]);
    }

    return string.Join(" ", finalneHaslo.Shuffle());
}

for (int i = 1; i < 5; i++)
{
    Console.WriteLine($"Wygenerowano losowe hasło nr {i}: {generujLosoweHaslo()}");
}


