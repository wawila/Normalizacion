Feature: ImportarNotas
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Importar Notas al Sistema
	Given La siguiente hoja electronica
	| AlumnoId | AlumnoNombre | MateriaId | MateriaNombre | Nota |
	| 1        | Juan         | 1         | Matematicas   | 50   |
	| 1        | Juan         | 2         | Español       | 70   |
	| 1        | Juan         | 3         | Quimica       | 60   |
	| 2        | Pedro         | 1         | Matematicas   | 70   |
	| 2        | Pedro         | 2         | Español       | 90   |
	| 2        | Pedro         | 3         | Quimica       | 100   |
	When Se importa la data
	Then La siguiente informacion se inserto en la tabla Alumno
	| AlumnoId | AlumnoNombre |
	| 1        | Juan         |
	| 2        | Pedro        |
	And La siguiente informacion se inserto en la tabla Materia
	| MateriaId | MateriaNombre |
	| 1         | Matematicas   |
	| 2         | Español       |
	| 3         | Quimica       |
	And La siguiente informacion se inserto en la tabla Notas
	| AlumnoId | MateriaId | Nota |
	| 1        | 1         | 50   |
	| 1        | 2         | 70   |
	| 1        | 3         | 60   |
	| 2        | 1         | 70   |
	| 2        | 2         | 90   |
	| 2        | 3         | 100   |
