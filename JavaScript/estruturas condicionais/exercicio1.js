/**
 * Faça um programa que dado as tres notas de um aluno em um semestre, ele calcule e imprime a sua média e a sua clasificação
 * conforme a tabela abaixo: 
 * Media = (nota1 + nota2 + nota3) / 3;
 * 
 * Classificação:
 * - Media menor que 5, reprovado;
 * - Media entre 5 e 7, recuperação;
 * - Media acima de 7, aprovado;
 */

let nota1 = 7;
let nota2 = 7;
let nota3 = 7;

let media = (nota1 + nota2 + nota3) / 3;
console.log(media.toFixed(2));

if (media < 5) {
    console.log("Reprovado!");
}else if (media >= 5 && media <= 7){
    console.log("Recuperação!");
}else{
    console.log("Aprovado!");
}
