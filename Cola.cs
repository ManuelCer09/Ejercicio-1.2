using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace Ejercicio_1._2
{
    public class Cola
    {
        private int[] elementos;   // Arreglo donde guardamos la cola
        private int frente;        
        private int final;         
        private int tamaño;        
        private int capacidad;     
        public Cola(int capacidad)
        {
            this.capacidad = capacidad;
            elementos = new int[capacidad];
            frente = 0;
            final = -1;
            tamaño = 0;
        }
        public bool EstaVacia()
        {
            return tamaño == 0;
        }
        public bool EstaLlena()
        {
            return tamaño == capacidad;
        }
        public void Encolar(int dato)
        {
            if (EstaLlena())
                throw new InvalidOperationException("La cola está llena.");
            final = (final + 1) % capacidad;
            elementos[final] = dato;
            tamaño++;
        }
        public int Desencolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");
            int dato = elementos[frente];
            frente = (frente + 1) % capacidad;
            tamaño--;
            return dato;
        }
        public int Peek()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");
            return elementos[frente];
        }
        public int[] ObtenerElementos()
        {
            int[] result = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                result[i] = elementos[(frente + i) % capacidad];
            }
            return result;
        }
    }
}