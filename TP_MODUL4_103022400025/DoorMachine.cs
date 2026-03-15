using System;

namespace TP_MODUL4_103022400025
{
    // Enum untuk merepresentasikan state pintu
    public enum DoorState
    {
        Terkunci,
        Terbuka
    }

    public class DoorMachine
    {
        // Variabel untuk menyimpan state saat ini
        private DoorState state;

        public DoorMachine()
        {
            // Inisiasi state awal Terkunci
            state = DoorState.Terkunci;
            Console.WriteLine("(State awal: Pintu terkunci)");
        }

        // Method untuk membuka pintu
        public void BukaPintu()
        {
            // Ubah state menjadi Terbuka
            state = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }

        // Method untuk mengunci pintu
        public void KunciPintu()
        {
            // Ubah state menjadi Terkunci
            state = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
