/*
 * Created by SharpDevelop.
 * User: Julio
 * Date: 15/10/2022
 * Time: 11:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lista_SE_Cascaron
{
	/// <summary>
	/// Description of Lista_SE.
	/// </summary>
	class Lista_SE<T>
	{
		private Nodo_SE<T> inicio;
        private int ce;

        public Lista_SE(T info)
        {
            inicio = new Nodo_SE<T>(info);
            ce = 0;
        }
        public Lista_SE()
        {
            inicio = new Nodo_SE<T>();
            ce = 0;
        }
        /// <summary>
        /// Obtiene la cantidad de elementos presentes en la lista
        /// </summary>
        public int Cantidad()
        {
            return ce;
        }
        public bool Es_Vacia()
        {
            if (ce == 0)
            {
                return true;
            }
            return false;

        }
      
        /// <summary>
        /// Método que permite INSERTAR un elemento en una posición determinada
        /// </summary>
        /// <param name="elemento">elemento a insertar</param>
        /// <param name="pos">posición en la que se desea insertar el elemento</param>
        public void Insertar(T elemento, int pos)
        {
            Nodo_SE<T> nuevo = new Nodo_SE<T>(elemento);
            if ((pos > 0) && (pos <= ce + 1))
            {
                if (pos == 1)//insertar en la 1ra posicion
                {
                    nuevo.Prox = inicio.Prox;
                    inicio.Prox = nuevo;
                    ce++;
                }
                else
                {
                    if (pos == ce + 1)//insertar al final
                    {
                        Nodo_SE<T> aux = inicio;
                        while (aux.Prox != null)
                        {
                            aux = aux.Prox;
                        }
                        aux.Prox = nuevo;
                        ce++;
                    }
                    else
                    {
                        Nodo_SE<T> aux = inicio.Prox;
                        int i = 1;
                        while (i < pos)
                        {
                            aux = aux.Prox;
                            i++;
                        }
                        nuevo.Prox = aux.Prox;
                        aux.Prox = nuevo;
                        ce++;
                    }
                }

            }
            else
                Console.WriteLine("La posición no es válida. No se puede insertar");
        }

        /// <summary>
        /// Método que permite ADICIONAR un elemento al final de la lista
        /// </summary>
        /// <param name="info">elemento a insertar</param>
        public void Adicionar(T info)
        {
            Nodo_SE<T> nuevo = new Nodo_SE<T>(info);
            if (ce == 0)
            {
                inicio.Prox = nuevo;
            }
            else
            {
                Nodo_SE<T> aux = inicio.Prox;
                while (aux.Prox != null)
                {
                    aux = aux.Prox;
                }
                aux.Prox = nuevo;
            }
            ce++;
        }

        /// <summary>
        /// Método que permite ELIMINAR un elemento de la lista dada una posición
        /// </summary>
        /// <param name="pos">posición del elemento a eliminar</param>
        public void Eliminar(int pos)
        {
            if ((pos > 0) && (pos <= ce))
            {
                if (pos == 1)// el 1er elemento
                {
                    inicio.Prox = inicio.Prox.Prox;
                    ce--;
                }
                else
                {
                    Nodo_SE<T> aux = inicio;
                    int i = 1;
                    while (i < pos)
                    {
                        aux = aux.Prox;
                        i++;
                    }
                    aux.Prox = aux.Prox.Prox;
                    ce--;
                }
            }
            else
                Console.WriteLine("La posición no es válida.");
        }

        /// <summary>
        /// Método que permite obtener la posicion de un elemento en la lista
        /// </summary>
        /// <param name="elemento">elemento a buscar en la lista</param>
        /// <returns>posición del elemento en la lista</returns>
        public int Buscar(T elemento)
        {
            int resp = -1; //no se encontró
            Nodo_SE<T> aux = inicio.Prox;
            int i = 1;
            while ((i <= ce) && (!aux.Info.Equals(elemento)))
            {
                aux = aux.Prox;
                i++;
            }
            if (i <= ce)//lo encontro
            {
                resp = i;
            }
            return resp;
        }

        /// <summary>
        /// Obtiene o establece el elemento que se encuentra en la posición especificada
        /// </summary>
        /// <param name="pos">Posición del elemento al que se desea acceder</param>
        /// <returns></returns>
        public T this[int pos]
        {
            get { return Obtener(pos).Info; }
            set { Obtener(pos).Info = value; }
        }

        /// <summary>
        /// Método que permite obtener un nodo a partir de una posición dada
        /// </summary>
        /// <param name="pos">posición del elemento a obtener</param>
        /// <returns>Nodo que se encuentra en la posición dada</returns>
        public Nodo_SE<T> Obtener(int pos)
        {
            if ((pos > 0) && (pos <= ce))
            {
                Nodo_SE<T> aux = inicio.Prox;
                for (int i = 1; i < pos; i++)
                {
                    aux = aux.Prox;
                }
                return aux;
            }
            else
            {
                throw new Exception("Posición fuera de los límites de la lista");
            }
        }
        /// <summary>
        /// Muestra la información de cada nodo de la Lista
        /// </summary>
        public void Mostrar()
        {
            Nodo_SE<T> Actual = inicio;
            while (Actual != null){
                Console.WriteLine(Actual.Info);
                Actual = Actual.Prox;
            }
        }

        //
        //Ejercicios para la preparación 
        //
        
        //Cantidad de veces que se repite un elemento en una lista.
        public void CantElemntRepite(T elemento)
        {
        	Nodo_SE<T> aux = inicio.Prox;
        	int i = 0;
        	int cont = 0;
        	int c = Cantidad();
        	while (i<c) {
                if (aux.Info.Equals(elemento))
        		{
        			cont++;
        		}
                aux = aux.Prox;
        		i++;
        	}
        	Console.WriteLine("El elemento: "+elemento+ ", se repite: " +cont+ " veces");     	
        }
        
        public Nodo_SE<T> PrimerE()
        {
            // ejecicio 1 inciso a
        	return inicio;
        }

        public Nodo_SE<T> UltimoE(){
            // ejercicio 1 inciso b
            Nodo_SE<T> aux = inicio;

            while(aux.Prox != null){
                aux = aux.Prox;
            }

            return aux;
        }

        public void insertNoRep(T info){
            // ejercicio 3
            if (this.Buscar(info) == -1){
                this.Adicionar(info);
            } else {
                Console.WriteLine("No agregado, ya existe.");
            }
        }

        public int ultimaOcurr(T elem){
            // ejercicio 6
            int pos = -1;

            Nodo_SE<T> aux = inicio;
            for (int i = 0; i <= ce; i++){
                if (aux.Info.Equals(elem)){
                    pos = i;
                }
                aux = aux.Prox;
            }
            return pos;
        }
	}
}
