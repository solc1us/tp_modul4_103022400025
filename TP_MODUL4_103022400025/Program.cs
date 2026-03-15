// See https://aka.ms/new-console-template for more information
using TP_MODUL4_103022400025;

Console.WriteLine("\n=== Simulasi DoorMachine ===");

// Inisiasi DoorMachine (state awal: Terkunci)
DoorMachine door = new DoorMachine();

// Simulasi perubahan state
door.BukaPintu();
door.KunciPintu();
door.KunciPintu();
door.BukaPintu();
door.BukaPintu();