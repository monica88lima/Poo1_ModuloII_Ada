using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace exercicio_18
{
    public class Camera
    {
        /*Crie uma classe Camera que deve ter como propriedades resolucaoMaxima e fotosTiradas e um método
             * tiraFoto que apenas aumenta o número de fotos tiradas. Crie uma classe Celular que tenha como propriedades
             * espacoDisponivel (em número de fotos), cameraFrontal e cameraTraseira. Tanto a cameraFrontal como a cameraTraseira
             * devem ser classes que herdam de Camera e tem como propriedades adicionais a resolucaoAtual
             * (não pode ser superior à resolucaoMaxima). Ambas apenas podem tirar fotos se houver espaço 
             * disponível no celular e a cameraFrontal deve ter resolucaoMaxima menor que a cameraTraseira.*/
        public int Resolucao_Maxima { get; set; }
        private int Fotos_Tiradas { get; set; }
        public Camera(int resolucaoMaxima)
        {
                this.Resolucao_Maxima = resolucaoMaxima;
        }

        public virtual void TirarFoto()
        {
            Fotos_Tiradas++;
        }

        public void MostraQuantidadeDeFotos()
        {
            Console.WriteLine("Total de Fotos Tiradas: "+ Fotos_Tiradas);
        }
    }
    
}
