/**
 * Faça um programa para calcular o valor gasto de combustivel em uma viagem.

Você terá três variáveis. Sendo elas: 
1 - Preço do combustivel;
2 - Valor médio de gasto do carro;
3 - Distancia em km da viagem;
4 - Preço do etanol
5 - Preço da gasolina

Imprima no console o valor que será gasto de combustivel em uma viagem;
 */

const precoEtanol = 5.79;
const precoGasolina = 6.76;
const kmPorLitro = 10;
const distanciaEmkm = 100;
const tipoCombustivel = 'gasolina';
const litrosConsumidos = distanciaEmkm / kmPorLitro;

if(tipoCombustivel === 'etanol'){
    valorGasto = precoEtanol * litrosConsumidos;
}
if(tipoCombustivel === 'gasolina'){
    valorGasto = precoGasolina * litrosConsumidos;
}

console.log(valorGasto.toFixed(2));