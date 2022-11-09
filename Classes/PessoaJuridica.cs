using UC12_ER7.Interfaces;
using System.Text.RegularExpressions;

namespace UC12_ER7.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string ?cnpj { get; set; }
        
        public string ?razaoSocial { get; set; }
         
        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";
        
        
        
        public override float PagarImposto(float rendimento)
        {
            /* Utilizar a seguite escala
            Até 1500 (considerando 1500) - 3%
            de 1500 a 3500 (considerando 3500) - 5% de  imposto
            de 3500 a 6000 (considerando 6000) - 7% de imposto
            Acima de 6000 - 9% de imposto
            */

            if (rendimento <= 1500) 
            {
                return (rendimento / 100) * 3;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return (rendimento / 100) * 5;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento / 100) * 7;            
            }
            else {
                return (rendimento / 100) * 9;
            }
            throw new NotImplementedException();
        }

// xx.xxx.xxx/0001-xx  \d{2}
// xxxxxxxxxxxxxx

        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11,4) == "0001")
                    {
                        return true;
                    }
                }
            else if (cnpj.Length == 14) 
            {
                if (cnpj.Substring(8,4) == "0001") //ele vai iniciar no caractere 8 e pegar os próximos 4
                {
                    return true;
                }
            }   

            }
        return false;

        }


        public void Inserir(PessoaJuridica pj)
        {
            VerificarPastaArquivo(caminho);

            string[] pjString = {$"{pj.nome},{pj.cnpj},{pj.rendimento}"};
            File.AppendAllLines(caminho, pjString);
    
        }

        public List<PessoaJuridica> Ler()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }
    }

}