using System.Data;

namespace Calculator.Presenter
{
    public interface IResultFormViewable
    {
        string Result { set; }
        DataTable Dt { set; }
    }
}
