using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_18
{
    public class Celular:Camera
    {
        public int EspacoLivre { get; set; }
        public int Camera_FrontalCelular { get; set; }
        public int Camera_TraseiraCelular { get; set; }

        public Celular(int resolucaoMaxima, int espacoLivre, int capacidadeCameraFrontal, int capacidadeCameratraseira) : base(resolucaoMaxima)
        {
            this.Resolucao_Maxima = resolucaoMaxima;
            this.EspacoLivre = espacoLivre;
            this.Camera_FrontalCelular = capacidadeCameraFrontal;
            this.Camera_TraseiraCelular = capacidadeCameratraseira;
        }

        public override void TirarFoto()
        {
            if(EspacoLivre <= 0)
            {
                Console.WriteLine("Limite de foto atingido. Apague algusn arquivos.");
            }
            else
            {
                EspacoLivre--;

                base.TirarFoto();

            }
            
        }

        /*Crie uma classe Celular que tenha como propriedades
        * espacoDisponivel(em número de fotos), cameraFrontal e cameraTraseira.Tanto a cameraFrontal como a cameraTraseira
        * devem ser classes que herdam de Camera e tem como propriedades adicionais a resolucaoAtual
        * (não pode ser superior à resolucaoMaxima). Ambas apenas podem tirar fotos se houver espaço 
        * disponível no celular e a cameraFrontal deve ter resolucaoMaxima menor que a cameraTraseira.*/
    }

}
