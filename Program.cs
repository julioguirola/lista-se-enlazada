/*
 * Created by SharpDevelop.
 * User: Julio
 * Date: 15/10/2022
 * Time: 11:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Lista_SE_Cascaron;

namespace Lista_SE_Cascaron
{
	class Program
	{
		//
        //Ejercicios para la preparación 
        //
        
        //Devolver la suma de todos los numeros de una lista
        public static int SumaTodos(Lista_SE<int> list)
        {
        	int suma = 0;
        	for (int i = 1; i <= list.Cantidad(); i++) {
        		suma += list.Obtener(i).Info;
        	}
        	return suma;       
        }
        
        public static int SumaTodos2(Lista_SE<int> lista)
        {
        	int suma=0;
        	Nodo_SE<int> aux = new Nodo_SE<int>();
        	aux=lista.PrimerE().Prox;
        	while (aux != null) {
        		suma += aux.Info;
        		aux=aux.Prox;
        	}
        	return suma;    	
        }		

        static int coincideElmPos(Lista_SE<int> lista){
            // 
            Nodo_SE<int> aux = lista.PrimerE();
            int cant = 0;
            for (int i = 0; i <= lista.Cantidad(); i++)
            {
                if (aux.Info.Equals(i)){
                    cant++;
                }
                aux = aux.Prox;
            }
            return cant;
        }
        static bool elemComun(Lista_SE<int> lista1, Lista_SE<int> lista2){
            Nodo_SE<int> aux1 = lista1.PrimerE();
            Nodo_SE<int> aux2 = lista2.PrimerE();

            while (aux1 != null){
                while (aux2 != null){
                    Console.WriteLine($"Comparando {aux1.Info} y {aux2.Info}");

                    if (aux1.Info == aux2.Info){
                        return true;
                    }
                    aux2 = aux2.Prox;
                }
                aux1 = aux1.Prox;
                aux2 = lista2.PrimerE();
            }

            return false;
        }
        static void eliminarQuePosPar(Lista_SE<string> lista){
            Nodo_SE<string> aux = lista.PrimerE();
            for (int cantRep = 0; aux != null; aux = aux.Prox){
                if (aux.Info == "que"){
                    cantRep++;
                }
                if (aux.Prox == null){
                    break;
                }
                if (cantRep % 2 != 0 && aux.Prox.Info == "que"){
                    aux.Prox = aux.Prox.Prox;
                    cantRep++;
                }

            }
        }
		public static void Main(string[] args)
		{
            Lista_SE<string> Lista = new Lista_SE<string>("que");

            Lista.Adicionar("casa");
            Lista.Adicionar("que");
            Lista.Adicionar("que");

            Lista.Adicionar("pato");
            Lista.Adicionar("que");

            eliminarQuePosPar(Lista);


            Lista.Mostrar();            
		}
	}
}