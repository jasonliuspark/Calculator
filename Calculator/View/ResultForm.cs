using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Presenter;

namespace Calculator.View
{
    public partial class ResultForm : Form, IResultFormViewable
    {    
        public ResultForm()
        {
            InitializeComponent();          
            _presenter=new ResultFormPresenter(this);
        }
        
        public string Result
        {
            set { this.ResultBox2.Text = value; }
        }

        private readonly ResultFormPresenter _presenter;
        
        private void ResultForm_Load(object sender, EventArgs e)
        {
            _presenter.ResultFormLoad();
        }
    }
}
