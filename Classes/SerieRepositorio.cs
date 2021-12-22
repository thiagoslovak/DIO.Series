using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>//Implementa uma interface e um repositorio de Serie que é uma classe
    {
        private List<Serie> listaSerie = new List<Serie>();
        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        } 
        public List<Serie> Lista()
        {
            return listaSerie;
        }
    }
}