Курсовая работа реализована в формате WPF приложения.

Основной функционал:
1. Программа обладает возможностью считывания информации из файла.
2. Программа предоставляет возможность сохранения зашифрованной и дешифрованной информации в файл.
3. Входящий и исходящий формат файла .txt, .docx.
4. Программа позволяет осуществлять дешифровку и расшифровку информации, находящейся в файле и вывод её на экран пользователя.
5. Программа предоставляет возможность для зашифрования и дешифрования информации, введенной пользователем с клавиатуры, а также возможность указать ключ.
6. Программа обладает интерфейсом для взаимодействия с пользователем.
7. Загрузка файла происходит в формате переноса информации в поле для ввода текста с клавиатуры.
8. Основной функционал покрыт Unit тестами.


Дополнительные возможности:
1. Программа содержит текстовое поле подсказок, которое появляется, если пользователь не совершил какое-то действие.
2. Поле подсказок всплывает при попытке скачать файл, до полученная какой-либо зашифрованной/зашифрованной информации.

![openFIle](https://user-images.githubusercontent.com/74231423/116739328-37537080-a9fc-11eb-9aa3-0ef552916922.gif) 

3. Поле подсказок всплывает при нажатии на кнопки дешифрования/шифрования, при незаполненном поле ключа, а также при некорректно заполненном поле.
4. В ходе шифрования/дешифрования не учитываются сторонние символы в ключе, не входящих в выбранный (русский/английский) алфавит.
5. Если в ходе шифрования/дешифрования ключ не содержит ни одного символа выбранного алфавита, итоговый текст не будет выведен, будет вызвано поле подсказок.
6. Шифрованию/дешифрованию подвергается русский/английский алфавит.
7. Выбор алфавита шифрования отображается в углу приложения, соответсвующим флагом странны. Для изменения языка шифрования достаточно нажать на флаг.

![changeLanguage](https://user-images.githubusercontent.com/74231423/116740256-6b7b6100-a9fd-11eb-8e30-07023230a70c.gif)
