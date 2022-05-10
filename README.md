## Teste Klingon

Arqueólogos encontraram um pergaminho com os seguintes textos:

Texto A:
https://raw.githubusercontent.com/f360-dev/provas/master/klingon-textoA.txt

Texto B:
https://raw.githubusercontent.com/f360-dev/provas/master/klingon-textoB.txt

Esses pergaminhos estão no antigo e misterioso idioma Klingon. Após muitos anos de estudo, os linguistas já conhecem algumas características desse idioma.

Primeiramente, as letras Klingon são classificadas em dois grupos: as letras s, l, f, w e k são chamadas "letras tipo foo", enquanto que as demais são conhecidas como "letras tipo bar".

Os linguistas descobriram que as preposições em Klingon são as palavras de 3 letras que terminam numa letra tipo bar, mas onde não ocorre a letra d. Portanto, é fácil ver que existem 63 preposições no Texto A. E no Texto B, quantas preposições existem?

Um outro fato interessante descoberto pelos linguistas é que, no Klingon, os verbos sempre são palavras de 8 ou mais letras que terminam numa letra tipo foo. Além disso, se um verbo começa com uma letra tipo bar, o verbo está em primeira pessoa.

Assim, lendo o Texto A, é possível identificar 26 verbos no texto, dos quais 23 estão em primeira pessoa.

#### Já no Texto B, quantos são os verbos?_____________________

#### E quantos verbos do Texto B estão em primeira pessoa?_____________________

## Lista de vocabulário em Klingon

Um professor universitário utilizará os textos A e B para ensinar o Klingon aos alunos. Para ajudar os alunos a compreender o texto, esse professor precisa criar uma lista de vocabulário para cada texto, isto é, uma lista ordenada (e sem repetições) das palavras que aparecem em cada um dos textos.
Essas listas devem estar ordenadas e não podem conter repetições de palavras. No Klingon, assim como no nosso alfabeto, as palavras são ordenadas lexicograficamente, mas o problema é que no Klingon, a ordem das letras no alfabeto é diferente da nossa. O alfabeto Klingon, em ordem, é: 
kbwrqdnfxjmlvhtcgzps. 

Assim, ao fazer essas listas, o professor deve respeitar a ordem alfabética Klingon.

O professor preparou a lista de vocabulário para o Texto A:

Lista de vocabulário do Texto A:
https://raw.githubusercontent.com/f360-dev/provas/master/klingon-textoA-ordenado.txt

#### Como seria a lista de vocabulário do Texto B?_____________________

## Mas como os Klingon escrevem números?

Bem, no Klingon, as palavras também são números dados em base 20, onde cada letra é um dígito, e os dígitos são ordenados do menos significativo para o mais significativo (o inverso do nosso sistema). Ou seja, a primeira posição é a unidade, a segunda posição vale 20, a terceira vale 400, e assim por diante. Os valores das letras são dados pela ordem em que elas aparecem no alfabeto Klingon (que é diferente da nossa ordem, como vimos acima). Ou seja, a primeira letra do alfabeto Klingon representa o dígito 0, a segunda representa o dígito 1, e assim por diante.
Por exemplo, a palavra vwv tem o valor numérico de 4852.

OBS: os números nesse problema podem ser grandes, então se você está usando um tipo de dados de tamanho limitado, tenha cuidado com possíveis overflows.

Os Klingons consideram um número bonito se ele satisfaz essas duas propriedades:

- é maior ou igual a 440566
- é divisível por 3

Ao consideramos o Texto A como uma lista de números (isto é, interpretando cada palavra como um número usando a convenção explicada acima), notamos que existem 126 números bonitos distintos.

#### E no Texto B, quantos números bonitos distintos existem?_____________________
