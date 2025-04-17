# Zadania konsolowe - Python i C#
Zadanie wykonane w ramach przedmiotu "Podstawy programowania zorientowane obiektowo".

## Wersje użytych technologii
- Python 3.13.3
- .NET 9 (9.0.200)

## Zadania
### Prosty kalkulator dwóch liczb
**Opis:** Napisz program, który prosi użytkownika o dwie liczby oraz o wybór operacji arytmetycznej (`+`, `-`, `*` lub `/`). Następnie, w zależności od wybranego działania, program oblicza wynik i wyświetla go na ekranie. Użyj instrukcji warunkowej (`if/elif`) do rozpoznania operacji.

**Przykład:**
- **Wejście:** 10, 20, `+`
- **Wyjście:** Wynik: 30

### Konwerter temperatur (Celsjusz ↔ Fahrenheit)
**Opis:** Napisz program, który umożliwia konwersję temperatur między skalą Celsjusza a Fahrenheita. Użytkownik najpierw wybiera kierunek konwersji: `C` – jeśli chce przeliczyć stopnie Celsjusza na Fahrenheity, lub `F` – jeśli chce przeliczyć stopnie Fahrenheita na Celsjusze. Następnie podaje wartość temperatury w wybranej skali, a program przelicza ją i wyświetla wynik. Wykorzystaj instrukcję warunkową do rozróżnienia dwóch przypadków konwersji.

_(Wzory konwersji: °F = °C * 1.8 + 32, °C = (°F – 32) / 1.8)_

**Przykład:**
- **Wejście:** `C`, 0  
- **Wyjście:** 0°C = 32°F

### Średnia ocen ucznia
**Opis:** Napisz program, który oblicza średnią z podanych ocen ucznia oraz sprawdza, czy uczeń zdał (zaliczył przedmiot). Najpierw użytkownik podaje liczbę ocen, które będzie wprowadzać. Następnie wpisuje kolejne oceny (zakładamy skalę 1–6, gdzie 6 to najwyższa ocena). Program oblicza średnią wartość z tych ocen i wyświetla ją z odpowiednim komunikatem. Przyjmijmy, że uczeń zalicza przedmiot, jeśli średnia jego ocen wynosi **co najmniej 3.0**. Użyj pętli `for` do odczytania serii ocen oraz instrukcji warunkowej do sprawdzenia warunku zaliczenia.

**Przykład:**
- **Wejście:** 4, 5, 3, 4, 2
- **Wyjście:**  
    Średnia: 3.50  
    Uczeń zdał.