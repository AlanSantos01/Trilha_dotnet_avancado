using Modelo;

Data d1 = new Data(09, 11, 1998, 10, 30, 10);
d1.Imprimir(Data.FORMATO_12H);
d1.Imprimir(Data.FORMATO_24H);

Data d2 = new Data(10, 06, 1996, 23, 15, 20);
d2.Imprimir(Data.FORMATO_12H);
d2.Imprimir(Data.FORMATO_24H);

Data d3 = new Data(16, 05, 2018);
d3.Imprimir(Data.FORMATO_12H);
d3.Imprimir(Data.FORMATO_24H);