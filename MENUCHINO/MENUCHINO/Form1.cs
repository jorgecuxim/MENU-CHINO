using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENUCHINO
{
    public partial class Form1 : Form
    {
        //contar las bases
        string[] baseDescripcion={"","","",""};
        string[] toppingDescripcion = {"","","","",""};
        string[] proteinaDescripcion = { "", "", "", "","" };
        string[] crujienteDescripcion = { "", "", "", "", };
        string[] aderezoDescripcion = { "", "", "", "", };
        
        int baseTotal = 0;
        bool b_ase = false;
        int toppingTotal = 0;
        bool topping = false;
        int totalproteina = 0;
        bool t_otal = false;
        int totalcrujiente = 0;
        bool to_tal = false;
        int totaladerezos = 0;
        bool tot_al = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void arroz_CheckedChanged(object sender, EventArgs e)
        {

            if (arroz.CheckState == CheckState.Checked)
            {

                baseTotal ++;
                baseDescripcion[0] = "ARROZ";
            }
            else
            {
                baseDescripcion[0] = "";
                baseTotal--;

            }
        }

        private void tallarines_CheckedChanged(object sender, EventArgs e)
        {
            if(tallarines.CheckState  == CheckState.Checked )
            {

              baseTotal ++;
                baseDescripcion[1] = "TALLARINES";
            }
            else
            {
                baseDescripcion[1] = "";
                baseTotal--;

            }
           
            

        }

        private void fideosPepino_CheckedChanged(object sender, EventArgs e)
        {
            if (fideosPepino .CheckState == CheckState.Checked)
            {

                baseTotal  ++;
                baseDescripcion[2] = "FIDEOS DE PEPINO";
                //baseTotal = baseTotal+1;
            }
            else 
            
            {
                baseDescripcion[2] = "";
                baseTotal--;
                //baseTotal = baseTotal-1; 

            }
        }

        private void lechuga_CheckedChanged(object sender, EventArgs e)
        {
            if (lechuga .CheckState == CheckState.Checked)
            {

                baseTotal  ++;
                baseDescripcion[3] = "LECHUGA";
            }
            else
            {
                baseDescripcion[3] = "";
                baseTotal--;

            }
        }

        private void ordenar_Click(object sender, EventArgs e)
        {
            //si el usuario eliguio solo una base = esta bien
            //si quiere una segunda= aviso de que no puede
            //si no tiene ninguna le decimos que deve escoger una


            if (baseTotal == 1)
            {
                AVISOBASE.Text = "BASE OK";
                b_ase = true;
            }
            else if (baseTotal == 0)
            {
                AVISOBASE.Text = "TIENE QUE ELEGUIR 1 BASE";
                b_ase = false;

            }
            else
            {
                AVISOBASE.Text = "SOLO PUEDE ELEGUIR 1 BASE";

            }//
            if (toppingTotal >= 1 && toppingTotal <= 3)
            {
                AVISOTOPPING.Text = "TOPPING OK";
                topping = true;
            }
            else if (toppingTotal == 0)
            {
                AVISOTOPPING.Text = "TIENE QUE ELEGUIR AL MENOS 1 TOPPING";
                topping = false;


            }
            else
            {
                AVISOTOPPING.Text = "SOLO PUEDE ELEGUIR 3 TOPINGS";

            }//
            if (totalproteina >= 1 && totalproteina <= 2)
            {
                AVISOPROTEINA.Text = "PROTEINA  OK";
                t_otal = true;
            }
            else if (totalproteina == 0)
            {
                AVISOPROTEINA.Text = "TIENE QUE ELEGUIR AL MENOS 1 PROTEINA ";
                t_otal = false;


            }
            else
            {
                AVISOPROTEINA.Text = "SOLO PUEDE ELEGUIR 2 PROTEINAS";

            }//
            if (totalcrujiente >= 1 && totalcrujiente <= 2)
            {
                AVISOCRUJIENTES.Text = "CRUJIENTE  OK";
                to_tal = true;
            }
            else if (totalcrujiente == 0)
            {
                AVISOCRUJIENTES.Text = "TIENE QUE ELEGUIR AL MENOS 1  CRUJIENTE ";
                to_tal = false;


            }
            else
            {
                AVISOCRUJIENTES.Text = "SOLO PUEDE ELEGUIR 2 CRUJIENTES";

            }//
            if (totaladerezos >= 1 && totaladerezos <= 2)
            {
                AVISOADEREZOS.Text = "ADEREZOS  OK";
                tot_al = true;
            }
            else if (totaladerezos == 0)
            {
                AVISOADEREZOS.Text = "TIENE QUE ELEGUIR AL MENOS 1 ADEREZO ";
                tot_al = false;


            }
            else
            {
                AVISOADEREZOS.Text = "SOLO PUEDE ELEGUIR 2 ADEREZOS ";

            }//
            if (b_ase == true && topping == true && t_otal == true && to_tal == true && tot_al == true)
            {
                MessageBox.Show("TU ORDEN ESTA SIENDO GENERADA ");
                string pedidoBase = "";
                for (int i = 0; i < 4; i++)
                {
                    if (baseDescripcion[i] != "")
                    {
                        pedidoBase = pedidoBase + baseDescripcion[i];
                    }
                }
                string pedidoTopping = "";
                for (int i = 0; i < 5; i++)
                {
                    if (toppingDescripcion[i] != "")
                    {
                        pedidoTopping = pedidoTopping + "\n" + toppingDescripcion[i];
                    }
                }
                string pedidoPROTEINA = "";
                for (int i = 0; i < 5; i++)
                {
                    if (proteinaDescripcion[i] != "")
                    {
                        pedidoPROTEINA = pedidoPROTEINA + "\n" + proteinaDescripcion[i];
                    }
                }
                string pedidocrujiente = "";
                for (int i = 0; i < 4; i++)
                {
                    if (crujienteDescripcion[i] != "")
                    {
                        pedidocrujiente = pedidocrujiente + "\n" + crujienteDescripcion[i];
                    }

                }
                string pedidoaderezo = "";
                for (int i = 0; i < 4; i++)
                {
                    if (aderezoDescripcion[i] != "")
                    {
                        pedidoaderezo = pedidoaderezo + "\n" + aderezoDescripcion[i];
                    }
                }
                MessageBox.Show("Base:\n" + pedidoBase + "\n\n Topping:" + pedidoTopping + "\n\n PROTEINA:" + pedidoPROTEINA + "\n\n CRUJIENTE:" + pedidocrujiente + "\n\n ADEREZO:" + pedidoaderezo);


            }
        }
        private void mango_CheckedChanged(object sender, EventArgs e)
        {
            if (mango .CheckState == CheckState.Checked)
            {

                toppingTotal++;
                toppingDescripcion[0] = "MANGO";
            }
            else
            {
                toppingDescripcion[0] = "";
                toppingTotal--;

            }
        }

        private void durazno_CheckedChanged(object sender, EventArgs e)
        {
            if (durazno .CheckState == CheckState.Checked)
            {

                toppingTotal++;
                toppingDescripcion[1] = "DURAZNO";
            }
            else
            {
                toppingDescripcion[1] = "";
                toppingTotal--;

            }
        }

        private void tomate_CheckedChanged(object sender, EventArgs e)
        {
            if (tomate.CheckState == CheckState.Checked)
            {

                toppingTotal++;
                toppingDescripcion[2] = "TOMATE";
            }
            else
            {
                toppingDescripcion[2] = "";
                toppingTotal--;

            }
        }

        private void edamame_CheckedChanged(object sender, EventArgs e)
        {
            if (edamame .CheckState == CheckState.Checked)
            {

                toppingTotal++;
                toppingDescripcion[3] = "EDAMAME";
            }
            else
            {
                toppingDescripcion[3] = "";
                toppingTotal--;

            }
        }

        private void champinones_CheckedChanged(object sender, EventArgs e)
        {
            if (champinones .CheckState == CheckState.Checked)
            {

                toppingTotal++;
                toppingDescripcion[4] = "CHAMPIÑONES";
            }
            else
            {
                toppingDescripcion[4] = "";
                toppingTotal--;

            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (pollo .CheckState == CheckState.Checked)
            {

                totalproteina ++;
                proteinaDescripcion[0] = "POLLO";


            }
            else
            {
                toppingDescripcion[0] = "";
                totalproteina--;

            }

        }

        private void rolloprimavera_CheckedChanged(object sender, EventArgs e)
        {
            if (rolloprimavera.CheckState == CheckState.Checked)
            {

                totalproteina   ++;
                proteinaDescripcion[1] = "ROLLO PRIMAVERA";
            }
            else
            {
                proteinaDescripcion[1] = "";
                totalproteina --;

            }
        }

        private void alitadepollo_CheckedChanged(object sender, EventArgs e)
        {
            if (alitadepollo .CheckState == CheckState.Checked)
            {

                totalproteina++;
                proteinaDescripcion[2] = "ALITA DE POLLO";
            }
            else
            {
                proteinaDescripcion[2] = "";
                totalproteina--;

            }
        }

        private void pollobingbing_CheckedChanged(object sender, EventArgs e)
        {
            if (pollobingbing .CheckState == CheckState.Checked)
            {

                totalproteina++;
                proteinaDescripcion[3] = "POLLO BING BING";
            }
            else
            {
                proteinaDescripcion[3] = "";
                totalproteina--;

            }
        }

        private void surimi_CheckedChanged(object sender, EventArgs e)
        {
            if (surimi.CheckState == CheckState.Checked)
            {

                totalproteina++;
                proteinaDescripcion[4] = "SURIMI";
            }
            else
            {
                proteinaDescripcion[4] = "";
                totalproteina--;

            }
        }

        private void arandano_CheckedChanged(object sender, EventArgs e)
        {
            if (arandano .CheckState == CheckState.Checked)
            {

                totalcrujiente ++;
                crujienteDescripcion[0] = "ARANDANO";


            }
            else
            {
                crujienteDescripcion[0] = "";
                totalcrujiente --;

            }
        }

        private void amaranto_CheckedChanged(object sender, EventArgs e)
        {
            if (amaranto .CheckState == CheckState.Checked)
            {

                totalcrujiente++;
                crujienteDescripcion[1] = "AMARANTO";
            }
            else
            {
                crujienteDescripcion[1] = "";
                totalcrujiente--;

            }
        }

        private void cacahuate_CheckedChanged(object sender, EventArgs e)
        {
            if (cacahuate .CheckState == CheckState.Checked)
            {

                totalcrujiente++;
                crujienteDescripcion[2] = "CACAHUATE";
            }
            else
            {
                crujienteDescripcion[2] = "";
                totalcrujiente--;

            }
        }

        private void semilladegirasol_CheckedChanged(object sender, EventArgs e)
        {
            if (semilladegirasol .CheckState == CheckState.Checked)
            {

                totalcrujiente++;
                crujienteDescripcion[3] = "SEMILLA DE GIRASOL";
            }
            else
            {
                crujienteDescripcion[3] = "";
                totalcrujiente--;

            }
        }

        private void aderezohke_CheckedChanged(object sender, EventArgs e)
        {
            if (aderezohke .CheckState == CheckState.Checked)
            {

                totaladerezos ++;
                aderezoDescripcion[0] = "ADEREZO HKE";
            }
            else
            {
                aderezoDescripcion[0] = "";
                totaladerezos --;

            }
        }

        private void agridulce_CheckedChanged(object sender, EventArgs e)
        {
            if (agridulce .CheckState == CheckState.Checked)
            {

                totaladerezos++;
                aderezoDescripcion[1] = "AGRIDULCE";
            }
            else
            {
                aderezoDescripcion[1] = "";
                totaladerezos--;

            }
        }

        private void soya_CheckedChanged(object sender, EventArgs e)
        {
            if (soya .CheckState == CheckState.Checked)
            {

                totaladerezos++;
                aderezoDescripcion[2] = "SOYA";
            }
            else
            {
                aderezoDescripcion[2] = "";
                totaladerezos--;

            }
        }

        private void salsachileseco_CheckedChanged(object sender, EventArgs e)
        {
            if (salsachileseco .CheckState == CheckState.Checked)
            {

                totaladerezos++;
                aderezoDescripcion[3] = "SALSA DE CHILE SECO";
            }
            else
            {
                aderezoDescripcion[3] = "";
                totaladerezos--;

            }

        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
          this.Close ();
           
        }

        private void recetiarbutton_Click(object sender, EventArgs e)
        {
            arroz.Checked = false;
            tallarines.Checked = false;
            fideosPepino.Checked = false;
            lechuga.Checked = false;
            pollo.Checked = false;
            rolloprimavera.Checked = false;
            alitadepollo.Checked = false;
            pollobingbing.Checked = false;
            surimi.Checked = false;
            aderezohke.Checked = false;
            agridulce.Checked = false;
            soya.Checked = false;
            salsachileseco.Checked = false;
            mango.Checked = false;
            durazno.Checked = false;
            tomate.Checked = false;
            edamame.Checked = false;
            champinones.Checked = false;
            arandano.Checked = false;
            amaranto.Checked = false;
            cacahuate.Checked = false;
            semilladegirasol.Checked = false;
        }
    }   
}