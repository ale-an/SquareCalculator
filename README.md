### SquareCalculator
Библиотека для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Для добавления новых фигур необходимо реализовать интерфейс ```IFigure``` и написать калькулятор, который будет реализовывать интерфейс ```IFigureCalculator```.
***
### Kubernetes
* Количество реплик: установлено 3, так как этого достаточно для обработки нагрузки.
* CPU: установлены requests и limits для CPU с учетом пиковой нагрузки (0.5 и 1 соответственно).
* Memory: установлены requests и limits для памяти на уровне 128M, так как это постоянное потребление.  
* Affinity: используется podAntiAffinity для размещения подов на разных нодах, чтобы обеспечить отказоустойчивость.
