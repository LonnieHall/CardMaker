using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardMaker
{
    public partial class frmCharacter : frmGeneric    
    {
        public frmCharacter()
        {
            InitializeComponent();            
            resizeAndRelocateTextWindow(190, 45, 13, 240);
            resizeAndRelocateTypeWindow(110, 21);
            setType("Character");
        }

        private void frmCharacter_Load(object sender, EventArgs e)
        {
            
        }
    }
}
