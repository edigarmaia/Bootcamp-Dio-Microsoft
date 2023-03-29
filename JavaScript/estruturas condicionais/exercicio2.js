/**
 * Crie um programa que calcule o valor a ser pago por um produto, considerando o preço normal 
 * e a escolha da forma de pagamento.
 * Utilize os códigos da tabela para ler a condição de pagamento e efetuar o calculo adequado.
 * 
 * Código Condição de pagamento:
 * 1 - À vista Débito, desconto de 10%
 * 2 - À vista Dinheiro ou Pix, desconto de 15%
 * 3 - Em duas vezes no cartão, valor da etiqueta sem juros;
 * 4 - Acima de duas vezes, preço normal mais juros de 10%
 * 
 */

let precoEtiqueta = 100.00;
let formaPagto = 4;

if(formaPagto === 1){
    //console.log('Desconto de 10% - Valor a ser pago é = R$ ' + (precoEtiqueta - (precoEtiqueta * 10 / 100).toFixed(2)));
    console.log('Desconto de 10% - Valor a ser pago é = R$ ' + (precoEtiqueta - (precoEtiqueta * 0.1)));
}else if(formaPagto === 2){
   
    console.log('Desconto de 15% - Valor a ser pago é = R$ ' + (precoEtiqueta - (precoEtiqueta * 0.15)));
}else if(formaPagto === 3){
    
    console.log('Sem desconto - Valor a ser pago é = R$ ' + precoEtiqueta);
}else if(formaPagto === 4){
    console.log('Com juros - Valor a ser pago é = R$ ' + (precoEtiqueta + (precoEtiqueta * 0.1)));
}


