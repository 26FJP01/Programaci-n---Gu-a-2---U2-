Algoritmo CalcFuncTrig
	Definir opcion Como Entero
    Definir anguloGrados, anguloRadianes Como Real
    Escribir "========== CALCULADORA DE FUNCIONES TRIGONOMETRICAS BASICAS =========="
    Escribir "1 - Seno"
    Escribir "2 - Coseno"
    Escribir "3 - Tangente"
    Escribir "********************************************************************"
    Escribir "Ingrese el angulo en grados:"
    Leer anguloGrados
    anguloRadianes <- anguloGrados * (PI / 180)
    Escribir "Escoge la opcion que deseas:"
    Leer opcion
    Segun opcion Hacer
        1:
            Escribir "El seno de tu angulo es: ", Sen(anguloRadianes)
        2:
            Escribir "El coseno de tu angulo es: ", Cos(anguloRadianes)
        3:
            Escribir "La tangente de tu angulo es: ", Tan(anguloRadianes)
        De Otro Modo:
            Escribir "ERROR AL OPERAR"
    FinSegun
FinAlgoritmo
