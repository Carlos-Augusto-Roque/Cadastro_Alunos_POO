namespace Cadastro_Alunos_POO.classes
{
    public class Aluno//classe
    {
        //atributos da classe
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        //métodos
        public float VerMediaAluno()
        {
            return this.mediaFinal;
        }
        
        public float VerMensalidade()
        {
            float valor;
            if (this.bolsista == true && this.mediaFinal >= 8)
            {
                valor = this.valorMensalidade *0.5f;
            }
            else if(this.bolsista == true && this.mediaFinal >=6)
            {
                valor = this.valorMensalidade *0.7f;
            }
            else
            {
                valor = this.valorMensalidade;
            }
            return valor;
        }
    }
}