/**
 * Faça um programa para calcular o valor gasto de combustivel em uma viagem.

Você terá três variáveis. Sendo elas: 
1 - Preço do combustivel;
2 - Valor médio de gasto do carro;
3 - Distancia em km da viagem;

Imprima no console o valor que será gasto de combustivel em uma viagem;
*/
const precoCombustivel = 5.79;
const kmPorLitro = 12;
const distanciaEmkm = 1580;

const litrosConsumidos = distanciaEmkm / kmPorLitro;
const valorGasto = precoCombustivel * litrosConsumidos;

console.log(valorGasto.toFixed(2));