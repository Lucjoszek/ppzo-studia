import os
import sys
from typing import Literal
from typing import List


def clear_console():
    '''Czyści ekran konsoli w zależności od systemu operacyjnego.'''
    os.system('cls' if os.name == 'nt' else 'clear')


def wait_for_enter_and_clear():
    '''Czeka na naciśnięcie Enter przez użytkownika, a następnie czyści ekran konsoli.'''
    input('Naciśnij Enter, aby kontynuować...')
    clear_console()


def get_number_from_user(prompt: str, num_type: Literal['int', 'float']) -> int | float:
    '''Pobiera od użytkownika liczbę określonego typu: 'int' lub 'float'.'''
    while True:
        input_str: str = input(f'{prompt}\n> ')
        input_num: int | float

        try:
            if num_type == 'int':
                input_num = int(input_str)
            if num_type == 'float':
                input_num = float(input_str)
        except:
            print('Podana wartość jest nieprawidłowa! Spróbuj ponownie.')
            continue

        # Sprawdź, czy wartość zrzutowana jest równa wartość podanej
        if (str(input_num) != input_str) and (str(input_num) != f'{input_str}.0'):
            print('Podana wartość jest nieprawidłowa! Spróbuj ponownie.')
            continue

        return input_num


def kalkulator():
    '''Realizuje działanie prostego kalkulatora.'''
    clear_console()

    print(
        'KALKULATOR\n' +
        '----------'
    )

    num1: float = get_number_from_user('Podaj pierwszą liczbę.', 'float')
    num2: float = get_number_from_user('Podaj drugą liczbę.', 'float')

    clear_console()
    print(
        f'Podane liczby to:\n' +
        f'{num1}\n' +
        f'{num2}' +
        'Wpisz znak operacji, którą chcesz wykonać:\n' +
        '[+] - Dodawanie\n' +
        '[-] - Odejmowanie\n' +
        '[*] - Mnożenie\n' +
        '[/] - Dzielenie'
    )

    result: float

    while True:
        option: str = input('> ')
        if option == '+':
            result = num1 + num2
        elif option == '-':
            result = num1 - num2
        elif option == '*':
            result = num1 * num2
        elif option == '/':
            if num2 == 0:
                print('Nie można dzielić przez 0! Spróbuj ponownie.')
                continue

            result = num1 / num2
        else:
            print('Podana operacja nie istnieje! Spróbuj ponownie.')
            continue

        break
    print(f'Wynik: {result}')


def konwerter_temperatur():
    '''Konwertuje temperatury między stopniami Celsjusza a Fahrenheita.'''
    clear_console()

    print(
        'KONWERTER TEMPERATUR\n' +
        '----------\n' +
        'Wybierz operację.\n' +
        '[C] - Celsjusz -> Fahrenheit\n' +
        '[F] - Fahrenheit -> Celsjusz'
    )

    temperature_type: str

    while True:
        temperature_type = input('> ')

        if (temperature_type != 'C' and temperature_type != 'F'):
            print('Podany typ temperatury nie istnieje! Spróbuj ponownie.')
            continue

        break

    temperature: float = get_number_from_user(
        'Podaj wartość temperatury.', 'float')

    if temperature_type == 'C':
        print(f'{temperature}°C = {temperature * 1.8 + 32}°F')
    if temperature_type == 'F':
        print(f'{temperature}°F = {(temperature - 32) / 1.8}°C')


def srednia_ocen_ucznia():
    '''Oblicza średnią ocen ucznia.'''
    clear_console()

    print(
        'ŚREDNIA OCEN UCZNIA\n' +
        '----------'
    )

    num_of_grades: int

    while True:
        num_of_grades: int = get_number_from_user(
            'Podaj liczbę ocen ucznia.', 'int')

        if num_of_grades <= 0:
            print('Liczba ocen ucznia musi być większa od 0!. Spróbuj ponownie.')
            continue

        break

    grades: List[int] = []

    for i in range(num_of_grades):
        grade: int

        while True:
            grade = get_number_from_user(
                f'Podaj ocenę nr.{i + 1}.', 'int')

            if not (1 <= grade <= 6):
                print('Podana ocena nie mieści się w zakresie 1-6!. Spróbuj ponownie.')
                continue

            break

        grades.append(grade)

    sum_of_grades: int = 0

    for grade in grades:
        sum_of_grades += grade

    average: float = sum_of_grades / num_of_grades

    print(
        f'Średnia: {average}\n' +
        ('Uczeń zdał.' if average >= 3.0 else 'Uczeń nie zdał.')
    )


def main():
    '''Wyświetla menu i obsługuje wybór użytkownika.'''
    while True:
        print(
            'MENU\n' +
            '----------\n' +
            '[1] Kalkulator\n' +
            '[2] Konwerter temperatur\n' +
            '[3] Średnia ocen ucznia\n' +
            '[9] Wyjście'
        )

        option: str = input("> ")

        match option:
            case "1":
                kalkulator()

            case "2":
                konwerter_temperatur()

            case "3":
                srednia_ocen_ucznia()

            case "9":
                sys.exit()

            case _:
                print('Podana opcja nie istnieje!')

        wait_for_enter_and_clear()


if __name__ == "__main__":
    main()
