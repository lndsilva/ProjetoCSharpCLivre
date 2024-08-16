using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
    class Bilhete : Passageiro
    {
        private int id;
        private int numero;
        private string assento;

        public void comprar()
        {
            //compra
        }

        public void cancelarReserva()
        {
            //cancela reserva
        }

        public void reservar(Passageiro psg)
        {
            this.assento = psg.NumeroCartao;
        }



    }
}
