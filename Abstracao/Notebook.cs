using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Abstracao
{
    public class Notebook
    {
        private string _nome;
        public USB Porta1 { get; set; }
        public USB Porta2 { get; set; }
        public USB Porta3 { get; set; }
        public string getNome()
    {
            return _nome;

    }
        public Notebook(string nome)
    {
            _nome = nome;

    }

    }

    }
    public abstract class USB
    {
     public abstract void Plugar();
    }
    public class Tablet : USB
    {
    public override void Plugar()
    {
        Console.WriteLine("Tablet plugado..");
    }
    }
    public class Mouse: USB
    {
    public override void Plugar()
    {
        Console.WriteLine("Mouse plugado..");
    }
    }
    public class Teclado : USB
    {
    public override void Plugar()
    {
        Console.WriteLine("Teclado plugado...");
    }
    }  