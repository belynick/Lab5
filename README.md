# Lab5

Инструкции
1) Створіть клас Printer. У тілі класу створіть метод void Print(string value), що виводить на екран значення аргументу. Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів, та виклику відповідного методу їх екземпляра, рядки, передані як аргументи методів, виводилися різними кольорами. Обов'язково використовуйте типи.

2) Створити клас, який представляє навчальний клас ClassRoom. Створити клас учень - Pupil. У тілі класу створіть методи void Study(), void Read(), void Write(), void Relax(). Створити 3 похідні класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil і перевизначити кожен із методів, залежно від успішності учня. Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів. Необхідно передбачити можливість, що користувач може передати 2 або 3 аргументи.
Виведіть інформацію про те, як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати.

3) Створіть клас DocumentWorker. У тілі класу створіть три методи OpenDocument(), EditDocument(), SaveDocument(). У тілі кожного з методів додайте виведення на екран відповідних рядків: "Документ відкритий", "Правка документа доступна у версії Про", "Збереження документа доступне у версії Про". Створіть похідний клас ProDocumentWorker. Перевизначте відповідні методи, при перевизначенні методів виводьте такі рядки: "Документ відредаговано", "Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт". Створити похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker. Перевизначте відповідний метод. При виклику даного методу необхідно виводити на екран “Документ збережений в новому форматі”. У тілі методу Main() реалізуйте можливість прийому від користувача ключа доступу pro і exp. Якщо користувач не вводить ключ, він може користуватися тільки безкоштовною версією (створюється екземпляр базового класу), якщо користувач ввів номери ключа доступу pro і exp, то повинен створити екземпляр відповідної версії класу, наведений до базового – DocumentWorker. Для наглядності роботи програми, всі операції мають проходити над реальними текстовими файлами (формат на ваш вибір).