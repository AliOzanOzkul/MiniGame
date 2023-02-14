using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunOrnek
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            switch (key)
            {
                case Keys.Up:
                    YukarıCık();
                    break;
                case Keys.Down:
                    AsagiIn();
                    break; 
                case Keys.Right:
                    SagaGit();
                    break;
                case Keys.Left:
                    SolaGit();
                    break;
                case Keys.W:
                    YukarıCık();
                    break;
                case Keys.S:
                    AsagiIn();
                    break;
                case Keys.A:
                    SolaGit();
                    break;
                case Keys.D:
                    SagaGit();
                    break;

                default:
                    break;
            }
            OyunBittiMi();
        }

        int kaybet;
        int kazan;
        private void OyunBittiMi()
        {

            bool kazandiMi = pnlKutu.Bounds.IntersectsWith(lblbitir.Bounds);
            bool kaybettiMi = pnlKutu.Bounds.IntersectsWith(lbl1d.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl2d.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl3d.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl4d.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl5d.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl6d.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl7d.Bounds);
                
            if(kazandiMi)
            {

                kazan++;
                DialogResult dr = MessageBox.Show("Tekrar deneyiniz", "Kazandınız!", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    pnlKutu.Location = new Point(106, 308);
                }
                else
                {
                    Application.Exit();
                }

            }
            
            if (kaybettiMi)
            {

                kaybet++;
                DialogResult dr = MessageBox.Show("Tekrar deneyiniz", "Kaybettiniz!", MessageBoxButtons.YesNo);
                
                lblKaybet.Text = (kaybet).ToString();

                if (dr == DialogResult.Yes)
                {
                    pnlKutu.Location = new Point(106, 308);
                }
                else
                {
                    Application.Exit();
                }

            }


        }
        private void SolaGit()
        {
            pnlKutu.Left -= 10;
        }

        private void SagaGit()
        {
            pnlKutu.Left += 10;
        }

        private void AsagiIn()
        {
            pnlKutu.Top += 10;
        }

        private void YukarıCık()
        {
            pnlKutu.Top -= 10;
        }
    }
}
