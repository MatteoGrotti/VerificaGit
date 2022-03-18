using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaGit
{
    class Alunni
    {
        private int _eta;
        private string _nome; 
        private string _cognome;
        private string _cicloStudi;
        public Alunni(string nome,string cognome, int eta, string cicloStudi)
        {
            Nome = nome;
            Cognome = cognome;
            CicloStudi = cicloStudi;
            Eta = eta;
        }

        public string Nome
        {
            get { return _nome; }
            set { if(string.IsNullOrEmpty(value) == true)
                {
                    throw new Exception("Stringa errata");
                }
                _nome = value;
            }
        }

        public string Cognome
        {
            get { return _cognome; }
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    throw new Exception("Stringa errata");
                }
                _cognome = value;
            }
        }

        public int Eta
        {
            get { return _eta; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Intero errato");
                }
                _eta = value;
            }
        }

        public string CicloStudi
        {
            get { return _cicloStudi; }
            set
            {
                if (_eta < 16)
                {
                    value = "Biennio";
                }
                else
                    value = "Triennio";

                _cicloStudi = value;
            }
        }
    }
}
