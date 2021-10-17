 using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series 
{
    public class SerieRepositorio : IRepositorio<Serie> //Classe SerieRepositorio implementa uma interface, só que ela implementa uma classe repositório de séries.
                                                        //A vantagem da interface é que pode ser reaproveitada, só substituir o T por série ou filme, caso tivesse.
    {
        private List<Serie> listaSerie = new List<Serie>(); //pseudo banco de dados
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}