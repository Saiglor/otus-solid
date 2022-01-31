# otus-solid
## Single Responsibility Principle (Принцип единственной обязанности)
Весь функционал не связанный с логикой игры был вынесен в отдельные классы, а также была проведена агрегация. В итоге класс `GuessNumberGame` стал выглядеть следующим образом:
```c#
private GameReader Reader { get; init; }
private GamePrinter Printer { get; init; }
private GameSettings Setting { get; init; }

public GuessNumberGame(IReader reader, IPrinter printer, GameSettings settings)
{
    Reader = new GameReader(reader);
    Printer = new GamePrinter(printer);
    Setting = settings;
}
```
## Open/Closed Principle (Принцип открытости/закрытости)
Для вывода текста был использован класс `ConsolePrinter`, который унаследован от интерфейса `IPrinter`, таким образом можно изменять способы вывода информации, добавив новый класс. Способ вывода текста определяется через передачу необходимой реализации в конструкторе класса `GuessNumberGame`.

Тоже самое было сделано для ввода текста пользователем.
## Liskov Substitution Principle (Принцип подстановки Лисков)
Класс `GuessNumberGame` наследуется от абстрактного класса `Game`, таким образом можно создавать классы других игр без внесения изменений в родительский класс.
## Interface Segregation Principle (Принцип разделения интерфейсов)
В программе нет ситуации, когда клиент не реализует какие-нибудь методы своего интерфейса, а значит принцип соблюдается. 
## Dependency Inversion Principle (Принцип инверсии зависимостей)
`ConsolePrinter` унаследован от интерфейса `IPrinter`, таким образом его абстаркция отделена от конкретных реализаций. Тоже касается и ввода текста 
