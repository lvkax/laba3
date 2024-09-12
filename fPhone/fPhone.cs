
namespace fPhone
{
    public partial class fPhone : Form
    {
        public clPhone ThePhone;

        public fPhone(clPhone t)
        {
            ThePhone = t;
            InitializeComponent();
        }
    }
    
}