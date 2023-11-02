Пример общения нескольких ViewModel для [темы на StackOverflow](https://ru.stackoverflow.com/questions/1549351/%d0%92%d0%b7%d0%b0%d0%b8%d0%bc%d0%be%d1%81%d0%b2%d1%8f%d0%b7%d1%8c-%d0%bc%d0%b5%d0%b6%d0%b4%d1%83-%d0%bd%d0%b5%d1%81%d0%ba%d0%be%d0%bb%d1%8c%d0%ba%d0%b8%d0%bc%d0%b8-viewmodel-c)

Данный пример включает в себя использование Prism и разделения главного окна на 2 региона:
1) LeftRegion - список машин
2) RightRegion - информация о выбранной машине

Взаимодействие между **LeftViewModel** и **RightViewModel** происходит через событие в Singleton-сервисе CarService.
