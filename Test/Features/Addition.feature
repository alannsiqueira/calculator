#language: pt-BR
Funcionalidade: Adição
Adição é uma das operações básicas da aritmética. Na sua forma mais simples, a adição combina dois números em um único número, denominado soma, total ou resultado
Adicionar mais números corresponde a repetir a operação. Por extensão, a adição de zero, um ou uma quantidade infinita de números pode ser definida.

Esquema do Cenário: Adição de dois números
	Dado o operando <operando_1> e o operando <operando_2>
	E realizo a operação de adição com esses operandos
	Então espero ter como resultado o valor de <resultado>

	Exemplos: Adição dois números
		| propriedade     | operando_1 | operando_2 | resultado |
		| clássico        | 50,50      | 50         | 100,50    |
		| comutativa      | 70         | 50         | 121       |
		| comutativa      | 50         | 70         | 120       |
		| elemento neutro | 0          | 42         | 42        |
		| elemento oposto | -50        | 50         | 0         |