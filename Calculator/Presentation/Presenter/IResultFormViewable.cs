using System.Data;

namespace Calculator.Presentation.Presenter
{
    public interface IResultFormViewable
    {
        string Result { set; }
        DataTable Dt { set; }
    }
}
