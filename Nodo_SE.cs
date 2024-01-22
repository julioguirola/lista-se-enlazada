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
	/// Description of Nodo_SE.
	/// </summary>
	class Nodo_SE<T>
	{
		private T info;
        private Nodo_SE<T> prox;

        public Nodo_SE()
        {
            info = default(T);
            prox = null;
        }

        public Nodo_SE(T info)
        {
            this.info = info;
            prox = null;
        }

        /// <summary>
        /// Propiedad que permite el acceso a la informacion del nodo
        /// </summary>
        public T Info
        {
            get { return info; }
            set { info = value; }
        }

        public Nodo_SE<T> Prox
        {
            get { return prox; }
            set { prox = value; }
        }

	}
}
