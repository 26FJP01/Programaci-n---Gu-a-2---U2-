Algoritmo convertidor
	Definir metros, resultado Como Real
    Definir opcion Como Caracter
    Escribir "===== CONVERSOR DE METROS ====="
    Escribir "Ingrese la cantidad de metros:"
    Leer metros
    Escribir "Seleccione conversion:"
    Escribir "a) Pies"
    Escribir "b) Centimetros"
    Escribir "c) Pulgadas"
    Leer opcion
    Segun opcion Hacer
		
        "a":
            resultado <- metros * 3.28084
            Escribir metros, " metros son ", resultado, " pies"
			
        "b":
            resultado <- metros * 100
            Escribir metros, " metros son ", resultado, " centimetros"
			
        "c":
            resultado <- metros * 39.3701
            Escribir metros, " metros son ", resultado, " pulgadas"
			
        De Otro Modo:
            Escribir "Opcion no valida"
	FinSegun
	
FinAlgoritmo
