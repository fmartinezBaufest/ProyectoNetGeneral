// See https://aka.ms/new-console-template for more information
using Ejercicios;

var et = new EjercicioTasks();

var t = et.MiMetodo1();
var r = et.MiMetodo2();

var tt = et.MiMetodo1Sincronico();
var rr = et.MiMetodo2Sincronico();

await t;
await r;



